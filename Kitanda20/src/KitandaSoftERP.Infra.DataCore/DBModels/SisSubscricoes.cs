using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisSubscricoes
    {
        public int SubCodigo { get; set; }
        public string SubDescricao { get; set; }
        public string SubCreatedBy { get; set; }
        public DateTime? SubCreatedDate { get; set; }
        public string SubUpdatedBy { get; set; }
        public DateTime? SubUpdatedDate { get; set; }
    }
}
