const baseUrl = `${_route}EvaluacionDocente/`;
let evaluaciones = [];
let idInstrumento = 0;
(async function () {
    try {
        await comboCarreras();
    } catch (e) {
        console.error(`${e.message}`);
    } finally {
        loader.hidden = true;
        container.hidden = false;
    }
})();

idMatricula.addEventListener("change", async function () {
    await comboAsignaturas();
});
async function comboCarreras() {
    try {
        const url = `${baseUrl}comboCarreras`;
        const res = (await axios.get(url)).data;
        let html = "<option value=''>Seleccione</option>";
        res.forEach(item => {
            html += `<option value='${item.idMatricula}'>${item.Carrera} (${item.Nivel})${item.seccion[0]}${item.modalidad[0]}</option>`
        });
        idMatricula.innerHTML = html;
    } catch (e) {
        handleError(e);
    }
}

async function comboAsignaturas() {
    try {
        evaluaciones = [];
        idAsignatura.innerHTML = "<option value=''>Seleccione una carrera</option>";
        if (idMatricula.value == "") return;
        const url = `${baseUrl}comboAsignaturas`;
        const res = (await axios.post(url, new FormData(frmDatos))).data;
        evaluaciones = res;
        let html = "<option value=''>Seleccione</option>";
        res.forEach(item => {
            html += `<option value='${item.idAsignacion}'>${item.asignatura}</option>`
        });
        idAsignatura.innerHTML = html;

    } catch (e) {
        handleError(e);
    }
}

idAsignatura.addEventListener("change", async function () {
    contenedorPreguntas.setAttribute("hidden", true);
    tablaEvaluacion.innerHTML = "";
    if (this.value == "") return;
    await cargarEvaluacion();
});

async function cargarEvaluacion() {
    try {
        const url = `${baseUrl}cargarEvaluacion`;
        const res = (await axios.get(url)).data;
        idInstrumento = res[0].idInstrumento;
        let numero = 0;
        const _evaluacion = evaluaciones.find(x => x.idAsignacion == idAsignatura.value);
        if (!!_evaluacion) {
            nombreDocente.innerHTML = `<b>DOCENTE: </b>${_evaluacion.abreviatura} ${_evaluacion.apellidos} ${_evaluacion.nombres}`
        }
        res.forEach(async function (item, id) {
            numero++;
            tablaEvaluacion.insertAdjacentHTML('beforeend',
                `
                <tr class='p-${item.idPregunta}'>
                    <td class='text-center'>${numero}</td>
                    <td style='width:auto !important;white-space:break-spaces !important'>${item.pregunta}</td>
                    <td>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="diez-p${item.idPregunta}" value="10">
                                    <label class="form-check-label" for="diez-p${item.idPregunta}">10</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="nueve-p${item.idPregunta}" value="9">
                                    <label class="form-check-label" for="nueve-p${item.idPregunta}">9</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="ocho-p${item.idPregunta}" value="8">
                                    <label class="form-check-label" for="ocho-p${item.idPregunta}">8</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="siete-p${item.idPregunta}" value="7">
                                    <label class="form-check-label" for="siete-p${item.idPregunta}">7</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="seis-p${item.idPregunta}" value="6">
                                    <label class="form-check-label" for="seis-p${item.idPregunta}">6</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="cinco-p${item.idPregunta}" value="5">
                                    <label class="form-check-label" for="cinco-p${item.idPregunta}">5</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="cuatro-p${item.idPregunta}" value="4">
                                    <label class="form-check-label" for="cuatro-p${item.idPregunta}">4</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="tres-p${item.idPregunta}" value="3">
                                    <label class="form-check-label" for="tres-p${item.idPregunta}">3</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="dos-p${item.idPregunta}" value="2">
                                    <label class="form-check-label" for="dos-p${item.idPregunta}">2</label>
                                </div>
                                <div class="form-check form-check-inline">
                                    <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="uno-p${item.idPregunta}" value="1">
                                    <label class="form-check-label" for="uno-p${item.idPregunta}">1</label>
                                </div>
                            </td>
                </tr>
                <tr class='verificarValidador' id='validar-p${item.idPregunta}' hidden><td colspan='3' class='text-center text-danger'><span>Escoja Una Opcion</span></td></tr>
                `
            )
        });
        contenedorPreguntas.removeAttribute("hidden");
    } catch (e) {
        handleError(e);
    }
}

async function seleccionarRespuesta(element) {
    try {
        document.querySelectorAll(`.sel-${element.id.split(`-`)[1]}`).forEach(async function (item, id) {
            item.classList.remove("seleccion");
            item.classList.remove("noSel");
        });
        element.closest("tr").classList.remove("invalid");
        element.classList.add("seleccion");
        document.getElementById(`validar-${element.id.split(`-`)[1]}`).hidden = true;
    } catch (e) {
        handleError(e);
    }
}

async function guardar() {
    try {
        let arrayEvaluacion = [];
        document.querySelectorAll(`.verificarValidador`).forEach(async function (item, id) {
            item.hidden = true;
        });

        document.querySelectorAll(`.noSel`).forEach(async function (item, id) {
            document.getElementById(`validar-${item.className.split('-')[3].split(' ')[0]}`).hidden = false;
            item.closest("tr").classList.add("invalid");
        });

        if (document.querySelectorAll(`.noSel`).length != 0) throw new Error("Complete todas las preguntas del test");

        document.querySelectorAll(`.seleccion`).forEach(async function (item, id) {
            arrayEvaluacion.push({
                idPregunta: item.className.split('@')[1],
                respuesta: item.value
            });
        });
        const evaluacion = evaluaciones.find(x => x.idAsignacion == idAsignatura.value);
        const data = new FormData();
        data.append('idInstrumento', idInstrumento);
        data.append('idPeriodo', evaluacion.idPeriodo);
        data.append('idAsignacion', evaluacion.idAsignacion);
        data.append('idMatricula', evaluacion.idMatricula);
        data.append('arrayEvaluacion', JSON.stringify(arrayEvaluacion));
        loaderShow();
        const url = `${baseUrl}guardar`;
        await axios.post(url, data);
        await toastSuccess("Evaluación docente guardada con exito");
        setTimeout(() => {
            top.location.reload();
        },1000);
    } catch (e) {
        handleError(e);
        loaderHide();
    }
}
