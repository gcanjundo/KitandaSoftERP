using KitandaSoftERP.Domain.Interfaces.Respository.Shared;
using KitandaSoftERP.Infra.DataCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace KitandaSoftERP.Infra.DataCore.Repository.Shared
{
    public class BaseReposity<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ContextApp SchemaDB;
        protected DbSet<TEntity> DbTable;

        public BaseReposity(ContextApp pDbSchema)
        {
            SchemaDB = pDbSchema;
            DbTable = SchemaDB.Set<TEntity>();
        }

        public virtual void AddNew(TEntity pEntity)
        {
            DbTable.Add(pEntity);
            SchemaDB.SaveChanges();
        }
        public virtual void Update(TEntity pEntity)
        {
            DbTable.Update(pEntity);
            SchemaDB.SaveChanges();
        }

        public virtual void Delete(TEntity pEntity)
        {
            DbTable.Remove(pEntity);
            SchemaDB.SaveChanges();
        }
        public virtual TEntity GetById(TEntity pEntity)
        {
            return DbTable.AsNoTracking().FirstOrDefault(); 
        }
         
        public virtual IEnumerable<TEntity> GetByFilter(TEntity pEntity)
        {
            return DbTable.ToList();
        }
        public void Dispose()
        {
            SchemaDB.Dispose();
        }

        public virtual TEntity GetByDesignation(string pDesignation)
        {
            return DbTable.AsNoTracking().FirstOrDefault();
        }
    }
}
