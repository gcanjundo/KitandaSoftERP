using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisRestFormularios
    {
        public int PosFormCodigo { get; set; }
        public int? PosFormTag { get; set; }
        public int? PosFormIndice { get; set; }

        public virtual SisFormulario PosFormCodigoNavigation { get; set; }
    }
}
