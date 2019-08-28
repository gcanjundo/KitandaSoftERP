using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisDocumentsFormate
    {
        public SisDocumentsFormate()
        {
            ComDocumento = new HashSet<ComDocumento>();
        }

        public string TypId { get; set; }
        public string TypDescription { get; set; }
        public string TypDocument { get; set; }

        public virtual ICollection<ComDocumento> ComDocumento { get; set; }
    }
}
