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
    public partial class FormVerDescripcion : Form
    {
        public FormVerDescripcion(string nombrePT,string descripcion, bool EsTarea)
        {
            InitializeComponent();
            this.nombrePT = nombrePT;
            this.descripcion = descripcion;
            this.EsTarea = EsTarea;
            MostrarDescripcion();

        }
        
        private string nombrePT, descripcion;
        private bool EsTarea;

        private void MostrarDescripcion()
        {
            if (EsTarea)
            {
                lblnombrePT.Text += $" Tarea: {nombrePT}";
            }
            else
            {
                lblnombrePT.Text += $" Proyecto: {nombrePT}";
            }

            txtDescripcion.Text = descripcion ;
        }
        private void lblnombrePT_Click(object sender, EventArgs e)
        {            
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
