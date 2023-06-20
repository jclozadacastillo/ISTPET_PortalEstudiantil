const baseUrl = `${_route}Inscripciones/`;
const espere = new bootstrap.Modal(modalEspere, {
    keyboard: false,
    backdrop: false
})
window.addEventListener("load", () => {
    setTimeout(() => {
        window.scrollTo({ top: 0, behavior: 'smooth' });
    }, 109);
    activarValidadores(frmDatos);
    comboMedios();
    //comboProvincias();
});

function terminos() {
    btnFinalizar.hidden = !btnFinalizar.hidden;
}

async function siguiente(_from) {
    try {
        if (_from == 0) {
            //divAcademicos.hidden = true;
            divInscripcion.hidden = true;
            if (!await validarTodo(personales)) throw new Error("Verifique los campos requeridos");
            if (confir.value != email.value) throw new Error("Los correos electrónicos no coinciden");
            //if (await validarTodo(academicos)) divInscripcion.hidden = false;
            //limpiarValidadoresForm(academicos);
            //tabAcademicos.click();
            //divAcademicos.hidden = false;
        }
        if (_from == 2) {
            divInscripcion.hidden = true;
            if (!await validarTodo(personales)) throw new Error("Verifique los campos requeridos");
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
        const data = new FormData(frmDatos);
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        let html = `<option value=''>Selecciona</option>`;
        res.forEach(item => {
            html += `<option value="${item.idNivel}">${conduccion.value == 'true' ? item.nivel : item.Carrera}</option>`;
        });
        idNivel.innerHTML = html;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function comboProvincias() {
    try {
        const url = `${baseUrl}comboProvincias`;
        const res = (await axios.get(url)).data;
        if (!!res.error) throw new Error(res.error);
        let html = `<option value=''>Selecciona</option>`;
        res.forEach(item => {
            html += `<option value="${item.provincia}">${item.provincia}</option>`;
        });
        provincia.innerHTML = html;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function comboCiudades() {
    try {
        if (provincia.value == "") {
            ciudad.innerHTML = `<option value=''>Selecciona una provincia</option>`;
            return;
        }
        const url = `${baseUrl}comboCiudades`;
        const data = new FormData(frmDatos);
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        let html = `<option value=''>Selecciona</option>`;
        res.forEach(item => {
            html += `<option value="${item.ciudad}">${item.ciudad}</option>`;
        });
        ciudad.innerHTML = html;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function comboInstituciones() {
    try {
        if (ciudad.value == "") {
            idInstitucion.innerHTML = `<option value=''>Selecciona una ciudad</option>`;
            return;
        }
        const url = `${baseUrl}comboInstituciones`;
        const data = new FormData(frmDatos);
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        let html = `<option value=''>Selecciona</option>`;
        res.forEach(item => {
            html += `<option value="${item.idInstitucion}">${item.institucion}</option>`;
        });
        idInstitucion.innerHTML = html;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function comboMedios() {
    try {
        const url = `${baseUrl}comboMedios`;
        const res = (await axios.get(url)).data;
        if (!!res.error) throw new Error(res.error);
        let html = `<option value=''>Selecciona</option>`;
        res.forEach(item => {
            html += `<option value="${item.idMedio}">${item.medio}</option>`;
        });
        idMedio.innerHTML = html;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function comboSecciones() {
    try {
        if (idNivel.value == "") {
            divSeccion.hidden = true;
            divModalidad.hidden = true;
            divPeriodo.hidden = true;
            divTerminos.hidden = true;
            politicas.checked = false
            btnFinalizar.hidden = true;
            idSeccion.innerHTML = "<option value=''>Selecciona</option>";
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
        divSeccion.hidden = false;
        divModalidad.hidden = true;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function comboModalidades() {
    try {
        if (idSeccion.value == "") {
            divModalidad.hidden = true;
            divPeriodo.hidden = true;
            divTerminos.hidden = true;
            politicas.checked = false
            btnFinalizar.hidden = true;
            idModalidad.innerHTML = "<option value=''>Selecciona</option>";
            return;
        }
        const url = `${baseUrl}comboModalidades`;
        const data = new FormData(frmDatos);
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        console.log(res);
        let html = `<option value=''>Selecciona</option>`;
        res.forEach(item => {
            html += `<option value="${item.idModalidad}">${item.modalidad}</option>`;
        });
        idModalidad.innerHTML = html;
        divModalidad.hidden = false;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function comboPeriodos() {
    try {
        if (idModalidad.value == "") {
            divPeriodo.hidden = true;
            divTerminos.hidden = true;
            politicas.checked = false
            btnFinalizar.hidden = true;
            idPeriodo.innerHTML = "<option value=''>Selecciona una modalidad</option>";
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
        divPeriodo.hidden = false;
        idPeriodo.innerHTML = html;
    } catch (e) {
        toastError(`${e.message}`);
    }
}

async function guardar() {
    try {
        if (!await validarTodo(frmDatos)) throw new Error("Verifique todos los campos requeridos");
        if (confir.value.toString().toLowerCase() != email.value.toString().toLowerCase()) throw new Error("Los correos electrónicos no coinciden");
        frmDatos.querySelectorAll("input").forEach(item => {
            if (!(item.dataset.validate == "email")) {
                item.value = item.value.toUpperCase();
            }
        });
        const url = `${baseUrl}guardar`;
        const data = new FormData(frmDatos);
        espere.show();
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        formulario.classList.remove(...formulario.classList);
        formulario.classList.add("container-fluid");
        formulario.innerHTML = `
        <div class='row facts text-center pt-28 shadow-sm advice' style='height:100vh'>
        <div class='col-sm-6 mx-auto'>
            <div class='card fs-5 crystal'>
                <div class='card-body'>
                    <i class='bi-check-circle text-success' style='font-size:3rem'></i>
                    <p class='mt-2 fs-5 text-center' style='color:black'>
                        ${res}
                    </p>
                </div>
                <div class='col-sm-12 mb-4'>
                    <button class='btn btn-light' onclick='top.location.reload()'>FINALIZAR</button>
                </div>
            </div>

        </div>
    </div>
        `;
        window.scrollTo({ top: 0, behavior: 'smooth' });
    } catch (e) {
        toastError(`${e.message}`);
        console.error(`${e.message}`);
    } finally {
        setTimeout(() => { espere.hide() }, 109);
    }
}

function personalizarCombos() {
    if (conduccion.value == "") {
        divNivel.hidden = true;
        divSeccion.hidden = true;
        divModalidad.hidden = true;
        divPeriodo.hidden = true;
        divTerminos.hidden = true;
        return;
    }
    labelNivel.innerText = conduccion.value == "true" ? "¿Qué tipo de licencia?" : "¿Qué carrera?";
    divNivel.hidden = false;
}

function verTerminos() {
    divTerminos.hidden = idPeriodo.value == "";
    if (idPeriodo.value == "") {
        politicas.checked = false
        btnFinalizar.hidden = true;
    };
}