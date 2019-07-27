using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class EvaluationResults : BaseEntity
    {
        public int StudentID { get; set; } 
        public int ClassRoomID { get; set; }
        public int CurricularUnitID { get; set; } 
        public string StudentCode { get; set; }
        public string StudentName { get; set; }
        public decimal PPT11 { get; set; }
        public decimal PPT12 { get; set; }
        public decimal PPT13 { get; set; }
        public decimal PPT14 { get; set; }
        public decimal MAC1 { get; set; }
        public decimal MTP1 { get; set; }
        public decimal MT1 { get; set; }
        public decimal PPT21 { get; set; }
        public decimal PPT22 { get; set; }
        public decimal PPT23 { get; set; }
        public decimal PPT24 { get; set; }
        public decimal MAC2 { get; set; }
        public decimal MTP2 { get; set; }
        public decimal MT2 { get; set; }
        public decimal PPT31 { get; set; }
        public decimal PPT32 { get; set; }
        public decimal PPT33 { get; set; }
        public decimal PPT34 { get; set; }
        public decimal MAC3 { get; set; }
        public decimal MTP3 { get; set; }
        public decimal MT3 { get; set; }
        public decimal CAP { get; set; }
        public decimal CPE { get; set; }
        public decimal CF { get; set; } 
        public decimal Exame { get; set; }
        public decimal ResourceExame { get; set; }
        public decimal CAA { get; set; }
        public decimal C10 { get; set; }
        public decimal OralExame { get; set; }
        public decimal SpecialExame { get; set; }
        public decimal SpecialOralExame { get; set; }
        public decimal ImprovementExam { get; set; } 
        public string FinalByExtensive { get; set; }
        public string ValidationBy { get; set; }
        public DateTime ValidationDate { get; set; }
        public decimal CFD { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
