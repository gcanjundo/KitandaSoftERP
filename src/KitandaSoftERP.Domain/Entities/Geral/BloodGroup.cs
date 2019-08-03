using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class BloodGroup : BaseEntity
    {
        public ICollection<EntityPerson> EntityPersonsList { get; set; }

        public BloodGroup()
        {
            EntityPersonsList = new HashSet<EntityPerson>();
        }
        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Designation))
                ErrorList.Add("A Designação do Grupo Sanguíneo é obrigatória");
            if (string.IsNullOrEmpty(ShortName))
                ErrorList.Add("Informe o Grupo Sanguíneo");

            return !ErrorList.Any();
        }
    }
}
