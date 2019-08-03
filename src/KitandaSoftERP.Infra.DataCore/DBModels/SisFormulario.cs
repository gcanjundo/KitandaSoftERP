using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisFormulario
    {
        public int FormCodigo { get; set; }
        public int FormCodigoModulo { get; set; }
        public string FormTitulo { get; set; }
        public string FormNome { get; set; }
        public string FormLink { get; set; }
        public int? FormTag { get; set; }
        public int FormIndice { get; set; }
        public string FormImagem { get; set; }

        public virtual SisModulo FormCodigoModuloNavigation { get; set; }
        public virtual SisPosFormularios SisPosFormularios { get; set; }
        public virtual SisRestFormularios SisRestFormularios { get; set; }
    }
}
