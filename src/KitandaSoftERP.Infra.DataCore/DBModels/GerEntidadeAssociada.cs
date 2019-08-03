using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class GerEntidadeAssociada
    {
        public int MainEntityId { get; set; }
        public int AssociedEntityId { get; set; }
        public string AssociationType { get; set; }
    }
}
