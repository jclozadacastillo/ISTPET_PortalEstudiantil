const toastInfo = (texto) => {
    toastClear();
    siiimpleToast.message(`<i class='bi-info-circle'></i> <strong>ISTPET</strong>  ${texto}`,
        {
            container: 'body',
            class: 'siiimpleToast-info',
            position: 'top|right',
            margin: 15,
            delay: 0,
            duration: 3000,
            style: {
            },
        }
    );
}

const toastSuccess = (texto) => {
    toastClear();
    siiimpleToast.message(`<i class='bi-check-circle'></i> <strong>ISTPET</strong> ${texto}`,
        {
            container: 'body',
            class: 'siiimpleToast-success',
            position: 'top|right',
            margin: 15,
            delay: 0,
            duration: 5410,
            style: {
            },
        }
    );
}

const toastWarning = (texto) => {
    toastClear();
    siiimpleToast.message(`<i class='bi-exclamation-triangle'></i> <strong>ISTPET</strong>  ${texto}`,
        {
            container: 'body',
            class: 'siiimpleToast-warning',
            position: 'top|right',
            margin: 15,
            delay: 0,
            duration: 3000,
            style: {
            },
        }
    );
}

const toastError = (texto) => {
    toastClear();
    siiimpleToast.message(`<i class='bi-exclamation-circle me-1'></i> <strong>ISTPET</strong> <span>${texto}</span>`,
        {
            container: 'body',
            class: 'siiimpleToast-error',
            position: 'top|right',
            margin: 15,
            delay: 0,
            duration: 3700,
            style: {
            },
        }
    );
}

const toastHtml = async (html) => {
    let response;
    try {
        response = new Promise(resolve => {
            Swal.fire({
                html: `<img alter='ISTPET' src='${_route}template/img/logo.png' width="136"/><div class='mb-3 text-justify-all'>${html}</div>`,
                showCancelButton: false,
                confirmButtonColor: '#1F295B',
                confirmButtonText: 'Entendido',
            });
        });
    } catch (error) {
        console.log(`${error}`);
    }
    return await response;
}

const toastPreguntar = async (mensaje) => {
    let response;
    try {
        response = new Promise(resolve => {
            Swal.fire({
                html: `<img alter='ISTPET' src='${_route}template/img/logo.png' width="136"/><div class='mb-3 text-justify-all'>${mensaje}</div>`,
                showCancelButton: true,
                confirmButtonColor: '#1F295B',
                cancelButtonColor: '#999999',
                confirmButtonText: 'Si, Continuar',
                cancelButtonText: 'Cancelar'
            }).then((result) => {
                resolve(result.isConfirmed);
            });
        });
    } catch (error) {
        console.log(`${error}`);
    }
    return await response;
}

const toastPromise = async (mensaje) => {
    let response;
    try {
        response = new Promise(resolve => {
            Swal.fire({
                html: `<img alter='ISTPET' src='${_route}template/img/logo.png' width="136"/><div class='mb-3 text-justify-all'>${mensaje}</div>`,
                showCancelButton: false,
                confirmButtonColor: '#1F295B',
                confirmButtonText: 'Entendido'
            }).then((result) => {
                resolve(result.isConfirmed);
            });
        });
    } catch (error) {
        console.log(`${error}`);
    }
    return await response;
}

const toastPreguntarSolicitud = async () => {
    let response;
    try {
        response = new Promise(resolve => {
            Swal.fire({
                html: `<img alter='ISTPET' src='${_route}Content/Utilities/img/logo-azul163.png'/>
                        <div class='mb-3 text-justify-all'>
                        <p class="text-center text-sm p-0" >
                        <strong>¿Deseas continuar?</strong>
                        </p>
                        <p class='text-sm text-center p-0'>
                        <span class='text-danger'>Apartir de aquí <strong>NO</strong> podrás <strong>MODIFICAR</strong> tú solicitud.</span>
                        </p>
                        </div>`,
                showCancelButton: true,
                confirmButtonColor: '#1F295B',
                cancelButtonColor: '#999999',
                confirmButtonText: 'Si, Continuar',
                cancelButtonText: 'Cancelar'
            }).then((result) => {
                resolve(result.isConfirmed);
            });
        });
    } catch (error) {
        console.log(`${error}`);
    }
    return await response;
}

const toastLogout = async () => {
    let timerInterval
    Swal.fire({
        html: `<img src="${_route}template/img/logo.png" width="136"/>
                <p class="text-danger mt-3 py-0">
                    <strong class='text-sm text-danger'>Estamos cerrando tú sesión</strong>
                        <br>
                    <small class='text-sm text-muted'>Espera un momento por favor...</small>
                </p>
                `,
        timer: 2000,
        timerProgressBar: true,
        allowOutsideClick: false,
        closeOnClickOutside: false,
        allowEscapeKey: false,
        didOpen: () => {
            Swal.showLoading()
            timerInterval = setInterval(() => {
            }, 100)
        },
        willClose: () => {
            clearInterval(timerInterval)
        }
    }).then((result) => {
        if (result.dismiss === Swal.DismissReason.timer) {
        }
    })
}

function toastClear() {
    document.querySelectorAll("div.siiimpleToast-error,div.siiimpleToast-warning,div.siiimpleToast-success,div.siiimpleToast-info").forEach(item => {
        item.remove();
    });
}