using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComPosConfiguracao
    {
        public string PosConfigAccount { get; set; }
        public int? PosConfigDocument { get; set; }
        public int? PosConfigPayment { get; set; }
        public int? PosConfigExpedition { get; set; }
        public int? PosConfigCustomer { get; set; }
        public int? PosConfigDocumentStatus { get; set; }
        public string PosConfigPageAfterSale { get; set; }
        public bool? PosConfigKeyboard { get; set; }
        public int? PosConfigCategory { get; set; }
        public int? PosConfigTotalProduct { get; set; }
        public int? PosConfigWarehouse { get; set; }
        public int? PosConfigCodigoFilial { get; set; }
        public int? PosConfigPaymentStatus { get; set; }
        public string PosConfigOperationMode { get; set; }
        public string PosConfigControlMode { get; set; }
        public bool? PosConfigCodeConfirmation { get; set; }
        public bool? PosConfigMultiplesCloses { get; set; }
        public string PosConfigPrinterName { get; set; }
        public string PosSupervisorCode { get; set; }
        public decimal? PosFundoDefault { get; set; }
        public int PosCodigo { get; set; }
        public bool? PosKitechenMonitor { get; set; }
        public string PosKitechenPrinterName { get; set; }
        public int? PosOpeningDocumentId { get; set; }
        public int? PosClosureDocumentId { get; set; }
        public int? PosDefaultInDocumentId { get; set; }
        public int? PosDefaultOutDocumentId { get; set; }
    }
}
