using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Seguranca;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class AcademicDocumentTemplate : Document
    { 
        public int BillingItemID { get; set; } 
        public virtual Product BillingItem { get; set; }
        public virtual ICollection<StudentDocumentOrder> StudentDocumentsOrderList  { get; set; }
        public AcademicDocumentTemplate()
        {
            BillingItem = new Product();
            Branch = new Branch();
            StudentDocumentsOrderList = new HashSet<StudentDocumentOrder>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
