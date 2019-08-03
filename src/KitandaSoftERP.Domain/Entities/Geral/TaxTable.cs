using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class TaxTable : BaseEntity
    {
        public string TaxType { get; set; }
        public string TaxCountryRegion { get; set; }
        public string TaxCode { get; set; }
        public DateTime TaxExpirationDate { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal TaxAmount { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }

        public TaxTable()
        {
            ProductList = new HashSet<Product>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        } 

    }
}
