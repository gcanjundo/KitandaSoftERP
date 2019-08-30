using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Worshop
{
    public partial class WorshopWorkorderServiceNotes
    {
        public int NoteId { get; set; }
        public int? OrderId { get; set; }
        public string NoteCode { get; set; }
        public string NoteDescription { get; set; }
        public int? NoteAuthorId { get; set; }
        public bool? Private { get; set; }
        public string NoteCreatedBy { get; set; }
        public DateTime? NoteCreatedDate { get; set; }
        public string NoteUpdatedBy { get; set; }
        public DateTime? NoteUpdatedDate { get; set; }

        public virtual RestFuncionarios NoteAuthor { get; set; }
        public virtual WorshopWorkorder Order { get; set; }
    }
}
