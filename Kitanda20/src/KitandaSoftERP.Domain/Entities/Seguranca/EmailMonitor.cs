using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Shared.ValueObject;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Seguranca
{
    public class EmailMonitor: BaseEntity
    {
          
        public string Remetente { get; set; }
        public Email Endereco { get; set; }
        public string Servidor { get; set; }
        public string UserName { get; set; }
        public string Porta { get; set; } 
        public bool AtivaSSL { get; set; }
        public virtual Branch Branch { get; set; }

        public EmailMonitor()
        {
            Branch = new Branch();
        }
        public override bool IsValid()
        {
            if (!Endereco.IsValidEmailAddress(Endereco.AddressEmail))
                ErrorList.Add("Enderço de Email Inválido");

            return !ErrorList.Any();
        }
    }
}
