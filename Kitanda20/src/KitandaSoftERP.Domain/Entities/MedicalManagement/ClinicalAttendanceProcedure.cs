using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class ClinicalAttendanceProcedure
    {
         
        public int ClinicalAttendanceID { get; set; }
        public int ClinicalProcudureID { get; set; }
        public decimal Quantity { get; set; } 
        public virtual ClinicalAttendance ClinicalAttendance { get; set; }

        public ClinicalAttendanceProcedure()
        {
            ClinicalAttendance = new ClinicalAttendance();
        }

    }
}
