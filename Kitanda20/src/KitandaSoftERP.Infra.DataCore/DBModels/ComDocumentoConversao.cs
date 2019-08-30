using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComDocumentoConversao
    {
        public int DocOriginalId { get; set; }
        public int DocConvertId { get; set; }
        public string DocOriginalType { get; set; }
        public string DocConvertableType { get; set; }

        public virtual ComDocumento DocConvert { get; set; }
        public virtual ComDocumento DocOriginal { get; set; }
    }
}
