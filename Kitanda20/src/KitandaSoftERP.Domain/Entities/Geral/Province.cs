using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Province:BaseEntity
    {
        public string IsoCode2 { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<City> CitiesList { get; set; }
        public virtual ICollection<Entity> EntitiesProvincesAddressList { get; set; }
        public virtual ICollection<EntityPerson> EntitiesBirthProvinceList { get; set; }
        public Province()
        {
            Country = new Country();
            CitiesList = new HashSet<City>();
            EntitiesProvincesAddressList = new HashSet<Entity>();
            EntitiesBirthProvinceList = new HashSet<EntityPerson>();
        }
        public override bool IsValid() => !ErrorList.Any();
    }
}
