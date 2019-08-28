
using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    

    public class User: Entity
    {  
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ProfileID { get; set; }
        public int LanguageID { get; set; }
        public string AccountStatus { get; set; }
        public DateTime? AccouExpiratioDate { get; set; }
        public bool IsSupervisorPOS { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual Profile UserProfile { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<UserProfileBranch> UserBranchesList { get; set; }
        public virtual ICollection<UserProfilePermission> UserProfilePermissionsList { get; set; }
        public virtual CashRegister CashRegister { get; set; }

        public User()
        {
            Entity = new Entity();
            UserProfile = new Profile();
            UserBranchesList = new HashSet<UserProfileBranch>();
            UserProfilePermissionsList = new HashSet<UserProfilePermission>();
            CashRegister = new CashRegister();
            Language = new Language(); 
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
