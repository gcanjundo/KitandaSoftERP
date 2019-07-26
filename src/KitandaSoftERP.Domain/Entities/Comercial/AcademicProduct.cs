using KitandaSoftERP.Domain.Entities.Academica;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class AcademicProduct:Product
    {
        public int AcademicProductID { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<AcademicDocumentTemplate> AcademicDocumentList { get; set; }

        public AcademicProduct():base()
        {
            Product = new Product();
            AcademicDocumentList = new HashSet<AcademicDocumentTemplate>();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
