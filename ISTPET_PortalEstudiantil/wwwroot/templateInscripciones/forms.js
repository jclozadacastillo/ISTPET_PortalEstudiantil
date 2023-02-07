const limpiarForm = (form) => {
    if (!!form)
        form.querySelectorAll("input,select,textarea").forEach((item) => {
            if (item.tagName.toUpperCase() == "SELECT") {
                item.selectedIndex = 0;
                item.classList.remove("is-invalid");
                limpiarSelect(item);
                if ($(item).data('select2')) {
                    $(item).val(item.options[0].value).trigger('change');
                    item.parentElement.querySelector("span.is-invalid")?.classList.remove("is-invalid");
                    return;
                }
            } else {
                item.value = "";
                item.classList.remove("is-invalid");
            }
        });
};

const cargarFormulario = (datos) => {
    Object.keys(datos).forEach(key => {
        let element = document.getElementById(key);
        if (!!element) {
            const _selectize = $(element)[0].selectize;
            if (!!_selectize) {
                setValueSelect(_selectize, datos[key]);
                return;
            }
            element.value = datos[key];
            if ($(element).data('select2')) {
                $(element).val(datos[key]).trigger('change');
                return;
            }
            if (element.getAttribute("type") == "date") {
                element.value = datos[key].split("T")[0];
            }
        }
    });
}

const cargarFormularioInForm = (form, datos) => {
    Object.keys(datos).forEach(key => {
        let element = form.querySelector(`#${key}`);
        if (!!element) {
            const _selectize = $(element)[0].selectize;
            if (!!_selectize) {
                setValueSelect(_selectize, datos[key]);
                return;
            }
            element.value = datos[key];
            if ($(element).data('select2')) {
                $(element).val(datos[key]).trigger('change');
                return;
            }
            if (element.getAttribute("type") == "date") {
                element.value = datos[key].split("T")[0];
            }
        }
    });
}

function activarValidadores(form) {
    if (!form) {
        console.error("No se ha enviado ningún form");
        return;
    }
    form.querySelectorAll("input,select,textarea").forEach((item) => {
        let special_validate = item.dataset.validate;
        if (special_validate == "no-validate") return;
        if (!special_validate) {
            item.addEventListener("keyup", () => {
                validarVacio(item);
            });
            if (item.tagName.toLocaleLowerCase() == "select" || item.type.toLocaleLowerCase() == "file" || item.type.toLocaleLowerCase().indexOf("date") >= 0) {
                item.addEventListener("change", () => {
                    validarVacio(item);
                });
                const elementSelect2 = item.classList.contains("select2-hidden-accessible");
                if (!!elementSelect2) {
                    $(item).on('select2:select', function (e) {
                        validarVacio(item);
                    });
                }
            }
        }
        if (special_validate?.split(",") > 0) {
            special_validate.split(",").forEach(__validador => {
                if (__validador == "edad-18") {
                    item.addEventListener("keyup", () => {
                        fechaMayorDeEdad(item);
                    });
                }
                if (__validador == "cedula") {
                    item.addEventListener("keyup", () => {
                        validarCedula(item);
                    });
                }
                if (__validador == "email") {
                    item.addEventListener("keyup", () => {
                        validarEmail(item);
                    });
                }
                if (__validador == "no-espacios") {
                    item.addEventListener("keyup", () => {
                        noEspacios(item);
                    });
                }
                if (__validador == "numeros") {
                    item.addEventListener("keyup", () => {
                        soloNumeros(item);
                    });
                }
                if (__validador == "numeros-no-cero") {
                    item.addEventListener("keyup", () => {
                        soloNumerosNoCero(item);
                    });
                }
                if (__validador == "letras") {
                    item.addEventListener("keyup", () => {
                        soloLetras(item);
                    });
                }
                if (__validador == "clave") {
                    item.addEventListener("keyup", () => {
                        validarClave(item);
                    });
                }

                if (__validador == "decimal") {
                    item.addEventListener("input", () => {
                        parseToDecimal(item);
                    });
                    item.addEventListener("keyup", () => {
                        decimal(item);
                    });
                }
            });
        } else {
            if (special_validate == "edad-18") {
                item.addEventListener("keyup", () => {
                    fechaMayorDeEdad(item);
                });
            }
            if (special_validate == "cedula") {
                item.addEventListener("keyup", () => {
                    validarCedula(item);
                });
            }
            if (special_validate == "email") {
                item.addEventListener("keyup", () => {
                    validarEmail(item);
                });
            }
            if (special_validate == "no-espacios") {
                item.addEventListener("keyup", () => {
                    noEspacios(item);
                });
            }
            if (special_validate == "numeros") {
                item.addEventListener("keyup", () => {
                    soloNumeros(item);
                });
            }
            if (special_validate == "numeros-no-cero") {
                item.addEventListener("keyup", () => {
                    soloNumerosNoCero(item);
                });
            }
            if (special_validate == "letras") {
                item.addEventListener("keyup", () => {
                    soloLetras(item);
                });
            }
            if (special_validate == "clave") {
                item.addEventListener("keyup", () => {
                    validarClave(item);
                });
            }

            if (special_validate == "decimal") {
                item.addEventListener("input", () => {
                    parseToDecimal(item);
                });
                item.addEventListener("keyup", () => {
                    decimal(item);
                });
            }
        }
    });
}

document.querySelector("form")?.querySelectorAll("input,select,textarea").forEach((item) => {
    let special_validate = item.dataset.validate;
    if (special_validate == "no-validate") return;
    if (!special_validate) {
        item.addEventListener("keyup", () => {
            validarVacio(item);
        });
        if (item.tagName.toLocaleLowerCase() == "select" || item.type.toLocaleLowerCase() == "file" || item.type.toLocaleLowerCase().indexOf("date") >= 0) {
            item.addEventListener("change", () => {
                validarVacio(item);
            });
            const elementSelect2 = item.classList.contains("select2-hidden-accessible");
            if (!!elementSelect2) {
                $(item).on('select2:select', function (e) {
                    validarVacio(item);
                });
            }
        }
    }

    if (special_validate?.split(",") > 0) {
        special_validate.split(",").forEach(__validador => {
            if (__validador == "cedula") {
                item.addEventListener("keyup", () => {
                    validarCedula(item);
                });
            }
            if (__validador == "email") {
                item.addEventListener("keyup", () => {
                    validarEmail(item);
                });
            }
            if (__validador == "no-espacios") {
                item.addEventListener("keyup", () => {
                    noEspacios(item);
                });
            }
            if (__validador == "numeros") {
                item.addEventListener("keyup", () => {
                    soloNumeros(item);
                });
            }
            if (__validador == "numeros-no-cero") {
                item.addEventListener("keyup", () => {
                    soloNumerosNoCero(item);
                });
            }
            if (__validador == "letras") {
                item.addEventListener("keyup", () => {
                    soloLetras(item);
                });
            }
            if (__validador == "clave") {
                item.addEventListener("keyup", () => {
                    validarClave(item);
                });
            }

            if (__validador == "decimal") {
                item.addEventListener("input", () => {
                    parseToDecimal(item);
                });
                item.addEventListener("keyup", () => {
                    decimal(item);
                });
            }
        });
    } else {
        if (special_validate == "cedula") {
            item.addEventListener("keyup", () => {
                validarCedula(item);
            });
        }
        if (special_validate == "email") {
            item.addEventListener("keyup", () => {
                validarEmail(item);
            });
        }
        if (special_validate == "no-espacios") {
            item.addEventListener("keyup", () => {
                noEspacios(item);
            });
        }
        if (special_validate == "numeros") {
            item.addEventListener("keyup", () => {
                soloNumeros(item);
            });
        }
        if (special_validate == "numeros-no-cero") {
            item.addEventListener("keyup", () => {
                soloNumerosNoCero(item);
            });
        }
        if (special_validate == "letras") {
            item.addEventListener("keyup", () => {
                soloLetras(item);
            });
        }
        if (special_validate == "clave") {
            item.addEventListener("keyup", () => {
                validarClave(item);
            });
        }

        if (special_validate == "decimal") {
            item.addEventListener("input", () => {
                parseToDecimal(item);
            });
            item.addEventListener("keyup", () => {
                decimal(item);
            });
        }
    }
});
document.querySelector("#frmClave")?.querySelectorAll("input").forEach((item) => {
    let special_validate = item.dataset.validate;
    if (!special_validate) {
        item.addEventListener("keyup", () => {
            validarVacio(item);
        });
    }
});

document.querySelector("#frmRegistro")?.querySelectorAll("input,select,textarea").forEach((item) => {
    let special_validate = item.dataset.validate;
    if (special_validate == "no-validate") return;
    if (!special_validate) {
        item.addEventListener("keyup", () => {
            validarVacio(item);
        });
        if (item.tagName.toLocaleLowerCase() == "select" || item.type.toLocaleLowerCase() == "file") {
            item.addEventListener("change", () => {
                validarVacio(item);
            });
        }
    }

    if (special_validate.split(",") > 0) {
        special_validate.split(",").forEach(__validador => {
            if (__validador == "cedula") {
                item.addEventListener("keyup", () => {
                    validarCedula(item);
                });
            }
            if (__validador == "email") {
                item.addEventListener("keyup", () => {
                    validarEmail(item);
                });
            }
            if (__validador == "no-espacios") {
                item.addEventListener("keyup", () => {
                    noEspacios(item);
                });
            }
            if (__validador == "numeros") {
                item.addEventListener("keyup", () => {
                    soloNumeros(item);
                });
            }
            if (__validador == "numeros-no-cero") {
                item.addEventListener("keyup", () => {
                    soloNumerosNoCero(item);
                });
            }
            if (__validador == "letras") {
                item.addEventListener("keyup", () => {
                    soloLetras(item);
                });
            }
            if (__validador == "clave") {
                item.addEventListener("keyup", () => {
                    validarClave(item);
                });
            }

            if (__validador == "decimal") {
                item.addEventListener("input", () => {
                    parseToDecimal(item);
                });
                item.addEventListener("keyup", () => {
                    decimal(item);
                });
            }
        });
    } else {
        if (special_validate == "cedula") {
            item.addEventListener("keyup", () => {
                validarCedula(item);
            });
        }
        if (special_validate == "email") {
            item.addEventListener("keyup", () => {
                validarEmail(item);
            });
        }
        if (special_validate == "no-espacios") {
            item.addEventListener("keyup", () => {
                noEspacios(item);
            });
        }
        if (special_validate == "numeros") {
            item.addEventListener("keyup", () => {
                soloNumeros(item);
            });
        }
        if (special_validate == "numeros-no-cero") {
            item.addEventListener("keyup", () => {
                soloNumerosNoCero(item);
            });
        }
        if (special_validate == "letras") {
            item.addEventListener("keyup", () => {
                soloLetras(item);
            });
        }
        if (special_validate == "clave") {
            item.addEventListener("keyup", () => {
                validarClave(item);
            });
        }

        if (special_validate == "decimal") {
            item.addEventListener("input", () => {
                parseToDecimal(item);
            });
            item.addEventListener("keyup", () => {
                decimal(item);
            });
        }
    }
});

document.querySelector("#frmClave")?.querySelectorAll("input").forEach((item) => {
    let special_validate = item.dataset.validate;
    if (!special_validate) {
        item.addEventListener("keyup", () => {
            validarVacio(item);
        });
    }
});

const validarVacio = async (item) => {
    return new Promise((resolve) => {
        try {
            item.classList.remove("is-invalid");
            if (item.tagName == "SELECT") {
                const tomselectObj = document.querySelector(`#${item.getAttribute("id")}-ts-control`);
                if (!!tomselectObj) {
                    tomselectObj.parentElement?.classList.remove("is-invalid");
                    const valorTomSelect = tomselectObj.parentElement.querySelector("div[data-value]");
                    if (!valorTomSelect) {
                        tomselectObj.parentElement?.classList.add("is-invalid");
                        throw new Error("false1");
                    }
                }
                const elementSelect2 = item.classList.contains("select2-hidden-accessible");
                if (!!elementSelect2) {
                    item.parentElement.querySelector(".select2-container")?.classList.remove("is-invalid");
                    if (!item.value) {
                        item.classList.add("is-invalid");
                        item.parentElement.querySelector(".select2-container")?.classList.add("is-invalid");
                        throw new Error("false2");
                    }
                }
            }
            if (item.value.trim() == "") {
                item.classList.add("is-invalid");
                if (item.getAttribute("id").search("ts-control") < 0) throw new Error(item);
            }
            resolve(true);
        } catch (e) {
            resolve(false);
        }
    });
};

const parseToDecimal = (e) => {
    e.value = e.value.replace(/(?!^[\-\d\,.])[^\d\\d\,.]/g, '');
    e.value = e.value.replaceAll(".", ",");
    e.value = e.value.replaceAll("d", "");
    if (e.value.split(",").length > 2)
        e.value = e.value.substring(0, e.value.length - 1);
}

const validarCedula = async (cedula) => {
    let respuesta;
    const feedback_cedula =
        cedula.parentElement.querySelector(".invalid-feedback");
    try {
        respuesta = new Promise((resolve) => {
            feedback_cedula.innerHTML = "* Campo requerido";
            cedula.classList.remove("is-invalid");
            let documento = cedula.value;
            if (documento.trim() == "") {
                cedula.classList.add("is-invalid");
                resolve(false);
                return;
            }
            feedback_cedula.innerHTML = "* Cédula inválida";

            if (documento.length != 10) {
                cedula.classList.add("is-invalid");
                resolve(false);
                return;
            }
            let veriRepe = 0;
            for (let index = 0; index < documento.length; index++) {
                if (documento[index] == documento[0]) veriRepe++;
            }
            if (veriRepe > 7) {
                cedula.classList.add("is-invalid");
                resolve(false);
                return;
            }
            var digito_region = documento.substring(0, 2);
            if (digito_region >= 1 && digito_region <= 24) {
                var ultimo_digito = documento.substring(9, 10);
                var pares =
                    parseInt(documento.substring(1, 2)) +
                    parseInt(documento.substring(3, 4)) +
                    parseInt(documento.substring(5, 6)) +
                    parseInt(documento.substring(7, 8));
                var numero1 = documento.substring(0, 1);
                var numero1 = numero1 * 2;
                if (numero1 > 9) {
                    var numero1 = numero1 - 9;
                }
                var numero3 = documento.substring(2, 3);
                var numero3 = numero3 * 2;
                if (numero3 > 9) {
                    var numero3 = numero3 - 9;
                }
                var numero5 = documento.substring(4, 5);
                var numero5 = numero5 * 2;
                if (numero5 > 9) {
                    var numero5 = numero5 - 9;
                }
                var numero7 = documento.substring(6, 7);
                var numero7 = numero7 * 2;
                if (numero7 > 9) {
                    var numero7 = numero7 - 9;
                }
                var numero9 = documento.substring(8, 9);
                var numero9 = numero9 * 2;
                if (numero9 > 9) {
                    var numero9 = numero9 - 9;
                }
                var impares = numero1 + numero3 + numero5 + numero7 + numero9;
                var suma_total = pares + impares;
                var primer_digito_suma = String(suma_total).substring(0, 1);
                var decena = (parseInt(primer_digito_suma) + 1) * 10;
                var digito_validador = decena - suma_total;
                if (digito_validador == 10) var digito_validador = 0;
                if (digito_validador == ultimo_digito) {
                    cedula.classList.remove("is-invalid");
                    resolve(true);
                    return;
                } else {
                    cedula.classList.add("is-invalid");
                    resolve(false);
                    return;
                }
            } else {
                cedula.classList.add("is-invalid");
                resolve(false);
                return;
            }
        });
    } catch (e) {
        console.log(e);
        respuesta = false;
    }
    return await respuesta;
};

const validarEmail = async (email) => {
    let res = new Promise((resolve) => {
        let valido = true;
        const msg = email.parentElement.querySelector(".invalid-feedback");
        email.classList.remove("is-invalid");
        if (email.value.trim() == "") {
            msg.innerText = "* Campo requerido";
            email.classList.add("is-invalid");
            valido = false;
            resolve(false);
            return;
        }
        msg.innerText = "* Email inválido";
        const res = email.value.match(/^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/g);
        if (res == null) {
            email.classList.add("is-invalid");
            valido = false;
        }
        resolve(valido);
    });
    return await res;
};
function fechaMayorDeEdad(_fecha){
    return new Promise((resolve) => {
        let valido = true;
        const msg = _fecha.parentElement.querySelector(".invalid-feedback");
        _fecha.classList.remove("is-invalid");
        if (_fecha.value.trim() == "") {
            msg.innerText = "* Campo requerido";
            _fecha.classList.add("is-invalid");
            valido = false;
            resolve(false);
            return;
        }
        msg.innerText = "* Fecha inválida";
        var hoy = new Date();
        var cumpleanos = new Date(_fecha.value);
        var edad = hoy.getFullYear() - cumpleanos.getFullYear();
        var m = hoy.getMonth() - cumpleanos.getMonth();
    
        if (m < 0 || (m === 0 && hoy.getDate() < cumpleanos.getDate())) {
            edad--;
        }
        if(edad<18 || edad>110){
            _fecha.classList.add("is-invalid");
            valido = false;
        }
        resolve(valido);
    });
};

const decimal = async (e) => {
    let respuesta = new Promise(resolve => {
        const minimo = 1;
        e.classList.remove("is-invalid");
        const msg = e.parentElement.querySelector(".invalid-feedback");
        let valido = true;
        msg.innerText = "* Campo requerido";
        if (e.value.trim() == "") {
            e.classList.add("is-invalid");
            valido = false;
        }
        if (e.value.split(",")[1] == "") {
            msg.innerText = "* Valor inválido";
            e.classList.add("is-invalid");
            valido = false;
        }
        if (parseFloat(e.value.replaceAll(",", ".")) < minimo) {
            msg.innerText = `* Mínimo ${minimo.toString().replaceAll(".", ",")}`;
            e.classList.add("is-invalid");
            valido = false;
        }
        resolve(valido)
    });
    return await respuesta;
}

const soloNumeros = async (e) => {
    let res = new Promise((resolve) => {
        e.classList.remove("is-invalid");
        e.value = e.value.replace(/[a-zA-Z]/g, "");
        e.value = e.value.replaceAll(" ", "");
        e.value = e.value.replaceAll("-", "");
        e.value = e.value.replaceAll("d", "");
        e.value = e.value.replaceAll("D", "");
        e.value = e.value.replace(/[`~!@#$%^&*()_|+\=?;:'",.<>\{\}\[\]\\\/]/gi, "");
        if (e.value.trim() == "") {
            e.classList.add("is-invalid");
            resolve(false);
        } else {
            resolve(true);
        }
    });
    return await res;
};

const noEspacios = async (e) => {
    let res = new Promise((resolve) => {
        e.classList.remove("is-invalid");
        e.value = e.value.replaceAll(" ", "");
        e.value = e.value.replaceAll("-", "");
        //e.value = e.value.replace(/[`~!@#$%^&*()_|+\=?;:'",.<>\{\}\[\]\\\/]/gi, "");
        if (e.value.trim() == "") {
            e.classList.add("is-invalid");
            resolve(false);
        } else {
            resolve(true);
        }
    });
    return await res;
};

const soloNumerosNoCero = async (e) => {
    let res = new Promise((resolve) => {
        e.classList.remove("is-invalid");
        e.value = e.value.replace(/[a-zA-Z]/g, "");
        e.value = e.value.replaceAll(" ", "");
        e.value = e.value.replaceAll("-", "");
        e.value = e.value.replaceAll("d", "");
        e.value = e.value.replaceAll("D", "");
        e.value = e.value.replace(/[`~!@#$%^&*()_|+\=?;:'",.<>\{\}\[\]\\\/]/gi, "");
        if (e.value.replaceAll(" ","").trim() == "") {
            e.classList.add("is-invalid");
            resolve(false);
        } else if (parseInt(e.value) == 0) {
            e.classList.add("is-invalid");
            resolve(false);
        } else {
            resolve(true);
        }
    });
    return await res;
};

const soloLetras = async (e) => {
    let res = new Promise((resolve) => {
        e.classList.remove("is-invalid");
        e.value = e.value.replace(/[0-9]/g, "");
        e.value = e.value.replaceAll(" ", "");
        e.value = e.value.replaceAll("-", "");
        e.value = e.value.replace(/[`~!@#$%^&*()_|+\=?;:'",.<>\{\}\[\]\\\/]/gi, "");
        if (e.value.trim() == "") {
            e.classList.add("is-invalid");
            resolve(false);
        } else {
            resolve(true);
        }
    });
    return await res;
};

const validarClave = async (clave) => {
    let res = new Promise((resolve) => {
        let valido = true;
        clave.classList.remove("is-invalid");
        clave.value = clave.value.replaceAll(" ", "");
        if (clave.value.trim() == "") {
            clave.classList.add("is-invalid");
            valido = false;
        }
        const confir = document.getElementById("clave_confir");
        const clave2 = document.getElementById("clave");
        const confir_msg = confir.parentElement.querySelector(".invalid-feedback");
        confir_msg.innerText = "* Campo requerido";
        if (confir.value != clave2.value) {
            confir_msg.innerText = "* Las claves no coinciden";
            confir.classList.add("is-invalid");
            valido = false;
        }
        if (confir.value == "") {
            confir.classList.add("is-invalid");
            confir_msg.innerText = "* Campo requerido";
            valido = false;
        }
        resolve(valido);
    });
    return await res;
};

const validarTodo = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            const vacios = await todoVacios(form);
            const emails = await todoEmail(form);
            const cedulas = await todoCedulas(form);
            const numeros = await todoNumeros(form);
            const numerosNoCero = await todoNumerosNoCero(form);
            const letras = await todoLetras(form);
            const decimales = await todoDecimales(form);
            const claves = await todoClaves(form);
            const espacios = await todoNoEspacios(form);
            const fechasMayorDeEdad = await todoFechasMayorDeEdad(form);
            const valido = vacios * emails * cedulas * numeros * claves * decimales * letras * numerosNoCero * espacios*fechasMayorDeEdad;
            resolve(valido > 0);
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};

const todoVacios = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            const grupo = form.querySelectorAll(
                "input:not([data-validate]),select:not([data-validate]),textarea:not([data-validate])"
            );
            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await validarVacio(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};

const todoEmail = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            let elementosGrupo = form.querySelectorAll(
                `input[data-validate]`
            );
            let grupo = [];
            await new Promise(resolveGrupo => {
                if (elementosGrupo.length == 0) resolveGrupo(true);
                elementosGrupo.forEach((item, index) => {
                    if (item.dataset.validate.split(",").indexOf('email') >= 0
                        && item.dataset.validate.split(",").indexOf('no-validate') < 0) grupo.push(item);
                    if (index == elementosGrupo.length - 1) resolveGrupo(true);
                });
            });
            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await validarEmail(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};

const todoNumeros = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            let elementosGrupo = form.querySelectorAll(
                `input[data-validate]`
            );
            let grupo = [];
            await new Promise(resolveGrupo => {
                if (elementosGrupo.length == 0) resolveGrupo(true);
                elementosGrupo.forEach((item, index) => {
                    if (item.dataset.validate.split(",").indexOf('numeros') >= 0
                        && item.dataset.validate.split(",").indexOf('no-validate') < 0) grupo.push(item);
                    if (index == elementosGrupo.length - 1) resolveGrupo(true);
                });
            });
            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await soloNumeros(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};
const todoNumerosNoCero = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            let elementosGrupo = form.querySelectorAll(
                `input[data-validate]`
            );
            let grupo = [];
            await new Promise(resolveGrupo => {
                if (elementosGrupo.length == 0) resolveGrupo(true);
                elementosGrupo.forEach((item, index) => {
                    if (item.dataset.validate.split(",").indexOf('numeros-no-cero') >= 0
                        && item.dataset.validate.split(",").indexOf('no-validate') < 0) grupo.push(item);
                    if (index == elementosGrupo.length - 1) resolveGrupo(true);
                });
            });

            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await soloNumerosNoCero(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};
const todoLetras = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            let elementosGrupo = form.querySelectorAll(
                `input[data-validate]`
            );
            let grupo = [];
            await new Promise(resolveGrupo => {
                if (elementosGrupo.length == 0) resolveGrupo(true);
                elementosGrupo.forEach((item, index) => {
                    if (item.dataset.validate.split(",").indexOf('letras') >= 0
                        && item.dataset.validate.split(",").indexOf('no-validate') < 0) grupo.push(item);
                    if (index == elementosGrupo.length - 1) resolveGrupo(true);
                });
            });
            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await soloLetras(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};

const todoNoEspacios = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            let elementosGrupo = form.querySelectorAll(
                `input[data-validate]`
            );
            let grupo = [];
            await new Promise(resolveGrupo => {
                if (elementosGrupo.length == 0) resolveGrupo(true);
                elementosGrupo.forEach((item, index) => {
                    if (item.dataset.validate.split(",").indexOf('no-espacios') >= 0
                        && item.dataset.validate.split(",").indexOf('no-validate') < 0) grupo.push(item);
                    if (index == elementosGrupo.length - 1) resolveGrupo(true);
                });
            });
            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await noEspacios(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};

const todoDecimales = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            let elementosGrupo = form.querySelectorAll(
                `input[data-validate]`
            );
            let grupo = [];
            await new Promise(resolveGrupo => {
                if (elementosGrupo.length == 0) resolveGrupo(true);
                elementosGrupo.forEach((item, index) => {
                    if (item.dataset.validate.split(",").indexOf('decimal') >= 0
                        && item.dataset.validate.split(",").indexOf('no-validate') < 0) grupo.push(item);
                    if (index == elementosGrupo.length - 1) resolveGrupo(true);
                });
            });
            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await decimal(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};

const todoCedulas = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            let elementosGrupo = form.querySelectorAll(
                `input[data-validate]`
            );
            let grupo = [];
            await new Promise(resolveGrupo => {
                if (elementosGrupo.length == 0) resolveGrupo(true);
                elementosGrupo.forEach((item, index) => {
                    if (item.dataset.validate.split(",").indexOf('cedula') >= 0
                        && item.dataset.validate.split(",").indexOf('no-validate') < 0) grupo.push(item);
                    if (index == elementosGrupo.length - 1) resolveGrupo(true);
                });
            });
            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await validarCedula(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};


const todoFechasMayorDeEdad = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            let elementosGrupo = form.querySelectorAll(
                `input[data-validate]`
            );
            let grupo = [];
            await new Promise(resolveGrupo => {
                if (elementosGrupo.length == 0) resolveGrupo(true);
                elementosGrupo.forEach((item, index) => {
                    if (item.dataset.validate.split(",").indexOf('edad-18') >= 0
                        && item.dataset.validate.split(",").indexOf('no-validate') < 0) grupo.push(item);
                    if (index == elementosGrupo.length - 1) resolveGrupo(true);
                });
            });
            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await fechaMayorDeEdad(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};

const todoClaves = async (form) => {
    let res;
    try {
        res = new Promise(async (resolve) => {
            let valido = true;
            let cont = 0;
            let elementosGrupo = form.querySelectorAll(
                `input[data-validate]`
            );
            let grupo = [];
            await new Promise(resolveGrupo => {
                if (elementosGrupo.length == 0) resolveGrupo(true);
                elementosGrupo.forEach((item, index) => {
                    if (item.dataset.validate.split(",").indexOf('clave') >= 0
                        && item.dataset.validate.split(",").indexOf('no-validate') < 0) grupo.push(item);
                    if (index == elementosGrupo.length - 1) resolveGrupo(true);
                });
            });
            if (grupo.length == 0) {
                resolve(true);
                return;
            }
            grupo.forEach(async (item) => {
                if (!(await validarClave(item))) valido = false;
                if (cont == grupo.length - 1) resolve(valido);
                cont++;
            });
        });
    } catch (e) {
        console.log(`${e}`);
    }
    return await res;
};

const disableForm = (form) => {
    form.querySelectorAll("input,select,textarea").forEach(item => {
        item.setAttribute("readonly", true);
    });
    form.querySelectorAll("button").forEach(item => {
        item.disabled = true;
    });

    document.querySelector(".modal")
    ?.querySelectorAll("button,a").forEach(item => {
        item.disabled = true;
    });

    document.querySelectorAll("div.modal").forEach(item => {
        const e1 = item.querySelector("button.close");
        const e2 = item.querySelector("button.btn-close");
        if (!!e1) e1.disabled = true;
        if (!!e2) e2.disabled = true;
    });
}

const disableFormNoButton = (form) => {
    form.querySelectorAll("input,select").forEach(item => {
        item.setAttribute("readonly", true);
    });
}

const enableForm = (form) => {
    form.querySelectorAll("input,select,textarea").forEach(item => {
        if (item.dataset.disabled != undefined) item.setAttribute("readonly", true);
        else item.removeAttribute("readonly");
    });
    form.querySelectorAll("button").forEach(item => {
        item.disabled = false;
    });

    document.querySelector(".modal")
    ?.querySelectorAll("button,a").forEach(item => {
        item.disabled = false;
    });

    document.querySelectorAll("div.modal").forEach(item => {
        const e1 = item.querySelector("button.close");
        const e2 = item.querySelector("button.btn-close");
        if (!!e1) e1.disabled = false;
        if (!!e2) e2.disabled = false;
    });
}

const parseHora = (date) => {
    let fecha = new Date(Date.parse(date));
    return fecha.toLocaleTimeString();
}

const parseFecha = (date) => {
    let fecha = new Date(Date.parse(date));
    return fecha.toLocaleDateString();
}

const controlarRangoFechas = (desde, hasta) => {
    let hoy = new Date().toISOString().split("T")[0];
    desde?.setAttribute("min", hoy);
    hasta?.setAttribute("min", hoy);
    sessionStorage.removeItem(`fechaDesde`);
    sessionStorage.removeItem(`fechaHasta`);
    desde?.addEventListener("change", (e) => {
        const msg = e.target.parentElement.querySelector(".invalid-feedback");
        if (!!msg) msg.innerText = "* Campo requerido";
        if (e.target.value == "") {
            sessionStorage.removeItem(`fechaDesde`);
            e.target.classList.add("is-invalid");
            return;
        }
        e.target.classList.remove("is-invalid");
        sessionStorage.setItem(`fechaDesde`, Date.parse(e.target.value));
        let fechaDesde = sessionStorage.getItem("fechaDesde");
        let fechaHasta = sessionStorage.getItem("fechaHasta");
        if (!fechaDesde || !fechaHasta) return;
        if (fechaHasta < fechaDesde) {
            if (!!msg) msg.innerText = "* Fecha fuera de rango";
            e.target.classList.add("is-invalid");
        } else {
            desde?.classList.remove("is-invalid");
            hasta?.classList.remove("is-invalid");
        }
    });
    hasta?.addEventListener("change", (e) => {
        const msg = e.target.parentElement.querySelector(".invalid-feedback");
        if (!!msg) msg.innerText = "* Campo requerido";
        if (e.target.value == "") {
            sessionStorage.removeItem(`fechaHasta`);
            e.target.classList.add("is-invalid");
            return;
        }
        e.target.classList.remove("is-invalid");
        sessionStorage.setItem(`fechaHasta`, Date.parse(e.target.value));
        let fechaDesde = sessionStorage.getItem("fechaDesde");
        let fechaHasta = sessionStorage.getItem("fechaHasta");
        if (fechaHasta < fechaDesde) {
            if (!!msg) msg.innerText = "* Fecha fuera de rango";
            e.target.classList.add("is-invalid");
        } else {
            desde?.classList.remove("is-invalid");
            hasta?.classList.remove("is-invalid");
        }
    });
}

const validarRangoFechas = (desde, hasta) => {
    return new Promise(resolve => {
        if (!desde || !hasta) {
            console.log("No se han enviado los dos objetos de fecha requeridos");
            resolve(false);
        } else if (Date.parse(hasta.value) < Date.parse(desde.value)) {
            const msg = desde.parentElement.querySelector(".invalid-feedback");
            if (!!msg) msg.innerText = "* Fechas fuera de rango";
            desde.classList.add("is-invalid");
            hasta.classList.remove("is-invalid");
            resolve(false);
        } else {
            const msg = desde.parentElement.querySelector(".invalid-feedback");
            if (!!msg) msg.innerText = "* Campo requerido";
            desde.classList.remove("is-invalid");
            hasta.classList.remove("is-invalid");
            resolve(true);
        }
    });
}

function limitarFechaInput(input, min, max) {
    try {
        if (!!min) {
            let fmin = new Date(Date.parse(min.split("T")[0]));
            fmin = fmin.toISOString().split("T")[0];
            input.setAttribute("min", fmin);
        }
        if (!!max) {
            let fmax = new Date(Date.parse(max.split("T")[0]));
            fmax = fmax.toISOString().split("T")[0];
            input.setAttribute("max", fmax);
        }
    } catch (e) {
        console.warn(`${e.message}`);
    }
}

function eliminarValidador(id) {
    try {
        const _element = document.querySelector(`#${id}`);
        if (!_element) return;
        _element.removeAttribute("data-validate");
        _element.setAttribute("data-validate", "no-validate");
        activarValidadores(_element.closest("form"));
    } catch (e) {
        console.warn(`${e.message}`);
    }
}

function reactivarValidador(id, tipo) {
    try {
        const _element = document.querySelector(`#${id}`);
        if (!_element) return;
        _element.removeAttribute("data-validate");
        if (!!tipo) _element.setAttribute("data-validate", tipo);
        activarValidadores(_element.closest("form"));
    } catch (e) {
        console.warn(`${e.message}`);
    }
}

function limpiarValidadoresForm(form) {
    if (!form) {
        console.warn("No se ha enviado un form o contenedor válido");
        return;
    }
    form.querySelectorAll(".is-invalid").forEach(item => {
        item.classList.remove("is-invalid");
    });
}

function setValueSelect(_select, _value) {
    try {
        const _selectize = $(_select)[0].selectize;
        if (!_selectize) return;
        _selectize.setValue(_value, true);
    } catch (e) {
        console.warn(`setValueSelectize: ${e.message}`);
    }
}

function destruirSelect(_select) {
    try {
        const _selectize = $(_select)[0].selectize;
        if (!!_selectize) _selectize.destroy();
    } catch (e) {
        console.warn(`destruirSelectize: ${e.message}`);
    }
}

function eventoSelect(evento, funcion) {
    try {
        const _selectize = $(_select)[0].selectize;
        if (!!_selectize) selectize.on(evento, funcion);
    } catch (e) {
        console.warn(`eventoSelectize: ${e.message}`);
    }
}

function crearSelect(_select, evento_change) {
    try {
        _select.classList.remove("form-select", "form-control");
        $(_select).selectize({ allowEmptyOption: true });
        document.querySelector(`#${_select.getAttribute("id")}-selectized`)?.setAttribute("data-validate", "no-validate");
        if (_select.dataset.validate != "no-validate") {
            $(_select)[0].selectize.on("change", () => {
                validarVacio(_select);
            });
        }
        if (!evento_change) return;
        $(_select)[0].selectize.on("change", evento_change);
    } catch (e) {
        console.warn(`crearSelectize: ${e.message}`);
    }
}

function limpiarSelect(_select) {
    try {
        const _tempSelect = $(_select)[0].selectize;
        if (!_tempSelect) return;
        const _valor_inicial = Object.keys(_tempSelect.options)[0];
        _tempSelect.setValue(_valor_inicial, false);
        _select.classList.remove("is-invalid");
    } catch (e) {
        console.warn(`limpiarSelectize: ${e.message}`);
    }
}
function addAntiForgeryToken(_formData) {
    try {
        const _tokenInput = document.querySelector("[name='__RequestVerificationToken']");
        if (!_tokenInput) throw new Error(`addAntiForgeryToken: No se ha declarado el @Html.AntiForgeryToken() en el HTML`);
        _formData.append("__RequestVerificationToken", _tokenInput.value);
    } catch (e) {
        console.error(`addAntiForgeryToken: ${e.message}`);
    }
}

async function todoMayusculas(contenedor) {
    return new Promise(resolve => {
        if (!contenedor) throw new Error("No se especifico ningun elemento")
        try {
            const _elementos = contenedor.querySelectorAll("input,textarea");
            if(_elementos.length==0) resolve(true);
            _elementos.forEach((item, index) => {
                if (item.type != "file" || item.type != "datetime") {
                    if (!!item.value && item.value != "") item.value = item.value.toUpperCase();
                }
                if (index == _elementos.length - 1) resolve(true);
            });

        } catch (e) {
            console.warn(`js.FORMS TODO MAYUSCULAS ${e.message}`);
            resolve(false);
        }
    })

}

document.addEventListener("keyup",event=>{
    if(event.key==="F2"){
        event.preventDefault();
        if(!!document.querySelector("body.modal-open"))return;
        const _ev__btn=document.querySelector("[onclick='nuevo()']");
        if(!!_ev__btn)_ev__btn.click();
        const _ev__btn2=document.querySelector(".f2-open-modal");
        if(!!_ev__btn2)_ev__btn2.click();
    }
})

