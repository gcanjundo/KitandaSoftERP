using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class AcademicDocumentTemplate : BaseEntity 
    {
        
        public string Link { get; set; }
        public string HtmlTemplate { get; set; }   
        public int BillingItemID { get; set; } 
        public virtual Product BillingItem { get; set; }
        public virtual Branch Branch { get; set; }
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
