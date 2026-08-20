function updateNavbarScrollState() {
    const navBlur = document.querySelector("#navbarBlur");
    if (!navBlur) return;
    const content = document.querySelector(".main-content");
    const scrollTop = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || (content ? content.scrollTop : 0) || 0;
    
    if (scrollTop > 10) {
        navBlur.classList.add("navbar-glass");
        navBlur.classList.remove("navbar-top-white");
        navBlur.classList.remove("bg-white");
        navBlur.classList.remove("bg-white-transparent");
    } else {
        navBlur.classList.remove("navbar-glass");
        navBlur.classList.remove("blur");
        navBlur.classList.remove("shadow-blur");
        navBlur.classList.remove("bg-white-transparent");
        navBlur.classList.add("navbar-top-white");
    }
}

window.addEventListener("scroll", updateNavbarScrollState, { passive: true });
document.addEventListener("scroll", updateNavbarScrollState, { passive: true });
const _mainContent = document.querySelector(".main-content");
if (_mainContent) {
    _mainContent.addEventListener("scroll", updateNavbarScrollState, { passive: true });
    _mainContent.addEventListener("ps-scroll-y", updateNavbarScrollState);
}
document.addEventListener("DOMContentLoaded", updateNavbarScrollState);
document.addEventListener("spfprocess", updateNavbarScrollState);
document.addEventListener("spfdone", updateNavbarScrollState);
updateNavbarScrollState();

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