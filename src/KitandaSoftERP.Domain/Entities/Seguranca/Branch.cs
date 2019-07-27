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
        
        public int CompanyID { get; set; } 
        public string Tipo { get; set; }
        public int TaxGroupID { get; set; } 
        public decimal SocialCapital { get; set; }
        public DateTime InapemRegistration { get; set; }
        public DateTime InapemLastUpdate { get; set; }
        public virtual TaxGroup TaxGroup { get; set; }
        public virtual Branch Company { get; set; }
        public virtual AcademicSettings AcademicSettings { get; set; }
        
        public virtual ICollection<AcademicYear > AcademicYearList { get; set; }
        public virtual ICollection<StudentRegistration> StudentRegistrationList { get; set; }
        public virtual ICollection<Student> StudentsList { get; set; }
        public virtual ICollection<Candidate> CandidatesList { get; set; }
        public virtual ICollection<Branch> BranchesList { get; set; }
        public virtual ICollection<CurrentSession> SessionsList { get; set; }
        public virtual ICollection<UserProfileBranch> UserProfileBranchesList { get; set; }
        public virtual ICollection<EmailMonitor> EmailsList { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }
        public virtual ICollection<Warehouse> WarehouseList { get; set; }

        public Branch()
        {
            TaxGroup = new TaxGroup();
            Company = new Branch();
            AcademicSettings = new AcademicSettings();
            AcademicYearList = new HashSet<AcademicYear >();
            StudentRegistrationList = new HashSet<StudentRegistration>();
            BranchesList = new HashSet<Branch>();
            SessionsList = new HashSet<CurrentSession>();
            UserProfileBranchesList = new HashSet<UserProfileBranch>();
            StudentsList = new HashSet<Student>();
            CandidatesList = new HashSet<Candidate>();
            EmailsList = new HashSet<EmailMonitor>();

        }



    }
}
