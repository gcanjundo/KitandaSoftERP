
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class StudentParent: EntityPerson
    {

        public int PhisicalPersonID { get; set; }
        public string WorkPlace { get; set; }
        public string WorkAddress { get; set; }
        public string WorkPhone { get; set; }
        public int RelationshipID { get; set; } 
        public virtual RelationshipType RelationShip { get; set; }
        public virtual EntityPerson PhisicalPerson { get; set; }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }

    }
}
