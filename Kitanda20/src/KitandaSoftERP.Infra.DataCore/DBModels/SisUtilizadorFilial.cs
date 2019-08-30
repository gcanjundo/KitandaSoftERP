using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisUtilizadorFilial
    {
        public string UtiFilialUtilizador { get; set; }
        public int UtiFilialCodigoFilial { get; set; }
        public bool? UtiFilialDefault { get; set; }
    }
}
