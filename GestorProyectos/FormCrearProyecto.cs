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

namespace GestorProyectos
{
    public partial class FormCrearProyecto : Form
    {
        private DatosDeProyectos datosDeProyectos;
        private FormInicio formInicio;
        public FormCrearProyecto(FormInicio formInicio, FormProyectos formProyectosExistente)
        {
            InitializeComponent();
            datosDeProyectos = formInicio.GetDatosDeProyectos();
            formProyectos = formProyectosExistente;
            this.formInicio = formInicio;
        }

        //variables globales
        FormProyectos formProyectos;
        private ErrorProvider errorProvider = new ErrorProvider();
        public static bool ProyectoCreado = false;
        public static string IDProyectoActual;
        public static string NombrePoryectoActual = "";


        public void LanzarFormCrearTarea()
        {
            FormCrearTarea formCrearTarea = new FormCrearTarea(formInicio);
            formCrearTarea.ShowDialog(); // Muestra el formulario de manera modal
        }

        private void FormCrearProyecto_Load(object sender, EventArgs e)
        {

        }

        //boton para crearlo
        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCrearProyecto())
            {
                // si es valido mandar datos al datsatable
                string IDProyecto = datosDeProyectos.generarIDProyecto();
                string pNombre = txtNombreProyecto.Text.Trim();
                string pCategoria = txtCategoriaProyecto.Text.Trim();
                string pEstado = comBoxEstadoProyecto.SelectedItem.ToString();
                double pPresupuesto = double.Parse(txtPresupuestoProyecto.Text.Trim());
                string fechaIn = dateTimeInicioProyecto.Value.ToString("dd/MM/yyyy");
                string fechaFin = dateTimeLimiteProyecto.Value.ToString("dd/MM/yyyy");
                string pDescrip = txtDescripcionProyecto.Text;

                datosDeProyectos.dtProyectos.Rows.Add(IDProyecto, pNombre, pCategoria, pEstado, pPresupuesto, fechaIn, fechaFin, pDescrip);
                formProyectos.ActualizardgvProyectos();

                IDProyectoActual = IDProyecto;
                NombrePoryectoActual = txtNombreProyecto.Text;
                datosDeProyectos.actualizarCantidadTareasYEmpleados();
                LanzarFormCrearTarea();
            }
            else MessageBox.Show("err");

        }


        //metodo que validad si los datos para crear el pryecto son validos
        private bool ValidarDatosCrearProyecto()
        {
            bool datosOk = true;
            Regex nombreCatValidar = new Regex(@"^[a-zA-Z0-9\s-]+$");

            //validar nombre
            if (string.IsNullOrEmpty(txtNombreProyecto.Text))
            {
                errorProvider.SetError(txtNombreProyecto, "El campo no puede estar vacio");
                datosOk = false;
            }
            else if (nombreCatValidar.IsMatch(txtNombreProyecto.Text))
            {
                errorProvider.SetError(txtNombreProyecto, string.Empty);
            }
            else
            {
                errorProvider.SetError(txtNombreProyecto, "Entrada no valida");
                datosOk = false;
            }

            //validar categoria
            if (string.IsNullOrEmpty(txtCategoriaProyecto.Text))
            {
                errorProvider.SetError(txtCategoriaProyecto, "El campo no puede estar vacio");
                datosOk = false;
            }
            else if (nombreCatValidar.IsMatch(txtCategoriaProyecto.Text))
            {
                errorProvider.SetError(txtCategoriaProyecto, string.Empty);
            }
            else
            {
                errorProvider.SetError(txtCategoriaProyecto, "Entrada no valida");
                datosOk = false;
            }

            //verificar estado
            if (comBoxEstadoProyecto.SelectedItem != null)
            {
                errorProvider.SetError(comBoxEstadoProyecto, string.Empty);
            }
            else
            {
                errorProvider.SetError(comBoxEstadoProyecto, "El campo no puede estar vacio");
                datosOk = false;
            }

            //verificar presupuesto
            if (string.IsNullOrEmpty((txtPresupuestoProyecto.Text)))
            {
                errorProvider.SetError(txtPresupuestoProyecto, "El campo no puede estar vacio");
                datosOk = false;
            }
            else if (double.TryParse(txtPresupuestoProyecto.Text, out double PresupuestoProyecto))
            {
                errorProvider.SetError(txtPresupuestoProyecto, string.Empty);
            }
            else
            {
                errorProvider.SetError(txtPresupuestoProyecto, "Entrada no valida");
                datosOk = false;
            }

            return datosOk;
        }







        private void txtIdProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoriaProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void comBoxEstadoProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPresupuestoProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeInicioProyecto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeLimiteProyecto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcionProyecto_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
