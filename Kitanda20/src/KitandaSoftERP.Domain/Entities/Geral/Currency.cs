using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral { 

    public class Currency:BaseEntity
    { 
        public string IsoCode { get; set; }
        public virtual AcademicSettings AcademicSettings { get; set; }
        public ICollection<SalesInvoice> SalesInvoicesList { get; set; }
        public Currency()
        {
            AcademicSettings = new AcademicSettings();
            SalesInvoicesList = new HashSet<SalesInvoice>();
        }
        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Designation))
                ErrorList.Add("A Designação oficial da moeda é obrigatória");
            if (string.IsNullOrEmpty(IsoCode))
                ErrorList.Add("Informe a Sigla da Moeda");

            return !ErrorList.Any();
        }
    }


}
