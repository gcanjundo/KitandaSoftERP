using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class ComSerieFaturacao
    {
        public int SerAno { get; set; }
        public string SerDescricao { get; set; }
        public DateTime? SerInicio { get; set; }
        public DateTime? SerTermino { get; set; }
        public bool? Deleted { get; set; }
        public bool? SerIsActive { get; set; }
    }
}
