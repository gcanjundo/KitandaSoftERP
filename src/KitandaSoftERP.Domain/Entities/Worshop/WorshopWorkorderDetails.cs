using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Worshop
{
    public partial class WorshopWorkorderDetails
    {
        public int DetailId { get; set; }
        public int? OrderNro { get; set; }
        public int ServiceOrderId { get; set; }
        public int OrderDetailId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Subtotal { get; set; }
        public int? TechnicianId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PrevisionDate { get; set; }
        public int? ServiceStatus { get; set; }
        public string Notes { get; set; }
        public bool? Actived { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DetailWarehouseId { get; set; }
        public int? DetailWorshopLocationId { get; set; }
        public decimal? CostPrice { get; set; }
        public int? InvoiceId { get; set; }

        public virtual GerArtigo OrderDetail { get; set; }
        public virtual WorshopWorkorder ServiceOrder { get; set; }
        public virtual RestFuncionarios Technician { get; set; }
    }
}
