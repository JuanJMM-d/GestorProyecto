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
        public FormCrearProyecto()
        {
            InitializeComponent();
           
        }

        private void FormCrearProyecto_Load(object sender, EventArgs e)
        {

        }

        //variables globales
        private ErrorProvider errorProvider;
        public static bool ProyectoCreado = false;
        public static string IDProyectoActual;


        //boton para crearlo
        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCrearProyecto())
            {
                // si es valido mandar datos al datsatable
                string Id = txtIdProyecto.Text;
                string pNombre = txtNombreProyecto.Text.Trim();
                string pCategoria = txtCategoriaProyecto.Text.Trim();
                string pEstado = comBoxEstadoProyecto.SelectedItem.ToString();
                double pPresupuesto = double.Parse(txtPresupuestoProyecto.Text.Trim());
                string fechaIn = dateTimeInicioProyecto.Value.ToString("dd/MM/yyyy");
                string fechaFin = dateTimeLimiteProyecto.Value.ToString("dd/MM/yyyy");
                string pDescrip = txtDescripcionProyecto.Text;

                DatosDeProyectos.dtProyectos.Rows.Add(Id, pNombre, pCategoria, pEstado, pPresupuesto, fechaIn, fechaFin, pDescrip);
                
                IDProyectoActual = txtIdProyecto.Text;
                LanzarFormCrearTarea();
            }

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
            else errorProvider.SetError(txtNombreProyecto, "Entrada no valida"); datosOk = false;

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
            else errorProvider.SetError(txtCategoriaProyecto, "Entrada no valida"); datosOk = false;

            //verificar estado
            if (comBoxEstadoProyecto.SelectedItem != null)
            {
                errorProvider.SetError(comBoxEstadoProyecto, string.Empty);
            }
            else errorProvider.SetError(comBoxEstadoProyecto, "El campo no puede estar vacio"); datosOk = false;

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
            else errorProvider.SetError(txtPresupuestoProyecto, "Entrada no valida"); datosOk = false;


            //retonar
            return datosOk;
        }

        public static void LanzarFormCrearTarea()
        {
            FormCrearTarea formCrearTarea = new FormCrearTarea();
            formCrearTarea.ShowDialog(); // Muestra el formulario de manera modal no deja interactuar hazta quee se cierre   

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
