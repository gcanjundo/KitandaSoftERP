using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class City: BaseEntity
    { 
        public int ProvinceID { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Commune> CommunesDisctrictsList { get; set; }
        public virtual ICollection<EntityPerson> EntityPersonsBirthCityList { get; set; }
        public virtual ICollection<Entity> EntitiesCityAddressList { get; set; } 
        public City()
        {
            CommunesDisctrictsList = new HashSet<Commune>();
            EntityPersonsBirthCityList = new HashSet<EntityPerson>();
            EntitiesCityAddressList = new HashSet<Entity>();
        }
        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Designation))
                ErrorList.Add("A Designação do Município é obrigatória");
            if (ProvinceID <= 0)
                ErrorList.Add("Informe a Província a que o Município pertence");

            return !ErrorList.Any();
        }
    }
}
