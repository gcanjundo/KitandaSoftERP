using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhRegistoFalta
    {
        public int FaltCodigo { get; set; }
        public int? FaltCodigoFunicionario { get; set; }
        public DateTime? FaltData { get; set; }
        public DateTime? FaltInicio { get; set; }
        public DateTime? FaltTermino { get; set; }
        public bool? FaltJustificacada { get; set; }
        public string FaltMotivo { get; set; }

        public virtual RhFuncionario FaltCodigoFunicionarioNavigation { get; set; }
    }
}
