

using KitandaSoftERP.Domain.Entities.Shared;
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
        public bool AllowInsert { get; set; } 
        public bool AllowEdit { get; set; } 
        public int AllowDelete { get; set; } 
        public int AllowSelect { get; set; } 
        public int AllowPrint { get; set; }  
        public int Allowed { get; set; }
        public UserProfilePermission()
        {
            Page = new Page();
            User = new User();
            Profile = new Profile();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }

    
}
