using GestorProyectos.Codes;
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
    public partial class FormChat : Form
    {
        public FormChat()
        {
            InitializeComponent();
        }

        private void txbMensaje_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                string remitente = "Pedro";
                string destinatario = cbDestinatario.Text;
                string mensaje=txbMensaje.Text.Trim();
                Chat.MensajesEnviados.EnviarMensaje(destinatario, remitente, mensaje);
            }
        }
    }
}
