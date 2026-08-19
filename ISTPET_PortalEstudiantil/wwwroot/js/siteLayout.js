window.onscroll = function () {
    const html = document.querySelector("html");
    const navBlur = document.querySelector("#navbarBlur");
    if (!navBlur) return;
    if (html.scrollTop < 7) {
        navBlur.classList.remove("bg-white-transparent");
        navBlur.classList.add("bg-white");
    } else {
        if (html.scrollTop >= 7) {
            navBlur.classList.remove("bg-white");
            navBlur.classList.add("bg-white-transparent");
        }
    }
}
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