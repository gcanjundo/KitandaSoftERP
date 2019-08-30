using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComPos
    {
        public ComPos()
        {
            ComPosStatus = new HashSet<ComPosStatus>();
        }

        public int PosCodigo { get; set; }
        public string PosDesignacao { get; set; }
        public string PosDescricao { get; set; }
        public string PosSigla { get; set; }
        public string PosStatus { get; set; }
        public int? PosDefaultWarehouse { get; set; }
        public int? PosDefaultDocumentSerie { get; set; }
        public int? PosDefaultCustomer { get; set; }
        public int? PosPaymentTermsId { get; set; }
        public string PosCreatedBy { get; set; }
        public DateTime? PosCreatedDate { get; set; }
        public string PosUpdatedBy { get; set; }
        public DateTime? PosUpdatedDate { get; set; }
        public int? PosPaymentMethodId { get; set; }
        public int? PosVendedorId { get; set; }
        public int? PosPvpId { get; set; }
        public decimal? PosFundoManeio { get; set; }
        public bool? PosAllowCalendar { get; set; }
        public bool? PosSuspenseSales { get; set; }
        public int? PosCashRefundSerieId { get; set; }
        public int? PosCreditRefundSerieId { get; set; }

        public virtual ICollection<ComPosStatus> ComPosStatus { get; set; }
    }
}
