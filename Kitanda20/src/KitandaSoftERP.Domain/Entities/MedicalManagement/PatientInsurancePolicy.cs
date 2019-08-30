using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class PatientInsurancePolicy
    { 
        public int PatientID { get; set; }
        public string InsurancePolicyCode { get; set; }
        public DateTime? IssedDate { get; set; }
        public DateTime? ExprieDate { get; set; }
        public string PS { get; set; }  
        public virtual Patient Patient { get; set; }
        public virtual HealtInsurancePlan PacConvCodigoPlanoNavigation { get; set; }
    }
}
