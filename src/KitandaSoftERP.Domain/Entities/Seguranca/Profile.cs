using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Shared.ValueObject;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{  
    public class Profile : BaseEntity
    {
        public Profile()
        {
            UserProfileBrancheList = new HashSet<UserProfileBranch>();
            Users = new HashSet<User>();
            UserProfilePermissionsList = new HashSet<UserProfilePermission>();

        }
        public int ProfileID { get; set; }  
        public string Status { get; set; } 
        public Email Email { get; set; } 
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UserProfileBranch> UserProfileBrancheList { get; set; }
        public virtual ICollection<UserProfilePermission> UserProfilePermissionsList { get; set; }
        public override bool IsValid()
        {
            if (!Email.IsValidEmailAddress(Email.AddressEmail))
                ErrorList.Add("Enderço de Email Inválido");

            return !ErrorList.Any();
        }
    }
}
