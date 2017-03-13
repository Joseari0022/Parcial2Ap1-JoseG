using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class TiposEmailBll
    {
        public static bool Guardar(TiposEmail te)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                {
                    db.TiposEmail.Add(te);
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

        public static bool Eliminar(TiposEmail t)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                TiposEmail te = db.TiposEmail.Find(t);
                {
                    db.TiposEmail.Remove(te);
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
                TiposEmail te = db.TiposEmail.Find(v);
                {
                    db.TiposEmail.Remove(te);
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

        public static TiposEmail Buscar(int Id)
        {
            try
            {
                Parcial2Db db = new Parcial2Db();
                {
                    return db.TiposEmail.Find(Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
