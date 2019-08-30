using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComPosMovimento
    {
        public int PosMovCodigoPos { get; set; }
        public int PosMovCodigoMovimento { get; set; }
        public int? PosMovStatus { get; set; }

        public virtual FinMovimentoCaixa PosMovCodigoMovimentoNavigation { get; set; }
        public virtual ComPosStatus PosMovCodigoPosNavigation { get; set; }
    }
}
