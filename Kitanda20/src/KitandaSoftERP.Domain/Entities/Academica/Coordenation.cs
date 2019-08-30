
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class Coordenation : BaseEntity
    {
        public Coordenation()
        {
            CoursesList = new HashSet<Course>();
        }
        public virtual ICollection<Course> CoursesList { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}