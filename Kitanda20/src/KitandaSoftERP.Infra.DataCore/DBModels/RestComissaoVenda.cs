using System;
using System.Collections.Generic;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class RestComissaoVenda
    {
        public RestComissaoVenda()
        {
            RestFuncionarios = new HashSet<RestFuncionarios>();
        }

        public int ComCodigo { get; set; }
        public string ComDescricao { get; set; }
        public decimal ComComissao { get; set; }
        public int? ComStatus { get; set; }
        public string ComCreatedBy { get; set; }
        public DateTime? ComCreatedDate { get; set; }
        public string ComUpdatedBy { get; set; }
        public DateTime? ComUpdatedDate { get; set; }

        public virtual ICollection<RestFuncionarios> RestFuncionarios { get; set; }
    }
}
