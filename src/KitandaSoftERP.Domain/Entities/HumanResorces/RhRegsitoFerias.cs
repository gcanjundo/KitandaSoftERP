using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhRegsitoFerias
    {
        public int FerCodigo { get; set; }
        public int? FerCodigoFuncionario { get; set; }
        public DateTime? FerInicio { get; set; }
        public DateTime? FerTermino { get; set; }
        public int? FerNroDias { get; set; }
        public DateTime? FerDataPagto { get; set; }
        public DateTime? FerDataAviso { get; set; }
        public DateTime? FerDataVencimento { get; set; }
        public bool? FerGozada { get; set; }
        public bool? FerDecimoTerceiro { get; set; }

        public virtual RhFuncionario FerCodigoFuncionarioNavigation { get; set; }
    }
}
