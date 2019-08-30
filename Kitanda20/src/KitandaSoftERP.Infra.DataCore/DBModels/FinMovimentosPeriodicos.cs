using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class FinMovimentosPeriodicos
    {
        public int ProgCodigo { get; set; }
        public string ProgDescricao { get; set; }
        public DateTime? ProgFrom { get; set; }
        public DateTime? ProgUntil { get; set; }
        public string ProgPeriodicidade { get; set; }
        public int? ProgDias { get; set; }
        public string ProgNatureza { get; set; }
        public int? ProgEntidadeId { get; set; }
        public int? ProgRubricaId { get; set; }
        public decimal? ProgValor { get; set; }
        public int? ProgMoedaId { get; set; }
        public decimal? ProgCambio { get; set; }
        public int? ProgDocumentId { get; set; }
        public int? ProgAccountId { get; set; }
        public bool? ProgStatus { get; set; }
        public string ProgCreatedBy { get; set; }
        public DateTime? ProgCreatedDate { get; set; }
        public string ProgUpdatedBy { get; set; }
        public DateTime? ProgUpdatedDate { get; set; }
        public string ProgDeletedBy { get; set; }
        public DateTime? ProgDeletedDate { get; set; }
    }
}
