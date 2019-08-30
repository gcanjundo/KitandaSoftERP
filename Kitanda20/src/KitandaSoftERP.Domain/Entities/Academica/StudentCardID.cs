using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class StudentCardID: BaseEntity
    {
        public StudentCardID()
        {
            Student = new Student();
        }
        public int CardID { get; set; }
        public int RegistrationID { get; set; }
        public DateTime IsseDate { get; set; }
        public DateTime ValidateDate { get; set; }
        public string BarCode { get; set; }
        public int Way { get; set; }
        public string CancelledReason { get; set; } 
        public string CancelledBy { get; set; }
        public DateTime CancelledDate { get; set; }

        public virtual Student Student { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
