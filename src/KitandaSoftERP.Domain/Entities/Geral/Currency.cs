using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral { 

    public class Currency:BaseEntity
    { 
        public string IsoCode { get; set; }
        public virtual AcademicSettings AcademicSettings { get; set; }
        public Currency()
        {
            AcademicSettings = new AcademicSettings();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }


}
