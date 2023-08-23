const form = document.querySelector("form");
const button = form.querySelector("button[type='submit']");
const baseUrl = `${_route}Login/`;
const modal = new bootstrap.Modal(document.getElementById("modal"), {
    keyboard: false
});
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
        if (res == "clave") {
            limpiarForm(frmClaves);
            modal.show();
        } else {
            top.location.reload();
        }
    } catch (e) {
        toastError(`${e.message}`);
        console.error(`${e.message}`);
    } finally {
        enableForm(form);
        button.innerHTML = "Ingresar";
    }
}


async function cambiarClave() {
    try {
        let valido = await validarClaves();
        if (!!valido) {
            toastError(valido);
            return;
        }
        if (!await validarTodo(frmClaves)) {
            toastInfo("Verifica los campos requeridos");
            return;
        }
        if (!await toastPreguntar(`<p class='mt-2'>
        <small>¿Está seguro que desa cambiar su contraseña?</small>
        </p>
        <p class='mt-1 text-center' style='line-height:11px'>
        <i class='bi-exclamation-triangle text-sm text-danger'></i>
        </br>
        <small class="text-danger fw-bold" style='font-size:0.64em;'>
        ESTA ACCIÓN NO SE PUEDE DESHACER Y DEBERÁ VOLVER A INCIAR SESIÓN</small>
        </p>
        `)) return;
        const url = `${baseUrl}cambiarPassword`;
        const data = new FormData();
        data.append("idAlumno", idAlumno.value);
        data.append("password", nueva.value);
        disableForm(form);
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        toastLogout();
        setTimeout(() => { top.location.reload() }, 1900);
    } catch (e) {
        if (e.message.search("401") >= 0) {
            toastError("Su sesión ha caducado");
            setTimeout(() => top.location.reload(), 1900);
        } else {
            toastError(`${e.message}`);
        }
        enableForm(form);
    }
}

function validarClaves() {
    return new Promise(resolve => {
        let mensaje = null;
        if (anterior.value != idAlumno.value && anterior.value != "") mensaje = "La contraseña no es la correcta";
        if (nueva.value != confir.value) mensaje = "Las contraseñas no coinciden";
        if (!nueva.value.match(/^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,20}$/)) {
            mensaje = "La contraseña debe tener de 6 a 20 dígitos con un dígito numerico, uno en mayúsculas y uno en minúsculas";
        }
        resolve(mensaje);
    });
}
