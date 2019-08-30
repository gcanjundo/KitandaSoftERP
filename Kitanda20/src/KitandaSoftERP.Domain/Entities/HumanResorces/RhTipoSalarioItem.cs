using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhTipoSalarioItem
    {
        public int ParCodigoVencimento { get; set; }
        public int ParCodigoBeneficio { get; set; }
        public double? ParValor { get; set; }
        public string ParIncidencia { get; set; }
        public string ParTipo { get; set; }

        public virtual RhBeneficios ParCodigoBeneficioNavigation { get; set; }
        public virtual RhVencimento ParCodigoVencimentoNavigation { get; set; }
    }
}
