using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestAtendimentoPedido
    {
        public int RestPedidoId { get; set; }
        public int? RestPedidoAtendimentoId { get; set; }
        public int? RestPedidoSalemanId { get; set; }
        public int? RestMesaId { get; set; }
        public int? RestPedidoFilial { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
