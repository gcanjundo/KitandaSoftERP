using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhDiasDescansoSemanal
    {
        public int DescFilialId { get; set; }
        public int DescDia { get; set; }
        public bool? DescActivo { get; set; }
        public string DescCreatedBy { get; set; }
        public DateTime? DescCreatedDate { get; set; }
        public string DescUpdatedBy { get; set; }
        public string DescUpdatedDate { get; set; }
        public string DescDeletedBy { get; set; }
        public DateTime? DescDeletedDate { get; set; }
    }
}
