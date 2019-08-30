using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhVencimento
    {
        public RhVencimento()
        {
            RhFuncionario = new HashSet<RhFuncionario>();
            RhTipoSalarioItem = new HashSet<RhTipoSalarioItem>();
        }

        public int VencCodigo { get; set; }
        public string VencDescricao { get; set; }
        public string VencSigla { get; set; }
        public string VencEstado { get; set; }
        public int? VencHoras { get; set; }

        public virtual ICollection<RhFuncionario> RhFuncionario { get; set; }
        public virtual ICollection<RhTipoSalarioItem> RhTipoSalarioItem { get; set; }
    }
}
