using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisImportacao
    {
        public string ImpDescricao { get; set; }
        public DateTime ImpData { get; set; }
        public DateTime? ImpImportacao { get; set; }
    }
}
