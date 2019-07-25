
using KitandaSoftERP.Domain.Entities.Academica;
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
            Users = new HashSet<User>();

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
        public virtual ICollection<User> Users { get; set; } 
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
