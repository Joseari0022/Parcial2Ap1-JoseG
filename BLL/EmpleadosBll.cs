using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Linq.Expressions;

namespace BLL
{
    public class EmpleadosBll
    { 
        public static bool Guardar(Empleados emp)
        {
            using (var conexion = new Parcial2Db())
            {
                try
                {
                    conexion.Empleados.Add(emp);
                    foreach(var p in emp.Retenciones)
                    {
                        conexion.Entry(p).State = System.Data.Entity.EntityState.Unchanged;
                    }
                    conexion.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return false;
        }

        public static bool Eliminar(Entidades.Empleados empleado)
        {
            using (var conexion = new Repository<Empleados>())
            {
                try
                {
                    return conexion.Eliminar(empleado);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return false;
        }

        public static bool Modificar(Entidades.Empleados empleado)
        {
            using (var conexion = new Repository<Empleados>())
            {
                try
                {
                    return conexion.Modificar(empleado);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static Entidades.Empleados Buscar(Expression<Func<Entidades.Empleados, bool>> Busqueda)
        {
            var emp = new Entidades.Empleados();

            using (var conexion = new Repository<Empleados>())
            {
                try
                {
                    emp = conexion.Buscar(Busqueda);

                    if (emp != null)
                    {
                        emp.Retenciones.Count();
                        emp.Relacion.Count();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return emp;
        }

        public static List<Empleados> GetList(Expression<Func<Empleados, bool>> Busqueda)
        {
            using (var conexion = new Repository<Empleados>())
            {
                try
                {
                    return conexion.GetList(Busqueda);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Entidades.Empleados> GetListTD()
        {
            using (var conexion = new Repository<Empleados>())
            {
                try
                {
                    return conexion.GetListTD();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
