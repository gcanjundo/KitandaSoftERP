using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class SatFolhaObra
    {
        public int FolCodigo { get; set; }
        public int? FolDocumentId { get; set; }
        public int? FolSerieDocumento { get; set; }
        public string FolDocumentReference { get; set; }
        public int? FolDocumentNumber { get; set; }
        public int? FolFuncionarioIn { get; set; }
        public DateTime? FolData { get; set; }
        public DateTime? FolDataInicio { get; set; }
        public int? FolDataTermino { get; set; }
        public string FolServicoPrincipal { get; set; }
        public bool? FolStatus { get; set; }
        public string FolCreatedBy { get; set; }
        public DateTime? FolCreatedDate { get; set; }
        public string FolUpdatedBy { get; set; }
        public DateTime? FolUpdatedDate { get; set; }

        public virtual ComDocumento FolDocument { get; set; }
        public virtual RestFuncionarios FolFuncionarioInNavigation { get; set; }
        public virtual ComSerieDocumentacao FolSerieDocumentoNavigation { get; set; }
    }
}
