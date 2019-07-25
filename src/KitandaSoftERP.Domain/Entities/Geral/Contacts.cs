using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Contacts:BaseEntity
    {
        public int EntityID { get; set; } 
        public string ContactDescription { get; set; } 
        public string ContactType { get; set; }
        public int Status { get; set; }
        public bool IsMainContact { get; set; } 
        public string RelationShip { get; set; }  
        public virtual Entity Entity { get; set; } 
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
