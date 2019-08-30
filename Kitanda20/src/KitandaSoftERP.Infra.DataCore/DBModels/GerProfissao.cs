using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerProfissao
    {
        public GerProfissao()
        {
            GerEntidadePessoa = new HashSet<GerEntidadePessoa>();
        }

        public int ProfCodigo { get; set; }
        public string ProfDescricao { get; set; }
        public string ProfSigla { get; set; }
        public string ProfStatus { get; set; }

        public virtual ICollection<GerEntidadePessoa> GerEntidadePessoa { get; set; }
    }
}
