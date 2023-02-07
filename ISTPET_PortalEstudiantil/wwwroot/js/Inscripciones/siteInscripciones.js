window.addEventListener("load", () => {
    activarValidadores(frmDatos);
})

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

async function cambiarTipoDocumento(){
    idAlumno.removeAttribute("data-validate");
    idAlumno.classList.remove("is-invalid");
    if(tipoDocumento.value=="C"){
        idAlumno.setAttribute("data-validate","cedula");
        validarCedula(idAlumno);
    }else{
        validarVacio(idAlumno);
    }
    activarValidadores(personales);

}
