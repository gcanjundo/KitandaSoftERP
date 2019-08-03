using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComTabelaPrecoArtigos
    {
        public int PvpArtigo { get; set; }
        public int PvpTabela { get; set; }
        public decimal? PvpPreco { get; set; }
        public int? PvpImpostoId { get; set; }
        public int? PvpUnidadeId { get; set; }
        public decimal? PvpImposto { get; set; }
        public decimal? PvpValorImposto { get; set; }
        public decimal? PvpQtd { get; set; }
        public bool? PvpImpostoIncluido { get; set; }
        public string PvpCreatedBy { get; set; }
        public DateTime? PvpCreatedDate { get; set; }
        public string PvpUpdatedBy { get; set; }
        public DateTime? PvpUpdatedDate { get; set; }

        public virtual GerArtigo PvpArtigoNavigation { get; set; }
        public virtual ComTabelaPreco PvpTabelaNavigation { get; set; }
    }
}
