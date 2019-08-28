using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class AcademicStatus : BaseEntity
    {
        
        public virtual ICollection<StudentRegistration> StudentRegistrationList { get; set; }
        public AcademicStatus()
        {
            StudentRegistrationList = new HashSet<StudentRegistration>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}