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
    public partial class FormCrearEmpleado : Form
    {
        public FormCrearEmpleado()
        {
            InitializeComponent();
        }

        private void FormCrearEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            string employee = txtCrearEmplName.Text.Trim();
            string passwd = txtCrearEmplPasswd.Text.Trim();
            bool isAdmin = cbAdmin.Checked;

            Usuarios usuario = new Usuarios();
            usuario.UserName = employee;
            usuario.Passwd = passwd;
            usuario.IsAdmin = isAdmin;

            DatosUsuarios.Usuarios.Add(usuario);
        }
    }
}
