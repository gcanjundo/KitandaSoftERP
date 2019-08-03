using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Worshop
{
    public partial class WorshopProduct:BaseEntity
    {
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        public override bool IsValid()
        {
            return ErrorList.Any();
        }
    }
}
