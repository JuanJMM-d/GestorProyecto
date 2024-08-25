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

namespace GestorProyectos
{
    public partial class FormCrearTarea : Form
    {
        private DatosDeProyectos datosDeProyectos;

        public FormCrearTarea(FormInicio datosDeProyectos)
        {
            InitializeComponent();
            this.datosDeProyectos = datosDeProyectos.GetDatosDeProyectos();
            lblNombrePoryecto.Text = FormCrearProyecto.NombrePoryectoActual; // NombreProyectoActual corregido
            grpEmpleados.Enabled = false;
            btnAddTarea.Enabled = false;
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
                IdProyectoTarea = contTarea.ToString() + FormCrearProyecto.IDProyectoActual;
                string tNombre = txtNombreTarea.Text;
                string tEstado = comboBoxTareaEstado.SelectedItem.ToString();
                string tDescripcion = txtDescripcionTarea.Text;

                datosDeProyectos.dtTareas.Rows.Add(IdProyectoTarea, tNombre, tEstado, tDescripcion);
                grpEmpleados.Enabled = true;
                toolTipAyuda.Hide(grpEmpleados);
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

        private void AddEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarEmpleado())
            {
                string idEmpleado = txtIdEmpleado.Text;
                string nombreEmpleado = txtEmpleadoNombre.Text;
                // Usa el campo de instancia 'IdProyectoTarea'
                string rolEmpleado = txtRolEmpleado.Text;

                // Asegúrate de usar la instancia correcta de 'DatosDeProyectos'
                datosDeProyectos.dtEmpleados.Rows.Add(idEmpleado, nombreEmpleado, IdProyectoTarea, rolEmpleado);

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
                errorProvider.SetError(txtIdEmpleado, "El campo no puede estar vacio");
                datosOk = false;
            }
            else if (idEmpleado.IsMatch(txtIdEmpleado.Text.Trim()))
            {
                errorProvider.SetError(txtIdEmpleado, string.Empty);
            }
            else errorProvider.SetError(txtIdEmpleado, "Entrada no valida"); datosOk = false;

            //verificar Nombre empleado
            if (string.IsNullOrEmpty(txtEmpleadoNombre.Text))
            {
                errorProvider.SetError(txtIdEmpleado, "El campo no puede estar vacio");
                datosOk = false;
            }
            else if (nombreEm.IsMatch(txtEmpleadoNombre.Text.Trim()))
            {
                errorProvider.SetError(txtIdEmpleado, string.Empty);
            }
            else errorProvider.SetError(txtIdEmpleado, "Entrada no valida"); datosOk = false;

            return datosOk;
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
    }
}
