using GestorProyectos.Code;
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
        private string remitenteActual;
        public FormChat(string Remitente)
        {
            remitenteActual = Remitente;
            InitializeComponent();
            cbDestinatario.Items.Clear();
            cbDestinatario.Items.AddRange(Users.ObtenerUsuarios.obtenerUsuarios().ToArray());
            cbDestinatario.SelectedIndex = 0;
            txbChat.Text = Chat.MensajesEnviados.RecibirMensaje(Remitente, cbDestinatario.SelectedItem.ToString());
        }

        private void txbMensaje_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                string remitente = remitenteActual;
                string destinatario = cbDestinatario.Text;
                string mensaje=txbMensaje.Text.Trim();
                Chat.MensajesEnviados.EnviarMensaje(destinatario, remitente, mensaje);
                txbChat.Text = Chat.MensajesEnviados.RecibirMensaje(remitente, destinatario);
            }
        }

        private void cbDestinatario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbChat.Text = Chat.MensajesEnviados.RecibirMensaje(remitenteActual, cbDestinatario.SelectedItem.ToString());
            txbMensaje.Focus();
        }
    }
}
