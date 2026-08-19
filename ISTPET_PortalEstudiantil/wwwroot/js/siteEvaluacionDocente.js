(function () {
    const baseUrl = `${_route}EvaluacionDocente/`;
    const loader = document.querySelector("#loader");
    const container = document.querySelector("#container");
    const frmDatos = document.querySelector("#frmDatos");
    if (!frmDatos) return;

    const idMatricula = frmDatos.querySelector("#idMatricula");
    const idAsignatura = frmDatos.querySelector("#idAsignatura");
    const contenedorPreguntas = document.querySelector("#contenedorPreguntas");
    const btnGuardarFlotante = document.querySelector("#btnGuardarFlotante");
    const tablaEvaluacion = document.querySelector("#tablaEvaluacion");
    const nombreDocente = document.querySelector("#nombreDocente");

    let evaluaciones = [];
    let idInstrumento = 0;

    const STORAGE_KEY_MATRICULA = "istpet_evaluacion_matricula";
    const STORAGE_KEY_ASIGNATURA = "istpet_evaluacion_asignatura";

    if (idMatricula) {
        idMatricula.addEventListener("change", async function () {
            if (idMatricula.value) {
                localStorage.setItem(STORAGE_KEY_MATRICULA, idMatricula.value);
            } else {
                localStorage.removeItem(STORAGE_KEY_MATRICULA);
                localStorage.removeItem(STORAGE_KEY_ASIGNATURA);
            }
            await comboAsignaturas();
        });
    }

    if (idAsignatura) {
        idAsignatura.addEventListener("change", async function () {
            if (contenedorPreguntas) contenedorPreguntas.setAttribute("hidden", true);
            if (btnGuardarFlotante) {
                btnGuardarFlotante.setAttribute("hidden", true);
            }
            if (tablaEvaluacion) tablaEvaluacion.innerHTML = "";
            if (this.value == "") {
                localStorage.removeItem(STORAGE_KEY_ASIGNATURA);
                return;
            }
            localStorage.setItem(STORAGE_KEY_ASIGNATURA, this.value);
            await cargarEvaluacion();
        });
    }

    // Inicialización automática desde localStorage
    init();

    async function init() {
        if (!idMatricula) return;
        const savedMatricula = localStorage.getItem(STORAGE_KEY_MATRICULA);
        let matriculaSeleccionada = false;

        if (savedMatricula && Array.from(idMatricula.options).some(o => o.value === savedMatricula)) {
            idMatricula.value = savedMatricula;
            matriculaSeleccionada = true;
        } else if (idMatricula.options.length === 2) {
            idMatricula.selectedIndex = 1;
            localStorage.setItem(STORAGE_KEY_MATRICULA, idMatricula.value);
            matriculaSeleccionada = true;
        }

        if (matriculaSeleccionada && idMatricula.value) {
            await comboAsignaturas(true);
        }
    }

    async function comboAsignaturas(restaurarGuardado = false) {
        try {
            evaluaciones = [];
            if (idAsignatura) idAsignatura.innerHTML = "<option value=''>Seleccione una carrera</option>";
            if (!idMatricula || idMatricula.value == "") return;
            const url = `${baseUrl}comboAsignaturas`;
            const res = (await axios.post(url, new FormData(frmDatos))).data;
            evaluaciones = res;
            let html = "<option value=''>Seleccione</option>";
            res.forEach(item => {
                html += `<option value='${item.idAsignacion}'>${item.asignatura}</option>`
            });
            if (idAsignatura) {
                idAsignatura.innerHTML = html;

                const savedAsignatura = localStorage.getItem(STORAGE_KEY_ASIGNATURA);
                if (restaurarGuardado && savedAsignatura && Array.from(idAsignatura.options).some(o => o.value === savedAsignatura)) {
                    idAsignatura.value = savedAsignatura;
                    await cargarEvaluacion();
                } else if (idAsignatura.options.length === 2) {
                    idAsignatura.selectedIndex = 1;
                    localStorage.setItem(STORAGE_KEY_ASIGNATURA, idAsignatura.value);
                    await cargarEvaluacion();
                }
            }
        } catch (e) {
            handleError(e);
        }
    }

    async function cargarEvaluacion() {
        try {
            const url = `${baseUrl}cargarEvaluacion`;
            const res = (await axios.get(url)).data;
            idInstrumento = res[0].idInstrumento;
            let numero = 0;
            const _evaluacion = evaluaciones.find(x => x.idAsignacion == idAsignatura.value);
            if (!!_evaluacion && nombreDocente) {
                nombreDocente.innerHTML = `${_evaluacion.abreviatura} ${_evaluacion.apellidos} ${_evaluacion.nombres}`
            }
            res.forEach(async function (item, id) {
                numero++;
                if (tablaEvaluacion) {
                    tablaEvaluacion.insertAdjacentHTML('beforeend',
                        `
                        <tr class='eval-q-row p-${item.idPregunta}'>
                            <td class='eval-col-num text-center align-middle py-3.5 ps-4 pe-2' style='width: 60px; min-width: 60px;'>
                                <span class='eval-num-badge'>${numero}</span>
                            </td>
                            <td class='eval-col-text align-middle py-3.5 px-3' style='width:auto !important; white-space:normal !important; word-break:break-word;'>
                                <span class='text-dark font-weight-semibold text-sm d-block' style='white-space:normal !important; line-height: 1.45;'>${item.pregunta}</span>
                            </td>
                            <td class='eval-col-rating align-middle text-center py-3.5 ps-2 pe-4' style='width: 410px; min-width: 410px;'>
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
                }
            });
            if (contenedorPreguntas) contenedorPreguntas.removeAttribute("hidden");
            if (btnGuardarFlotante) {
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
            const valEl = document.getElementById(`validar-${element.id.split(`-`)[1]}`);
            if (valEl) valEl.hidden = true;
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
                const targetVal = document.getElementById(`validar-${item.className.split('-')[3].split(' ')[0]}`);
                if (targetVal) targetVal.hidden = false;
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
            localStorage.removeItem(STORAGE_KEY_ASIGNATURA);
            await toastSuccess("Evaluación docente guardada con exito");
            setTimeout(() => {
                top.location.reload();
            }, 1000);
        } catch (e) {
            handleError(e);
            loaderHide();
        }
    }

    window.seleccionarRespuesta = seleccionarRespuesta;
    window.guardar = guardar;
})();
