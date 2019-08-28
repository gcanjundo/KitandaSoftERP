using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public class ClinicalDepartment : BaseEntity
    {
        public virtual ICollection<ClinicalAttendance> ClinicalAttendanceList { get; set; }

        public ClinicalDepartment()
        {
            ClinicalAttendanceList = new HashSet<ClinicalAttendance>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
