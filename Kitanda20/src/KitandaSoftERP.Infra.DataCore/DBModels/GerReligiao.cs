using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerReligiao
    {
        public int RelCodigo { get; set; }
        public string RelDescricao { get; set; }
        public string RelSigla { get; set; }
        public string RelStatus { get; set; }
    }
}
