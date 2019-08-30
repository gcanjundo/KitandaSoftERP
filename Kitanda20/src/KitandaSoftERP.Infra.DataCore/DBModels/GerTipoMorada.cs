using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerTipoMorada
    {
        public GerTipoMorada()
        {
            GerEntidadeMorada = new HashSet<GerEntidadeMorada>();
        }

        public int MorCodigo { get; set; }
        public string MorDescricao { get; set; }
        public string MorSigla { get; set; }
        public bool? MorStatus { get; set; }
        public string MorCreatedBy { get; set; }
        public DateTime? MorCreatedDate { get; set; }
        public string MorUpdatedBy { get; set; }
        public DateTime? MorUpdatedDate { get; set; }

        public virtual ICollection<GerEntidadeMorada> GerEntidadeMorada { get; set; }
    }
}
