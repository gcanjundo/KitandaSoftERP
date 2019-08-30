using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhBeneficios
    {
        public RhBeneficios()
        {
            RhTipoSalarioItem = new HashSet<RhTipoSalarioItem>();
        }

        public int BenCodigo { get; set; }
        public string BenDescricao { get; set; }
        public string BenCategoria { get; set; }
        public string BenSigla { get; set; }
        public string BenStatus { get; set; }

        public virtual ICollection<RhTipoSalarioItem> RhTipoSalarioItem { get; set; }
    }
}
