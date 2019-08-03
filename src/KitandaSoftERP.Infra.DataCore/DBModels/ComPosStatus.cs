using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComPosStatus
    {
        public ComPosStatus()
        {
            ComPosMovimento = new HashSet<ComPosMovimento>();
        }

        public int PosStaCodigo { get; set; }
        public int PosStaPosto { get; set; }
        public string PosStaUtilizador { get; set; }
        public DateTime PosStaData { get; set; }
        public decimal? PosStaValorInicial { get; set; }
        public int PosStaTurno { get; set; }
        public DateTime? PosStaAbertura { get; set; }
        public decimal? PosStaValorFinal { get; set; }
        public DateTime? PosStaFecho { get; set; }
        public string PosIp { get; set; }
        public int? PosStaCodigoFilial { get; set; }

        public virtual SisEmpresa PosStaCodigoFilialNavigation { get; set; }
        public virtual ComPos PosStaPostoNavigation { get; set; }
        public virtual GerTurnos PosStaTurnoNavigation { get; set; }
        public virtual ICollection<ComPosMovimento> ComPosMovimento { get; set; }
    }
}
