using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhHorarioTabalho
    {
        public int HorCodigo { get; set; }
        public string HorDescricao { get; set; }
        public decimal? HorCargaSemanal { get; set; }
        public string HorUnidade { get; set; }
        public string HorModRecolha { get; set; }
        public string HorCargaMensal { get; set; }

        public virtual RhHorarioTrabalhoSemana RhHorarioTrabalhoSemana { get; set; }
    }
}
