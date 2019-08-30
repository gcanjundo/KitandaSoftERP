using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestAtendimentoSala
    {
        public int AtendMesaCodigo { get; set; }
        public int? AtendMesaAtendimento { get; set; }
        public int? AtendMesaCodigoMesa { get; set; }
        public int? AtendMesaStatus { get; set; }
    }
}
