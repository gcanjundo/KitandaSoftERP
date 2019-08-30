using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Restaurant
{
    public class ConsomerCard : BaseEntity
    {
        public string Barcode { get; set; }
        public override bool IsValid()
        {
            return ErrorList.Any();
        }
    }
}
