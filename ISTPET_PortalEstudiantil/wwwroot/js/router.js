const _route = { pruebas: "../../", produccion: "../../../PortalEstudiantil/" }.pruebas;
function _getToken() {
    const el = document.createElement("div");
    el.innerHTML = _token;
    const tokeValue = el.querySelector("input").value;
    el.remove();
    return tokeValue;
}