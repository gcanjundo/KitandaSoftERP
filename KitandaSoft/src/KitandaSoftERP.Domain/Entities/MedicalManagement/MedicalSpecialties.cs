using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class MedicalSpecialties:BaseEntity
    {
        public MedicalSpecialties()
        {
            ProfessionalList = new HashSet<ClinicalProfessional>();
            ClincalServicesList = new HashSet<ClinicalServices>();
        }  

        public virtual ICollection<ClinicalProfessional> ProfessionalList { get; set; }
        public virtual ICollection<ClinicalServices> ClincalServicesList { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
