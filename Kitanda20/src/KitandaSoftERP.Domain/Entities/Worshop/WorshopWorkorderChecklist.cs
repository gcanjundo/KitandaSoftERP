using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Worshop
{
    public partial class WorshopWorkorderChecklist
    {
        public int ServiceOrderId { get; set; }
        public int? TechnicianId { get; set; }
        public bool? Macaco { get; set; }
        public bool? ChaveRodas { get; set; }
        public bool? Manivela { get; set; }
        public bool? PneusSocorro { get; set; }
        public bool? PiscaFle { get; set; }
        public bool? PiscaFld { get; set; }
        public bool? PiscaTle { get; set; }
        public bool? PiscaTld { get; set; }
        public bool? StopLe { get; set; }
        public bool? StopLd { get; set; }
        public bool? FarolLe { get; set; }
        public bool? FarolLd { get; set; }
        public bool? SimboloFrontal { get; set; }
        public bool? SimboloTraseiro { get; set; }
        public bool? RetrovisorLe { get; set; }
        public bool? RetrovisorLd { get; set; }
        public bool? RetrovisorInterior { get; set; }
        public bool? RadioCd { get; set; }
        public bool? TapeteFle { get; set; }
        public bool? TapeteFld { get; set; }
        public bool? TapeteTle { get; set; }
        public bool? TapeteTld { get; set; }
        public bool? TapeteTmeio { get; set; }
        public bool? Isqueiro { get; set; }
        public bool? ElevadorFle { get; set; }
        public bool? ElevadorFld { get; set; }
        public bool? ElevadorTle { get; set; }
        public bool? ElevadorTld { get; set; }
        public bool? Colete { get; set; }
        public bool? Triangulo { get; set; }
        public string FluelLevel { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual WorshopWorkorder ServiceOrder { get; set; }
        public virtual RestFuncionarios Technician { get; set; }
    }
}
