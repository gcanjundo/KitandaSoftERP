using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Worshop;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public partial class Vehicle:BaseEntity
    {
         
        public string ChassiNumber { get; set; }
        public string EngineNumber { get; set; }
        public int MarkID { get; set; }
        public int FuelID { get; set; }
        public int VehicleCategoryID { get; set; }
        public decimal? Cylinders { get; set; }
        public int? VehicleColorId { get; set; }
        public string PathImage { get; set; }
        public byte VehicleImage { get; set; } 
        public string GearBox { get; set; } 
        public int? CylindersNumber { get; set; }
        public string Pneumatic { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Tara { get; set; }
        public decimal? Eixos { get; set; }
        public int? DoorNumber { get; set; }
        public int? ManufactureYear { get; set; }
        public string VehicleType { get; set; }
        public int OwnerId { get; set; }
        public string LicenseId { get; set; }
        public DateTime? LastIntervention { get; set; }
        public DateTime? NextIntervention { get; set; }
        public string Valves { get; set; } 
        public virtual VehicleCategory VehicleCategory { get; set; }
        public virtual Colors VehicleColor { get; set; }
        public virtual Marks Mark { get; set; }
        public virtual Entity Owner { get; set; }
        public virtual ICollection<WorshopBooking> WorshopBookingList { get; set; }
        public virtual ICollection<WorshopWorkorder> WorkOrderList { get; set; }
        

        public Vehicle()
        {
            WorshopBookingList = new HashSet<WorshopBooking>();
            WorkOrderList = new HashSet<WorshopWorkorder>();
            VehicleCategory = new VehicleCategory();
            VehicleColor = new Colors();
            Mark = new Marks();
            Owner = new Customer();
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
