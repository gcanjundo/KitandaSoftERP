using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Interfaces.Respository.Shared;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Interfaces.Repository.Seguranca
{
    public interface IBranchRepository : IRepository<Branch>
    {
        IEnumerable<Branch> GetLicensedCompany(Branch pBranch);
    }
}
