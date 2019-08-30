using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisEmailMonitor
    {
        public int EmailCodigo { get; set; }
        public string EmailRemetente { get; set; }
        public string EmailEndereco { get; set; }
        public string EmailHost { get; set; }
        public string EmailUsuario { get; set; }
        public string EmailSenha { get; set; }
        public int? EmailPorta { get; set; }
        public bool? EmailEnableSsl { get; set; }
        public string EmailModulo { get; set; }
        public int? EmailCodigoFilial { get; set; }
    }
}
