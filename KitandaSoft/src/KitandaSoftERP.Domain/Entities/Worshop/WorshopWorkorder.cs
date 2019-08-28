using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Worshop
{
    public partial class WorshopWorkorder:BaseEntity
    {
        public WorshopWorkorder()
        {
            WorshopWorkorderAnexos = new HashSet<WorshopWorkorderAttachment>();
            WorshopWorkorderDetails = new HashSet<WorshopWorkorderDetails>();
            WorshopWorkorderNotas = new HashSet<WorshopWorkorderServiceNotes>();
            WorshopWorkorderOcorrencias = new HashSet<WorshopWorkorderOccurrences>();
        }

        public int SerieId { get; set; }
        public bool OsType { get; set; }
        public string DocumentReference { get; set; }
        public int DocumentNumber { get; set; }
        public int? TechnicianId { get; set; }
        public int? VehicleId { get; set; }
        public decimal? CarKm { get; set; }
        public int? WorkOrderStatusId { get; set; }
        public int? WorkOrderBookingId { get; set; }
        public int? CheckinTechnicianId { get; set; }
        public DateTime? CheckinDate { get; set; }
        public string DriverPeople { get; set; }
        public string DriverContact { get; set; }
        public DateTime? WorkStartDate { get; set; }
        public DateTime? WorkFinishDate { get; set; }
        public int? CheckoutTechnicianId { get; set; }
        public DateTime? CheckoutDate { get; set; } 
        public bool? Actived { get; set; } 
        public DateTime? PredictionClosing { get; set; }
        public int? InvoiceId { get; set; }
        public int? BillingEntityId { get; set; } 

        public virtual Customer BillingEntity { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Vehicle Car { get; set; }
        public virtual WorshopEmployees CheckinTechnician { get; set; }
        public virtual WorshopEmployees CheckoutTechnician { get; set; }
        public virtual SerialCommercialDocuments DocumentSerial { get; set; }
        public virtual SalesInvoice Invoice { get; set; }
        public virtual WorshopBooking Booking { get; set; } 
        public virtual WorshopEmployees Technician { get; set; }
        public virtual WorshopWorkorderChecklist WorshopWorkorderChecklist { get; set; }
        public virtual ICollection<WorshopWorkorderAttachment> WorshopWorkorderAttachmentList { get; set; }
        public virtual ICollection<WorshopWorkorderDetails> WorshopWorkorderDetailsList { get; set; }
        public virtual ICollection<WorshopWorkorderServiceNotes> WorshopWorkorderServicesNotesList { get; set; }
        public virtual ICollection<WorshopWorkorderOccurrences> WorshopWorkorderOcorrencesList { get; set; } 
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }
    }
}
