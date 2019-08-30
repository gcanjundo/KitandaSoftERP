using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComAnoFaturacao
    {
        public ComAnoFaturacao()
        {
            ComSerieDocumentacao = new HashSet<ComSerieDocumentacao>();
        }

        public int AnoAno { get; set; }
        public int AnoCodigoFilial { get; set; }
        public string AnoDescricao { get; set; }
        public DateTime? AnoInicio { get; set; }
        public DateTime? AnoTermino { get; set; }
        public bool? AnoDeleted { get; set; }
        public bool? AnoIsActive { get; set; }
        public string AnoCreatedBy { get; set; }
        public DateTime? AnoCreatedDate { get; set; }
        public string AnoUpdatedBy { get; set; }
        public DateTime? AnoUpdatedDate { get; set; }

        public virtual SisEmpresa AnoCodigoFilialNavigation { get; set; }
        public virtual ICollection<ComSerieDocumentacao> ComSerieDocumentacao { get; set; }
    }
}
