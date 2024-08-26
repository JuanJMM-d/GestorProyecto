using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorProyectos
{
    public partial class FormHome : Form
    {
        public FormHome(FormInicio formInicio)
        {
            InitializeComponent();
            this.formInicio = formInicio;
        }

        //Variables globales
        FormInicio formInicio;

        private void FormHome_Load(object sender, EventArgs e)
        {
            timerHome.Start();
        }

        private void btnHomeLinkProyectos_Click(object sender, EventArgs e)
        {
            formInicio.ejecutarBtnProyectos();
        }

        //Hora y fecha timer..
        private void timerHome_Tick(object sender, EventArgs e)
        {
            lblFechaHome.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraHome.Text = DateTime.Now.ToString("HH:MM:ss");

        }

        private void btnHomeLinkEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeLinkGraficos_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeLinkBuzon_Click(object sender, EventArgs e)
        {

        }

        private void lblHoraHome_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaHome_Click(object sender, EventArgs e)
        {

        }

       
    }
}
