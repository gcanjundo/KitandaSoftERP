using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestAtendimentoConsultaConta
    {
        public int ConsCodigo { get; set; }
        public int ConsDocumentId { get; set; }
        public int ConsSerie { get; set; }
        public string ConsReference { get; set; }
        public int? ConsNumeracao { get; set; }
        public int? ConsAtendimentoId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
