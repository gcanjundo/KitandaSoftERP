using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestLocalizacao
    {
        public RestLocalizacao()
        {
            RestMesa = new HashSet<RestMesa>();
        }

        public int LocCodigo { get; set; }
        public string LocDescricao { get; set; }
        public string LocSigla { get; set; }
        public string LocStatus { get; set; }

        public virtual ICollection<RestMesa> RestMesa { get; set; }
    }
}
