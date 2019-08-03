using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace KitandaSoftERP.Domain.Interfaces.Respository.Shared
{
    public interface IRepository<TEntity>:IDisposable where TEntity:class
    {

        void AddNew(TEntity pEntity); 
        void Update(TEntity pEntity);
        void Delete(TEntity pEntity);
        TEntity GetById(TEntity pEntity);
        TEntity GetByDesignation(string pDesignation);
        IEnumerable<TEntity>GetByFilter(TEntity pEntity); 
        //int SaveChanges();
    }
}   
