using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Occupation : BaseEntity
    {
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }


    }
}
