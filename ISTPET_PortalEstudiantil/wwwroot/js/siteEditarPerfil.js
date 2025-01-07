const baseUrl = `${_route}Cuenta/`;
const container = document.querySelector(".container-main");
const loader = document.querySelector(".loader");
const form = document.querySelector("#formEditarPerfil");
const etniaSelect = document.querySelector("#idEtnia");
const previewFoto = document.querySelector("#previewFoto");
const etniaField = document.querySelector(".etnia-field");

init();

async function init() {
    try {
        const actualizacionDisponible = await verificarActualizacionDisponible();
        if (!actualizacionDisponible) {
            etniaField.style.display = "none";
        } else {
            etniaField.style.display = "block";
            await cargarEtnias();
        }
        await cargarDatosAlumno();
    } catch (e) {
        console.error(`${e.message}`);
    } finally {
        loader.hidden = true;
        container.hidden = false;
    }
}

async function cargarDatosAlumno() {
    const url = `${baseUrl}DatosAlumno`;
    const alumno = (await axios.get(url)).data;

    form.direccion.value = alumno.direccion || "";
    form.email.value = alumno.email || "";
    form.telefono.value = alumno.telefono || "";
    form.celular.value = alumno.celular || "";
    form.idEtnia.value = alumno.idEtnia || "";

    if (alumno.archivoFoto) {
        const fotoUrl = `${_route}${alumno.archivoFoto}?v=${(new Date()).getTime()}`;
        previewFoto.src = fotoUrl;
        previewFoto.style.display = "block";
    } else {
        previewFoto.style.display = "none";
    }
}

async function cargarEtnias() {
    const url = `${baseUrl}ListaEtnias`;
    const etnias = (await axios.get(url)).data;

    etnias.forEach(etnia => {
        const option = document.createElement("option");
        option.value = etnia.idEtnia;
        option.textContent = etnia.etnia;
        etniaSelect.appendChild(option);
    });
}

async function verificarActualizacionDisponible() {
    try {
        const url = `${baseUrl}verificarActualizacionDisponible`;
        const res = (await axios.get(url)).data;
        return res;
    } catch (e) {
        if (e.message.includes("401")) {
            toastError("Su sesión ha caducado");
            setTimeout(() => top.location.reload(), 1900);
        } else {
            toastError(`${e.message}`);
        }
        return false;
    }
}

function validarYMostrarFoto() {
    const input = document.querySelector("#foto");
    if (!input.files || !input.files[0]) {
        previewFoto.style.display = "none";
        return;
    }

    const file = input.files[0];
    if (file.size > 500 * 1024) {
        toastError("El archivo seleccionado excede el tamaño máximo de 500 KB.");
        return;
    }

    const reader = new FileReader();
    reader.onload = e => {
        previewFoto.src = e.target.result;
        previewFoto.style.display = "block";
    };
    reader.readAsDataURL(file);
}

function validarFormulario() {
    const inputs = form.querySelectorAll("input, select");
    let isValid = true;

    inputs.forEach(input => {
        if (input.type !== "file" && input.required && !input.value.trim()) {
            if (input.id === "idEtnia" && etniaField.style.display === "none") return;
            input.classList.add("is-invalid");
            input.classList.remove("is-valid");
            isValid = false;
        } else if (input.id === "email" && !validarEmail(input.value)) {
            input.classList.add("is-invalid");
            input.classList.remove("is-valid");
            isValid = false;
            toastError("Ingrese un correo válido.");
        } else if (input.id === "celular" && !validarCelular(input.value)) {
            input.classList.add("is-invalid");
            input.classList.remove("is-valid");
            isValid = false;
            toastError("El celular debe tener exactamente 10 dígitos.");
        } else {
            input.classList.remove("is-invalid");
            input.classList.add("is-valid");
        }
    });

    return isValid;
}

function validarEmail(email) {
    const regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return regex.test(email);
}

function validarCelular(celular) {
    return /^\d{10}$/.test(celular);
}

async function guardar() {
    if (!validarFormulario()) {
        toastError("Por favor, complete todos los campos requeridos.");
        return;
    }

    const formData = new FormData(form);
    const url = `${baseUrl}GuardarCambios`;

    try {
        await axios.post(url, formData, {
            headers: { "Content-Type": "multipart/form-data" },
        });
        toastSuccess("Cambios guardados exitosamente.");
    } catch (e) {
        toastError(`Error al guardar los cambios: ${e.message}`);
    }
}
