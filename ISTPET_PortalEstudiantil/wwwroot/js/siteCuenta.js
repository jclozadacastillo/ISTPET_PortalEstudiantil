const baseUrl = `${_route}Cuenta/`;
const container = document.querySelector(".container-main");
const loader = document.querySelector(".loader");
const form=document.querySelector("form");
const modal= new bootstrap.Modal(document.getElementById("modal"),{
    keyboard:false
});

const anterior=form.querySelector("#anterior");
const nueva=form.querySelector("#password");
const confir=form.querySelector("#confir");


document.querySelector("#btnClave").addEventListener("click",()=>{
    form.querySelectorAll("input").forEach(item=>{
        item.classList.remove("is-invalid");
        item.value="";
    });
    modal.show();
});

let datos={};
init();
async function init() {
    try {
        await datosPersonales();
    } catch (e) {
        console.error(`${e.message}`);
    } finally {
        loader.hidden = true;
        container.hidden = false;
    }
}

async function datosPersonales() {
    try {
        datos={};
        const url = `${baseUrl}datosPersonales`;
        const res = (await axios.get(url)).data;
        if (!!res.error) throw new Error(res.error);
        datos=res;
        Object.keys(datos).forEach(key=>{
            const element=document.querySelector(`#${key}`);
            if(!!element) element.innerText=datos[key]||'SIN REGISTRO';
        });
        document.querySelector("#tipo").innerText=datos.tipoDocumento!="C"?"PASAPORTE":"CÉDULA";
        document.querySelector("#nombres").innerText=`${datos.primerNombre||""} ${datos.segundoNombre||""}`;
        document.querySelector("#apellidos").innerText=`${datos.apellidoPaterno||""} ${datos.apellidoMaterno||""}`;
    } catch (e) {
        if (e.message.search("401") >= 0) {
            toastError("Su sesión ha caducado");
            setTimeout(() => top.location.reload(), 1900);
        } else {
            toastError(`${e.message}`);
        }
    }
}


anterior.addEventListener("keyup",function(){
    const msg=this.closest("div").querySelector(".invalid-feedback");
    msg.innerText="* Campo requerido";
    if(this.value=="") return;
    if (this.value != datos.password) {
        msg.innerText = "* La contraseña no es la correcta";
        this.classList.add("is-invalid");
    } else {
        this.classList.remove("is-invalid");
    }
});


confir.addEventListener("keyup",function(){
    const msg=this.closest("div").querySelector(".invalid-feedback");
    msg.innerText="* Campo requerido";
    if(this.value=="") return;
    if(this.value!=nueva.value){
        msg.innerText="* Las contraseñas no coinciden";
        this.classList.add("is-invalid");
    } else {
        this.classList.remove("is-invalid");
    }
});

async function guardar(){
    try {
        let valido=await validarClaves();
        if(!!valido){
            toastError(valido);
            return;
        }
        if(!await validarTodo(form)){
            toastInfo("Verifica los campos requeridos");
            return;
        }
        if(!await toastPreguntar(`<p class='mt-2'>
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
        const data=new FormData(form);
        data.append("idAlumno",datos.idAlumno);
        disableForm(form);
        const res = (await axios.post(url,data)).data;
        if (!!res.error) throw new Error(res.error);
        toastLogout();
        setTimeout(()=>{top.location.reload()},1900);
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
        if (anterior.value != datos.password && anterior.value != "") mensaje = "La contraseña no es la correcta";
        if (nueva.value != confir.value) mensaje = "Las contraseñas no coinciden";
        if (!nueva.value.match(/^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,20}$/)) {
            mensaje = "La contraseña debe tener de 6 a 20 dígitos con un dígito numerico, uno en mayúsculas y uno en minúsculas";
        }
        resolve(mensaje);
    });
}