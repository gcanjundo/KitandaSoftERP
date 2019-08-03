using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using Dapper;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Interfaces.Repository.Geral;
using KitandaSoftERP.Infra.DataCore.Context;
using KitandaSoftERP.Infra.DataCore.Repository.Shared;
using Microsoft.EntityFrameworkCore;

namespace KitandaSoftERP.Infra.DataCore.Repository.Geral
{
    public class EntityRepository : BaseReposity<Entity>, IEntityRepository
    {
         
        public EntityRepository(ContextApp pContext):base(pContext)
        {

        }
        public override Entity GetById(Entity pEntity)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {
                return connection.Query<EntityEnterprise>("stp_GER_GetEntityByID", new { pEntityID = pEntity.ID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public override IEnumerable<Entity> GetByFilter(Entity pEntity)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            { 
                return connection.Query<EntityPerson>("stp_GER_GetEntityByFilter", new { pDesignation = pEntity.Designation }, commandType: CommandType.StoredProcedure);
            }
        }


        public void AddEnterprise(EntityEnterprise pEnterprise)
        {
            SchemaDB.EntityEnterprise.Add(pEnterprise);
            SchemaDB.SaveChanges();
        }

        public void UpdateEnterprise(EntityEnterprise pEnterprise)
        {
            SchemaDB.EntityEnterprise.Update(pEnterprise);
            SchemaDB.SaveChanges();
        }

        public virtual EntityEnterprise GetEnterpriseByID(EntityEnterprise pEnterprise)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            { 
                return connection.Query<EntityEnterprise>("stp_GER_GetEntityEnterpriseByID", new { pEntityID = pEnterprise.ID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public virtual IEnumerable<EntityEnterprise> GetEnterprisesByFilter(EntityEnterprise pEnterprise)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            { 
                return connection.Query<EntityEnterprise>("stp_GER_GetEntityEnterpriseByFilter", new { pDesignation = pEnterprise.Designation }, commandType: CommandType.StoredProcedure);
            }
        }

        public void AddPerson(EntityPerson pPerson)
        {
            SchemaDB.EntityPerson.Add(pPerson);
            SchemaDB.SaveChanges();
        }

        public void UpdatePerson(EntityPerson pPerson)
        {
            SchemaDB.EntityPerson.Update(pPerson);
            SchemaDB.SaveChanges();
        }

        public virtual EntityPerson GetPersonByID(EntityPerson pPerson)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {

                return connection.Query<EntityPerson>("stp_GER_GetEntityPersonByID", new { pEntityID = pPerson.ID }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }  
         
        public virtual IEnumerable<EntityPerson> GetPersonsByFilter(EntityPerson pPerson)
        {
            using (var connection = SchemaDB.Database.GetDbConnection())
            {

                return connection.Query<EntityPerson>("stp_GER_GetEntityPersonByFilter", new { pDesignation = pPerson.Designation }, commandType: CommandType.StoredProcedure);
            }
        } 
    }
}
