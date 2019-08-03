using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComSeriePermissoes
    {
        public int PermCodigo { get; set; }
        public int PermSerSerieId { get; set; }
        public int PermSerUtilizadorId { get; set; }
        public int? PermSerPerfilId { get; set; }
        public bool? PermSerInsert { get; set; }
        public bool? PermSerUpdate { get; set; }
        public bool? PermSerSelect { get; set; }
        public string PermSerCreatedBy { get; set; }
        public DateTime? PermSerCreatedDate { get; set; }
        public string PermSerUpdatedBy { get; set; }
        public DateTime? PermSerUpdatedDate { get; set; }
    }
}
