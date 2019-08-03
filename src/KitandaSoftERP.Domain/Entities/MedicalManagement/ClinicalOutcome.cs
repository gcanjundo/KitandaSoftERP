using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalOutcome:BaseEntity
    { 
        public virtual ICollection<ClinicalAttendance> CLinicalAttendanceList { get; set; }

        public ClinicalOutcome()
        {
            CLinicalAttendanceList = new HashSet<ClinicalAttendance>();
        } 
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
