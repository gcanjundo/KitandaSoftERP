using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerMeioPagamento
    {
        public GerMeioPagamento()
        {
            FinMovimentoCaixa = new HashSet<FinMovimentoCaixa>();
        }

        public int PagCodigo { get; set; }
        public string PagDescricao { get; set; }
        public string PagSigla { get; set; }
        public bool? PagStatus { get; set; }
        public bool? PagPosVisible { get; set; }
        public string PagDescricaoOutcome { get; set; }
        public string PagAccount { get; set; }
        public string PagAction { get; set; }
        public string PagCreatedBy { get; set; }
        public DateTime? PagCreatedDate { get; set; }
        public string PagUpdatedBy { get; set; }
        public DateTime? PagUpdatedDate { get; set; }
        public string PagImage { get; set; }
        public bool? PagTroco { get; set; }
        public string PagShortname { get; set; }

        public virtual ICollection<FinMovimentoCaixa> FinMovimentoCaixa { get; set; }
    }
}
