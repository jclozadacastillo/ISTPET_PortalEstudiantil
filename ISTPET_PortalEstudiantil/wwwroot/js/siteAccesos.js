(function () {
    "use strict";

    // SPF can request the same script more than once. Keep a single set of handlers.
    if (window.portalAccesos) {
        window.portalAccesos.init();
        return;
    }

    var pageStates = new WeakMap();
    var activePage = null;
    var activeState = null;
    var expiryTimer = null;
    var maskTimer = null;
    var passwordVisibleFor = 30000;

    function stopExpiryTimer() {
        clearTimeout(expiryTimer);
        expiryTimer = null;
    }

    function maskPasswords(page) {
        clearTimeout(maskTimer);
        maskTimer = null;
        if (!page) return;
        page.querySelectorAll("[data-credential-password]").forEach(function (field) {
            field.type = "password";
        });
        page.querySelectorAll("[data-password-target]").forEach(function (button) {
            button.setAttribute("aria-pressed", "false");
            button.setAttribute("aria-label", "Mostrar contraseña temporal");
            button.setAttribute("title", "Mostrar contraseña temporal");
            var icon = button.querySelector("i");
            if (icon) icon.className = "bi-eye";
        });
    }

    function clearCredentialValues(page) {
        if (!page) return;
        maskPasswords(page);
        page.querySelectorAll("[data-credential-field]").forEach(function (field) {
            field.value = "";
            field.defaultValue = "";
            field.removeAttribute("value");
        });
    }

    function expireCredentials(page) {
        stopExpiryTimer();
        clearCredentialValues(page);
        var content = page.querySelector("[data-credential-content]");
        if (content) {
            content.replaceChildren();
            content.hidden = true;
        }
        var expired = page.querySelector("[data-credential-expired]");
        if (expired) expired.hidden = false;
        page.dataset.credentialExpired = "true";
        document.querySelectorAll("[data-acceso-temporal]").forEach(function (item) { item.remove(); });
    }

    function remainingTime(state) {
        // Use the server's Ecuador clock. Monotonic time also prevents extending
        // the display window when a device clock moves backwards.
        var elapsed = Math.max(performance.now() - state.startedAt, Date.now() - state.wallClockStartedAt);
        return state.duration - elapsed;
    }

    function formatRemaining(milliseconds) {
        var seconds = Math.max(0, Math.ceil(milliseconds / 1000));
        var days = Math.floor(seconds / 86400);
        var hours = Math.floor((seconds % 86400) / 3600);
        var minutes = Math.floor((seconds % 3600) / 60);
        if (days > 0) return "Tiempo restante: " + days + (days === 1 ? " día" : " días") + " y " + hours + " h";
        if (hours > 0) return "Tiempo restante: " + hours + " h " + minutes + " min";
        if (minutes > 0) return "Tiempo restante: " + minutes + " min";
        return "Tiempo restante: " + seconds + " s";
    }

    function updateClock() {
        stopExpiryTimer();
        if (!activePage || !activePage.isConnected || !activeState) return;
        var remaining = remainingTime(activeState);
        if (!Number.isFinite(remaining) || remaining <= 0) {
            expireCredentials(activePage);
            return;
        }
        var countdown = activePage.querySelector("[data-credential-countdown]");
        if (countdown) countdown.textContent = formatRemaining(remaining);
        expiryTimer = setTimeout(updateClock, Math.min(1000, remaining));
    }

    function init() {
        stopExpiryTimer();
        var page = document.querySelector("[data-portal-accesos]");
        if (activePage !== page) maskPasswords(activePage);
        activePage = page;
        activeState = null;
        if (!page || !page.querySelector("[data-credential-content]") || page.dataset.credentialExpired === "true") return;

        var state = pageStates.get(page);
        if (!state) {
            var serverNow = Date.parse(page.dataset.credentialServerNow);
            var deadline = Date.parse(page.dataset.credentialLimit);
            state = {
                duration: deadline - serverNow,
                // Credential routes use full navigation. Count loading time too,
                // so a slow response cannot extend the visibility deadline.
                startedAt: 0,
                wallClockStartedAt: Date.now() - performance.now()
            };
            pageStates.set(page, state);
        }
        activeState = state;
        updateClock();
    }

    function feedback(page, message, isError) {
        var element = page.querySelector("[data-copy-feedback]");
        if (!element) return;
        element.textContent = message;
        element.classList.toggle("is-error", Boolean(isError));
    }

    function refreshPasswordMask() {
        if (!activePage || !activePage.querySelector('[data-credential-password][type="text"]')) return;
        clearTimeout(maskTimer);
        maskTimer = setTimeout(function () { maskPasswords(activePage); }, passwordVisibleFor);
    }

    async function copyField(field) {
        if (navigator.clipboard && window.isSecureContext) {
            await navigator.clipboard.writeText(field.value);
            return;
        }

        // Older browsers can copy from a transient element; never keep a second
        // credential value in attributes, storage, or application state.
        var temporary = document.createElement("textarea");
        temporary.value = field.value;
        temporary.readOnly = true;
        temporary.setAttribute("aria-hidden", "true");
        temporary.style.position = "fixed";
        temporary.style.left = "-9999px";
        document.body.appendChild(temporary);
        try {
            temporary.select();
            if (!document.execCommand("copy")) throw new Error("Copy unavailable");
        } finally {
            temporary.value = "";
            temporary.remove();
        }
    }

    document.addEventListener("click", async function (event) {
        var button = event.target.closest("[data-copy-target], [data-password-target]");
        if (!button) return;
        var page = button.closest("[data-portal-accesos]");
        if (!page || page !== activePage) return;
        if (!activeState || remainingTime(activeState) <= 0) {
            expireCredentials(page);
            return;
        }

        var targetId = button.dataset.copyTarget || button.dataset.passwordTarget;
        var field = document.getElementById(targetId);
        if (!field || !page.contains(field) || !field.value) return;

        if (button.hasAttribute("data-password-target")) {
            var show = field.type === "password";
            field.type = show ? "text" : "password";
            button.setAttribute("aria-pressed", String(show));
            button.setAttribute("aria-label", show ? "Ocultar contraseña temporal" : "Mostrar contraseña temporal");
            button.setAttribute("title", show ? "Ocultar contraseña temporal" : "Mostrar contraseña temporal");
            var icon = button.querySelector("i");
            if (icon) icon.className = show ? "bi-eye-slash" : "bi-eye";
            if (show) refreshPasswordMask();
            else maskPasswords(page);
            return;
        }

        try {
            await copyField(field);
            if (page.isConnected && page.dataset.credentialExpired !== "true") feedback(page, "Dato copiado al portapapeles.", false);
        } catch (_) {
            if (page.isConnected && page.dataset.credentialExpired !== "true") feedback(page, "No se pudo copiar. Selecciona el dato para copiarlo manualmente.", true);
        } finally {
            if (button.isConnected) button.focus({ preventScroll: true });
        }
    });

    document.addEventListener("pointerdown", refreshPasswordMask, { passive: true });
    document.addEventListener("keydown", refreshPasswordMask);
    document.addEventListener("visibilitychange", function () {
        if (document.hidden) maskPasswords(activePage);
        else updateClock();
    });
    window.addEventListener("blur", function () { maskPasswords(activePage); });
    window.addEventListener("pagehide", function () {
        stopExpiryTimer();
        clearCredentialValues(activePage);
    });
    window.addEventListener("pageshow", function (event) {
        // Revalidate access with the server after browser back/forward restoration.
        if (event.persisted && activePage && activePage.hasAttribute("data-credential-limit")) window.location.reload();
    });
    document.addEventListener("spfprocess", function () {
        stopExpiryTimer();
        clearCredentialValues(activePage);
    });
    document.addEventListener("spfdone", init);
    document.addEventListener("DOMContentLoaded", init);

    window.portalAccesos = { init: init };
    init();
})();
