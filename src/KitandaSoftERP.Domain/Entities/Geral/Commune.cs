using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Commune : BaseEntity
    { 
        public int CityID { get; set; }
        public virtual City City { get; set; } 
        public int DistrictCommuneID { get; set;}
        public virtual Commune DistrictCommune { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
