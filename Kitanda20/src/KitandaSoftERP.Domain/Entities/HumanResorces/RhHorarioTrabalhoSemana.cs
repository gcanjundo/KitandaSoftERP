using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhHorarioTrabalhoSemana
    {
        public int JornCodigo { get; set; }
        public int JornDia { get; set; }
        public string JornEntrada1 { get; set; }
        public string JornSaida1 { get; set; }
        public string JornEntrada2 { get; set; }
        public string JornSaida2 { get; set; }
        public string JornEntrada3 { get; set; }
        public string JornSaida3 { get; set; }

        public virtual RhHorarioTabalho JornCodigoNavigation { get; set; }
    }
}
