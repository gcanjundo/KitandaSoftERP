using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestPratoDia
    {
        public int PraCodigo { get; set; }
        public int PraCodigoArtigo { get; set; }
        public int PraDia { get; set; }

        public virtual GerArtigo PraCodigoArtigoNavigation { get; set; }
    }
}
