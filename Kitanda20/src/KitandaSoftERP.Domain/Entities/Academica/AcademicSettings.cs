using System.Linq;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;

namespace KitandaSoftERP.Domain.Entities.Academica
{
    public class AcademicSettings : BaseEntity
    {
        public int ConfigurationID { get; set; }   
        public string DeadLineRegistration { get; set; }  
        public decimal ApprovalResult { get; set; } 
        public int ApprovalDiscipleNumber { get; set; } 
        public string AllowRegistrationWithPeddingDue { get; set; } 
        public int CurrencyID { get; set; } 
        public string AcademicDirectorName { get; set; }
        public string GeneralSecretaryDirectorName { get; set; } 
        public string FinanceDirectorName { get; set; } 
        public string HRDirectorName { get; set; }
        public string ConfCobrancaMulta { get; set; }
        public string ConfLancaNota { get; set; }
        public string ConfImportacao { get; set; }
        public string AllowAutomaticalClassRoomGenation { get; set; }
        public string AllowRegistrationWithoutTax { get; set; } 
        public string ConfPautaDivida { get; set; } 
        public string ConfAtribDesconto { get; set; } 
        public decimal ConfNotaExameIni { get; set; }
        public string CobrarMultaLastMonth { get; set; }
        public int ConfNumProva { get; set; }
        public string ConfAplicacaoExame { get; set; }
        public decimal ConfExameTerm { get; set; } 
        public string ConfImpressora { get; set; } 
        public int ConfAccaoBolseiroInterno { get; set; } 
        public string ConfMatCadeiraAtraso { get; set; } 
        public string ConfDenomicacaoClasse { get; set; } 
        public string ConfInicioCobranca { get; set; } 
        public string CobraMultaFirstMonth { get; set; } 
        public string ConfPagamentosFaseado { get; set; }
        public string DefaultAddress { get; set; } = "EMP"; 
        public int CountryID { get; set; }  
        public string BackupPath { get; set; } 
        public bool AllowCentralizedCashRegister { get; set;}  
        public string TaxaInscricao { get; set; } 
        public string MultaMatricula { get; set; } 
        public string BaseDados { get; set; } 
        public string CabecalhoDocuementos { get; set; } 
        public string GestaoCaixa { get; set; } 
        public string HorarioAuto { get; set; } 
        public int ProvinceCode { get; set; } 
        public string Linha1 { get; set; } 
        public string Linha2 { get; set; } 
        public string BDIP { get; set; } 
        public string DirectorGeral { get; set; } 
        public string DirectorPedagogico { get; set; } 
        public string DirectorFinaceiro { get; set; } 
        public string ModoPesquisaInscricao { get; set; } 
        public string FormatoBoletim { get; set; } 
        public string ModoLancamento { get; set; }  
        public bool YearConfigured { get; set; } 
        public int YearConfigurationCode { get; set; } 
        public int PeriodoLectivoActivo { get; set; } 
        public string PeriodoLectivoActivoDesignation { get; set; } 
        public string TerminoPeridoLectivoActivo { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Country Country { get; set; }
        public virtual Branch Branch { get; set; }
        public AcademicSettings()
        {
            Country = new Country();
            Currency = new Currency();
            Branch = new Branch();
        }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
