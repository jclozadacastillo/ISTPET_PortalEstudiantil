(function () {
    const baseUrl = `${_route}Cuenta/`;
    const container = document.querySelector(".container-main");
    const loader = document.querySelector(".loader");
    const form = document.querySelector("#formEditarPerfil");
    if (!form) return;

    const etniaSelect = document.querySelector("#idEtnia");
    const previewFoto = document.querySelector("#previewFoto");
    const etniaField = document.querySelector(".etnia-field");

    function validarYMostrarFoto() {
        const input = document.querySelector("#foto");
        const placeholder = document.querySelector("#placeholderFoto");
        if (!input || !input.files || !input.files[0]) {
            if (previewFoto) previewFoto.style.display = "none";
            if (placeholder) placeholder.style.display = "flex";
            return;
        }

        const file = input.files[0];
        if (file.size > 500 * 1024) {
            toastError("El archivo seleccionado excede el tamaño máximo de 500 KB.");
            input.value = "";
            if (previewFoto) previewFoto.style.display = "none";
            if (placeholder) placeholder.style.display = "flex";
            return;
        }

        const reader = new FileReader();
        reader.onload = e => {
            if (previewFoto) {
                previewFoto.src = e.target.result;
                previewFoto.style.display = "block";
            }
            if (placeholder) {
                placeholder.style.display = "none";
            }
        };
        reader.readAsDataURL(file);
    }

    function validarFormulario() {
        const inputs = form.querySelectorAll("input, select");
        let isValid = true;

        inputs.forEach(input => {
            if (input.type !== "file" && input.required && !input.value.trim()) {
                if (input.id === "idEtnia" && etniaField && etniaField.style.display === "none") return;
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

    window.validarYMostrarFoto = validarYMostrarFoto;
    window.guardar = guardar;
})();
