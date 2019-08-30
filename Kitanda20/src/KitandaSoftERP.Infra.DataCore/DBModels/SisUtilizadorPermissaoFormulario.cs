using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisUtilizadorPermissaoFormulario
    {
        public string UtiPermFormUtilizador { get; set; }
        public int UtiPermFormCodigoFormulario { get; set; }
        public int? UtiPermFormAcesso { get; set; }
        public int? UtiPermFormInserir { get; set; }
        public int? UtiPermFormAlterar { get; set; }
        public int? UtiPermFormExcluir { get; set; }
        public int? UtiPermFormImprimir { get; set; }
        public int? UtiPermFormConsultar { get; set; }
    }
}
