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

            tareasConEmpleados = new DataTable();
            dtTareasYEmpleados();


            actualizarCantidadTareasYEmpleadosProyectos();
            actualizarCantidadTareasYProyectosEmpleados();
        }

        
        public DataTable dtProyectos;
        public  DataTable dtTareas;
        public  DataTable dtEmpleados;
        public DataTable dtAsignaciones;
       public  DataTable tareasConEmpleados;


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
            dtTareas.Columns.Add("IdEmpleado", typeof(string));
            dtTareas.Columns.Add("Descripcion", typeof(string)); 
        }

        private void dtAsinacionesAddColumnas()
        {
            dtAsignaciones.Columns.Add("idAsignacion", typeof(string));
            dtAsignaciones.Columns.Add("IdEmpleado", typeof(string));
            dtAsignaciones.Columns.Add("IDProyectoTarea", typeof(string));

        }

        //crear campos en dtEmpleados ///
        private void dtEmpleadosAddCoolumnas()
        {
            dtEmpleados.Columns.Add("IdEmpleado", typeof(string));
            dtEmpleados.Columns.Add("Nombre", typeof(string));
            dtEmpleados.Columns.Add("Rol", typeof(string));
            dtEmpleados.Columns.Add("Salario", typeof(double));
      
        }

        //temporal
        private void dtTareasYEmpleados()
        {            
            tareasConEmpleados.Columns.Add("IDTarea");
            tareasConEmpleados.Columns.Add("NombreTarea");
            tareasConEmpleados.Columns.Add("EstadoTarea");
            tareasConEmpleados.Columns.Add("Empleado");
            tareasConEmpleados.Columns.Add("RolEmpleado");
            tareasConEmpleados.Columns.Add("Descripcion");
        }

        public bool IdEmpleadoExiste(string idEmpleado)
        {
            return dtEmpleados.AsEnumerable()
                .Any(row => row.Field<string>("IdEmpleado") == idEmpleado);
        }

        public void actualizarCantidadTareasYProyectosEmpleados()
        {
            foreach (DataRow empleadoRow in dtEmpleados.Rows)
            {
                string idEmpleado = empleadoRow["IdEmpleado"].ToString();

                var idsAsignaciones = dtAsignaciones.AsEnumerable().Where(row => row["IdEmpleado"].ToString() == idEmpleado)
                    .Select(row => row["IDProyectoTarea"].ToString()).ToList();

                int cantidadTareas = idsAsignaciones.Count;

                int cantidadProyectos = dtTareas.AsEnumerable().Where(row => idsAsignaciones.Contains(row["IDProyectoTarea"].ToString()))
                              .Select(row => row["IDProyecto"].ToString()).Distinct().Count();


                empleadoRow["Tareas"] = cantidadTareas;
                empleadoRow["Proyectos"] = cantidadProyectos;
            }
        }

        public void actualizarCantidadTareasYEmpleadosProyectos()
        {
            foreach (DataRow proyectoRow in dtProyectos.Rows)
            {
                string idProyecto = proyectoRow["IDProyecto"].ToString();

                var idsTareas = dtTareas.AsEnumerable().Where(row => row["IDProyecto"].ToString() == idProyecto)
                                        .Select(row => row["IDProyectoTarea"].ToString()).ToList();

                int cantidadTareas = idsTareas.Count;

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
            return generarID("Tar", dtTareas, "IDProyectoTarea");
        }

        //generar IDAsignacion
        public string generarIDAsignacion()
        {
            return generarID("Asg-", dtAsignaciones, "idAsignacion");
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
