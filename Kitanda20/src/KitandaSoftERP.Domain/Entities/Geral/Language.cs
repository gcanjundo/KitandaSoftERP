
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Language : BaseEntity
    {
        public virtual ICollection<User> User { get; set; }
        public override bool IsValid()
        {
           return !ErrorList.Any();
        }
    }
}
