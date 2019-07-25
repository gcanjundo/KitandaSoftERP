using KitandaSoftERP.Domain.Entities.Shared; 
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class ProductCategory  : BaseEntity
    {
        public int CategoryID { get; set; }
        public string PhotoPath { get; set; }
        public byte[] Photo { get; set; }
        public virtual ProductCategory Category { get; set; }
        public virtual ICollection<Product> ProductsList { get; set; }

        public ProductCategory()
        {
            Category = new ProductCategory();
            ProductsList = new HashSet<Product>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }


    }


}
