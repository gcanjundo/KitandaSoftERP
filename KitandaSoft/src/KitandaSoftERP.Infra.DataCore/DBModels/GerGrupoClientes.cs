using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerGrupoClientes
    {
        public GerGrupoClientes()
        {
            GerTerceiros = new HashSet<GerTerceiros>();
        }

        public int GruCodigo { get; set; }
        public string GruDescricao { get; set; }
        public string GruSigla { get; set; }
        public string GruStatus { get; set; }

        public virtual ICollection<GerTerceiros> GerTerceiros { get; set; }
    }
}
