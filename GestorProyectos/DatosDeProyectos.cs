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
        public DatosDeProyectos()
        {
            dtProyectos = new DataTable();
            dtProyectosAddColumnas();

            dtTareas = new DataTable();
            dtTareasAddColumas();

            dtEmpleados = new DataTable();
            dtEmpleadosAddCoolumnas();

            dtAsignaciones = new DataTable();
            dtAsinacionesAddColumnas();
            actualizarCantidadTareasYEmpleados();
        }

        
        public DataTable dtProyectos;
        public  DataTable dtTareas;
        public  DataTable dtEmpleados;
        public DataTable dtAsignaciones;

        //Metodo para crear campos en el dtProyectos
        private void dtProyectosAddColumnas()
        {
            dtProyectos.Columns.Add("IDProyecto", typeof(string));
            dtProyectos.Columns.Add("Nombre", typeof(string));
            dtProyectos.Columns.Add("Categoria", typeof(string));
            dtProyectos.Columns.Add("Estado", typeof(string));
            dtProyectos.Columns.Add("Presupuesto", typeof(double));
            dtProyectos.Columns.Add("Fecha_Inicio", typeof(DateTime));
            dtProyectos.Columns.Add("Fecha_Final", typeof(DateTime));
            dtProyectos.Columns.Add("Descripcion", typeof(string));
            dtProyectos.Columns.Add("Catidadad_Tareas", typeof(int));
            dtProyectos.Columns.Add("Empleados", typeof(int));
        }

        //crear campos en dtTareas
        private void dtTareasAddColumas()
        {
            dtTareas.Columns.Add("IDProyectoTarea", typeof(string));
            dtTareas.Columns.Add("Nombre", typeof(string));
            dtTareas.Columns.Add("Estado", typeof(string));
            dtTareas.Columns.Add("IDProyecto", typeof(string));
            dtTareas.Columns.Add("DescripcionT", typeof(string));    
        }

        private void dtAsinacionesAddColumnas()
        {
            dtAsignaciones.Columns.Add("idAsignacion", typeof(string));
            dtAsignaciones.Columns.Add("IdEmpleado", typeof(string));
            dtAsignaciones.Columns.Add("IDProyectoTarea", typeof(string));

        }

        //crear campos en dtEmpleados
        private void dtEmpleadosAddCoolumnas()
        {
            dtEmpleados.Columns.Add("IdEmpleado", typeof(string));
            dtEmpleados.Columns.Add("Nombre", typeof(string));
            dtEmpleados.Columns.Add("Rol", typeof(string));
            dtEmpleados.Columns.Add("Salario", typeof(string));

        }



        public void actualizarCantidadTareasYEmpleados()
        {
            foreach (DataRow proyectoRow in dtProyectos.Rows)
            {
                string idProyecto = proyectoRow["IDProyecto"].ToString();

                int cantidadTareas = dtTareas.AsEnumerable()
                                             .Count(row => row["IDProyecto"].ToString() == idProyecto);

                var idsTareas = dtTareas.AsEnumerable().Where(row => row["IDProyecto"].ToString() == idProyecto)
                                        .Select(row => row["IDProyectoTarea"].ToString());

                int cantidadEmpleados = dtAsignaciones.AsEnumerable().Where(row => idsTareas.Contains(row["IDProyectoTarea"].ToString()))
                                                      .Select(row => row["IdEmpleado"].ToString()).Distinct().Count();


                proyectoRow["Catidadad_Tareas"] = cantidadTareas;
                proyectoRow["Empleados"] = cantidadEmpleados;
            }
        }





        // crear ID del Proyecto
        public string generarIDProyecto()
        {
            return generarID("PYT-", dtProyectos, "IDProyecto");
        }

        // generar IDProyectoTarea
        public string generarIDProyectoTarea()
        {
            return generarID("T", dtTareas, "IDProyectoTarea");
        }

        //generar IDAsignacion
        public string generarIDAsignacion()
        {
            return generarID("ASGN-", dtAsignaciones, "idAsignacion");
        }

        //genara el IdPara todos
        private string generarID(string prefijo, DataTable tabla, string columnaID)
        {
            Random random = new Random();
            string nuevoID;

            do
            {
                int numero = random.Next(100, 1000); 
                nuevoID = $"{prefijo}{numero:D3}";

            } while (IDYaExiste(nuevoID, tabla, columnaID));

            return nuevoID;
        }

        // Verificar si  ID ya existe
        private bool IDYaExiste(string id, DataTable tabla, string columnaID)
        {
            DataRow[] filasExistentes = tabla.Select($"{columnaID} = '{id}'");

            return filasExistentes.Length > 0;
        }





    }
}
