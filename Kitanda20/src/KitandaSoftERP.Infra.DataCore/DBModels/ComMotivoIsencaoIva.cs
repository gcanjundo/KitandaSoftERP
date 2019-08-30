using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComMotivoIsencaoIva
    {
        public int IsenCodigo { get; set; }
        public string IsenDescricao { get; set; }
        public string IsenSigla { get; set; }
        public bool? IsenStatus { get; set; }
        public string IsenCreatedBy { get; set; }
        public DateTime? IsenCreatedDate { get; set; }
        public string IsenUpdatedBy { get; set; }
        public DateTime? IsenUpdatedDate { get; set; }
    }
}
