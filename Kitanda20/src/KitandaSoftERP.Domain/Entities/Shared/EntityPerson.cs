using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Geral;
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
        public int? NationalityID { get; set; }
        public int? CountryOfBirthID { get; set; }
        public int? ProvinceOfBirthID { get; set; }
        public int? CityOfBirthID { get; set; }
        public int? CommuneOfBirthID { get; set; }
        public int? BloodGroupID { get; set; }
        public int? AcademicQuanlificationID { get; set; }
        public int? OccupationID { get; set; }
        public virtual City CityOfBirth { get; set; }
        public virtual Country Nationality { get; set; }
        public virtual Country CountryOfBirth { get; set; }
        public virtual Province ProvinceOfBirth { get; set; } 
        public virtual Commune CommuneOfBirth { get; set; }
        public virtual Student Student { get; set; } 
        public virtual Teacher Teacher { get; set; }
        public virtual BloodGroup BloodGroup { get; set; }
        public virtual Qualifications AcademicQualification { get; set; }
        public virtual Occupation Occupation { get; set; }
        public virtual Entity Entity { get; set; }
        public EntityPerson()
        {    
            Student = new Student();
            Teacher = new Teacher();
            CityOfBirth = new City();
            CountryOfBirth = new Country();
            Nationality = new Country();
            ProvinceOfBirth = new Province(); 
            CommuneOfBirth = new Commune();
        }
        public override bool IsValid()
        { 
            return !ErrorList.Any();
        }  
    }
}
