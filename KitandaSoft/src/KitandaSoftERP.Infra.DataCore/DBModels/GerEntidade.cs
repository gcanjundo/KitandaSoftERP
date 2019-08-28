using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerEntidade
    {
        public GerEntidade()
        {
            AutoMarcacao = new HashSet<AutoMarcacao>();
            AutoOrdemServico = new HashSet<AutoOrdemServico>();
            CliPlanoConvenio = new HashSet<CliPlanoConvenio>();
            ComContratos = new HashSet<ComContratos>();
            ComFaturaClienteFatCodigoClienteNavigation = new HashSet<ComFaturaCliente>();
            ComFaturaClienteFatEntityBill = new HashSet<ComFaturaCliente>();
            ComFaturaFornecedorFatCodigoFornecedorNavigation = new HashSet<ComFaturaFornecedor>();
            ComFaturaFornecedorFatEntityBill = new HashSet<ComFaturaFornecedor>();
            FinContaBancaria = new HashSet<FinContaBancaria>();
            FinMovimentoCaixa = new HashSet<FinMovimentoCaixa>();
            GerEntidadeDocumentacao = new HashSet<GerEntidadeDocumentacao>();
            GerTaskTaskExecutor = new HashSet<Tasks>();
            GerTaskTaskTarget = new HashSet<Tasks>();
            GerTerceiros = new HashSet<GerTerceiros>();
            GerViatura = new HashSet<GerViatura>();
            RestFuncionarios = new HashSet<RestFuncionarios>();
        }

        public int EntCodigo { get; set; }
        public string EntNomeCompleto { get; set; }
        public DateTime? EntDataNascimento { get; set; }
        public int? EntLocalNascimento { get; set; }
        public int? EntCodigoPais { get; set; }
        public int? EntCodigoDocumento { get; set; }
        public int? EntLocalMorada { get; set; }
        public string EntRua { get; set; }
        public string EntBairro { get; set; }
        public string EntTelefone { get; set; }
        public string EntTelefoneAlternativo { get; set; }
        public string EntTelefoneFax { get; set; }
        public string EntEmail { get; set; }
        public string EntWebsite { get; set; }
        public string EntStatus { get; set; }
        public DateTime? EntDataInclusao { get; set; }
        public string EntIdentificacao { get; set; }
        public int? EntNacionalidade { get; set; }
        public byte[] EntFotografia { get; set; }
        public string EntFotografiaPath { get; set; }
        public string EntFotografiaExtensao { get; set; }
        public string EntDistrito { get; set; }
        public string EntCreatedBy { get; set; }
        public string EntUpdatedBy { get; set; }
        public DateTime? EntUpdatedDate { get; set; }

        public virtual GerPais EntCodigoPaisNavigation { get; set; }
        public virtual GerMunicipio EntLocalMoradaNavigation { get; set; }
        public virtual GerMunicipio EntLocalNascimentoNavigation { get; set; }
        public virtual GerPais EntNacionalidadeNavigation { get; set; }
        public virtual FinBanco FinBanco { get; set; }
        public virtual GerEntidadeMorada GerEntidadeMorada { get; set; }
        public virtual GerEntidadePessoa GerEntidadePessoa { get; set; }
        public virtual SisEmpresa SisEmpresa { get; set; }
        public virtual ICollection<AutoMarcacao> AutoMarcacao { get; set; }
        public virtual ICollection<AutoOrdemServico> AutoOrdemServico { get; set; }
        public virtual ICollection<CliPlanoConvenio> CliPlanoConvenio { get; set; }
        public virtual ICollection<ComContratos> ComContratos { get; set; }
        public virtual ICollection<ComFaturaCliente> ComFaturaClienteFatCodigoClienteNavigation { get; set; }
        public virtual ICollection<ComFaturaCliente> ComFaturaClienteFatEntityBill { get; set; }
        public virtual ICollection<ComFaturaFornecedor> ComFaturaFornecedorFatCodigoFornecedorNavigation { get; set; }
        public virtual ICollection<ComFaturaFornecedor> ComFaturaFornecedorFatEntityBill { get; set; }
        public virtual ICollection<FinContaBancaria> FinContaBancaria { get; set; }
        public virtual ICollection<FinMovimentoCaixa> FinMovimentoCaixa { get; set; }
        public virtual ICollection<GerEntidadeDocumentacao> GerEntidadeDocumentacao { get; set; }
        public virtual ICollection<Tasks> GerTaskTaskExecutor { get; set; }
        public virtual ICollection<Tasks> GerTaskTaskTarget { get; set; }
        public virtual ICollection<GerTerceiros> GerTerceiros { get; set; }
        public virtual ICollection<GerViatura> GerViatura { get; set; }
        public virtual ICollection<RestFuncionarios> RestFuncionarios { get; set; }
    }
}
