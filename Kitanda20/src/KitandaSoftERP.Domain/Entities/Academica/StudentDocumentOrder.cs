using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class StudentDocumentOrder: BaseEntity
    {
        public StudentDocumentOrder()
        {
            DocumentOrderStudent = new Student();
        }
        public int DocumentOrderID { get; set; }
        public int DocumentOrderDocumentID { get; set; }
        public int DocumentOrderStudentID { get; set; }
        public int DocumentOrderRequesterID { get; set; }
        public string DocumentOrderDestination { get; set; }
        public DateTime DocumentOrderDate { get; set; }
        public bool DocumentOrderAborted { get; set; }
        public int DocumentOrderAutorizationBy { get; set; }
        public DateTime DocumentOrderAuthorizationDate { get; set; }
        public DateTime DocumentOrderDeliveryDate { get; set; }
        public virtual Student DocumentOrderStudent { get; set; }
        public virtual AcademicDocumentTemplate DocumentOrderDocument { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
