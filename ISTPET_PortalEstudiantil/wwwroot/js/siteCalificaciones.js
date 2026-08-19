(function () {
    const baseUrl = `${_route}Calificaciones/`;
    const containerTable = document.querySelector(".container-table");
    const container = document.querySelector(".container-main");
    const loader = document.querySelector(".loader");
    const form = document.querySelector("form#frm");
    if (!form) return;
    const cmbCarreras = form.querySelector("#idCarrera");
    const cmbNiveles = form.querySelector("#idMatricula");
    const table = document.querySelector("table");
    const tbody = table ? table.querySelector("tbody") : null;
    const STORAGE_KEY_CARRERA = "istpet_calificaciones_carrera";
    const STORAGE_KEY_MATRICULA = "istpet_calificaciones_matricula";

    if (cmbCarreras) {
        cmbCarreras.addEventListener("change", async () => {
            if (cmbCarreras.value) {
                localStorage.setItem(STORAGE_KEY_CARRERA, cmbCarreras.value);
            } else {
                localStorage.removeItem(STORAGE_KEY_CARRERA);
                localStorage.removeItem(STORAGE_KEY_MATRICULA);
            }
            await comboNiveles();
        });
    }

    if (cmbNiveles) {
        cmbNiveles.addEventListener("change", () => {
            if (cmbNiveles.value) {
                localStorage.setItem(STORAGE_KEY_MATRICULA, cmbNiveles.value);
            } else {
                localStorage.removeItem(STORAGE_KEY_MATRICULA);
            }
            listaNotas();
        });
    }

    // Inicialización automática desde localStorage
    init();

    async function init() {
        if (!cmbCarreras) return;
        const savedCarrera = localStorage.getItem(STORAGE_KEY_CARRERA);
        let carreraSeleccionada = false;

        if (savedCarrera && Array.from(cmbCarreras.options).some(o => o.value === savedCarrera)) {
            cmbCarreras.value = savedCarrera;
            carreraSeleccionada = true;
        } else if (cmbCarreras.options.length === 2) {
            cmbCarreras.selectedIndex = 1;
            localStorage.setItem(STORAGE_KEY_CARRERA, cmbCarreras.value);
            carreraSeleccionada = true;
        }

        if (carreraSeleccionada && cmbCarreras.value) {
            await comboNiveles(true);
        }
    }

    async function comboNiveles(restaurarGuardado = false) {
        try {
            if (containerTable) containerTable.hidden = true;
            if (tbody) tbody.innerHTML = "";
            if (!cmbCarreras || !cmbCarreras.value) {
                if (cmbNiveles) cmbNiveles.innerHTML = `<option value="">Seleccione una carrera</option>`;
                return;
            }
            const url = `${baseUrl}comboNiveles`;
            const data = new FormData(form);
            const res = (await axios.post(url, data)).data;
            let html = `<option value="">Seleccione</option>`;
            if (res.length == 0) {
                if (cmbNiveles) cmbNiveles.innerHTML = html;
                return;
            }
            if (!!res.error) throw new Error(res.error);
            res.forEach(item => {
                html += `<option value='${item.idMatricula}'>${item.nivel}</option>`
            });
            if (cmbNiveles) {
                cmbNiveles.innerHTML = html;

                const savedMatricula = localStorage.getItem(STORAGE_KEY_MATRICULA);
                if (restaurarGuardado && savedMatricula && Array.from(cmbNiveles.options).some(o => o.value === savedMatricula)) {
                    cmbNiveles.value = savedMatricula;
                    await listaNotas();
                } else if (cmbNiveles.options.length === 2) {
                    cmbNiveles.selectedIndex = 1;
                    localStorage.setItem(STORAGE_KEY_MATRICULA, cmbNiveles.value);
                    await listaNotas();
                }
            }
        } catch (e) {
            if (e.message.search("401") >= 0) {
                toastError("Su sesión ha caducado");
                setTimeout(() => top.location.reload(), 1900);
            } else {
                toastError(`${e.message}`);
            }
        }
    }

    async function listaNotas() {
        try {
            if (containerTable) containerTable.hidden = true;
            if (tbody) tbody.innerHTML = "";
            if (!cmbNiveles || !cmbCarreras || !cmbNiveles.value || !cmbCarreras.value) return;
            const url = `${baseUrl}listaNotas`;
            const data = new FormData(form);
            const res = (await axios.post(url, data)).data;
            if (!!res.error) throw new Error(res.error);
            let html = "";
            res.forEach(item => {
                html += `
                        <tr>
                        <td class="text-xs font-weight-bold text-dark no-wrap ps-4">
                                <span>${item.asignatura}</span>
                        </td>
                        <td class="text-center text-xs font-weight-bold">
                                <span>${item.ef1 || 0}</span>
                        </td>
                        <td class="text-center text-xs font-weight-bold">
                                <span>${item.ep1 || 0}</span>
                        </td>
                        <td class="text-center text-xs font-weight-bold">
                                <span>${item.nota1 || 0}</span>
                        </td>
                        <td class="text-center text-xs font-weight-bold">
                                <span>${item.ef2 || 0}</span>
                        </td>
                        <td class="text-center text-xs font-weight-bold">
                                <span>${item.ep2 || 0}</span>
                        </td>
                        <td class="text-center text-xs font-weight-bold">
                                <span>${item.nota2 || 0}</span>
                        </td>
                        <td class="text-center text-xs font-weight-bold">
                              <span>${item.examen || 0}</span>
                        </td>
                        <td class="text-center text-xs font-weight-bold">
                              <span>${item.promedio_final || 0}</span>
                        </td>
                        <td class="text-center text-xs font-weight-bold">
                              ${item.aprobado?"<span class='text-success'>SI</span>":"<span class='text-danger'>NO</span>"}
                        </td>                    
                        </tr>
                        `;
            });
            if (tbody) tbody.innerHTML = html;
            if (containerTable) containerTable.hidden = false;
        } catch (e) {
            if (e.message.search("401") >= 0) {
                toastError("Su sesión ha caducado");
                setTimeout(() => top.location.reload(), 1900);
            } else {
                toastError(`${e.message}`);
            }
        }
    }
})();