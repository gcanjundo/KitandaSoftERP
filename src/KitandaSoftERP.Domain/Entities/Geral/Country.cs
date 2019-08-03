
using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Shared;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Country : BaseEntity
    {
        
        public string IsoCode2 { get; set; }
        public string IsoCode3 { get; set; }
        public string DailyCode { get; set; }
        public string IsoNumeralCode { get; set; }
        public string Nationality { get; set; }
        public virtual ICollection<Province> ProvincesList { get; set; }
        public virtual ICollection<Entity> EntitiesCountryAddressList { get; set; }
        public virtual ICollection<EntityPerson> EntitiesNationalityList { get; set; }
        public virtual ICollection<EntityPerson> EntitiesBirthCountryList { get; set; }

        public Country()
        {
            ProvincesList = new HashSet<Province>();
            EntitiesCountryAddressList = new HashSet<Entity>();
            EntitiesNationalityList = new HashSet<EntityPerson>();
            EntitiesBirthCountryList = new HashSet<EntityPerson>();

        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
