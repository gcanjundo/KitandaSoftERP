using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisSaftAoExport
    {
        public int SaftCodigo { get; set; }
        public int? SaftComapnyId { get; set; }
        public string SaftFinalidade { get; set; }
        public DateTime? SaftData { get; set; }
        public string SaftVersao { get; set; }
        public DateTime? SaftFrom { get; set; }
        public DateTime? SaftUntil { get; set; }
        public string SaftDesignacao { get; set; }
        public string SaftStatus { get; set; }
        public string SaftCreatedBy { get; set; }
        public DateTime? SaftCreatedDate { get; set; }
        public string SaftUpdatedBy { get; set; }
        public DateTime? SaftUpdatedDate { get; set; }
        public int? SaftFiscalYear { get; set; }
        public int? SaftPeriodoId { get; set; }
    }
}
