using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestorProyectos.Code.Users;

namespace GestorProyectos.Codes
{
    internal class Chat
    {
        public class Mensajes
        {
            public string remitente { set; get; }
            public string destinatario { set; get; }
            public string mensaje { set; get; }
            public DateTime fecha { set; get; }
        }

        public static class BaseMensajes
        {
            public static List<Mensajes> Mensajeria { get; set; } = new List<Mensajes>();
        }

        public static class MensajesEnviados
        {
            public static string RecibirMensaje(string Destinatario)
            {
                string Mensaje = "";
                foreach (Mensajes mensaje in BaseMensajes.Mensajeria)
                {
                    if (mensaje.destinatario == Destinatario)
                    {
                        Mensaje += $"{mensaje.remitente} ({mensaje.fecha}): {mensaje.mensaje}\n\n";
                    }
                    else if (mensaje.remitente == Destinatario)
                    {
                        Mensaje += $"{mensaje.destinatario} ({mensaje.fecha}): {mensaje.mensaje}\n\n";
                    }
                }

                return Mensaje;
            }

            public static bool EnviarMensaje(string Destinatario, string Remitente ,string Mensaje)
            {
                Mensajes mensaje = new Mensajes();
                mensaje.destinatario = Destinatario;
                mensaje.remitente = Remitente;
                mensaje.mensaje = Mensaje;
                BaseMensajes.Mensajeria.Add(mensaje);

                return true;
            }
        }
    }
}
