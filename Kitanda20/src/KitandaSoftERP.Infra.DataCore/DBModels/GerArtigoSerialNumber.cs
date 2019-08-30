using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerArtigoSerialNumber
    {
        public int SerialCodigo { get; set; }
        public int SerialArtigoId { get; set; }
        public string SerialSerialNumber { get; set; }
        public string SerialBarcode { get; set; }
        public bool? SerialStatus { get; set; }
        public string SerialCreatedBy { get; set; }
        public DateTime? SerialCreatedDate { get; set; }
        public string SerialUpdatedBy { get; set; }
        public DateTime? SerialUpdatedDate { get; set; }

        public virtual GerArtigo SerialArtigo { get; set; }
    }
}
