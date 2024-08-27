using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorProyectos
{
    public partial class FormProyectos : Form
    {
        public FormProyectos(FormInicio formInicio)
        {
            InitializeComponent();
            datosDeProyectos = formInicio.GetDatosDeProyectos();
            datosDeProyectos.actualizarCantidadTareasYEmpleadosProyectos();
            this.formInicio = formInicio;
            btnEditarProyecto.Enabled = false;
            TareasVistas = false;


        }
        //variables de campo
        private DatosDeProyectos datosDeProyectos;
        private FormInicio formInicio;
        private bool TareasVistas;
        

        //actualiza con datatable el dgv desde DatosDeProyectos
        public void ActualizardgvProyectos()
        {
            dgvProyectos.DataSource = datosDeProyectos.dtProyectos;
        }

        private void FiltrarProyectos()
        {
            DataView filtroDtProyectos = new DataView(datosDeProyectos.dtProyectos);

            string filtro = "";

            if (!string.IsNullOrEmpty(txtNombreBuscar.Text))
            {
                filtro += $"Nombre LIKE '%{txtNombreBuscar.Text}%'";
            }

            if (!string.IsNullOrEmpty(textBoxBuscarCategoria.Text))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"Categoria LIKE '%{textBoxBuscarCategoria.Text}%'";
            }

            if (comboBoxOrdenaEstado.SelectedIndex != -1)
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"Estado = '{comboBoxOrdenaEstado.SelectedItem.ToString()}'";
            }

            if (comboBoxTEP.SelectedIndex != -1)
            {
                if (filtro.Length > 0) filtro += " AND ";

                string columnaFiltro = "";
                switch (comboBoxTEP.SelectedItem.ToString())
                {
                    case "Tareas":
                        columnaFiltro = "Catidadad_Tareas";
                        break;
                    case "Empleados":
                        columnaFiltro = "Empleados";
                        break;
                    case "Presupuesto":
                        columnaFiltro = "Presupuesto";
                        break;
                }

                string valorMin = txtTEPmin.Text;
                string valorMax = txtTEPmax.Text;

                if (!string.IsNullOrEmpty(columnaFiltro))
                {
                    if (!string.IsNullOrEmpty(valorMin) && !string.IsNullOrEmpty(valorMax))
                    {
                        if (filtro.Length > 0) filtro += " AND ";
                        filtro += $"{columnaFiltro} >= {valorMin} AND {columnaFiltro} <= {valorMax}";
                    }
                    else if (!string.IsNullOrEmpty(valorMin))
                    {
                        if (filtro.Length > 0) filtro += " AND ";
                        filtro += $"{columnaFiltro} >= {valorMin}";
                    }
                    else if (!string.IsNullOrEmpty(valorMax))
                    {
                        if (filtro.Length > 0) filtro += " AND ";
                        filtro += $"{columnaFiltro} <= {valorMax}";
                    }
                }
            }

            if (DTFechaInicio.Value != null)
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"Fecha_Inicio >= '{DTFechaInicio.Value.ToString("yyyy-MM-dd")}'";
            }

            if (DTFechaFinal.Value != null)
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"Fecha_Final <= '{DTFechaFinal.Value.ToString("yyyy-MM-dd")}'";
            }

            filtroDtProyectos.RowFilter = filtro;

            // Asignar la vista filtrada al DataGridView
            dgvProyectos.DataSource = filtroDtProyectos;
        }
        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtNombreBuscar.Clear();
            textBoxBuscarCategoria.Clear();
            comboBoxOrdenaEstado.SelectedIndex = -1;
            comboBoxTEP.SelectedIndex = -1;
            DTFechaInicio.Value = DateTime.Now;
            DTFechaFinal.Value = DateTime.Now;
            TareasVistas = false;

            ActualizardgvProyectos();
        }

        private void btnVerTareas_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count > 0)
            {
                string idProyectoSeleccionado = dgvProyectos.SelectedRows[0].Cells["IDProyecto"].Value.ToString();

                var tareasFiltradasEnumerable = datosDeProyectos.dtTareas.AsEnumerable()
                    .Where(row => row.Field<string>("IDProyecto") == idProyectoSeleccionado);

                if (tareasFiltradasEnumerable.Any())
                {
                    var tareasFiltradas = tareasFiltradasEnumerable.CopyToDataTable();

                    datosDeProyectos.tareasConEmpleados.Rows.Clear();

                    foreach (DataRow tarea in tareasFiltradas.Rows)
                    {
                        string idTarea = tarea.Field<string>("IDProyectoTarea");
                        string nombreTarea = tarea.Field<string>("Nombre");
                        string estadoTarea = tarea.Field<string>("Estado");
                        string descripcionTarea = tarea.Field<string>("Descripcion"); 

                        var asignacionesFiltradas = datosDeProyectos.dtAsignaciones.AsEnumerable()
                            .Where(row => row.Field<string>("IDProyectoTarea") == idTarea);

                        foreach (var asignacion in asignacionesFiltradas)
                        {
                            string idEmpleado = asignacion.Field<string>("IdEmpleado");

                            var empleado = datosDeProyectos.dtEmpleados.AsEnumerable()
                                .FirstOrDefault(row => row.Field<string>("IdEmpleado") == idEmpleado);

                            if (empleado != null)
                            {
                                string nombreEmpleado = empleado.Field<string>("Nombre");
                                string rolEmpleado = empleado.Field<string>("Rol");

                                datosDeProyectos.tareasConEmpleados.Rows.Add(idTarea, nombreTarea, estadoTarea, nombreEmpleado, rolEmpleado, descripcionTarea);
                            }
                        }
                    }
                }
                dgvProyectos.DataSource = datosDeProyectos.tareasConEmpleados;
                TareasVistas = true;
            } 
                        
        }

        private void btnEditarProyecto_Click(object sender, EventArgs e)
        {
            FormCrearProyecto formCrearProyecto = new FormCrearProyecto(formInicio, this);
            formCrearProyecto.ShowDialog(this);

            DataGridViewRow selectedRow = dgvProyectos.SelectedRows[0];

            string idProyecto = selectedRow.Cells["IDProyecto"].Value.ToString();
            string nombre = selectedRow.Cells["Nombre"].Value.ToString();
            string categoria = selectedRow.Cells["Categoria"].Value.ToString();
            string estado = selectedRow.Cells["Estado"].Value.ToString();
            double presupuesto = Convert.ToDouble(selectedRow.Cells["Presupuesto"].Value);
            DateTime fechaInicio = Convert.ToDateTime(selectedRow.Cells["Fecha_Inicio"].Value);
            DateTime fechaFinal = Convert.ToDateTime(selectedRow.Cells["Fecha_Final"].Value);
            string descripcion = selectedRow.Cells["Descripcion"].Value.ToString();

            formCrearProyecto.editarProyecto(idProyecto, nombre, categoria, estado, presupuesto,
                fechaInicio, fechaFinal, descripcion);

        }
        //activar botones sio se selcciona un a fila en el dgv
        private void dgvProyectos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count > 0)
            {
                btnEditarProyecto.Enabled = true;
                btnEditarTaea.Enabled = true;
                btnElimarProyecto.Enabled = true;
                btnVerDescripcion.Enabled = true;
            }
            else
            {
                btnEditarTaea.Enabled = false;
                btnEditarProyecto.Enabled = false;
                btnElimarProyecto.Enabled = false;  
                btnVerDescripcion.Enabled = false;
            }
        }

        private void btnElimarProyecto_Click(object sender, EventArgs e)
        {

            if (dgvProyectos.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvProyectos.SelectedRows[0];
                string idProyecto = selectedRow.Cells["IDProyecto"].Value.ToString();

                DialogResult result = MessageBox.Show("¿Estas seguro de que quieres eliminar este proyecto","aviso", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Elimina las tareas relacionadas con el proyecto
                    var tareasRelacionadas = datosDeProyectos.dtTareas.AsEnumerable()
                        .Where(row => row.Field<string>("IDProyecto") == idProyecto).ToList();

                    foreach (var tarea in tareasRelacionadas)
                    {
                        string idTarea = tarea.Field<string>("IDProyectoTarea");

                        var asignacionesRelacionadas = datosDeProyectos.dtAsignaciones.AsEnumerable()
                            .Where(row => row.Field<string>("IDProyectoTarea") == idTarea)
                            .ToList();

                        foreach (var asignacion in asignacionesRelacionadas)
                        {
                            datosDeProyectos.dtAsignaciones.Rows.Remove(asignacion);
                        }

                        datosDeProyectos.dtTareas.Rows.Remove(tarea);
                    }

                    var proyecto = datosDeProyectos.dtProyectos.AsEnumerable()
                        .FirstOrDefault(row => row.Field<string>("IDProyecto") == idProyecto);

                    if (proyecto != null)
                    {
                        datosDeProyectos.dtProyectos.Rows.Remove(proyecto);
                    }

                    ActualizardgvProyectos();

                    MessageBox.Show("Proyecto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarProyectos();
        }

        private void textBoxBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            FiltrarProyectos();
        }

        private void comboBoxOrdenaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProyectos();
        }

        private void comboBoxTEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProyectos();
        }

        private void DTFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            FiltrarProyectos();
        }

        private void DTFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            FiltrarProyectos();
        }

        private void btnBuscarProyecto_Click(object sender, EventArgs e)
        {
            FiltrarProyectos();
        }
     

        private void txtTEPmax_TextChanged(object sender, EventArgs e)
        {
            FiltrarProyectos();

        }

        private void txtTEPmin_TextChanged(object sender, EventArgs e)
        {
            FiltrarProyectos();

        }



        private void btnEditarTaea_Click(object sender, EventArgs e)
        {
            if (TareasVistas && dgvProyectos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProyectos.SelectedRows[0];
                string idTarea = selectedRow.Cells["IDTarea"].Value.ToString();
                string nombreTarea = selectedRow.Cells["NombreTarea"].Value.ToString();
                string estadoTarea = selectedRow.Cells["EstadoTarea"].Value.ToString();
                string empleado = selectedRow.Cells["Empleado"].Value.ToString();
                string rolEmpleado = selectedRow.Cells["RolEmpleado"].Value.ToString();
                string descripcionTarea = selectedRow.Cells["DescripcionTarea"].Value.ToString();
                string idEmpleado = idEmpleadoEsditarTarea(idTarea);
                double? eSalario = EmpleadoSalarioEditarTarea(idEmpleado);


                FormCrearTarea formCrearTarea = new FormCrearTarea(formInicio);

                formCrearTarea.editarTarea(idTarea, nombreTarea, estadoTarea, empleado, rolEmpleado, descripcionTarea, idEmpleado, eSalario);

                formCrearTarea.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una tarea de la lista.");
            }
        }
        /// El ? puede ser nulo
        private double? EmpleadoSalarioEditarTarea(string idEmpleado)
        {
            var empleado = datosDeProyectos.dtEmpleados.AsEnumerable()
                .FirstOrDefault(row => row.Field<string>("IdEmpleado") == idEmpleado);

            if (empleado != null)
            {
                return empleado.Field<double>("Salario");
            }
            return null;
        }
        private string idEmpleadoEsditarTarea(string idProyectoTarea)
        {
            var empleado = datosDeProyectos.dtAsignaciones.AsEnumerable()
                .FirstOrDefault(row => row.Field<string>("IDProyectoTarea") == idProyectoTarea);

            if (empleado != null)
            {
                return empleado.Field<string>("IdEmpleado");
            }
            return null;
        }


        private void btnVerDescripcion_Click(object sender, EventArgs e)
        {

            string descripcion = dgvProyectos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            string nombrePT = dgvProyectos.SelectedRows[0].Cells["Nombre"].Value.ToString();

            FormVerDescripcion formVerDescripcion = new FormVerDescripcion(nombrePT , descripcion, TareasVistas);
            formVerDescripcion.ShowDialog();
        }
    }
}
