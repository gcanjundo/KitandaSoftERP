using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq; 

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Room : BaseEntity
    {
        public int Lotation { get; set; }
        public string Type { get; set; }
        public virtual ICollection<ClassRoom> ClassesRoom { get; set; }
        public Room()
        {
            ClassesRoom = new HashSet<ClassRoom>();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }


    }
}
