using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerTipoActividade
    {
        public GerTipoActividade()
        {
            GerTask = new HashSet<Tasks>();
        }

        public int ActCodigo { get; set; }
        public string ActDescricao { get; set; }
        public string ActSigla { get; set; }
        public bool? ActStatus { get; set; }
        public string ActCreatedBy { get; set; }
        public DateTime? ActCreatedDate { get; set; }
        public string ActUpdatedBy { get; set; }
        public DateTime? ActUpdatedDate { get; set; }

        public virtual ICollection<Tasks> GerTask { get; set; }
    }
}
