using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerImpostos
    {
        public GerImpostos()
        {
            ComFaturaClienteItem = new HashSet<ComFaturaClienteItem>();
            ComFaturaFornecedorItem = new HashSet<ComFaturaFornecedorItem>();
            GerArtigo = new HashSet<GerArtigo>();
        }

        public int ImpCodigo { get; set; }
        public string ImpDescricao { get; set; }
        public string ImpSigla { get; set; }
        public string ImpStatus { get; set; }
        public decimal? ImpValor { get; set; }
        public string ImpValorizacao { get; set; }
        public int? ImpZonaFiscal { get; set; }
        public string ImpTipo { get; set; }
        public string ImpCategoria { get; set; }
        public bool? ImpIncluido { get; set; }
        public string ImpObservacoes { get; set; }

        public virtual ICollection<ComFaturaClienteItem> ComFaturaClienteItem { get; set; }
        public virtual ICollection<ComFaturaFornecedorItem> ComFaturaFornecedorItem { get; set; }
        public virtual ICollection<GerArtigo> GerArtigo { get; set; }
    }
}
