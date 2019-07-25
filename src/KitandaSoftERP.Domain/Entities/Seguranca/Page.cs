

using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public class Page: BaseEntity
    {
         
        public int ModuleID { get; set; } 
        public virtual Module Module { get; set; }  
        public string Link { get; set; } 
        public int TAG { get; set; } 
        public int Indice { get; set; } 
        public string Imagem { get; set; } 
        public virtual ICollection<UserProfilePermission> UserProfilePermissionsList { get; set; }
        public Page()
        {
            UserProfilePermissionsList = new HashSet<UserProfilePermission>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }

    
}
