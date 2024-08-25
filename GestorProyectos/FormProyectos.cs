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
        }

        //variables de campo
        private DatosDeProyectos datosDeProyectos;

        //actualiza con datatable el dgv desde DatosDeProyectos
        public void ActualizardgvProyectos()
        {
            dgvProyectos.DataSource = datosDeProyectos.dtProyectos;
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

    }
}
