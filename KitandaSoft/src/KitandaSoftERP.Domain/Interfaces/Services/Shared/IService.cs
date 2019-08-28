using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KitandaSoftERP.Domain.Interfaces.Services.Shared
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {

        TEntity AddNew(TEntity pEntity);
        TEntity Update(TEntity pEntity);
        TEntity Delete(TEntity pEntity);
        TEntity GetById(int pID);
        TEntity GetByDesignation(TEntity pEntity);
        IEnumerable<TEntity> GetByFilter(Expression<Func<TEntity, bool>> predicate);
    }
}
