

using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public class UserProfileBranch:BaseEntity
    {
        public int ProfileID { get; set; }
        public int UserID { get; set; } 
        public virtual Branch Branch { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual User User { get; set; }
        public UserProfileBranch()
        {
            Branch = new Branch();
            Profile = new Profile();
            User = new User();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }

    
}
