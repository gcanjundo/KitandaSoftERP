using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerProvincia
    {
        public GerProvincia()
        {
            GerEntidadePessoa = new HashSet<GerEntidadePessoa>();
            GerMunicipio = new HashSet<GerMunicipio>();
        }

        public int ProvCodigo { get; set; }
        public int ProvCodigoPais { get; set; }
        public string ProvDescricao { get; set; }
        public bool? ProvStatus { get; set; }
        public string ProvIsoCode { get; set; }

        public virtual GerPais ProvCodigoPaisNavigation { get; set; }
        public virtual ICollection<GerEntidadePessoa> GerEntidadePessoa { get; set; }
        public virtual ICollection<GerMunicipio> GerMunicipio { get; set; }
    }
}
