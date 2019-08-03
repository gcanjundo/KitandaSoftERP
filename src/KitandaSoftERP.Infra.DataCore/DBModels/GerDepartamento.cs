using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerDepartamento
    {
        public GerDepartamento()
        {
            RhFuncionario = new HashSet<RhFuncionario>();
        }

        public int DepCodigo { get; set; }
        public string DepDescricao { get; set; }
        public string DepSigla { get; set; }
        public bool? DepStatus { get; set; }

        public virtual ICollection<RhFuncionario> RhFuncionario { get; set; }
    }
}
