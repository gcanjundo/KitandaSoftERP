using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisEmpresa
    {
        public SisEmpresa()
        {
            AutoOrdemServico = new HashSet<AutoOrdemServico>();
            CliAtendimento = new HashSet<ClinicalAttendance>();
            ComAnoFaturacao = new HashSet<ComAnoFaturacao>();
            ComFaturaCliente = new HashSet<ComFaturaCliente>();
            ComFaturaFornecedor = new HashSet<ComFaturaFornecedor>();
            ComPosStatus = new HashSet<ComPosStatus>();
            ComReciboCliente = new HashSet<ComReciboCliente>();
            ComSerieDocumentacao = new HashSet<ComSerieDocumentacao>();
            FinMovimentoCaixa = new HashSet<FinMovimentoCaixa>();
            GerArtigo = new HashSet<GerArtigo>();
            GerTerceiros = new HashSet<GerTerceiros>();
            RestAtendimento = new HashSet<RestAtendimento>();
            RestFuncionarios = new HashSet<RestFuncionarios>();
            RhFuncionario = new HashSet<RhFuncionario>();
        }

        public int FilCodigo { get; set; }
        public int? FilCodigoEmpresa { get; set; }
        public int? FilCategoria { get; set; }
        public string FilRazaoSocial { get; set; }
        public string FilNomeComercial { get; set; }
        public bool? FilStatus { get; set; }
        public string FilSigla { get; set; }
        public decimal? FilCapitalSocial { get; set; }
        public string FilRegistoComercial { get; set; }
        public string FilConservatoria { get; set; }
        public string FilNaturezaJuridca { get; set; }
        public string FilSoftwareNif { get; set; }
        public int? FilSoftwareValidationId { get; set; }
        public string FilSoftwareDesignation { get; set; }
        public string FilSoftwareProductVersion { get; set; }

        public virtual GerEntidade FilCodigoNavigation { get; set; }
        public virtual ICollection<AutoOrdemServico> AutoOrdemServico { get; set; }
        public virtual ICollection<ClinicalAttendance> CliAtendimento { get; set; }
        public virtual ICollection<ComAnoFaturacao> ComAnoFaturacao { get; set; }
        public virtual ICollection<ComFaturaCliente> ComFaturaCliente { get; set; }
        public virtual ICollection<ComFaturaFornecedor> ComFaturaFornecedor { get; set; }
        public virtual ICollection<ComPosStatus> ComPosStatus { get; set; }
        public virtual ICollection<ComReciboCliente> ComReciboCliente { get; set; }
        public virtual ICollection<ComSerieDocumentacao> ComSerieDocumentacao { get; set; }
        public virtual ICollection<FinMovimentoCaixa> FinMovimentoCaixa { get; set; }
        public virtual ICollection<GerArtigo> GerArtigo { get; set; }
        public virtual ICollection<GerTerceiros> GerTerceiros { get; set; }
        public virtual ICollection<RestAtendimento> RestAtendimento { get; set; }
        public virtual ICollection<RestFuncionarios> RestFuncionarios { get; set; }
        public virtual ICollection<RhFuncionario> RhFuncionario { get; set; }
    }
}
