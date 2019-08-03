using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class FiscalYear : BaseEntity
    {
        public int CivilYear { get; set; }
        public DateTime FiscalYearStartDate { get; set; }
        public DateTime FiscalYearEndDate { get; set; }

        public virtual ICollection<SerialCommercialDocuments> SerialDocumentsList { get; set; }

        public FiscalYear()
        {
            SerialDocumentsList = new HashSet<SerialCommercialDocuments>();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
