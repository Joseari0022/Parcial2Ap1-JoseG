using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class RetencionesBll
    {
        public static bool Guardar(Retenciones r)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                {
                    db.Retenciones.Add(r);
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

        public static bool Eliminar(Retenciones re)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                Retenciones rt = db.Retenciones.Find(re);
                {
                    db.Retenciones.Remove(re);
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
                Retenciones r = db.Retenciones.Find(v);
                {
                    db.Retenciones.Remove(r);
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

        public static Retenciones Buscar(int Id)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                {
                    return db.Retenciones.Find(Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
