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
    public class TiposEmailBll
    {
        public static bool Guardar(TiposEmails tipo)
        {
            using (var conexion = new Repository<TiposEmails>())
            {
                try
                {
                    return conexion.Guardar(tipo);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Eliminar(TiposEmails tipo)
        {
            using (var conexion = new Repository<TiposEmails>())
            {
                try
                {
                    return conexion.Eliminar(tipo);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Modificar(TiposEmails tipo)
        {
            using (var conexion = new Repository<TiposEmails>())
            {
                try
                {
                    return conexion.Modificar(tipo);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static TiposEmails Buscar(Expression<Func<TiposEmails, bool>> Busqueda)
        {
            using (var conexion = new Repository<TiposEmails>())
            {
                try
                {
                    return conexion.Buscar(Busqueda);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<TiposEmails> GetList(Expression<Func<TiposEmails, bool>> Busqueda)
        {
            using (var conexion = new Repository<TiposEmails>())
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

        public static List<TiposEmails> GetListTD()
        {
            var tipo = new TiposEmails();

            using (var conexion = new Repository<TiposEmails>())
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
