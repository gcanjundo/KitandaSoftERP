using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerDocumento
    {
        public GerDocumento()
        {
            GerEntidadeDocumentacao = new HashSet<GerEntidadeDocumentacao>();
        }

        public int DocCodigo { get; set; }
        public string DocDescricao { get; set; }
        public string DocSigla { get; set; }
        public string DocEstado { get; set; }
        public string DocTipo { get; set; }

        public virtual ICollection<GerEntidadeDocumentacao> GerEntidadeDocumentacao { get; set; }
    }
}
