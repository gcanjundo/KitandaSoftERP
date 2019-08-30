
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq; 

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class Student: EntityPerson
    {         
        public int PersonID { get; set; }
        public int? CandidateID { get; set; } 
        public int OrderNumber { get; set; }
        public string RegistrationReference { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string PhisicalProcessNumber { get; set; }
        public int FatherID { get; set; }
        public int MotherID { get; set; }
        public int EducationSponsorID { get; set; }
        public int EducationFinanceSponsorID { get; set; }
        public string EducationalInstitutionFrom { get; set; }
        public DateTime EducationalInstitutionFromExitDate { get; set; }
        public string EducationalInstitutionFromFinalStatus { get; set; }
        public string EducationalInstitutionFromLastCourse { get; set; }
        public string EducationalInstitutionFromLastAcademicYear { get; set; }
        public DateTime GraduationDate { get; set; }
        public bool AllowedPortalAccess { get; set; }
        public DateTime AllowedPortalAccessDate { get; set; }
        public bool ExternalStudent { get; set; }
        public virtual EntityPerson Person { get; set; }
        public virtual EntityPerson Father { get; set; }
        public virtual EntityPerson Mother { get; set; }
        public virtual Entity EducationSponsor { get; set; } 
        public virtual ICollection<StudentCardID> StudentCardList { get; set; }
        public virtual ICollection<StudentRegistration> StudentRegistrationList { get; set; } 
        
        private void StudentModelValidation()
        {
            ConfirmaValidacaoEmail();
            if (Birthday == DateTime.MinValue)
                ErrorList.Add("A Data de Nascimento é obrigatória");
            if(CitizenDocumentID<=0)
                ErrorList.Add("Seleccione o nome documento de identificação");

            if (string.IsNullOrEmpty(CitizenOrFiscalDocNumber))
                ErrorList.Add("O Documento de Identificação é obrigatório");

            if (string.IsNullOrEmpty(Gender) || Gender == "-1")
                ErrorList.Add("O Sexo é obrigatório");

            if(EducationSponsorID <=0)
                ErrorList.Add("Informe o nome do Encarregado de Educação");
        }
        public override bool IsValid()
        {
            StudentModelValidation();
            return !ErrorList.Any();
        }
    }
}
