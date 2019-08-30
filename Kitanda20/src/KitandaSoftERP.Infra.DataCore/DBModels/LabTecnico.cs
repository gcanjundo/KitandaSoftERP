using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class LabTecnico
    {
        public int TecCodigo { get; set; }
        public int? TecCodigoFuncionario { get; set; }
        public string TecNome { get; set; }
    }
}
