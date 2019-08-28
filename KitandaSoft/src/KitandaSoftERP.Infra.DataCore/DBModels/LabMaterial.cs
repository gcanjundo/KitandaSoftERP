using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class LabMaterial
    {
        public LabMaterial()
        {
            LabExameMaterial = new HashSet<LabExameMaterial>();
        }

        public int MatCodigo { get; set; }
        public string MatNome { get; set; }
        public int MatMedicao { get; set; }
        public int? MatCodigoCategoria { get; set; }

        public virtual LabCategoriaMaterial MatCodigoCategoriaNavigation { get; set; }
        public virtual ICollection<LabExameMaterial> LabExameMaterial { get; set; }
    }
}
