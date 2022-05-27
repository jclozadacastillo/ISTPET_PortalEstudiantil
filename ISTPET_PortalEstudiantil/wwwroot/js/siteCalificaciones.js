const baseUrl = `${_route}Calificaciones/`;
const containerTable = document.querySelector(".container-table");
const container = document.querySelector(".container-main");
const loader = document.querySelector(".loader");
const form = document.querySelector("form#frm");
const cmbCarreras = form.querySelector("#idCarrera");
const cmbNiveles = form.querySelector("#idMatricula");
const table = document.querySelector("table");
const tbody = table.querySelector("tbody");
cmbCarreras.addEventListener("change", () => {
    comboNiveles();
    listaNotas();
});
cmbNiveles.addEventListener("change", () => {
    listaNotas();
});
init();
async function init() {
    try {
        await comboCarreras();
    } catch (e) {
        console.error(`${e.message}`);
    } finally {
        loader.hidden = true;
        container.hidden = false;
    }
}

async function comboCarreras() {
    try {
        const url = `${baseUrl}comboCarreras`;
        const res = (await axios.get(url)).data;
        if (!!res.error) throw new Error(res.error);
        let html = `<option value="">Seleccione</option>`;
        res.forEach(item => {
            html += `<option value='${item.idCarrera}'>${item.Carrera}</option>`
        });
        cmbCarreras.innerHTML = html;
    } catch (e) {
        if (e.message.search("401") >= 0) {
            toastError("Su sesión ha caducado");
            setTimeout(() => top.location.reload(), 1900);
        } else {
            toastError(`${e.message}`);
        }
    }
}


async function comboNiveles() {
    try {
        const url = `${baseUrl}comboNiveles`;
        const data = new FormData(form);
        const res = (await axios.post(url, data)).data;
        let html = `<option value="">Seleccione una carrera</option>`;
        if (res.length==0) {
            cmbNiveles.innerHTML = html;
            return;
        }
        if (!!res.error) throw new Error(res.error);
        html = `<option value="">Seleccione</option>`;
        res.forEach(item => {
            html += `<option value='${item.idMatricula}'>${item.nivel}</option>`
        });
        cmbNiveles.innerHTML = html;
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
        containerTable.hidden = true;
        tbody.innerHTML = "";
        if (!cmbNiveles.value || !cmbCarreras.value) return;
        const url = `${baseUrl}listaNotas`;
        const data = new FormData(form);
        const res = (await axios.post(url, data)).data;
        if (!!res.error) throw new Error(res.error);
        let html = "";
        res.forEach(item => {
            html += `
                    <tr>
                      <td class="text-xs font-weight-bold text-dark">
                         <span>${item.asignatura}</span>
                      </td>
                      <td class="text-center text-xs font-weight-bold">
                          <span>${item.nota1||0}</span>
                      </td>
                        <td class="text-center text-xs font-weight-bold">
                          <span>${item.nota2 || 0}</span>
                      </td>
                      <td class="text-center text-xs font-weight-bold">
                          <span>${item.nota3 || 0}</span>
                      </td>
                      <td class="text-center text-xs font-weight-bold">
                          <span>${item.examen || 0}</span>
                      </td>
                      <td class="text-center text-xs font-weight-bold">
                          <span>${item.promedio_final || 0}</span>
                      </td>
                    </tr>
                    `;
        });
        tbody.innerHTML = html;
        containerTable.hidden = false;
    } catch (e) {
        if (e.message.search("401") >= 0) {
            toastError("Su sesión ha caducado");
            setTimeout(() => top.location.reload(), 1900);
        } else {
            toastError(`${e.message}`);
        }
    }
}