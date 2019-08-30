using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerCores
    {
        public GerCores()
        {
            GerViatura = new HashSet<GerViatura>();
            SatViaturas = new HashSet<SatViaturas>();
        }

        public int CorCodigo { get; set; }
        public string CorDescricao { get; set; }
        public string CorSigla { get; set; }
        public string CorStatus { get; set; }

        public virtual ICollection<GerViatura> GerViatura { get; set; }
        public virtual ICollection<SatViaturas> SatViaturas { get; set; }
    }
}
