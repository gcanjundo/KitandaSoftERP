using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhVinculoContratual
    {
        public RhVinculoContratual()
        {
            RhFuncionario = new HashSet<RhFuncionario>();
        }

        public int VincCodigo { get; set; }
        public string VincDescricao { get; set; }
        public string VincSigla { get; set; }
        public string VincEstado { get; set; }

        public virtual ICollection<RhFuncionario> RhFuncionario { get; set; }
    }
}
