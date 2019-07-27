using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class FeeManagement : BaseEntity
    {
        public int FeeID { get; set; }
        public int FeeType { get; set; }
        public int Periodicity { get; set; }
        public int InitialPeriod { get; set; }
        public int FinalPeriod { get; set; }
        public int PaymentMethod { get; set; }
        public int GeneratedDocumentID { get; set; }
        public bool GenerateTax { get; set; }
        public decimal CommercialDiscount { get; set; }
        public decimal FinanceDiscount { get; set; }
        public virtual CommercialDocuments GeneratedDocument { get; set; }
        public FeeManagement()
        {
            GeneratedDocument = new CommercialDocuments();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
