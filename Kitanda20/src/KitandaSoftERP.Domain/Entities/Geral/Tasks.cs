using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Domain.Entities.Geral
{
    public partial class Tasks
    {
        public Tasks()
        {
            ComCobrancaDocumentos = new HashSet<ComCobrancaDocumentos>();
        }

        public int TaskId { get; set; }
        public int? TaskActividadeId { get; set; }
        public string TaskDesignation { get; set; }
        public int? TaskOwnerUserId { get; set; }
        public int? TaskExecutorId { get; set; }
        public DateTime? TaskScheduleDate { get; set; }
        public int? TaskExecutorUserId { get; set; }
        public int? TaskTargetId { get; set; }
        public int? TaskPrioridadeId { get; set; }
        public bool? TaskStatus { get; set; }
        public DateTime? TaskImplementationDate { get; set; }
        public string TaskDetails { get; set; }
        public string TaskContactPerson { get; set; }
        public string TaskContact { get; set; }
        public bool? TaskAllday { get; set; }
        public int? TaskRecurrence { get; set; }
        public DateTime? TaskEndImplementationDate { get; set; }
        public string TaskReport { get; set; }
        public string TaskInternalNotes { get; set; }
        public string TaskCreatedBy { get; set; }
        public DateTime? TaskCreatedDate { get; set; }
        public string TaskUpdatedBy { get; set; }
        public DateTime? TaskUpdatedDate { get; set; }
        public bool? TaskDeleted { get; set; }
        public string TaskDeletedBy { get; set; }
        public DateTime? TaskDeletedDate { get; set; }

        public virtual GerTipoActividade TaskActividade { get; set; }
        public virtual GerEntidade TaskExecutor { get; set; }
        public virtual GerEntidade TaskTarget { get; set; }
        public virtual ICollection<ComCobrancaDocumentos> ComCobrancaDocumentos { get; set; }
    }
}
