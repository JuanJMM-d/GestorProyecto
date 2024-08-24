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
    public partial class FormInicio : Form
    {

        public FormInicio(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
        }

        //variables globales
        Form1 form1;

        private void panelMenuSeleccionado_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
