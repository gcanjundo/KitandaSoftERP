using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerArmazemPermissoes
    {
        public int WarPermCodigo { get; set; }
        public int WarPermArmazemId { get; set; }
        public int? WarPermPerfilId { get; set; }
        public int? WarPermUtilizadorId { get; set; }
        public bool? WarPermInsert { get; set; }
        public bool? WarPermUpdate { get; set; }
        public bool? WarPermSelect { get; set; }
        public bool? WarPermPrint { get; set; }
        public bool? WarPermDelete { get; set; }
        public bool? WarPermStatus { get; set; }
        public string WarPermCreatedBy { get; set; }
        public DateTime? WarPermCreatedDate { get; set; }
        public string WarPermUpdatedBy { get; set; }
        public DateTime? WarPermUpdatedDate { get; set; }

        public virtual GerArmazem WarPermArmazem { get; set; }
        public virtual SisPerfil WarPermPerfil { get; set; }
        public virtual SisUtilizador WarPermUtilizador { get; set; }
    }
}
