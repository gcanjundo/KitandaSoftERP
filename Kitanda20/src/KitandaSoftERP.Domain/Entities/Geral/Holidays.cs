using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Holidays: BaseEntity
    {
        public int Day { get; set; }
        public int Mounth { get; set; } 

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
