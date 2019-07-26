using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Shared
{
    public abstract class BaseEntity
    {

        public BaseEntity()
        {
            ErrorList = new List<string>();
        }
        public int ID { get; set; }
        public int BranchID { get; set; }
        public string SocialName { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public string DesignationOtherLanguage { get; set; }
        public string Notes { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; } 
        public List<string> ErrorList { get; set;} 
        public abstract bool IsValid();
    }
}
