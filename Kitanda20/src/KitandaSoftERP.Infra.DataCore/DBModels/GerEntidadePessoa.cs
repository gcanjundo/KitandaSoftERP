using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerEntidadePessoa
    {
        public int PesCodigo { get; set; }
        public string PesNome { get; set; }
        public string PesSobrenome { get; set; }
        public string PesSexo { get; set; }
        public string PesEstadoCivil { get; set; }
        public string PesTratamento { get; set; }
        public byte[] PesFotografia { get; set; }
        public string PesFotoExtensao { get; set; }
        public string PesFotoPath { get; set; }
        public int? PesCodigoHabilitacoes { get; set; }
        public int? PesCodigoProfissao { get; set; }
        public int? PesCodigoGrupoSanguineo { get; set; }
        public string PesNomePai { get; set; }
        public string PesNomeMae { get; set; }
        public string PesResponsavel { get; set; }
        public int? PesNaturalidade { get; set; }
        public int? PesReligiao { get; set; }
        public int? PesRaca { get; set; }

        public virtual GerGrupoSanguineo PesCodigoGrupoSanguineoNavigation { get; set; }
        public virtual GerHabilitacoes PesCodigoHabilitacoesNavigation { get; set; }
        public virtual GerEntidade PesCodigoNavigation { get; set; }
        public virtual GerProfissao PesCodigoProfissaoNavigation { get; set; }
        public virtual GerProvincia PesNaturalidadeNavigation { get; set; }
        public virtual RhFuncionario RhFuncionario { get; set; }
    }
}
