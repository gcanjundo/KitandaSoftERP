using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.MedicalManagement;
using KitandaSoftERP.Domain.Entities.Shared; 
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class ProductCategory:BaseEntity
    { 
        public string PhotoPath { get; set; }
        public byte[] Photo { get; set; }
        public int SubCategoryProductCategoryID { get; set; }
        public virtual ProductCategory SubCategoryProductCategory { get; set; }
        public virtual ClinicalServicesCategory ClinicalServicesCategory { get; set; }
        public virtual ICollection<Product> ProductsList { get; set; }
        public virtual ICollection<ProductCategory> SubCategoryProducCategoryList { get; set; }

        public ProductCategory()
        {    
            ProductsList = new HashSet<Product>();
            SubCategoryProducCategoryList = new HashSet<ProductCategory>();
            SubCategoryProductCategory = new ProductCategory();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }


}
