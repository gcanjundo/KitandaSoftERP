using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerTurnos
    {
        public GerTurnos()
        {
            ComPosStatus = new HashSet<ComPosStatus>();
        }

        public int TurCodigo { get; set; }
        public string TurDescricao { get; set; }
        public string TurSigla { get; set; }
        public string TurStatus { get; set; }
        public DateTime? TurBegin { get; set; }
        public DateTime? TurEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<ComPosStatus> ComPosStatus { get; set; }
    }
}
