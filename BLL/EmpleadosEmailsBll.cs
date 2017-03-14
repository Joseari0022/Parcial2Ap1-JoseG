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
    public class EmpleadosEmailsBll
    {
        public static bool Guardar(Entidades.EmpleadosEmails email)
        {
            using (var conexion = new Repository<EmpleadosEmails>())
            {
                try
                {
                    return conexion.Guardar(email);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Eliminar(EmpleadosEmails email)
        {
            using (var conexion = new Repository<EmpleadosEmails>())
            {
                try
                {
                    return conexion.Eliminar(email);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Modificar(EmpleadosEmails email)
        {
            using (var conexion = new Repository<EmpleadosEmails>())
            {
                try
                {
                    return conexion.Modificar(email);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static EmpleadosEmails Buscar(Expression<Func<EmpleadosEmails, bool>> criterio)
        {
            using (var conexion = new Repository<EmpleadosEmails>())
            {
                try
                {
                    return conexion.Buscar(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Entidades.EmpleadosEmails> GetList(Expression<Func<Entidades.EmpleadosEmails, bool>> criterio)
        {
            using (var conexion = new Repository<EmpleadosEmails>())
            {
                try
                {
                    return conexion.GetList(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<EmpleadosEmails> GetListTD()
        {
            using (var conexion = new Repository<EmpleadosEmails>())
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
