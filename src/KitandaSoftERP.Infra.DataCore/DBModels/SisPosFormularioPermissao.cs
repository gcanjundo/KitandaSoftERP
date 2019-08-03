using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisPosFormularioPermissao
    {
        public int FormPermCodigo { get; set; }
        public int FormPermCodigoFormulario { get; set; }
        public int FormPermCodigoPerfil { get; set; }
        public int FormPermInclusao { get; set; }
        public int FormPermAlteracao { get; set; }
        public int FormPermExclusao { get; set; }
        public int FormPermConsulta { get; set; }
        public int FormPermImpressao { get; set; }
        public int FormPermAcesso { get; set; }
    }
}
