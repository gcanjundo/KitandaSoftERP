using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class ProductComposed:Product
    {
        public int ComposeID { get; set; }
        public int ProductID { get; set; } 
        public virtual Product Product { get; set; }


    }
}
