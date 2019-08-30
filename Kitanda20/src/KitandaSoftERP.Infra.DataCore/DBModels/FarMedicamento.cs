using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class FarMedicamento
    {
        public FarMedicamento()
        {
            CliConsultaReceitaMedicamento = new HashSet<CliConsultaReceitaMedicamento>();
        }

        public uint MedCodigo { get; set; }
        public string MedCodigoBarras { get; set; }
        public string MedNomeComercial { get; set; }
        public string MedNomeQuimico { get; set; }
        public int? MedCodigoFabricante { get; set; }
        public string MedFormaFarmaceutica { get; set; }
        public int? MedCodigoUnidade { get; set; }
        public DateTime? MedValidade { get; set; }
        public string MedApresentacao { get; set; }
        public string MedPrescricao { get; set; }
        public int? MedTipo { get; set; }
        public string MedFormula { get; set; }

        public virtual ICollection<CliConsultaReceitaMedicamento> CliConsultaReceitaMedicamento { get; set; }
    }
}
