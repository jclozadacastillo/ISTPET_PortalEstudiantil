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
    if (typeof btnGuardarFlotante !== 'undefined' && btnGuardarFlotante) {
        btnGuardarFlotante.setAttribute("hidden", true);
    }
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
            nombreDocente.innerHTML = `${_evaluacion.abreviatura} ${_evaluacion.apellidos} ${_evaluacion.nombres}`
        }
        res.forEach(async function (item, id) {
            numero++;
            tablaEvaluacion.insertAdjacentHTML('beforeend',
                `
                <tr class='eval-q-row p-${item.idPregunta}'>
                    <td class='text-center align-middle py-3.5 ps-4 pe-2' style='width: 60px; min-width: 60px;'>
                        <span class='eval-num-badge'>${numero}</span>
                    </td>
                    <td class='align-middle py-3.5 px-3' style='width:auto !important; white-space:normal !important; word-break:break-word;'>
                        <span class='text-dark font-weight-semibold text-sm d-block' style='white-space:normal !important; line-height: 1.45;'>${item.pregunta}</span>
                    </td>
                    <td class='align-middle text-center py-3.5 ps-2 pe-4' style='width: 410px; min-width: 410px;'>
                        <div class="eval-rating-container">
                            <label class="eval-pill-item" title="Calificación 1 (Mínimo)">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r1-p${item.idPregunta}" value="1">
                                <span class="eval-pill-btn">1</span>
                            </label>
                            <label class="eval-pill-item" title="Calificación 2">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r2-p${item.idPregunta}" value="2">
                                <span class="eval-pill-btn">2</span>
                            </label>
                            <label class="eval-pill-item" title="Calificación 3">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r3-p${item.idPregunta}" value="3">
                                <span class="eval-pill-btn">3</span>
                            </label>
                            <label class="eval-pill-item" title="Calificación 4">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r4-p${item.idPregunta}" value="4">
                                <span class="eval-pill-btn">4</span>
                            </label>
                            <label class="eval-pill-item" title="Calificación 5">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r5-p${item.idPregunta}" value="5">
                                <span class="eval-pill-btn">5</span>
                            </label>
                            <label class="eval-pill-item" title="Calificación 6">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r6-p${item.idPregunta}" value="6">
                                <span class="eval-pill-btn">6</span>
                            </label>
                            <label class="eval-pill-item" title="Calificación 7">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r7-p${item.idPregunta}" value="7">
                                <span class="eval-pill-btn">7</span>
                            </label>
                            <label class="eval-pill-item" title="Calificación 8">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r8-p${item.idPregunta}" value="8">
                                <span class="eval-pill-btn">8</span>
                            </label>
                            <label class="eval-pill-item" title="Calificación 9">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r9-p${item.idPregunta}" value="9">
                                <span class="eval-pill-btn">9</span>
                            </label>
                            <label class="eval-pill-item" title="Calificación 10 (Excelente)">
                                <input onclick="seleccionarRespuesta(this)" class="form-check-input sel-p${item.idPregunta} pre@${item.idPregunta}@ noSel eval-pill-input" type="radio" name="inlineRadioOptions-p${item.idPregunta}" id="r10-p${item.idPregunta}" value="10">
                                <span class="eval-pill-btn">10</span>
                            </label>
                        </div>
                    </td>
                </tr>
                <tr class='verificarValidador' id='validar-p${item.idPregunta}' hidden>
                    <td colspan='3' class='p-2 border-0'>
                        <div class='eval-validation-alert text-center'>
                            <i class='bi-exclamation-triangle-fill me-1'></i> Por favor seleccione una opción entre 1 y 10 para esta pregunta.
                        </div>
                    </td>
                </tr>
                `
            )
        });
        contenedorPreguntas.removeAttribute("hidden");
        if (typeof btnGuardarFlotante !== 'undefined' && btnGuardarFlotante) {
            btnGuardarFlotante.removeAttribute("hidden");
        }
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
