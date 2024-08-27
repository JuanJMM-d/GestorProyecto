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
    public partial class FormCrearEmpleado : Form
    {
        public FormCrearEmpleado(FormInicio formInicio)
        {
            InitializeComponent();
            datosDeProyectos = formInicio.GetDatosDeProyectos();
            errorProvider = new ErrorProvider();    

        }
        private ErrorProvider errorProvider;
        private DatosDeProyectos datosDeProyectos;

        private void FormCrearEmpleado_Load(object sender, EventArgs e)
        {

        }



        private bool validarEmpleado()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtCrearEmplID.Text.Trim()))
            {
                errorProvider.SetError(txtCrearEmplID, "El ID del empleado es obligatorio.");
                valid = false;
            }
            else
            {
                errorProvider.SetError(txtCrearEmplID, "");
            }

            if (string.IsNullOrEmpty(txtCrearEmplNombre.Text.Trim()))
            {
                errorProvider.SetError(txtCrearEmplNombre, "El nombre del empleado es obligatorio.");
                valid = false;
            }
            else
            {
                errorProvider.SetError(txtCrearEmplNombre, "");
            }

            return valid;
        }
        private void txtCrearEmplID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCrearEmplNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            if (validarEmpleado())
            {
                string idEmpleado = txtCrearEmplID.Text.Trim();
                string nombre = txtCrearEmplNombre.Text.Trim();
                double.TryParse(txtCrearEmplSalario.Text, out double Esalario);

                datosDeProyectos.dtEmpleados.Rows.Add(idEmpleado, nombre,"No-Asignado", Esalario);

                MessageBox.Show("Empleado creado exitosamente.", "exito", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}

