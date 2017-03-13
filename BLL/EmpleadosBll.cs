using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class EmpleadosBll
    {

        public static bool Guardar(Empleados e)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                {
                    db.Empleados.Add(e);
                    db.SaveChanges();
                    db.Dispose();
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
                throw;
            }
        }

        public static bool Eliminar(Empleados e)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                Empleados em = db.Empleados.Find(e);
                {
                    db.Empleados.Remove(e);
                    db.SaveChanges();
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
                throw;
            }

        }

        public static bool Eliminar(int v)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                Empleados e = db.Empleados.Find(v);
                {
                    db.Empleados.Remove(e);
                    db.SaveChanges();
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
                throw;
            }


        }

        public static Empleados Buscar(int Id)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                {
                    return db.Empleados.Find(Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
