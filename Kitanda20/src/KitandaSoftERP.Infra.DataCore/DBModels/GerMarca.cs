using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerMarca
    {
        public GerMarca()
        {
            GerArtigo = new HashSet<GerArtigo>();
            GerModelo = new HashSet<GerModelo>();
            GerViatura = new HashSet<GerViatura>();
            InverseMarRootNavigation = new HashSet<GerMarca>();
            SatViaturas = new HashSet<SatViaturas>();
        }

        public int MarCodigo { get; set; }
        public string MarDescricao { get; set; }
        public string MarSigla { get; set; }
        public string MarStatus { get; set; }
        public int? MarRoot { get; set; }

        public virtual GerMarca MarRootNavigation { get; set; }
        public virtual ICollection<GerArtigo> GerArtigo { get; set; }
        public virtual ICollection<GerModelo> GerModelo { get; set; }
        public virtual ICollection<GerViatura> GerViatura { get; set; }
        public virtual ICollection<GerMarca> InverseMarRootNavigation { get; set; }
        public virtual ICollection<SatViaturas> SatViaturas { get; set; }
    }
}
