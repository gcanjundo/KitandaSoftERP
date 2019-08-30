using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class StockEntrada
    {
        public int DocEntCodigo { get; set; }
        public string DocEntOrigem { get; set; }

        public virtual StockFaturaCompra StockFaturaCompra { get; set; }
    }
}
