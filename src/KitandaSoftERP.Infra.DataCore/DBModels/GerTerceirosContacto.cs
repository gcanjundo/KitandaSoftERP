using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerTerceirosContacto
    {
        public int PartContactId { get; set; }
        public int? PartPatnerId { get; set; }
        public string PartContactName { get; set; }
        public string PartDepartment { get; set; }
        public string PartPhone { get; set; }
        public string PartMobile { get; set; }
        public string PartFax { get; set; }
        public string PartFunction { get; set; }
        public string PartEmail { get; set; }
        public bool? PartCobranca { get; set; }
        public bool? PartAdministrativo { get; set; }
        public bool? PartComercial { get; set; }
        public bool? PartStatus { get; set; }
        public string PartCreatedBy { get; set; }
        public DateTime? PartCreatedDate { get; set; }
        public string PartUpdatedBy { get; set; }
        public DateTime? PartUpdatedDate { get; set; }

        public virtual GerTerceiros PartPatner { get; set; }
    }
}
