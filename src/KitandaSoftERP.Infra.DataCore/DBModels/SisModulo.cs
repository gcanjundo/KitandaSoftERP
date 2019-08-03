using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SisModulo
    {
        public SisModulo()
        {
            SisFormulario = new HashSet<SisFormulario>();
        }

        public int ModCodigo { get; set; }
        public string ModDescricao { get; set; }
        public string ModAbreviacao { get; set; }
        public string ModLink { get; set; }
        public int? ModTag { get; set; }
        public int? ModIndice { get; set; }
        public string ModImagem { get; set; }
        public bool? ModStatus { get; set; }

        public virtual ICollection<SisFormulario> SisFormulario { get; set; }
    }
}
