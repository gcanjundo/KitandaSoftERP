using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComExpedicao
    {
        public ComExpedicao()
        {
            ComFaturaCliente = new HashSet<ComFaturaCliente>();
            ComFaturaFornecedor = new HashSet<ComFaturaFornecedor>();
        }

        public int ExpCodigo { get; set; }
        public string ExpDescricao { get; set; }
        public string ExpSigla { get; set; }
        public string ExpStatus { get; set; }

        public virtual ICollection<ComFaturaCliente> ComFaturaCliente { get; set; }
        public virtual ICollection<ComFaturaFornecedor> ComFaturaFornecedor { get; set; }
    }
}
