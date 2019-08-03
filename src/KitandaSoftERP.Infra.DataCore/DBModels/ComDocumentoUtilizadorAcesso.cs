using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComDocumentoUtilizadorAcesso
    {
        public int? DocAceCodigoDocumento { get; set; }
        public int? DocAceCodigoPerfil { get; set; }
        public string DocAceUtilizador { get; set; }
        public bool? DocAceInsert { get; set; }
        public bool? DocAceUpdate { get; set; }
        public bool? DocAceDelete { get; set; }
        public bool? DocAceSelect { get; set; }
        public int DocAceCodigo { get; set; }
    }
}
