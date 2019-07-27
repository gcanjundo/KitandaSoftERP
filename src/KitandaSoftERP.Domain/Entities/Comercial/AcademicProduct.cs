using KitandaSoftERP.Domain.Entities.Academica;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Comercial
{
    public class AcademicProduct:Product
    {
        public int AcademicProductID { get; set; }
        public int CurricularYearID { get; set; } 
        public virtual CurricularYear CurricularYear { get; set; }
        public virtual ICollection<AcademicDocumentTemplate> AcademicDocumentList { get; set; }

        public AcademicProduct():base()
        {
            CurricularYear = new CurricularYear();
            AcademicDocumentList = new HashSet<AcademicDocumentTemplate>();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
