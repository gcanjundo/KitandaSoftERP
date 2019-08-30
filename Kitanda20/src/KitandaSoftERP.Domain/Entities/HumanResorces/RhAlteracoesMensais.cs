using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhAlteracoesMensais
    {
        public int AltCodigo { get; set; }
        public int? AltCodigoFuncionario { get; set; }
        public string AltStatus { get; set; }
        public int? AltCodigoOperacao { get; set; }
        public DateTime? AltData { get; set; }
        public DateTime? AltInicio { get; set; }
        public DateTime? AltTermino { get; set; }
        public decimal? AltDuracao { get; set; }
        public string AltUnidade { get; set; }
    }
}
