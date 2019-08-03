using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.HuamnResources
{
    public partial class RhBeneficioCargo
    {
        public int CarBenCodigoCargo { get; set; }
        public int CarBenCodigoBeneficio { get; set; }
        public DateTime CarBenInicio { get; set; }
        public DateTime? CarBenTermino { get; set; }
    }
}
