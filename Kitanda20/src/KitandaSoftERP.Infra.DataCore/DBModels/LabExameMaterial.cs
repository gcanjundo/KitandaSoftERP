using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class LabExameMaterial
    {
        public int ExaMatCodigoExame { get; set; }
        public int ExaMatCodigoMaterial { get; set; }

        public virtual LabExame ExaMatCodigoExameNavigation { get; set; }
        public virtual LabMaterial ExaMatCodigoMaterialNavigation { get; set; }
    }
}
