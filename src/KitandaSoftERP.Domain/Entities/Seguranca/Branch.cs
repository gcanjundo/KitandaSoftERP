using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Stock;
using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public class Branch: EntityEnterprise
    {
        public int EnterpriseID { get; set; }
        public int CompanyID { get; set; } 
        public string Tipo { get; set; }
        public string TaxGroup { get; set; } 
        public decimal SocialCapital { get; set; } 
        public string Conservatoria { get; set; }
        public string NaturezaJuridica { get; set; }
        public DateTime InapemRegistration { get; set; }
        public DateTime InapemLastUpdate { get; set; }
        public string SoftwareDesignation { get; set; }
        public string SoftwareNIF { get; set; }
        public string SoftwareProductVersion { get; set; }
        public string SoftwareValidationId { get; set; } 
        public virtual EntityEnterprise Enterprise { get; set; }
        public virtual Branch Company { get; set; }
        public virtual AcademicSettings AcademicSettings { get; set; } 
        public virtual ICollection<AcademicYear > AcademicYearList { get; set; }
        public virtual ICollection<StudentRegistration> StudentRegistrationList { get; set; }
        public virtual ICollection<Student> StudentsList { get; set; }
        public virtual ICollection<Candidate> CandidatesList { get; set; }
        public virtual ICollection<Branch> BranchesList { get; set; } 
        public virtual ICollection<UserProfileBranch> UserProfileBranchesList { get; set; }
        public virtual ICollection<EmailMonitor> EmailsList { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }
        public virtual ICollection<Warehouse> WarehouseList { get; set; }
        public virtual ICollection<CurrentSession> CurrentSessionList { get; set; }

        public Branch()
        {     
            Company = new Branch();
            AcademicSettings = new AcademicSettings();
            AcademicYearList = new HashSet<AcademicYear >();
            StudentRegistrationList = new HashSet<StudentRegistration>();
            BranchesList = new HashSet<Branch>(); 
            UserProfileBranchesList = new HashSet<UserProfileBranch>();
            StudentsList = new HashSet<Student>();
            CandidatesList = new HashSet<Candidate>();
            EmailsList = new HashSet<EmailMonitor>();
            CurrentSessionList = new HashSet<CurrentSession>();

        }



    }
}
