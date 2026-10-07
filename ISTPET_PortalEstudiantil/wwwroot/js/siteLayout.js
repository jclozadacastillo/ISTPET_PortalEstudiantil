// Use server-relative time to hide temporary menu entries even if the browser clock differs.
let _accesosTemporalesTimer;
const _fechaInstitucional = Date.parse(document.body.dataset.fechaInstitucional);
const _inicioRelojInstitucional = 0;
function actualizarAccesosTemporales() {
    clearTimeout(_accesosTemporalesTimer);
    let proximoVencimiento = Infinity;
    document.querySelectorAll('[data-acceso-temporal]').forEach(item => {
        if (!item._portalVencimiento) {
            const limite = Date.parse(item.dataset.fechaLimite);
            // A cached home fragment must retain its original absolute deadline.
            item._portalVencimiento = Number.isFinite(limite) && Number.isFinite(_fechaInstitucional)
                ? _inicioRelojInstitucional + limite - _fechaInstitucional : performance.now();
        }
        const restante = item._portalVencimiento - performance.now();
        if (restante <= 0) item.remove();
        else proximoVencimiento = Math.min(proximoVencimiento, restante);
    });
    if (Number.isFinite(proximoVencimiento)) {
        _accesosTemporalesTimer = setTimeout(actualizarAccesosTemporales, Math.min(proximoVencimiento, 60000));
    }
}
document.addEventListener('DOMContentLoaded', actualizarAccesosTemporales);
document.addEventListener('spfdone', actualizarAccesosTemporales);
document.addEventListener('visibilitychange', actualizarAccesosTemporales);
window.addEventListener('pageshow', actualizarAccesosTemporales);
actualizarAccesosTemporales();

// Eliminar lag y saltos bruscos suprimiendo transiciones CSS mientras se redimensiona la ventana
let _windowResizeTimer;
window.addEventListener("resize", function () {
    document.body.classList.add("is-resizing");
    clearTimeout(_windowResizeTimer);
    _windowResizeTimer = setTimeout(function () {
        document.body.classList.remove("is-resizing");
    }, 150);
}, { passive: true });


async function salir() {
    try {
        await toastLogout();
        const url = `${_route}Login/logout`;
        await axios.get(url);
        top.location.reload();
    } catch (e) {
        console.error(`${e.message}`);
    }
}

_menu();
function _menu() {
    const nav = document.getElementById("sidenav-collapse-main");
    if (!nav) return;
    const urlVec = window.location.pathname.toLowerCase().split("/");
    let ref = urlVec.pop();
    if (["correoinstitucional", "usuarioeva", "chatconduccion"].includes(ref)) ref = "accesosinstitucionales";
    if (parseInt(ref) >= 0 || parseInt(ref).toString() == "NaN") {
        if (!nav.querySelector(`a[data-menu='${ref}']`)) ref = urlVec[urlVec.length - 1];
    }
    if (!ref) ref = urlVec[urlVec.length - 1];
    if (!ref) ref = urlVec[urlVec.length - 2];

    nav.querySelectorAll("a[data-menu]").forEach(item => {
        item.classList.remove("active");
        if (item.dataset.menu == ref) item.classList.add("active");
    });
    if (!ref) {
        nav.querySelector("a[data-menu='sistema']")?.classList.add("active");
        return;
    }
}

// Inicialización y eventos de SPF (Structured Page Fragments)
if (window.spf) {
    spf.init();
}

document.addEventListener('spfprocess', function () {
    _menu();
});

document.addEventListener('spfdone', function () {
    _menu();
    window.scrollTo({ top: 0, behavior: 'instant' });
    const body = document.body;
    if (body.classList.contains('g-sidenav-pinned')) {
        body.classList.remove('g-sidenav-pinned');
    }
});

document.addEventListener('spfhistory', function () {
    _menu();
});
