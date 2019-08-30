using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerEntidadeMorada
    {
        public int EntMorEntidadeId { get; set; }
        public int? EntMorMoradaId { get; set; }
        public string EntMorMorada { get; set; }
        public int? EntMorMunicipioId { get; set; }
        public string EntMorDistrito { get; set; }
        public string EntMorTelefone { get; set; }
        public string EntMorTelefax { get; set; }

        public virtual GerEntidade EntMorEntidade { get; set; }
        public virtual GerTipoMorada EntMorMoradaNavigation { get; set; }
        public virtual GerMunicipio EntMorMunicipio { get; set; }
    }
}
