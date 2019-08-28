using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisCore
    {
        public int SisId { get; set; }
        public string SisCode { get; set; }
        public string SisDesignation { get; set; }
        public string SisStatus { get; set; }
        public string SisUrl { get; set; }
    }
}
