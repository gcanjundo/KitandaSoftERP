using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Interfaces.Respository.Shared;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace KitandaSoftERP.Domain.Interfaces.Repository.Geral
{
    public interface IEntityRepository : IRepository<Entity>
    {
        void AddPerson(EntityPerson pPerson);
        void UpdatePerson(EntityPerson pPerson);
        EntityPerson GetPersonByID(EntityPerson pPerson); 
        IEnumerable<EntityPerson> GetPersonsByFilter(EntityPerson pPerson);

        void AddEnterprise(EntityEnterprise pEnterprise);
        void UpdateEnterprise(EntityEnterprise pEnterprise);
        EntityEnterprise GetEnterpriseByID(EntityEnterprise pEnterprise); 
        IEnumerable<EntityEnterprise> GetEnterprisesByFilter(EntityEnterprise pEnterprise);
    }
}
