using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerSubCategoria
    {
        public GerSubCategoria()
        {
            GerItem = new HashSet<GerItem>();
        }

        public int SubCodigo { get; set; }
        public int? SubCodigoCategoria { get; set; }
        public string SubDescricao { get; set; }
        public bool? SubStatus { get; set; }

        public virtual GerCategoria SubCodigoCategoriaNavigation { get; set; }
        public virtual ICollection<GerItem> GerItem { get; set; }
    }
}
