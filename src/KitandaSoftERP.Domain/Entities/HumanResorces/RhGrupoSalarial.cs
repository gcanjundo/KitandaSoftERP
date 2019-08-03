using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhGrupoSalarial
    {
        public RhGrupoSalarial()
        {
            RhFuncionario = new HashSet<RhFuncionario>();
        }

        public int SalCodigo { get; set; }
        public string SalDescricao { get; set; }
        public string SalSigla { get; set; }
        public int? SalStatus { get; set; }
        public int? SalCodigoMoeda { get; set; }
        public double? SalSalario { get; set; }

        public virtual FinMoeda SalCodigoMoedaNavigation { get; set; }
        public virtual ICollection<RhFuncionario> RhFuncionario { get; set; }
    }
}
