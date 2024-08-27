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
    public partial class FormLogin : Form
    {

        //Recibe la instancia del Form1 en el constriuctor del FormLogin
        public FormLogin(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        //variables globales
        Form1 form1;
            
        //boton que verifica credenciales validas
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim(); 
            string pass = $@"{txtPassword.Text.Trim()}";

            string userOk = "q";
            string passOk = @"q";

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
            {
                if (user == userOk && pass == passOk)
                {
                    //llamando al metodo en el form1 para cargar el Form de Inicio
                    form1.CargarFormInicio();
                }
                else MessageBox.Show("Error", "Credenciales No validas");
            }
            else MessageBox.Show("Error", "Campos Vacios");
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
