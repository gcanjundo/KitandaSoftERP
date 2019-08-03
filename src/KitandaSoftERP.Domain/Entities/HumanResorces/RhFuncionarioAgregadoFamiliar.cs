using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhFuncionarioAgregadoFamiliar
    {
        public int? AgreCodigoFuncionario { get; set; }
        public string AgreNome { get; set; }
        public string AgreIdentificacao { get; set; }
        public string AgreParentesco { get; set; }
        public DateTime? AgreDataNascimento { get; set; }

        public virtual RhFuncionario AgreCodigoFuncionarioNavigation { get; set; }
    }
}
