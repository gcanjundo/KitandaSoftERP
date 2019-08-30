using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerItem
    {
        public int ItemCodigo { get; set; }
        public string ItemNome { get; set; }
        public int? ItemCodigoSubcategoria { get; set; }

        public virtual GerSubCategoria ItemCodigoSubcategoriaNavigation { get; set; }
    }
}
