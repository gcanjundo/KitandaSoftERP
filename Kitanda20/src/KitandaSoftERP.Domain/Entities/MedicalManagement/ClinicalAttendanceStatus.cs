using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalAttendanceStatus : BaseEntity
    {
        public virtual ICollection<ClinicalAttendance> ClinicalAttendanceList { get; set; }

        public ClinicalAttendanceStatus()
        {
            ClinicalAttendanceList = new HashSet<ClinicalAttendance>();
        }
        public override bool IsValid()
        {
            return ErrorList.Any();
        }
    }
}
