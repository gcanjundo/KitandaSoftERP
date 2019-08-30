using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhOperacoesMensais
    {
        public int OpeCodigo { get; set; }
        public string OpeDescricao { get; set; }
        public string OpeOperacao { get; set; }
        public string OpeTipo { get; set; }
        public string OpeStatus { get; set; }
    }
}
