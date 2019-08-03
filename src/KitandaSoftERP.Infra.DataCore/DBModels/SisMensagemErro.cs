using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisMensagemErro
    {
        public long MsgCodigo { get; set; }
        public string MsgCodigoErro { get; set; }
        public string MsgMensagem { get; set; }
    }
}
