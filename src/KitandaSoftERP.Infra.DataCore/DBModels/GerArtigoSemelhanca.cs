using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerArtigoSemelhanca
    {
        public int SemCodigoArtigoA { get; set; }
        public int SemCodigoArtigoB { get; set; }

        public virtual GerArtigo SemCodigoArtigoANavigation { get; set; }
        public virtual GerArtigo SemCodigoArtigoBNavigation { get; set; }
    }
}
