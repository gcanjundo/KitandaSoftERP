using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisModuloPermissao
    {
        public int? ModPermCodigo { get; set; }
        public int ModPermCodigoModulo { get; set; }
        public int ModPermCodigoPerfil { get; set; }
        public int? ModPermAcesso { get; set; }
        public int? ModPermVisibilidade { get; set; }
        public int? ModPermAutorizar { get; set; }
    }
}
