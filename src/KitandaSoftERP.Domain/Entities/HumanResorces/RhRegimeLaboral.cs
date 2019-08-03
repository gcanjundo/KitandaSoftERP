using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhRegimeLaboral
    {
        public RhRegimeLaboral()
        {
            RhFuncionario = new HashSet<RhFuncionario>();
        }

        public int RegCodigo { get; set; }
        public string RegDescricao { get; set; }
        public string RegSigla { get; set; }
        public bool? RegStatus { get; set; }

        public virtual ICollection<RhFuncionario> RhFuncionario { get; set; }
    }
}
