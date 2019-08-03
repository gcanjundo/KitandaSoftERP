using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Stock
{
    public partial class StockInventory:BaseEntity
    {
        
        public int WarehouseID { get; set; } 
        public DateTime InventoryStartDate { get; set; } 
        public DateTime InventoryClosingDate { get; set; }
        public int TechnicianID { get; set; }   
        public virtual Warehouse Warehouse { get; set; }
        //public virtual Employee Technician { get; set; }
        public virtual ICollection<StockInventoryItems> StockInventoryItemsList { get; set; }

        public StockInventory()
        {
            Warehouse = new Warehouse();
            StockInventoryItemsList = new HashSet<StockInventoryItems>();
            // Technician = new Employee();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
