using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisPrinters
    {
        public int PrintCodigo { get; set; }
        public string PrintName { get; set; }
        public string PrintDescription { get; set; }
        public string PrintIp { get; set; }
        public string PrintPath { get; set; }
        public string PrintCreatedBy { get; set; }
        public DateTime? PrintCreatedDate { get; set; }
        public string PrintUpdatedBy { get; set; }
        public DateTime? PrintUpdatedDate { get; set; }
    }
}
