using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Shared; 
using System.Linq; 

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class StudentFamily: BaseEntity
    {
        public int StudentID { get; set; }
        public int RelatedPersonID { get; set; }
        public int RelationshipID { get; set; } 
        public virtual Student Student { get; set; }
        public virtual EntityPerson RelatedPerson { get; set; }
        public virtual RelationshipType RelationShip { get; set; }
        public StudentFamily()
        {
            Student = new Student();
            RelatedPerson = new EntityPerson();
            RelationShip = new RelationshipType();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
