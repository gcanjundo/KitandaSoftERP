using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Restaurant
{
    public class Table : BaseEntity
    {
        public int LocationID { get; set; }
        public string TableType { get; set; }
        public int PlacesNumber { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
