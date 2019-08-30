using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhMotivo
    {
        public RhMotivo()
        {
            RhFuncionarioFunMotivoAdmissaoNavigation = new HashSet<RhFuncionario>();
            RhFuncionarioFunMotivoDemissaoNavigation = new HashSet<RhFuncionario>();
        }

        public int MotCodigo { get; set; }
        public string MotDescricao { get; set; }
        public string MotCategoria { get; set; }
        public string MotSigla { get; set; }
        public string MotEstado { get; set; }

        public virtual ICollection<RhFuncionario> RhFuncionarioFunMotivoAdmissaoNavigation { get; set; }
        public virtual ICollection<RhFuncionario> RhFuncionarioFunMotivoDemissaoNavigation { get; set; }
    }
}
