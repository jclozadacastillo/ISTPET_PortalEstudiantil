const form = document.querySelector("form");
const button = form.querySelector("button[type='submit']");
const baseUrl = `${_route}Login/`;
form.addEventListener("submit", e => {
    e.preventDefault();
    login();
})

async function login() {
    try {
        if (!await validarTodo(form)) {
            toastError("Complete los campos requeridos")
            return;
        }
        const url = `${baseUrl}login`;
        const data = new FormData(form);
        data.append("__RequestVerificationToken", _getToken());
        disableForm(form);
        button.innerHTML = "Espere por favor...";
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        top.location.reload();
    } catch (e) {
        toastError(`${e.message}`);
        console.error(`${e.message}`);
    } finally {
        enableForm(form);
        button.innerHTML = "Ingresar";
    }
}
