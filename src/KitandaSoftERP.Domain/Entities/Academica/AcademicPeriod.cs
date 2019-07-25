using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class AcademicPeriod : BaseEntity
    {
        
        public int AcademicPeriodID { get; set; }
        public int AcademicYearID { get; set; }
        public DateTime Start { get; set; }
        public DateTime Terminate { get; set; }
        public DateTime RegistrationBegin { get; set; }
        public DateTime RegistrationTerminate { get; set; }
        public virtual AcademicYear AcademicYear { get; set; }
        public virtual ICollection<CurricularUnit> CurricularUnits { get; set; }
        public AcademicPeriod()
        {
            CurricularUnits = new HashSet<CurricularUnit>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}