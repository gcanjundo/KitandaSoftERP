using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComGuiaEntrega
    {
        public int GuiaCodigo { get; set; }
        public DateTime? GuiaData { get; set; }
        public DateTime? GuiaDataEntrega { get; set; }
        public int? GuiaCodigoDocumento { get; set; }
        public int? GuiaDocumentoOrigem { get; set; }
        public int? GuiaCodigoFuncionario { get; set; }
        public int? GuiaCodigoMotorista { get; set; }
        public string GuiaCreatedBy { get; set; }
        public DateTime? GuiaCreatedDate { get; set; }
        public string GuiaUpdatedBy { get; set; }
        public DateTime? GuiaUpdatedDate { get; set; }
        public int? GuiaCodigoSerie { get; set; }
        public int? GuiaNumeracao { get; set; }
        public string GuiaReferencia { get; set; }
    }
}
