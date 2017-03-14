using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class EmpleadosDescuentosBll
    {
        public static bool Guardar(EmpleadosRetenciones relacion)
        {
            using (var conexion = new Repository<Empleados>())
            {
                try
                {
                    return conexion.Guardar(relacion);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Guardar(List<EmpleadosRetenciones> lista)
        {
            try
            {
                foreach (var rel in lista)
                {
                    Guardar(rel);
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }
    }
}
