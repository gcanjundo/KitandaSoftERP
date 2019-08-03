using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerModelo
    {
        public int ModCodigo { get; set; }
        public int? ModCodigoMarca { get; set; }
        public string ModDescricao { get; set; }
        public bool? ModStatus { get; set; }

        public virtual GerMarca ModCodigoMarcaNavigation { get; set; }
    }
}
