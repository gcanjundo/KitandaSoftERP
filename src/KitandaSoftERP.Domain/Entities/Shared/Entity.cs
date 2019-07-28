
using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Contabilidade;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Shared.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Shared
{
    public class Entity:BaseEntity
    {
        public Entity()
        {
            Address = new Address();
            EmailAddress = new Email();
            UsersList = new HashSet<User>();
            GeneralAccountPlan = new GeneralAccountPlan();

        }
        public int EntityID { get; set; }
        public string SearchName { get; set; }
        public DateTime BirthDay { get; set; } 
        public Address Address { get; set; }
        public Email EmailAddress { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string OtherPhone { get; set; }
        public string Fax { get; set; }
        public string WhatsAppNumber { get; set; }
        public string PhotoPath { get; set; }
        public byte[] Photo { get; set; }
        public int AccountGeneralPlanID { get; set; }
        public virtual ICollection<User> UsersList { get; set; }
        public virtual ICollection<Product> ExternalEntityList { get; set; }
        public virtual EntityPerson EntityPerson { get; set; }
        public virtual EntityEnterprise EntityEnterprise { get; set; }
        public virtual GeneralAccountPlan GeneralAccountPlan { get; set; }
        public override bool IsValid()
        {
            return !ErrorList.Any();
        }

        protected void ConfirmaValidacaoEmail()
        {
            if (!EmailAddress.IsValidEmailAddress(EmailAddress.AddressEmail)) ErrorList.Add(string.Format("O E-mail informado é inválido"));
        }

    }
}
