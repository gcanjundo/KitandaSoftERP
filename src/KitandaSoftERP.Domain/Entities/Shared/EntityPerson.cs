using KitandaSoftERP.Domain.Entities.Academica;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Shared
{
    public class EntityPerson : Entity
    {
         
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public string CivilState { get; set; } 
        public virtual Student Student { get; set; } 
        public virtual Teacher Teacher { get; set; } 
        public EntityPerson()
        {    
            Student = new Student();
            Teacher = new Teacher();
        }
        public override bool IsValid()
        { 
            return !ErrorList.Any();
        }

        
    }
}
