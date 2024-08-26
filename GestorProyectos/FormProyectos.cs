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
            datosDeProyectos.actualizarCantidadTareasYEmpleados();
        }
        //variables de campo
        private DatosDeProyectos datosDeProyectos;


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

            ActualizardgvProyectos();
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
    }
}
