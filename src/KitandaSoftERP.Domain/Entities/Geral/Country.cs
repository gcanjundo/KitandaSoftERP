
using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Shared;
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
        public virtual AcademicSettings AcademicSettings{ get; set; }
        public Country()
        {
            AcademicSettings = new AcademicSettings();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
