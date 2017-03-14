using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        DAL.Parcial2Db Context = null;

        public Repository()
        {
            Context = new Parcial2Db();
        }

        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Context.Set<TEntity>();
            }
        }

        public bool Guardar(EmpleadosRetenciones relacion)
        {
            throw new NotImplementedException();
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> Busqueda)
        {
            try
            {
                return EntitySet.FirstOrDefault(Busqueda);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool Guarda(TEntity laEntidad)
        {
            try
            {
                EntitySet.Add(laEntidad);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public bool Modificar(TEntity laEntidad)
        {
            try
            {
                EntitySet.Attach(laEntidad);
                Context.Entry(laEntidad).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

            return false;
        }

        public void Dispose()
        {
            if(Context != null)
            {
                Context.Dispose();
            }
        }

        public bool Eliminar(TEntity laEntidad)
        {
            try
            {
                EntitySet.Attach(laEntidad);
                EntitySet.Remove(laEntidad);
                return Context.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> Busqueda)
        {
            try
            {
                return EntitySet.Where(Busqueda).ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<TEntity> GetListTD()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool Guardar(TEntity laEntidad)
        {
            throw new NotImplementedException();
        }
    }
}
