using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public partial class Colors : BaseEntity
    {
        public virtual ICollection<Product> ProductList { get; set; }
        public virtual ICollection<Vehicle> VehicleList { get; set; }

        public Colors()
        {
            ProductList = new HashSet<Product>();
            VehicleList = new HashSet<Vehicle>();
        }
        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Designation))
                ErrorList.Add("A Designação da Cor é obrigatória");

            return !ErrorList.Any();
        }
    }
}
