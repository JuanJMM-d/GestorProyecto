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
            this.formInicio = formInicio;
            ActualizardgvEmpleados();
        }
       
        //variables globales
        DatosDeProyectos datosDeProyectos;
        FormInicio formInicio;
        
        public void ActualizardgvEmpleados()
        {
            dgvEmpleados.DataSource = datosDeProyectos.dtEmpleados;
        }

        private void FiltrarEmpleados()
        {
            DataView filtroDtEmpleados = new DataView(datosDeProyectos.dtEmpleados);

            string filtro = "";

            if (!string.IsNullOrEmpty(txtNombreBuscarEmpleado.Text))
            {
                filtro += $"Nombre LIKE '%{txtNombreBuscarEmpleado.Text}%'";
            }

            if (!string.IsNullOrEmpty(txtBuscarIdEmpleado.Text))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"IdEmpleado LIKE '%{txtBuscarIdEmpleado.Text}%'";
            }

            if (double.TryParse(txtSalariomax.Text, out double salarioMax))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"Salario <= {salarioMax}";
            }

            if (double.TryParse(txtSalarioMin.Text, out double salarioMin))
            {
                if (filtro.Length > 0) filtro += " AND ";
                filtro += $"Salario >= {salarioMin}";
            }

            filtroDtEmpleados.RowFilter = filtro;

            dgvEmpleados.DataSource = filtroDtEmpleados;
        }
        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtNombreBuscarEmpleado.Clear();
            txtBuscarIdEmpleado.Clear();
            txtSalarioMin.Clear();
            txtSalariomax.Clear();

            ActualizardgvEmpleados();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {

            FormCrearEmpleado formCrearEmpleado = new FormCrearEmpleado(formInicio);
            formCrearEmpleado.ShowDialog();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FormEmpleadosInicio_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void txtBuscarIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }


        private void txtSalariomax_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void txtSalarioMin_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

      
    }
}
