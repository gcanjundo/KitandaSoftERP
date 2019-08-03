using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComArtigoFornecedor
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public bool? Main { get; set; }

        public virtual GerArtigo Product { get; set; }
        public virtual GerTerceiros Supplier { get; set; }
    }
}
