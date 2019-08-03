using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Worshop
{
    public partial class WorshopWorkorderAttachment
    {
        public int FileId { get; set; }
        public int OrderId { get; set; }
        public string FilePath { get; set; }
        public byte[] Phisical { get; set; }

        public virtual WorshopWorkorder Order { get; set; }
    }
}
