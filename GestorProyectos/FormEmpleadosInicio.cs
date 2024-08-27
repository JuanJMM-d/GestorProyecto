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
    public partial class FormEmpleadosInicio : Form
    {
        public FormEmpleadosInicio(FormInicio formInicio)
        {
            InitializeComponent();
            datosDeProyectos = formInicio.GetDatosDeProyectos();
            ActualizardgvEmpleados();
        }
       
        //variables globales
        DatosDeProyectos datosDeProyectos;

        public void ActualizardgvEmpleados()
        {
            dgvEmpleados.DataSource = datosDeProyectos.dtEmpleados;
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPTRmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEmpleadosInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            FormCrearEmpleado frm = new FormCrearEmpleado();
            frm.Show();
        }
    }
}
