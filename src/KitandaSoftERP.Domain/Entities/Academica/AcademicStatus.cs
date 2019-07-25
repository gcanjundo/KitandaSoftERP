﻿using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class AcademicStatus : BaseEntity
    {
        
        public virtual ICollection<StudentRegistration> StudentRegistrations { get; set; }
        public AcademicStatus()
        {
            StudentRegistrations = new HashSet<StudentRegistration>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}