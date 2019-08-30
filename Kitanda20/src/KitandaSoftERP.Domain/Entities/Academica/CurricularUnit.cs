using KitandaSoftERP.Domain.Entities.Shared; 
using System.Linq; 

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class CurricularUnit: BaseEntity
    {

        public int UnitOrder { get; set; }
        public int DisciplineID { get; set; } 
        public int CurricularYearID { get; set; }
        public string UnitLevel { get; set; }
        public int UnitClassificationID { get; set; }
        public int AcademicPeriodID { get; set; }
        public int AcademicYearID { get; set; }
        public string Content { get; set; }
        public string Literature { get; set; }
        public string EvaluationMethods { get; set; }
        public string Goal { get; set; }
        public string Requirements { get; set; }
        public decimal Credits { get; set; }
        public string Orientation { get; set; }
        public string Color { get; set; }
        public bool AllowExamination { get; set; }
        public bool AllowResourceExamination { get; set; }
        public string SchoolReport { get; set; }
        public decimal WeeklyWorkLoad { get; set; }
        public decimal TheoryWorkLoad { get; set; }
        public decimal PraticalWorkLoad { get; set; }
        public int NumberPraticalWorks { get; set; }
        public decimal AcademicPeriodWorkLoad { get; set; }
        public int PriorUnitID { get; set; }
        public bool Condicioned { get; set; }
        public int CondicionerUnitID { get; set; }
        public bool IsCurricularUnit { get; set; }
        public virtual Discipline Discipline { get; set; }
        public virtual CurricularYear CurricularYear { get; set; }
        public virtual UnitClassification UnitClassification { get; set; }
        public virtual AcademicYear  AcademicYear { get; set; }  
        public virtual AcademicPeriod AcademicPeriod { get; set; }

        public CurricularUnit()
        {
            Discipline = new Discipline();
            CurricularYear = new CurricularYear();
            UnitClassification = new UnitClassification();
            AcademicYear = new AcademicYear();
            AcademicPeriod = new AcademicPeriod();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
