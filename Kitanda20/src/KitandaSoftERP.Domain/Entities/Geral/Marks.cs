using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public partial class Marks : BaseEntity
    {
        public int ModelMarkID { get; set; }
        public virtual Marks ModelMark { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }
        public virtual ICollection<Vehicle> VehicleList { get; set; }
        public virtual ICollection<Marks> ModelMarkList { get; set; }

        public Marks()
        {
            ProductList = new HashSet<Product>();
            VehicleList = new HashSet<Vehicle>();
            ModelMarkList = new HashSet<Marks>();
            ModelMark = new Marks();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
