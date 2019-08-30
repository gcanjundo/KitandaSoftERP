using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerTerceiros
    {
        public GerTerceiros()
        {
            ComArtigoFornecedor = new HashSet<ComArtigoFornecedor>();
            ComReciboCliente = new HashSet<ComReciboCliente>();
            ComSeguradoras = new HashSet<ComSeguradoras>();
            GerTerceirosContacto = new HashSet<GerTerceirosContacto>();
            RestReserva = new HashSet<RestReserva>();
        }

        public int TerCodigo { get; set; }
        public int? TerCodigoEntidade { get; set; }
        public int? TerCodigoCategoria { get; set; }
        public int? TerCodigoFilial { get; set; }
        public string TerTipo { get; set; }
        public string TerNomeComercial { get; set; }
        public decimal? TerLimiteCredito { get; set; }
        public decimal? TerSaldo { get; set; }
        public decimal? TerDesconto { get; set; }
        public int? TerPaymentMethodId { get; set; }
        public int? TerPaymentTermsId { get; set; }
        public decimal? TerLineDiscount { get; set; }
        public int? TerMaturityDays { get; set; }
        public int? TerDeadline { get; set; }
        public int? TerCurrencyId { get; set; }
        public int? TerSalesmanId { get; set; }
        public int? TerChargesmanId { get; set; }
        public int? TerBankId { get; set; }
        public string TerAccountNumber { get; set; }
        public string TerIban { get; set; }
        public string TerSwift { get; set; }
        public int? TerTablePriceId { get; set; }
        public string TerComercialPeople { get; set; }
        public string TerComercialFunction { get; set; }
        public string TerComercialPhonenumber { get; set; }
        public string TerComercialEmail { get; set; }
        public string TerChargesPeople { get; set; }
        public string TerChargesFunction { get; set; }
        public string TerChargesPhone { get; set; }
        public string TerChargesEmail { get; set; }
        public string TerAdministrativePeople { get; set; }
        public string TerAdministrativeFunction { get; set; }
        public string TerAdministrativePhone { get; set; }
        public string TerAdministrativeEmail { get; set; }
        public int? TerExpeditionId { get; set; }
        public bool? TerAllowAlert { get; set; }
        public int? TerAlertDays { get; set; }
        public int? TerAlertPeddingValue { get; set; }
        public int? TerRegimeIvaId { get; set; }
        public int? TerManagementId { get; set; }
        public int? TerAngariadorId { get; set; }
        public bool? TerRetencao { get; set; }
        public bool? TerSujeitoPassivo { get; set; }
        public bool? TerImpostoIncluido { get; set; }
        public int? TerMoedaId { get; set; }
        public int? TerAccountSupplierId { get; set; }
        public int? TerAccountCustomerId { get; set; }
        public bool? TerSelfbilling { get; set; }
        public bool? TerExported { get; set; }

        public virtual GerGrupoClientes TerCodigoCategoriaNavigation { get; set; }
        public virtual GerEntidade TerCodigoEntidadeNavigation { get; set; }
        public virtual SisEmpresa TerCodigoFilialNavigation { get; set; }
        public virtual ComRegimeIva TerRegimeIva { get; set; }
        public virtual ICollection<ComArtigoFornecedor> ComArtigoFornecedor { get; set; }
        public virtual ICollection<ComReciboCliente> ComReciboCliente { get; set; }
        public virtual ICollection<ComSeguradoras> ComSeguradoras { get; set; }
        public virtual ICollection<GerTerceirosContacto> GerTerceirosContacto { get; set; }
        public virtual ICollection<RestReserva> RestReserva { get; set; }
    }
}
