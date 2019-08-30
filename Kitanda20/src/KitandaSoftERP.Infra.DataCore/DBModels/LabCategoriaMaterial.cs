using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class LabCategoriaMaterial
    {
        public LabCategoriaMaterial()
        {
            LabMaterial = new HashSet<LabMaterial>();
        }

        public int CatCodigo { get; set; }
        public string CatDescricao { get; set; }

        public virtual ICollection<LabMaterial> LabMaterial { get; set; }
    }
}
