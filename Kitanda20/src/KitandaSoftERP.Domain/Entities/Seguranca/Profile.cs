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
            ProfileBranchsList = new HashSet<UserProfileBranch>();
            UsersList = new HashSet<User>();
            ProfilePermissionsList = new HashSet<UserProfilePermission>();

        }
        public int ProfileID { get; set; }   
        public Email Email { get; set; }
        public bool IsSupervisorPOS { get; set; }
        public virtual ICollection<User> UsersList { get; set; }
        public virtual ICollection<UserProfileBranch> ProfileBranchsList { get; set; }
        public virtual ICollection<UserProfilePermission> ProfilePermissionsList { get; set; }
        public override bool IsValid()
        {
            if (!Email.IsValidEmailAddress(Email.AddressEmail))
                ErrorList.Add("Enderço de Email Inválido");

            return !ErrorList.Any();
        }
    }
}
