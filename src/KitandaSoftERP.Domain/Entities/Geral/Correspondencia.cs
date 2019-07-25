using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public class Correspondencia:BaseEntity
    { 
        public string InternalReference { get; set; }
        public string ExternaRefence { get; set; }
        public int SenderID { get; set; }
        public int ReceptorID { get; set; }
        public int RecipientID { get; set; }
        public int CategoryID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string ReceptorName { get; set; }
        public string Subject { get; set; }  
        public string Status { get; set; }
        public int RecipientDepartamentID { get; set; }
        public string Barcode { get; set; }
        public string PathFile { get; set; }
        public string ImageByte { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
