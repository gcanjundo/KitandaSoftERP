using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComRegimeIva
    {
        public ComRegimeIva()
        {
            GerTerceiros = new HashSet<GerTerceiros>();
        }

        public int RegIvaCodigo { get; set; }
        public string RegIvaDesignacao { get; set; }
        public string RegIvaDescricao { get; set; }
        public string RegIvaSigla { get; set; }
        public bool? RegIvaStatus { get; set; }
        public string RegIvaCreatedBy { get; set; }
        public DateTime? RegIvaCreatedDate { get; set; }
        public string RegIvaUpdatedBy { get; set; }
        public DateTime? RegIvaUpdatedDate { get; set; }

        public virtual ICollection<GerTerceiros> GerTerceiros { get; set; }
    }
}
