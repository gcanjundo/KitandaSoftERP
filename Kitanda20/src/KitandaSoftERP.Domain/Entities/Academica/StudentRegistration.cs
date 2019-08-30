using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class StudentRegistration: BaseEntity
    {
        public int RegistrationID { get; set; }
        public int StudentID { get; set; } 
        public int ClassRoomID { get; set; }
        public bool FirstTime { get; set; }
        public int RegistrationStatusID { get; set; }
        public int AcademicInitialStatusID { get; set; }
        public int AcademicFinalStatusID { get; set; }
        public DateTime RegistrationConfirmationDate { get; set; }
        public DateTime RegistrationTransferDate { get; set; }
        public DateTime RegistrationCancelDate { get; set; }
        public DateTime RegistrationReactionDate { get; set; }
        public DateTime RegistrationActivationDate { get; set; } 
        public string LanguageOption { get; set; }
        public bool IsExemptRegistration { get; set; }
        public bool IsExemptMonthyPayment { get; set; }
        public int ScholarShipID { get; set; }
        public string RegistrationConfirmatedBy { get; set; }
        public string RegistrationTransferedBy { get; set; }
        public string RegistrationCancelledBy { get; set; }
        public string RegistrationReactivedBy { get; set; }
        public string RegistrationActivatedBy { get; set; } 

        public virtual Student Student { get; set; }  
        public virtual ClassRoom ClassRoom { get; set; }
        public virtual RegistrationStatus RegistrationStatus { get; set; }
        public virtual AcademicStatus AcademicInitialStatus { get; set; }
        public virtual AcademicStatus AcademicFinalStatus { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }


    }
}
