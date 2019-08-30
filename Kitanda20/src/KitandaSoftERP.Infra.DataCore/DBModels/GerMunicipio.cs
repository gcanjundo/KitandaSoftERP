using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerMunicipio
    {
        public GerMunicipio()
        {
            GerDistritos = new HashSet<GerDistritos>();
            GerEntidadeEntLocalMoradaNavigation = new HashSet<GerEntidade>();
            GerEntidadeEntLocalNascimentoNavigation = new HashSet<GerEntidade>();
            GerEntidadeMorada = new HashSet<GerEntidadeMorada>();
        }

        public int MunCodigo { get; set; }
        public int? MunCodigoProvincia { get; set; }
        public string MunDescricao { get; set; }
        public bool? MunStatus { get; set; }

        public virtual GerProvincia MunCodigoProvinciaNavigation { get; set; }
        public virtual ICollection<GerDistritos> GerDistritos { get; set; }
        public virtual ICollection<GerEntidade> GerEntidadeEntLocalMoradaNavigation { get; set; }
        public virtual ICollection<GerEntidade> GerEntidadeEntLocalNascimentoNavigation { get; set; }
        public virtual ICollection<GerEntidadeMorada> GerEntidadeMorada { get; set; }
    }
}
