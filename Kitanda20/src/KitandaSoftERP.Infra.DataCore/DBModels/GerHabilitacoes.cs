using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerHabilitacoes
    {
        public GerHabilitacoes()
        {
            GerEntidadePessoa = new HashSet<GerEntidadePessoa>();
            RhFuncionario = new HashSet<RhFuncionario>();
        }

        public int HabCodigo { get; set; }
        public string HabDescricao { get; set; }
        public string HabSigla { get; set; }
        public bool? HabStatus { get; set; }

        public virtual ICollection<GerEntidadePessoa> GerEntidadePessoa { get; set; }
        public virtual ICollection<RhFuncionario> RhFuncionario { get; set; }
    }
}
