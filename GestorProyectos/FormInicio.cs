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
        private string usuarioActivo;
        public FormInicio(string Usuario)
        {
            InitializeComponent();
            usuarioActivo = Usuario;
            lblAdmin.Text = usuarioActivo;
            manejoDeDatos = new ManejoDeDatos();
            formProyectos = new FormProyectos(this);    
        }

        //variables globales
        private ManejoDeDatos manejoDeDatos;
        FormProyectos formProyectos;

        //metodo que gestiona el acceso a la misma instancia de DatosDeProyectos
        internal DatosDeProyectos GetDatosDeProyectos()
        {
            return manejoDeDatos.GetDatosDeProyectos();
        }


        //metodo para mostra formularios en el panel   panelMenuSeleccionado
        private void MostrarEnElPanel(Form formulario, Panel panel)
        {
            panel.Controls.Clear();   //liberamos el panel del FormLogin
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;        // configuramos para que llene todo el Panel
            panel.Controls.Add(formulario);   //Agregamos los controles del FormLogin
            formulario.Show();
        }

        private void btnCrearProycto_Click(object sender, EventArgs e)
        {
            // Pasar FormInicio y la instancia existente de FormProyectos al constructor de FormCrearProyecto
            FormCrearProyecto formCrearProyecto = new FormCrearProyecto(this, formProyectos);
            MostrarEnElPanel(formCrearProyecto, panelMenuSeleccionado);
        }
        private void btnMenuEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleadosInicio formEmpleadosInicio = new FormEmpleadosInicio(this);

            MostrarEnElPanel(formEmpleadosInicio, panelMenuSeleccionado);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(this);
            MostrarEnElPanel(formHome, panelMenuSeleccionado);
        }

        private void btnProyectosLista_Click(object sender, EventArgs e)
        {
            
            MostrarEnElPanel(formProyectos, panelMenuSeleccionado);
        }


        //Metodos que ejecutan btns desde el FormHome para el FormInico
        public void ejecutarBtnProyectos()
        {
            btnProyectosLista.PerformClick();
        }
        public void ejecutarBtnHome()
        {
            btnHome.PerformClick();
        }


        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
        private void panelMenuSeleccionado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 form1 = (Form1)this.ParentForm;
            form1.CargarForm();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearEmpleado formCrearEmpleado=new FormCrearEmpleado();
            formCrearEmpleado.Show();
        }

        private void btnMenuBuzon_Click(object sender, EventArgs e)
        {
            FormChat formChat = new FormChat(usuarioActivo);
            formChat.Show();
        }
    }

    internal class ManejoDeDatos
    {
        private DatosDeProyectos datosDeProyectos;

        public ManejoDeDatos()
        {
            datosDeProyectos = new DatosDeProyectos();
        }

        public DatosDeProyectos GetDatosDeProyectos()
        {
            return datosDeProyectos;
        }
    }

}
