

using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Shared.ValueObject;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public class UserProfilePermission:BaseEntity 
    {
        public int UserProfilePermissionID { get; set; }
        public int PageID { get; set; } 
        public virtual Page Page { get; set; } 
        public int ProfileID { get; set; }
        public virtual Profile Profile { get; set; } 
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public Permission Permission { get; set; }
        public UserProfilePermission()
        {
            Page = new Page();
            User = new User();
            Profile = new Profile();
            Permission = new Permission();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }

    
}
