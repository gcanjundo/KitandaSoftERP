
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class AcademicYear: BaseEntity
    {
        public AcademicYear()
        {
            CurricularUnits = new HashSet<CurricularUnit>();
            ClassesRoom = new HashSet<ClassRoom>();
            AcademicPeriodList = new HashSet<AcademicPeriod>();
        }

        public int AcademicYearID { get; set; }
        public int CivilYear { get; set; }
        public DateTime Start { get; set; }
        public DateTime Terminate { get; set; }
        public DateTime RegistrationBegin { get; set; }
        public DateTime RegistrationTerminate { get; set; }  
        public virtual Branch Branch { get; set; }
        public virtual ICollection<CurricularUnit> CurricularUnits { get; set; }
        public virtual ICollection<ClassRoom> ClassesRoom { get; set; }
        public virtual ICollection<AcademicPeriod> AcademicPeriodList { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
