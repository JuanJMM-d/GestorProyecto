using GestorProyectos.Code;
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
    public partial class FormColaboradores : Form
    {
        public FormColaboradores()
        {
            InitializeComponent();
            foreach (Users.Usuarios usuario in Users.DatosUsuarios.Usuarios)
            {
                int rowindex = dgvColaboradores.Rows.Add();

                dgvColaboradores.Rows[rowindex].Cells[0].Value = usuario.UserName;
                dgvColaboradores.Rows[rowindex].Cells[1].Value = usuario.IsAdmin;
            }
        }
    }
}
