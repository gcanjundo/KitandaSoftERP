using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhCargo
    {
        public RhCargo()
        {
            RhFuncionario = new HashSet<RhFuncionario>();
        }

        public int CrgCodigo { get; set; }
        public string CrgDescricao { get; set; }
        public string CrgSigla { get; set; }
        public bool? CrgStatus { get; set; }

        public virtual ICollection<RhFuncionario> RhFuncionario { get; set; }
    }
}
