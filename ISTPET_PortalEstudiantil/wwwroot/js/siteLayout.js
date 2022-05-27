window.onscroll = function () {
    const html = document.querySelector("html");
    const navBlur = document.querySelector("#navbarBlur");
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