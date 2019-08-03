using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class LabAmostra
    {
        public LabAmostra()
        {
            LabExame = new HashSet<LabExame>();
        }

        public int AmoCodigo { get; set; }
        public string AmoDescricao { get; set; }

        public virtual ICollection<LabExame> LabExame { get; set; }
    }
}
