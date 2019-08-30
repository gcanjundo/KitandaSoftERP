using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComFaturaFornecedorItem
    {
        public int FatItemCodigo { get; set; }
        public int FatItemCodigoArtigo { get; set; }
        public int FatItemCodigoCompra { get; set; }
        public decimal FatItemQuantidade { get; set; }
        public decimal FatItemPreco { get; set; }
        public decimal? FatItemDescontoLinha { get; set; }
        public decimal? FatItemDescontoCompra { get; set; }
        public decimal? FatItemImposto { get; set; }
        public decimal? FatItemValorDescontos { get; set; }
        public decimal? FatItemValorImpostos { get; set; }
        public decimal FatItemTotal { get; set; }
        public string FatItemComentarios { get; set; }
        public int? FatOrdem { get; set; }
        public int? FatItemStatus { get; set; }
        public int? FatItemComposicao { get; set; }
        public int? FatItemLoteId { get; set; }
        public int? FatItemDimensaoId { get; set; }
        public decimal? FatItemEncomendada { get; set; }
        public decimal? FatItemReservada { get; set; }
        public decimal? FatRetencao { get; set; }
        public int? FatItemDocOrigemId { get; set; }
        public int? FatItemDocOrigemLinha { get; set; }
        public int? FatItemEnvioDocId { get; set; }
        public int? FatItemEnvioDocLinha { get; set; }
        public DateTime? FatItemDataEntrega { get; set; }
        public decimal? FatItemDescontoFinanceiro { get; set; }
        public decimal? FatItemValorDescontoFinanceiro { get; set; }
        public decimal? FatItemDescontoNumerarioLinha { get; set; }
        public int? FatItemSerialnumberId { get; set; }
        public int? FatItemWarehouseId { get; set; }
        public string FatItemCreatedBy { get; set; }
        public DateTime? FatItemCreatedDate { get; set; }
        public string FatItemUpdatedBy { get; set; }
        public DateTime? FatItemUpdatedDate { get; set; }
        public string FatItemDeletedBy { get; set; }
        public DateTime? FatItemDeletedDate { get; set; }
        public decimal? FatItemPrecoCusto { get; set; }
        public decimal? FatItemValorTributavel { get; set; }
        public int? FatItemImpostoId { get; set; }

        public virtual GerArtigo FatItemCodigoArtigoNavigation { get; set; }
        public virtual ComFaturaFornecedor FatItemCodigoCompraNavigation { get; set; }
        public virtual GerImpostos FatItemImpostoNavigation { get; set; }
    }
}
