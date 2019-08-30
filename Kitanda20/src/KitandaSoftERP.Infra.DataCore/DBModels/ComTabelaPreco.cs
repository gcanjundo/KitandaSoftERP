using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComTabelaPreco
    {
        public ComTabelaPreco()
        {
            ComTabelaPrecoArtigos = new HashSet<ComTabelaPrecoArtigos>();
        }

        public int PreCodigo { get; set; }
        public string PreDescricao { get; set; }
        public string PreSigla { get; set; }
        public bool? PreStatus { get; set; }
        public bool? PreDefault { get; set; }
        public string PreCreatedBy { get; set; }
        public DateTime? PreCreatedDate { get; set; }
        public string PreUpdatedBy { get; set; }
        public DateTime? PreUpdatedDate { get; set; }

        public virtual ICollection<ComTabelaPrecoArtigos> ComTabelaPrecoArtigos { get; set; }
    }
}
