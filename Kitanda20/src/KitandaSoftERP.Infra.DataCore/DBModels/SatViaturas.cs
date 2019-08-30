using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SatViaturas
    {
        public int ViaCodigo { get; set; }
        public string ViaMatricula { get; set; }
        public int? ViaMarca { get; set; }
        public int? ViaCor { get; set; }
        public string ViaCategoria { get; set; }
        public int? ViaProprietario { get; set; }
        public string ViaNumeroSerie { get; set; }

        public virtual GerCores ViaCorNavigation { get; set; }
        public virtual GerMarca ViaMarcaNavigation { get; set; }
    }
}
