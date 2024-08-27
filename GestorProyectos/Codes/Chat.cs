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
            public static string RecibirMensaje(string remitente, string destinatario)
            {
                string mensajeCompleto = "";
                foreach (Mensajes mensaje in BaseMensajes.Mensajeria)
                {
                    if (mensaje.remitente == remitente & mensaje.destinatario == destinatario)
                    {
                        mensajeCompleto += $"{mensaje.remitente} ({mensaje.fecha}): {mensaje.mensaje}\n";
                    }
                    else if (mensaje.destinatario == remitente && mensaje.remitente == destinatario)
                    {
                        mensajeCompleto += $"{mensaje.remitente} ({mensaje.fecha}): {mensaje.mensaje}\n";

                    }
                }

                return mensajeCompleto;
            }


            public static bool EnviarMensaje(string Destinatario, string Remitente ,string Mensaje)
            {
                Mensajes mensaje = new Mensajes();
                mensaje.destinatario = Destinatario;
                mensaje.remitente = Remitente;
                mensaje.mensaje = Mensaje;
                mensaje.fecha = DateTime.Now;
                BaseMensajes.Mensajeria.Add(mensaje);

                return true;
            }
        }
    }
}
