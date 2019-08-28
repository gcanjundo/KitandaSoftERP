using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Geral;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalServicesCategory : ProductCategory
    {
        public int ClinicalServicesProductCategoryID { get; set; }
        public virtual ProductCategory ClinicalServicesProductCategory { get; set; }
        public virtual ICollection<ClinicalServices> ClinicalServicesList { get; set; }
        public ClinicalServicesCategory()
        {
            ClinicalServicesList = new HashSet<ClinicalServices>();
            ClinicalServicesProductCategory = new ProductCategory();
        }
    }
}
