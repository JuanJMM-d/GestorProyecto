using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//21-8-2024
namespace GestorProyectos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables globales
        FormLogin formLogin;  
        FormInicio formInicio;


        private void Form1_Load(object sender, EventArgs e)
        {
            //crear instancias de formularios
            formLogin = new FormLogin(this);   // con this enviamos la instancia actual
            formInicio = new FormInicio(this);  


            //cargar el form login
            CargarFormLogin();
        }


        //Metodo para cargar el FormLogin aqui en el Form1
        private void CargarFormLogin()
        {
            
            this.panelPrincipal.Controls.Clear();   //liberamos el panel del FormLogin
            formLogin.TopLevel = false;
            formLogin.FormBorderStyle = FormBorderStyle.None;
            formLogin.Dock = DockStyle.Fill;        // configuramos para que llene todo el Panel
            this.panelPrincipal.Controls.Add(formLogin);   //Agregamos los controles del FormLogin
            formLogin.Show();
        }

        ////Metodo para cargar el FormInicio luego de login valido
        public void CargarFormInicio()
        {
            this.panelPrincipal.Controls.Clear();
            formInicio.TopLevel = false;
            formInicio.FormBorderStyle = FormBorderStyle.None;
            formInicio.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(formInicio);
            formInicio.Show();

        }




        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
//Este es un comentario de prueba