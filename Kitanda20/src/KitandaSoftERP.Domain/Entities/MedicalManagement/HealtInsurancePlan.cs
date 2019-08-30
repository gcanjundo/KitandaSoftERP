using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.MedicalManagement
{
    public partial class HealtInsurancePlan:BaseEntity
    {  
        public decimal DiscountPercentual { get; set; } 
        public int InsuranceCompanyID { get; set; }
        public bool IsParticular { get; set; }
        public decimal? PatientPercentualPayment { get; set; } 
        public virtual EntityEnterprise InsuranceCompany { get; set; }
        public virtual ICollection<PatientInsurancePolicy> PatientInsurancePolicyList { get; set; }
        public virtual ICollection<HealtInsurancePlanCoverage> HealtInsurancePlanCoverageList { get; set; }

        public HealtInsurancePlan()
        {
            InsuranceCompany = new EntityEnterprise();
            PatientInsurancePolicyList = new HashSet<PatientInsurancePolicy>();
            HealtInsurancePlanCoverageList = new HashSet<HealtInsurancePlanCoverage>();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
