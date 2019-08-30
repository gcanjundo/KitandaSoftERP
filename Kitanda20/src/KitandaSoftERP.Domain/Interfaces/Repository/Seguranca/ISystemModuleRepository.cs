using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Interfaces.Respository.Shared;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Interfaces.Repository.Seguranca
{
    public interface ISystemModuleRepository : IRepository<SystemModule>
    {
        IEnumerable<SystemModule> GetAllBranchLicensedSystems(Branch pBranch);
        IEnumerable<SystemModule> GetAllSystemModulesList(SystemModule pModule);
    }
}
