using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisPerfil
    {
        public SisPerfil()
        {
            GerArmazemPermissoes = new HashSet<GerArmazemPermissoes>();
        }

        public int PerCodigo { get; set; }
        public string PerNome { get; set; }
        public string PerDescricao { get; set; }
        public string PerStatus { get; set; }
        public string PerEmail { get; set; }
        public string PerCreatedBy { get; set; }
        public DateTime? PerCreatedDate { get; set; }
        public string PerUpdatedBy { get; set; }
        public DateTime? PerUpdatedDate { get; set; }
        public bool? PerSupervisor { get; set; }

        public virtual ICollection<GerArmazemPermissoes> GerArmazemPermissoes { get; set; }
    }
}
