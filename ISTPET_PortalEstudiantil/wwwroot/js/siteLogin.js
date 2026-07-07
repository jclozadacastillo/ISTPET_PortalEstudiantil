const form = document.querySelector("form");
const button = form.querySelector("button[type='submit']");
const baseUrl = `${_route}Login/`;
const modal = new bootstrap.Modal(document.getElementById("modal"), {
    keyboard: false
});
const modalRecuperar = new bootstrap.Modal(document.getElementById("modalRecuperarClave"), {
    keyboard: false
});
const modalTerminos = new bootstrap.Modal(document.getElementById("modalTerminos"), {
    keyboard: false
});
let terminosAceptados = false;
let terminosLeidos = false;
let limpiarEventosLecturaTerminos = null;
crearPasswordPreview();
form.addEventListener("submit", e => {
    e.preventDefault();
    login();
})
chkAceptaTerminos.addEventListener("change", actualizarEstadoAceptarTerminos);

document.getElementById("modalTerminos").addEventListener("hidden.bs.modal", async () => {
    if (terminosAceptados) return;
    try {
        await axios.get(`${baseUrl}logout`);
    } catch (e) {
        console.error(`${e.message}`);
    } finally {
        top.location.reload();
    }
});

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
            activarValidadores(frmClaves);
            modal.show();
        } else {
            if (await mostrarTerminosPendientes()) return;
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

async function mostrarTerminosPendientes() {
    const res = (await axios.get(`${baseUrl}terminoVigentePendiente`)).data;
    if (!!res.error) throw new Error(res.error);
    if (!res.requiereAceptar) return false;

    terminosAceptados = false;
    idTerminoVigente.value = res.idTermino;
    reiniciarLecturaTerminos();
    archivoTerminos.onload = configurarLecturaTerminos;
    archivoTerminos.src = res.archivoHtmlUrl;
    modalTerminos.show();
    return true;
}

async function aceptarTerminos() {
    try {
        if (!terminosLeidos) {
            toastInfo("Debe revisar el documento hasta el final para continuar");
            return;
        }

        if (!chkAceptaTerminos.checked) {
            toastInfo("Debe aceptar el tratamiento de sus datos personales");
            return;
        }

        const data = new FormData();
        data.append("__RequestVerificationToken", _getToken());
        data.append("idTermino", idTerminoVigente.value);
        data.append("datosDispositivo", await obtenerDatosDispositivo());

        btnAceptarTerminos.disabled = true;
        btnAceptarTerminos.innerHTML = "Espere por favor...";

        const res = (await axios.post(`${baseUrl}aceptarTerminos`, data)).data;
        if (!!res.error) throw new Error(res.error);

        terminosAceptados = true;
        modalTerminos.hide();
        top.location.reload();
    } catch (e) {
        handleError(e);
    } finally {
        btnAceptarTerminos.innerHTML = "Aceptar";
        actualizarEstadoAceptarTerminos();
    }
}

function reiniciarLecturaTerminos() {
    terminosLeidos = false;
    chkAceptaTerminos.checked = false;
    chkAceptaTerminos.disabled = true;
    btnAceptarTerminos.disabled = true;
    estadoLecturaTerminos.classList.remove("is-read");
    estadoLecturaTerminos.innerHTML = `<i class="bi bi-arrow-down-circle"></i> Revise el documento hasta el final`;

    if (limpiarEventosLecturaTerminos) {
        limpiarEventosLecturaTerminos();
        limpiarEventosLecturaTerminos = null;
    }
}

function configurarLecturaTerminos() {
    try {
        const doc = archivoTerminos.contentDocument || archivoTerminos.contentWindow.document;
        const win = archivoTerminos.contentWindow;
        const scrollElement = doc.scrollingElement || doc.documentElement || doc.body;

        const verificarLectura = () => {
            if (!scrollElement || terminosLeidos) return;

            const distanciaFinal = scrollElement.scrollHeight - scrollElement.scrollTop - scrollElement.clientHeight;
            if (distanciaFinal <= 12) {
                habilitarAceptacionTerminos();
            }
        };

        win.addEventListener("scroll", verificarLectura, { passive: true });
        doc.addEventListener("scroll", verificarLectura, { passive: true });
        limpiarEventosLecturaTerminos = () => {
            win.removeEventListener("scroll", verificarLectura);
            doc.removeEventListener("scroll", verificarLectura);
        };

        setTimeout(verificarLectura, 150);
    } catch (e) {
        console.error(`${e.message}`);
        estadoLecturaTerminos.innerHTML = `<i class="bi bi-exclamation-circle"></i> No se pudo validar la lectura del documento`;
    }
}

function habilitarAceptacionTerminos() {
    terminosLeidos = true;
    chkAceptaTerminos.disabled = false;
    actualizarEstadoAceptarTerminos();
    estadoLecturaTerminos.classList.add("is-read");
    estadoLecturaTerminos.innerHTML = `<i class="bi bi-check-circle"></i> Documento revisado`;
}

function actualizarEstadoAceptarTerminos() {
    btnAceptarTerminos.disabled = !(terminosLeidos && chkAceptaTerminos.checked);
}

async function obtenerDatosDispositivo() {
    const datos = {
        userAgent: navigator.userAgent,
        platform: navigator.platform,
        language: navigator.language,
        languages: navigator.languages?.join(","),
        cookieEnabled: navigator.cookieEnabled,
        screen: `${screen.width}x${screen.height}`,
        viewport: `${window.innerWidth}x${window.innerHeight}`,
        timezone: Intl.DateTimeFormat().resolvedOptions().timeZone
    };

    if (navigator.userAgentData) {
        datos.mobile = navigator.userAgentData.mobile;
        datos.uaPlatform = navigator.userAgentData.platform;
        datos.brands = navigator.userAgentData.brands?.map(item => `${item.brand} ${item.version}`).join(",");
        if (navigator.userAgentData.getHighEntropyValues) {
            try {
                const valores = await navigator.userAgentData.getHighEntropyValues(["architecture", "model", "platformVersion", "fullVersionList"]);
                datos.architecture = valores.architecture;
                datos.model = valores.model;
                datos.platformVersion = valores.platformVersion;
                datos.fullVersionList = valores.fullVersionList?.map(item => `${item.brand} ${item.version}`).join(",");
            } catch (e) {
                console.error(`${e.message}`);
            }
        }
    }

    return JSON.stringify(datos);
}

function validarClaves() {
    return new Promise(resolve => {
        let mensaje = null;
        if (anterior.value != idAlumno.value && anterior.value != "") mensaje = "La contraseña no es la correcta";
        if (nueva.value != confir.value) mensaje = "Las contraseñas no coinciden";
        if (!nueva.value.match(/^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,10}$/)) {
            mensaje = "La contraseña debe tener de 6 a 10 dígitos con un dígito numerico, uno en mayúsculas y uno en minúsculas";
        }
        resolve(mensaje);
    });
}

function recuperarClave() {
    try {
        limpiarForm(frmRecuperar);
        activarValidadores(frmRecuperar);
        modalRecuperar.show();
    } catch (e) {
        handleError(e);
    }
}

async function solicitudRecuperarClave() {
    try {
        if (!await validarTodo(frmRecuperar)) {
            toastInfo("Verifica los campos requeridos");
            return;
        }
        disableForm(frmRecuperar);
        const url = `${baseUrl}recuperarClave`;
        const data = new FormData(frmRecuperar);
        const responsae = (await axios.post(url, data)).data;
        if (!!responsae.error) throw new Error(responsae.error);
        toastSuccess("Se ha enviado un correo con las instrucciones para recuperar su contraseña");
        modalRecuperar.hide();
    } catch (e) {
        handleError(e);
    } finally {
        enableForm(frmRecuperar);
    }
}
