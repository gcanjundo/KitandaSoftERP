using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class CurricularUnitEvalutionResult : BaseEntity
    {
        public int EvaluationID { get; set; }
        public int StudentID { get; set; }
        public int ClassRoomID { get; set; }
        public int CurricularUnitID { get; set; }
        public int TeacherID { get; set; } 
        public decimal Result { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
