using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerPais
    {
        public GerPais()
        {
            GerEntidadeEntCodigoPaisNavigation = new HashSet<GerEntidade>();
            GerEntidadeEntNacionalidadeNavigation = new HashSet<GerEntidade>();
            GerProvincia = new HashSet<GerProvincia>();
        }

        public int PaiCodigo { get; set; }
        public string PaiDescricao { get; set; }
        public string PaiNacionalidade { get; set; }
        public string PaiStatus { get; set; }
        public string PaiSigla { get; set; }
        public int? PaiMoeda { get; set; }
        public string PaiIsoCode3 { get; set; }
        public string PaiDailingCode { get; set; }
        public string PaiIsoNumeralCode { get; set; }
        public string PaiDesignacaoOficial { get; set; }

        public virtual ICollection<GerEntidade> GerEntidadeEntCodigoPaisNavigation { get; set; }
        public virtual ICollection<GerEntidade> GerEntidadeEntNacionalidadeNavigation { get; set; }
        public virtual ICollection<GerProvincia> GerProvincia { get; set; }
    }
}
