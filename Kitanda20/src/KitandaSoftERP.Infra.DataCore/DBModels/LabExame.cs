using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class LabExame
    {
        public LabExame()
        {
            LabExameItem = new HashSet<LabExameItem>();
            LabExameMaterial = new HashSet<LabExameMaterial>();
            LabPrecoExame = new HashSet<LabPrecoExame>();
        }

        public int ExaCodigo { get; set; }
        public string ExaDescricao { get; set; }
        public int ExaCategoria { get; set; }
        public string ExaSigla { get; set; }
        public int? ExaCodigoAmostra { get; set; }
        public int? ExaPeriodoEntrega { get; set; }

        public virtual LabAmostra ExaCodigoAmostraNavigation { get; set; }
        public virtual ICollection<LabExameItem> LabExameItem { get; set; }
        public virtual ICollection<LabExameMaterial> LabExameMaterial { get; set; }
        public virtual ICollection<LabPrecoExame> LabPrecoExame { get; set; }
    }
}
