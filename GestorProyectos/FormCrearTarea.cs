using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace GestorProyectos
{
    public partial class FormCrearTarea : Form
    {
        private DatosDeProyectos datosDeProyectos;
        private FormEmpleadosInicio formEmpleadosInicio;

        public FormCrearTarea(FormInicio formInicio)
        {
            InitializeComponent();
            this.datosDeProyectos = formInicio.GetDatosDeProyectos();
            lblNombrePoryecto.Text = FormCrearProyecto.NombrePoryectoActual; // NombreProyectoActual corregido
            grpEmpleados.Enabled = false;
              btnNuevaTarea.Enabled = false; btnAddTarea.Enabled = true;
            formEmpleadosInicio = new FormEmpleadosInicio(formInicio);
            errorProvider = new ErrorProvider();
        }


        //variables globales
        private ErrorProvider errorProvider;
        private bool mensajeMostrado = false;
        private int contTarea = 0;
        private string IdProyectoTarea = "";

        private void btnAddTarea_Click(object sender, EventArgs e)
        {
            if (ValidarTarea())
            {
                contTarea++;
                IdProyectoTarea = txtNombreTarea.Text + datosDeProyectos.generarIDProyectoTarea();
                string tNombre = txtNombreTarea.Text;
                string tEstado = comboBoxTareaEstado.SelectedItem.ToString();
                string tDescripcion = txtDescripcionTarea.Text;
                string IDProyecto = FormCrearProyecto.IDProyectoActual;

                datosDeProyectos.dtTareas.Rows.Add(IdProyectoTarea, tNombre, tEstado, IDProyecto, tDescripcion);

                grpEmpleados.Enabled = true;
                lblAddEmpleadoTarea.Text = $"Add Empleados a Tarea: {tNombre}";
                toolTipAyuda.Hide(grpEmpleados);

                datosDeProyectos.actualizarCantidadTareasYEmpleados();

            }
        }

        private bool ValidarTarea()
        {
            bool datosOk = true;
            Regex nombreCatValidar = new Regex(@"^[a-zA-Z0-9\s-]+$");

            //validar nombre
            if (string.IsNullOrEmpty(txtNombreTarea.Text))
            {
                errorProvider.SetError(txtNombreTarea, "El campo no puede estar vacío");
                datosOk = false;
            }
            else if (nombreCatValidar.IsMatch(txtNombreTarea.Text))
            {
                errorProvider.SetError(txtNombreTarea, string.Empty);
            }
            else
            {
                errorProvider.SetError(txtNombreTarea, "Entrada no válida");
                datosOk = false;
            }

            //validar estado
            if (comboBoxTareaEstado.SelectedItem == null || string.IsNullOrEmpty(comboBoxTareaEstado.SelectedItem.ToString()))
            {
                errorProvider.SetError(comboBoxTareaEstado, "El campo no puede estar vacío");
                datosOk = false;
            }
            else if (nombreCatValidar.IsMatch(comboBoxTareaEstado.SelectedItem.ToString()))
            {
                errorProvider.SetError(comboBoxTareaEstado, string.Empty);
            }
            else
            {
                errorProvider.SetError(comboBoxTareaEstado, "Entrada no válida");
                datosOk = false;
            }

            return datosOk;
        }

        private void AddEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarEmpleado())
            {
                string idEmpleado = txtIdEmpleado.Text;
                string nombreEmpleado = txtEmpleadoNombre.Text;
                string rolEmpleado = txtRolEmpleado.Text;
                string Esalario = txtEmpleadoSalario.Text;

                datosDeProyectos.dtEmpleados.Rows.Add(idEmpleado, nombreEmpleado, rolEmpleado, Esalario);

                string IdAsignacion = datosDeProyectos.generarIDAsignacion();

                datosDeProyectos.dtAsignaciones.Rows.Add(IdAsignacion, idEmpleado, IdProyectoTarea);

                datosDeProyectos.actualizarCantidadTareasYEmpleados();
                formEmpleadosInicio.ActualizardgvEmpleados();

                btnNuevaTarea.Enabled = true;
            }
        }


        private bool ValidarEmpleado()
        {
            bool datosOk = true;
            Regex idEmpleado = new Regex(@"^[a-zA-Z0-9]+$");
            Regex nombreEm = new Regex(@"^[a-zA-Z\s]+$");

            if (string.IsNullOrEmpty(txtIdEmpleado.Text))
            {
                errorProvider.SetError(txtIdEmpleado, "El campo no puede estar vacío");
                datosOk = false;
            }
            else if (idEmpleado.IsMatch(txtIdEmpleado.Text.Trim()))
            {
                errorProvider.SetError(txtIdEmpleado, string.Empty);
            }
            else
            {
                errorProvider.SetError(txtIdEmpleado, "Entrada no válida");
                datosOk = false;
            }

            if (string.IsNullOrEmpty(txtEmpleadoNombre.Text))
            {
                errorProvider.SetError(txtEmpleadoNombre, "El campo no puede estar vacío");
                datosOk = false;
            }
            else if (nombreEm.IsMatch(txtEmpleadoNombre.Text.Trim()))
            {
                errorProvider.SetError(txtEmpleadoNombre, string.Empty);
            }
            else
            {
                errorProvider.SetError(txtEmpleadoNombre, "Entrada no válida");
                datosOk = false;
            }

            // Validar el campo de salario
            if (string.IsNullOrEmpty(txtEmpleadoSalario.Text))
            {
                errorProvider.SetError(txtEmpleadoSalario, "El campo no puede estar vacío");
                datosOk = false;
            }
            else
            {
                if (decimal.TryParse(txtEmpleadoSalario.Text.Trim(), out decimal salario) && salario > 0)
                {
                    errorProvider.SetError(txtEmpleadoSalario, string.Empty);
                }
                else
                {
                    errorProvider.SetError(txtEmpleadoSalario, "Entrada no válida. Debe ser un número positivo.");
                    datosOk = false;
                }
            }
            return datosOk;
        }


        private void btnCrearTareaOk_Click(object sender, EventArgs e)
        {
            // Verificar si hay tareas creadas y al menos un empleado asignado
            if (contTarea > 0 && datosDeProyectos.dtAsignaciones.Select($"IDProyectoTarea = '{IdProyectoTarea}'").Length > 0)
            {
                mensajeMostrado = false;
                contTarea = 0;
                IdProyectoTarea = "";

                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("No agregaste un empleado ni una tarea. Salir de todas formas?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void grpEmpleados_MouseHover(object sender, EventArgs e)
        {
        }
        private void FormCrearTarea_Load(object sender, EventArgs e)
        {
        }


        private void groupBoxTareas_Enter(object sender, EventArgs e)
        {

        }

        

        private void txtNombreTarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTareaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcionTarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpEmpleados_Enter(object sender, EventArgs e)
        {

        }

        private void toolTipAyuda_Popup(object sender, PopupEventArgs e)
        {

        }

        
        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpleadoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRolEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {

        }

        private void lblNombrePoryecto_Click(object sender, EventArgs e)
        {

        }

        private void lblAddEmpleadoTarea_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpleadoSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
