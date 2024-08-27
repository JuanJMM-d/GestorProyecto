using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestorProyectos.Code.Users;

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

            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
            {
                bool IsAlreadyAnAdmin = false;
                foreach (Usuarios usuario in DatosUsuarios.Usuarios)
                    if (usuario.IsAdmin == true)
                    {
                        IsAlreadyAnAdmin = true;
                        break;
                    }

                if (!IsAlreadyAnAdmin)
                {
                    Usuarios newUsuario = new Usuarios();
                    newUsuario.UserName = user;
                    newUsuario.Passwd = pass;
                    newUsuario.IsAdmin = true;
                    DatosUsuarios.Usuarios.Add(newUsuario);
                }

                if (Autenticacion.ValidarCredenciales(user, pass))
                    //llamando al metodo en el form1 para cargar el Form de Inicio
                    form1.CargarFormInicio(user);
                else
                    MessageBox.Show("Credenciales No validas", "Error");

            }
            else
                MessageBox.Show("Campos Vacios", "Error");
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
