using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class RegistrationStatus:BaseEntity
    {
        public RegistrationStatus()
        {
            StudentRegistrationList = new HashSet<StudentRegistration>();
        }
        public bool Billed { get; set; }
        public int BillingReferenceID { get; set; }
        public virtual ICollection<StudentRegistration> StudentRegistrationList { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}