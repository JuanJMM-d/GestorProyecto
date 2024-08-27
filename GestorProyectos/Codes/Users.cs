using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestorProyectos.Code.Users;

namespace GestorProyectos.Code
{
    internal class Users
    {
        public class Usuarios
        {
            public string UserName { get; set; }
            public string Passwd { get; set; }
            public bool IsAdmin { get; set; }
        }

        public static class DatosUsuarios
        {
            public static List<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
        }

        public static class ObtenerUsuarios
        {

            public static List<string> obtenerUsuarios()
            {   
                List<string> usuarios = new List<string>();
                foreach (Usuarios usuario in DatosUsuarios.Usuarios)
                {
                    usuarios.Add(usuario.UserName);
                }
                return usuarios;
            }
        }

        public static class Autenticacion
        {
            public static bool ValidarCredenciales(string nombreUsuario, string contrasena)
            {
                var usuarioEncontrado = DatosUsuarios.Usuarios.FirstOrDefault(u => u.UserName == nombreUsuario);
                return usuarioEncontrado != null && usuarioEncontrado.Passwd == contrasena;
            }
        }
    }
}
