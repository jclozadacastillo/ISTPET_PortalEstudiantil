const baseUrl = `${_route}Inscripciones/`;
window.addEventListener("load", () => {
    setTimeout(() => {
        window.scrollTo({ top: 0, behavior: 'smooth' });
    }, 109);
    activarValidadores(frmDatos);
    comboCarreras();
});

function terminos() {
    formulario.hidden = !formulario.hidden;
    if (!formulario.hidden) {
        top.location.href = "#formulario";
        setTimeout(() => {
            const coeficiente = (formulario.getBoundingClientRect().height - window.screen.height) + 220;
            window.scrollTo({ top: formulario.getBoundingClientRect().height - coeficiente })
        }, 10)
    } else {
        window.scrollTo({ top: 0, behavior: 'smooth' });
    }
}

async function siguiente(_from) {
    try {
        if (_from == 0) {
            divAcademicos.hidden = true;
            divInscripcion.hidden = true;
            if (!await validarTodo(personales)) throw new Error("Verifique los campos requeridos");
            if (await validarTodo(academicos)) divInscripcion.hidden = false;
            limpiarValidadoresForm(academicos);
            tabAcademicos.click();
            divAcademicos.hidden = false;
        }
        if (_from == 1) {
            divInscripcion.hidden = true;
            if (!await validarTodo(academicos)) throw new Error("Verifique los campos requeridos");
            tabInscripcion.click();
            divInscripcion.hidden = false;
        }
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function cambiarTipoDocumento() {
    idAlumno.removeAttribute("data-validate");
    idAlumno.classList.remove("is-invalid");
    if (tipoDocumento.value == "C") {
        idAlumno.setAttribute("data-validate", "cedula");
        validarCedula(idAlumno);
    } else {
        validarVacio(idAlumno);
    }
    activarValidadores(personales);

}

async function comboCarreras() {
    try {
        const url = `${baseUrl}comboCarreras`;
        const res = (await axios.get(url)).data;
        if (!!res.error) throw new Error(res.error);
        let html = `<option value=''>Selecciona</option>`;
        res.forEach(item => {
            html += `<option value="${item.idCarrera}">${item.Carrera}</option>`;
        });
        idCarrera.innerHTML = html;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function comboSecciones() {
    try {
        if (idCarrera.value == "") {
            idSeccion.innerHTML = "<option value=''>Selecciona una carrera</option>";
            return;
        }
        const url = `${baseUrl}comboSecciones`;
        const data = new FormData(frmDatos);
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        let html = `<option value=''>Selecciona</option>`;
        res.forEach(item => {
            html += `<option value="${item.idSeccion}">${item.seccion}</option>`;
        });
        idSeccion.innerHTML = html;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function comboPeriodos() {
    try {
        if (idSeccion.value == "") {
            idPeriodo.innerHTML = "<option value=''>Selecciona una sección</option>";
            return;
        }
        const url = `${baseUrl}comboPeriodos`;
        const data = new FormData(frmDatos);
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        let html = `<option value=''>Selecciona</option>`;
        moment.locale("es");
        res.forEach(item => {
            const fecha = moment(item.fecha_inicial).format("LLLL").split("0:00")[0];
            html += `<option value="${item.idPeriodo}">${fecha.toUpperCase()} PERIODO: ${item.detalle}</option>`;
        });
        idPeriodo.innerHTML = html;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function guardar() {
    try {
        if (!await validarTodo(frmDatos)) throw new Error("Verifique todos los campos requeridos");
        formulario.classList.remove(...formulario.classList);
        formulario.classList.add("container-fluid");
        formulario.innerHTML = `<div class='row bg-success text-center pt-28' style='height:100vh'>
                                <div class='col-sm-12'>
                                    <h1 class='text-white'>
                                    <i class='bi-check-circle text-white' style='font-size:7rem'></i>
                                    <br>
                                    <br>
                                    TÚ INSCRIPCIÓN EN LÍNEA SE REALIZÓ CORRECTAMENTE
                                    </h1>  
                                </div>
                                <div class='col-sm-12'>
                                    <button class='btn btn-light' onclick='top.location.reload()'>RELIZAR OTRA INSCRIPCIÓN</button>
                                </div>
                            </div>`;
        const coeficiente = (formulario.getBoundingClientRect().height - window.screen.height) + 220;
        window.scrollTo({ top: formulario.getBoundingClientRect().height - coeficiente })
    } catch (e) {
        toastError(`${e.message}`);
    }
}