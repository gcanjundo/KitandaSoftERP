using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerGrupoSanguineo
    {
        public GerGrupoSanguineo()
        {
            GerEntidadePessoa = new HashSet<GerEntidadePessoa>();
        }

        public int SangCodigo { get; set; }
        public string SangDescricao { get; set; }
        public string SangSigla { get; set; }
        public string SangEstado { get; set; }

        public virtual ICollection<GerEntidadePessoa> GerEntidadePessoa { get; set; }
    }
}
