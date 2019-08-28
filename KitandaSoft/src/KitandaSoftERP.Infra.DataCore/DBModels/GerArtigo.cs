using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerArtigo
    {
        public GerArtigo()
        {
            AutoMarcacao = new HashSet<AutoMarcacao>();
            AutoOrdemServicoDetails = new HashSet<AutoOrdemServicoDetails>();
            CliPlanoConvenioCobertura = new HashSet<CliPlanoConvenioCobertura>();
            ComArtigoFornecedor = new HashSet<ComArtigoFornecedor>();
            ComFaturaClienteItem = new HashSet<ComFaturaClienteItem>();
            ComFaturaFornecedorItem = new HashSet<ComFaturaFornecedorItem>();
            ComPromocoesArtigos = new HashSet<PromotionsProducts>();
            ComStock = new HashSet<ComStock>();
            ComStockInventarioArtigos = new HashSet<StockInventoryItems>();
            ComTabelaPrecoArtigos = new HashSet<ComTabelaPrecoArtigos>();
            GerArtigoComposicaoCompCodigoArtigoNavigation = new HashSet<GerArtigoComposicao>();
            GerArtigoComposicaoCompCodigoComponenteNavigation = new HashSet<GerArtigoComposicao>();
            GerArtigoSemelhancaSemCodigoArtigoANavigation = new HashSet<GerArtigoSemelhanca>();
            GerArtigoSemelhancaSemCodigoArtigoBNavigation = new HashSet<GerArtigoSemelhanca>();
            GerArtigoSerialNumber = new HashSet<GerArtigoSerialNumber>();
            RestPratoDia = new HashSet<RestPratoDia>();
            StockMovimentosDirectosArtigos = new HashSet<StockMovimentosDirectosArtigos>();
        }

        public int ArtCodigo { get; set; }
        public string ArtCodigoBarras { get; set; }
        public string ArtReferencia { get; set; }
        public string ArtTipo { get; set; }
        public string ArtDesignacao { get; set; }
        public int? ArtCategoria { get; set; }
        public int? ArtMarca { get; set; }
        public int? ArtUnidadeVenda { get; set; }
        public decimal? ArtPrecoCusto { get; set; }
        public int? ArtCodigoImposto { get; set; }
        public decimal? ArtPrecoVenda { get; set; }
        public string ArtImagem { get; set; }
        public int? ArtCodigoFilial { get; set; }
        public string ArtMovimentaStock { get; set; }
        public decimal? ArtMargemLucro { get; set; }
        public string ArtStatus { get; set; }
        public DateTime? ArtCadastro { get; set; }
        public DateTime? ArtValidade { get; set; }
        public decimal? ArtPeso { get; set; }
        public decimal? ArtVolume { get; set; }
        public decimal? ArtQtdCompra { get; set; }
        public decimal? ArtQtdVenda { get; set; }
        public int? ArtUnidadeCompra { get; set; }
        public string ArtDescricaoCurta { get; set; }
        public int? ArtCodigoFabricante { get; set; }
        public int? ArtAnoFabrico { get; set; }
        public bool? ArtPedidoCozinha { get; set; }
        public bool? ArtDevolucao { get; set; }
        public bool? ArtImpostoIncluido { get; set; }
        public decimal? ArtPcmPadrao { get; set; }
        public decimal? ArtPcmCalculado { get; set; }
        public decimal? ArtDesconto { get; set; }
        public bool? ArtAllowLote { get; set; }
        public bool? ArtAllowDimensoes { get; set; }
        public bool? ArtComposto { get; set; }
        public bool? ArtTabelaPreco { get; set; }
        public bool? ArtDescontinuado { get; set; }
        public DateTime? ArtUltimaEntrada { get; set; }
        public DateTime? ArtUltimaSaida { get; set; }
        public int? ArtArtigoBase { get; set; }
        public string ArtCreatedBy { get; set; }
        public DateTime? ArtCreatedDate { get; set; }
        public string ArtUpdatedBy { get; set; }
        public DateTime? ArtUpdatedDate { get; set; }
        public int? ArtParcela { get; set; }
        public decimal? ArtPercentImposto { get; set; }
        public bool? ArtPos { get; set; }
        public int? ArtUnidadeEntrada { get; set; }
        public decimal? ArtQtdEntrada { get; set; }
        public int? ArtUnidadeSaida { get; set; }
        public decimal? ArtQtdSaida { get; set; }
        public int? ArtUnidadeReferencia { get; set; }
        public decimal? ArtQtdReferencia { get; set; }
        public decimal? ArtPesoLiquido { get; set; }
        public int? ArtPrazoEntrega { get; set; }
        public int? ArtMainFornecedorId { get; set; }
        public string ArtDescricaoComercial { get; set; }
        public int? ArtMainVendedor { get; set; }
        public decimal? ArtComissao { get; set; }
        public decimal? ArtValorImposto { get; set; }
        public string ArtObservacoes { get; set; }
        public decimal? ArtCalorias { get; set; }
        public decimal? ArtProteinas { get; set; }
        public decimal? ArtGorduras { get; set; }
        public decimal? ArtCarbohidratos { get; set; }
        public string ArtVideo { get; set; }
        public decimal? ArtQtdBalanca { get; set; }
        public string ArtComposeType { get; set; }
        public decimal? ArtComposePrice { get; set; }
        public bool? ArtExterno { get; set; }
        public bool? ArtOnlyOrder { get; set; }
        public bool? ArtRestpos { get; set; }
        public int? ArtTempoPreparacao { get; set; }
        public int? ArtContaStock { get; set; }
        public int? ArtContaPurchase { get; set; }
        public int? ArtContaSales { get; set; }
        public int? ArtDevolucaoPurchase { get; set; }
        public int? ArtDevolucaoSales { get; set; }
        public int? ArtRetailId { get; set; }
        public int? ArtAlertaRuptura { get; set; }
        public int? ArtVasilhameId { get; set; }
        public string ArtLoteManagment { get; set; }
        public string ArtAllowReserveStock { get; set; }
        public int? ArtAllowDownStock { get; set; }
        public int? ArtRetencaoId { get; set; }
        public int? ArtIsencaoId { get; set; }
        public string ArtMotivoIsencao { get; set; }
        public bool? ArtIsgriftCard { get; set; }
        public bool? ArtIscam { get; set; }
        public bool? ArtProvideCam { get; set; }
        public decimal? ArtDurcaoCam { get; set; }
        public string ArtDiscountType { get; set; }
        public bool? ArtInterno { get; set; }

        public virtual GerCategoria ArtCategoriaNavigation { get; set; }
        public virtual SisEmpresa ArtCodigoFilialNavigation { get; set; }
        public virtual GerImpostos ArtCodigoImpostoNavigation { get; set; }
        public virtual GerMarca ArtMarcaNavigation { get; set; }
        public virtual GerUnidadeMedicao ArtUnidadeVendaNavigation { get; set; }
        public virtual AutoArtigos AutoArtigos { get; set; }
        public virtual ICollection<AutoMarcacao> AutoMarcacao { get; set; }
        public virtual ICollection<AutoOrdemServicoDetails> AutoOrdemServicoDetails { get; set; }
        public virtual ICollection<CliPlanoConvenioCobertura> CliPlanoConvenioCobertura { get; set; }
        public virtual ICollection<ComArtigoFornecedor> ComArtigoFornecedor { get; set; }
        public virtual ICollection<ComFaturaClienteItem> ComFaturaClienteItem { get; set; }
        public virtual ICollection<ComFaturaFornecedorItem> ComFaturaFornecedorItem { get; set; }
        public virtual ICollection<PromotionsProducts> ComPromocoesArtigos { get; set; }
        public virtual ICollection<ComStock> ComStock { get; set; }
        public virtual ICollection<StockInventoryItems> ComStockInventarioArtigos { get; set; }
        public virtual ICollection<ComTabelaPrecoArtigos> ComTabelaPrecoArtigos { get; set; }
        public virtual ICollection<GerArtigoComposicao> GerArtigoComposicaoCompCodigoArtigoNavigation { get; set; }
        public virtual ICollection<GerArtigoComposicao> GerArtigoComposicaoCompCodigoComponenteNavigation { get; set; }
        public virtual ICollection<GerArtigoSemelhanca> GerArtigoSemelhancaSemCodigoArtigoANavigation { get; set; }
        public virtual ICollection<GerArtigoSemelhanca> GerArtigoSemelhancaSemCodigoArtigoBNavigation { get; set; }
        public virtual ICollection<GerArtigoSerialNumber> GerArtigoSerialNumber { get; set; }
        public virtual ICollection<RestPratoDia> RestPratoDia { get; set; }
        public virtual ICollection<StockMovimentosDirectosArtigos> StockMovimentosDirectosArtigos { get; set; }
    }
}
