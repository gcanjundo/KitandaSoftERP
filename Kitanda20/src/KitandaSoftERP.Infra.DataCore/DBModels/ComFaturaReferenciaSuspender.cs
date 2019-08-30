using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComFaturaReferenciaSuspender
    {
        public ComFaturaReferenciaSuspender()
        {
            ComFaturaSuspensa = new HashSet<ComFaturaSuspensa>();
        }

        public int ComFatRefSuspCodigo { get; set; }
        public string ComFatRefSuspDesignacao { get; set; }
        public decimal? ComFatRefSuspValorTotal { get; set; }
        public string ComFatRefSuspUtilizador { get; set; }
        public DateTime? ComFatRefSuspData { get; set; }
        public int? ComFatRefSuspFilial { get; set; }

        public virtual ICollection<ComFaturaSuspensa> ComFaturaSuspensa { get; set; }
    }
}
