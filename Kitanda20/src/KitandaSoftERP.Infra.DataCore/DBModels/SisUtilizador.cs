using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisUtilizador
    {
        public SisUtilizador()
        {
            GerArmazemPermissoes = new HashSet<GerArmazemPermissoes>();
        }

        public int UtiCodigo { get; set; }
        public string UtiUtilizador { get; set; }
        public string UtiNome { get; set; }
        public string UtiSenha { get; set; }
        public string UtiEstado { get; set; }
        public string UtiEmail { get; set; }
        public int? UtiCodigoPerfil { get; set; }
        public string UtiFotoPath { get; set; }
        public int? UtiIdioma { get; set; }
        public bool? UtiSupervisor { get; set; }

        public virtual ICollection<GerArmazemPermissoes> GerArmazemPermissoes { get; set; }
    }
}
