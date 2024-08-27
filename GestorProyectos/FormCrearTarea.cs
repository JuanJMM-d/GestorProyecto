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
using static System.Windows.Forms.MonthCalendar;

namespace GestorProyectos
{
    public partial class FormCrearTarea : Form
    {
        private DatosDeProyectos datosDeProyectos;
        private FormEmpleadosInicio formEmpleadosInicio;
        private FormInicio formInicio;
        public FormCrearTarea(FormInicio formInicio)
        {
            InitializeComponent();
            this.datosDeProyectos = formInicio.GetDatosDeProyectos();
            lblNombrePoryecto.Text = FormCrearProyecto.NombrePoryectoActual; 
            formEmpleadosInicio = new FormEmpleadosInicio(formInicio);
           this.formInicio = formInicio;
            iniciarVariables();
        }
        private void iniciarVariables()
        {

            grpEmpleados.Enabled = false;
            btnNuevaTarea.Enabled = false;
            btnAddCrearTarea.Enabled = true;
            errorProvider = new ErrorProvider();
            editantoTarea = false;
            formProyectos = new FormProyectos(formInicio);
        }

        //variables globales
        private ErrorProvider errorProvider;
        private bool mensajeMostrado = false;
        private int contTarea = 0;
        private string IdProyectoTarea = "";
        private bool editantoTarea;
        private string IDTareaEditando = "";
        private FormProyectos formProyectos;
        
        public void editarTarea(string idTarea, string nombreTarea, string estadoTarea,
              string empleadoNombre, string rolEmpleado, string descripcionTarea, string idEmpleado, double? eSalario)
        {
            editantoTarea=true;
            btnAddCrearTarea.Text = "Editar Tarea";
            txtNombreTarea.Text = nombreTarea;
            comboBoxTareaEstado.SelectedItem = estadoTarea;
            txtDescripcionTarea.Text = descripcionTarea;

            txtIdEmpleado.Text = idEmpleado;
            txtEmpleadoNombre.Text = empleadoNombre;
            txtRolEmpleado.Text = rolEmpleado;
            txtEmpleadoSalario.Text = eSalario?.ToString();
            IDTareaEditando = idTarea;

            AddEmpleado.Enabled = true;            
            btnNuevaTarea.Enabled = true;
            
        }







        private void btnAddCrearTarea_Click(object sender, EventArgs e)
        {
            if (ValidarTarea() && !editantoTarea)
            {
                contTarea++;
                IdProyectoTarea = txtNombreTarea.Text + datosDeProyectos.generarIDProyectoTarea();
                string tNombre = txtNombreTarea.Text;
                string tEstado = comboBoxTareaEstado.SelectedItem.ToString();
                string tDescripcion = txtDescripcionTarea.Text;
                string IdEmpleado = txtIdEmpleado.Text;
                string IDProyecto = FormCrearProyecto.IDProyectoActual;

                datosDeProyectos.dtTareas.Rows.Add(IdProyectoTarea, tNombre, tEstado, IDProyecto, IdEmpleado, tDescripcion);

                grpEmpleados.Enabled = true;
                lblAddEmpleadoTarea.Text = $"Añadir Empleados a Tarea: {tNombre}";
                toolTipAyuda.Hide(grpEmpleados);

                formProyectos.ActualizardgvProyectos();
                formEmpleadosInicio.ActualizardgvEmpleados();
                datosDeProyectos.actualizarCantidadTareasYEmpleadosProyectos();

                MessageBox.Show("Tarea creada exitosamente.");
                btnAddCrearTarea.Enabled = false;
                btnNuevaTarea.Enabled = true;
            }
            else if (ValidarTarea() && editantoTarea)
            {
                string tNombre = txtNombreTarea.Text;
                string tEstado = comboBoxTareaEstado.SelectedItem.ToString();
                string tDescripcion = txtDescripcionTarea.Text;
                string IDProyecto = FormCrearProyecto.IDProyectoActual;

                DataRow rowEditar = datosDeProyectos.dtTareas.AsEnumerable()
                    .FirstOrDefault(row => row.Field<string>("IDProyectoTarea") == IDTareaEditando);

                if (rowEditar != null)
                {
                    rowEditar["Nombre"] = tNombre;
                    rowEditar["Estado"] = tEstado;
                    rowEditar["Descripcion"] = tDescripcion;
                    editantoTarea = false;
                    MessageBox.Show("Tarea editada exitosamente");
                    this.Close();
                }
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

        private void vaciaAddEmpleado()
        {
            txtIdEmpleado.Text += string.Empty;
            txtEmpleadoNombre.Text = string.Empty;
            txtEmpleadoSalario.Text = string.Empty;
           txtRolEmpleado.Text = string.Empty;
        }
        private void vaciarTareas()
        {
            txtDescripcionTarea.Text = string.Empty;
            txtNombreTarea.Text = string.Empty;    comboBoxTareaEstado.SelectedIndex = -1;
        }

        private void AddEmpleado_Click(object sender, EventArgs e)
        {
            if (editantoTarea)
            {
                DialogResult result = MessageBox.Show("Deseas agregar un nuevo empleado?", "Agregar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    vaciaAddEmpleado(); editantoTarea = false;
                }                
            }

            else if (ValidarEmpleado() && !datosDeProyectos.IdEmpleadoExiste(txtIdEmpleado.Text))
            {
                 string idEmpleado = txtIdEmpleado.Text;
                string nombreEmpleado = txtEmpleadoNombre.Text;
                string rolEmpleado = txtRolEmpleado.Text;
                string Esalario = txtEmpleadoSalario.Text;

                datosDeProyectos.dtEmpleados.Rows.Add(idEmpleado, nombreEmpleado, rolEmpleado, Esalario);
                string idAsignacion = datosDeProyectos.generarIDAsignacion();
                datosDeProyectos.dtAsignaciones.Rows.Add(idAsignacion, idEmpleado, IdProyectoTarea);

                formProyectos.ActualizardgvProyectos();
                formEmpleadosInicio.ActualizardgvEmpleados();
                datosDeProyectos.actualizarCantidadTareasYEmpleadosProyectos();

                vaciaAddEmpleado();
            }
        }
        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseas agregar una nueva tarea?", "Agregar Tarea", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                editantoTarea = false;
                btnNuevaTarea.Enabled = false;
                btnAddCrearTarea.Text = "Add Tarea";
                contTarea = 0;
                IdProyectoTarea = "";
                IDTareaEditando = "";
                vaciaAddEmpleado();
                vaciarTareas();
                btnAddCrearTarea.Enabled = true;
                
                iniciarVariables();
               
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
