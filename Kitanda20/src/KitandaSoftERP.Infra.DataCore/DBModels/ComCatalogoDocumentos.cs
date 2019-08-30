using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComCatalogoDocumentos
    {
        public int CatCodigo { get; set; }
        public string CatDescricao { get; set; }
        public string CatSigla { get; set; }
        public short? CatStatus { get; set; }
    }
}
