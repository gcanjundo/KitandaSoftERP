using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class LabExameItem
    {
        public int ItemCodigoExame { get; set; }
        public string ItemNome { get; set; }
        public string ItemUnidade { get; set; }
        public string ItemReferencia { get; set; }
        public string ItemVariavel { get; set; }
        public string ItemTipo { get; set; }

        public virtual LabExame ItemCodigoExameNavigation { get; set; }
    }
}
