using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;


namespace KitandaSoftERP.Domain.Entities.Geral
{
    public partial class VehicleCategory: BaseEntity
    {  
        public virtual ICollection<Vehicle> VehicleList { get; set; }
        public VehicleCategory()
        {
            VehicleList = new HashSet<Vehicle>();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
