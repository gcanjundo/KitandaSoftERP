﻿using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Commune : BaseEntity
    { 
        public int CityID { get; set; }
        public virtual City City { get; set; } 
        public int DistrictCommuneID { get; set;}
        public virtual Commune DistrictCommune { get; set; }  
        public virtual ICollection<Commune> DistrictCommuneList { get; set; }
        public virtual ICollection<EntityPerson> EntityPersonsBirthCommuneList { get; set; }
        public virtual ICollection<Entity> EntitiesCommuneAddressList { get; set; }

        public Commune()
        {
            DistrictCommuneList = new HashSet<Commune>();
            EntityPersonsBirthCommuneList = new HashSet<EntityPerson>();
            EntitiesCommuneAddressList = new HashSet<Entity>();
        }
        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Designation))
                ErrorList.Add("A Designação da Comuna ou do Distrito é obrigatória");
            if (CityID <= 0)
                ErrorList.Add("Informe o Município a que pertence a Comuna ou Distrito");

            return !ErrorList.Any();
        }
    }
}
