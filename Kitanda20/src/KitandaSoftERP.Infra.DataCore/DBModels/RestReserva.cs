using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestReserva
    {
        public int ResCodigo { get; set; }
        public int ResCodigoMesa { get; set; }
        public int? ResCodigoCliente { get; set; }
        public string ResCustomerName { get; set; }
        public int? ResLugares { get; set; }
        public DateTime? ResBooking { get; set; }
        public DateTime? ResHoraPrevista { get; set; }
        public string ResPhoneNumber { get; set; }
        public string ResObs { get; set; }
        public string ResStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual GerTerceiros ResCodigoClienteNavigation { get; set; }
        public virtual RestMesa ResCodigoMesaNavigation { get; set; }
    }
}
