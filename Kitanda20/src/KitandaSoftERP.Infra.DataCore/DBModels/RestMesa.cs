using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestMesa
    {
        public RestMesa()
        {
            RestReserva = new HashSet<RestReserva>();
        }

        public int MesCodigo { get; set; }
        public int? MesCodigoLocalizacao { get; set; }
        public string MesDescricao { get; set; }
        public string MesSigla { get; set; }
        public string MesStatus { get; set; }
        public string MesLugares { get; set; }
        public string MesCliente { get; set; }

        public virtual RestLocalizacao MesCodigoLocalizacaoNavigation { get; set; }
        public virtual ICollection<RestReserva> RestReserva { get; set; }
    }
}
