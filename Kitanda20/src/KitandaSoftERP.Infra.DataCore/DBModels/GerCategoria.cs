using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerCategoria
    {
        public GerCategoria()
        {
            CliCategoriaAcomodacoes = new HashSet<CliCategoriaAcomodacoes>();
            GerArtigo = new HashSet<GerArtigo>();
            GerSubCategoria = new HashSet<GerSubCategoria>();
        }

        public int CatCodigo { get; set; }
        public string CatDescricao { get; set; }
        public string CatSigla { get; set; }
        public string CatStatus { get; set; }
        public int? CatCategoria { get; set; }
        public string CatImagem { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CliCategoriaAcomodacoes> CliCategoriaAcomodacoes { get; set; }
        public virtual ICollection<GerArtigo> GerArtigo { get; set; }
        public virtual ICollection<GerSubCategoria> GerSubCategoria { get; set; }
    }
}
