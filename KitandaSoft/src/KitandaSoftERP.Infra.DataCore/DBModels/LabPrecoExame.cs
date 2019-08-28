using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class LabPrecoExame
    {
        public int PreCodigo { get; set; }
        public int PreCodigoExame { get; set; }
        public double PrePreco { get; set; }
        public DateTime PreDataInicio { get; set; }
        public DateTime? PreDataFim { get; set; }

        public virtual LabExame PreCodigoExameNavigation { get; set; }
    }
}
