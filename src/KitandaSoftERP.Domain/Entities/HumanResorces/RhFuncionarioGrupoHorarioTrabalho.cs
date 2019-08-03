using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhFuncionarioGrupoHorarioTrabalho
    {
        public int GruHorCodigo { get; set; }
        public string GruHorDescricao { get; set; }
        public string GruHorSigla { get; set; }
        public string GruHorEstado { get; set; }
    }
}
