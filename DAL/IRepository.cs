using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        bool Guardar(TEntity laEntidad);
        bool Modificar(TEntity laEntidad);
        bool Eliminar(TEntity laEntidad);
        TEntity Buscar(Expression<Func<TEntity, bool>> Busqueda);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> Busqueda);
        List<TEntity> GetListTD();
    }
}
