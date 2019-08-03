using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhFuncionario
    {
        public RhFuncionario()
        {
            RhFuncionarioAgregadoFamiliar = new HashSet<RhFuncionarioAgregadoFamiliar>();
            RhFuncionarioCoordenadasBancarias = new HashSet<RhFuncionarioCoordenadasBancarias>();
            RhRegistoFalta = new HashSet<RhRegistoFalta>();
            RhRegsitoFerias = new HashSet<RhRegsitoFerias>();
        }

        public int FunCodigo { get; set; }
        public int FunNumFuncionario { get; set; }
        public DateTime? FunDataAdmissao { get; set; }
        public DateTime? FunDataDemissao { get; set; }
        public string FunExtensao { get; set; }
        public string FunEmail { get; set; }
        public int? FunCodigoCargo { get; set; }
        public int? FunCodigoGrupoSalarial { get; set; }
        public int? FunCodigoRegime { get; set; }
        public double? FunSalarioBase { get; set; }
        public DateTime? FunUltimaRevisaoSalarial { get; set; }
        public int? FunMotivoAdmissao { get; set; }
        public string FunStatus { get; set; }
        public int? FunCodigoDepartamento { get; set; }
        public int? FunTipoSalario { get; set; }
        public string FunTurno { get; set; }
        public string FunCargaSemanal { get; set; }
        public string FunCargaMensal { get; set; }
        public int? FunCodigoVinculo { get; set; }
        public DateTime? FunInicioContrato { get; set; }
        public DateTime? FunTerminoContrato { get; set; }
        public int? FunVigenciaContrato { get; set; }
        public int? FunPeriodoExperimental { get; set; }
        public DateTime? FunDataAvisoPrevio { get; set; }
        public int? FunMotivoDemissao { get; set; }
        public int? FunCodigoHabilitacao { get; set; }
        public int? FunCodigoFormacao { get; set; }
        public DateTime? FunDataObtencaoFormacao { get; set; }
        public int? FunCodigoProfissao { get; set; }
        public int? FunCodigoBanco { get; set; }
        public string FunContaBancaria { get; set; }
        public string FunIban { get; set; }
        public string FunNib { get; set; }
        public string FunSwift { get; set; }
        public int? FunCodigoFilial { get; set; }
        public string FunUtilizador { get; set; }
        public string FunNomePai { get; set; }
        public string FunNomeMae { get; set; }

        public virtual FinBanco FunCodigoBancoNavigation { get; set; }
        public virtual RhCargo FunCodigoCargoNavigation { get; set; }
        public virtual GerDepartamento FunCodigoDepartamentoNavigation { get; set; }
        public virtual SisEmpresa FunCodigoFilialNavigation { get; set; }
        public virtual RhGrupoSalarial FunCodigoGrupoSalarialNavigation { get; set; }
        public virtual GerHabilitacoes FunCodigoHabilitacaoNavigation { get; set; }
        public virtual GerEntidadePessoa FunCodigoNavigation { get; set; }
        public virtual RhRegimeLaboral FunCodigoRegimeNavigation { get; set; }
        public virtual RhVinculoContratual FunCodigoVinculoNavigation { get; set; }
        public virtual RhMotivo FunMotivoAdmissaoNavigation { get; set; }
        public virtual RhMotivo FunMotivoDemissaoNavigation { get; set; }
        public virtual RhVencimento FunTipoSalarioNavigation { get; set; }
        public virtual ICollection<RhFuncionarioAgregadoFamiliar> RhFuncionarioAgregadoFamiliar { get; set; }
        public virtual ICollection<RhFuncionarioCoordenadasBancarias> RhFuncionarioCoordenadasBancarias { get; set; }
        public virtual ICollection<RhRegistoFalta> RhRegistoFalta { get; set; }
        public virtual ICollection<RhRegsitoFerias> RhRegsitoFerias { get; set; }
    }
}
