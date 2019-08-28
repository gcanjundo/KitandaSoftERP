using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestAtendimento
    {
        public int AtendCodigo { get; set; }
        public int? AtendCliente { get; set; }
        public DateTime? AtendData { get; set; }
        public DateTime? AtendInicio { get; set; }
        public DateTime? AtendTermino { get; set; }
        public int? AtendAtendente { get; set; }
        public string AtendDestino { get; set; }
        public string AtendStatus { get; set; }
        public int? AtendCodigoFilial { get; set; }
        public int? AtendCodigoFatura { get; set; }
        public string AtendCriadoPor { get; set; }
        public string AtendFechadoPor { get; set; }
        public DateTime? AtendDataFecho { get; set; }
        public decimal? AtendConta { get; set; }
        public string AtendAnuladoPor { get; set; }
        public string AtendMotivoAnulacao { get; set; }
        public int? AtendDocumentId { get; set; }
        public int? AtendSerieId { get; set; }
        public string AtendRefrencia { get; set; }
        public int? AtendNumeracao { get; set; }
        public DateTime? AtendCancelDate { get; set; }

        public virtual ComFaturaCliente AtendCodigoFaturaNavigation { get; set; }
        public virtual SisEmpresa AtendCodigoFilialNavigation { get; set; }
    }
}
