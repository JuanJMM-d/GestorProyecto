using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProyectos
{
    internal class DatosDeProyectos
    {
        //constructor para la clase DatosDeProyectos
        public DatosDeProyectos(FormCrearProyecto formCrearProyecto)
        {
            dtProyectos = new DataTable();
            dtProyectosAddColumnas();
            this.formCrearProyecto = formCrearProyecto;
        }

        //Variables globales
        public static DataTable dtProyectos;
        public static DataTable dtTareas;
        public static DataTable dtEmpleados;

        FormCrearProyecto formCrearProyecto;


        //crear campos en dtTareas
        private void dtTareasAddColumas()
        {
            dtTareas.Columns.Add("IDProyectoTarea", typeof(string));
            dtTareas.Columns.Add("Nombre", typeof(string));
            dtTareas.Columns.Add("Estado", typeof(string));

        }

        //crear campos en dtEmpleados
        private void dtEmpleadosAddCoolumnas()
        {
            dtEmpleados.Columns.Add("IdEmpleado", typeof(string));
            dtEmpleados.Columns.Add("Nombre", typeof(string));
            dtEmpleados.Columns.Add("IdTarea", typeof(string));
            dtEmpleados.Columns.Add("Rol", typeof(string));

        }




        //Metodo para crear campos en el dtProyectos
        private void dtProyectosAddColumnas()
        {
            dtProyectos.Columns.Add("ID", typeof(string));
            dtProyectos.Columns.Add("Nombre", typeof(string));
            dtProyectos.Columns.Add("Categoria", typeof(string));
            dtProyectos.Columns.Add("Estado", typeof(string));
            dtProyectos.Columns.Add("Presupuesto", typeof(double));
            dtProyectos.Columns.Add("Fecha_Inicio", typeof(string));
            dtProyectos.Columns.Add("Fecha_Final", typeof(string));
            dtProyectos.Columns.Add("Descrripcion", typeof(string));
        }
           




    }
}
