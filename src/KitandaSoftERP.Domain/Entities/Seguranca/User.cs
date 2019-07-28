
using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
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
        public virtual Entity Entity { get; set; }
        public virtual Profile UserProfile { get; set; }
        public virtual ICollection<UserProfileBranch> UserProfileBranchesList { get; set; }
        public virtual ICollection<UserProfilePermission> UserProfilePermissionsList { get; set; }
        public virtual CashRegister CashRegister { get; set; }

        public User()
        {
            Entity = new Entity();
            UserProfile = new Profile();
            UserProfileBranchesList = new HashSet<UserProfileBranch>();
            UserProfilePermissionsList = new HashSet<UserProfilePermission>();
            CashRegister = new CashRegister();

        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
