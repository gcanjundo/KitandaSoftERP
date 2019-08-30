
using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Contabilidade;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Shared.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KitandaSoftERP.Domain.Entities.Shared
{
    public class Entity:BaseEntity
    {    
        public int EntityID { get; set; }
        public string SearchName { get; set; }
        public DateTime Birthday { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string AddressDetail { get; set; }
        public  int? CityID { get; set; }
        public int? DistrictCommuneID { get; set; }
        public string PostalCode { get; set; }
        public int? AddressProvinceID { get; set; }
        public int? AddressCountryID { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string OtherPhone { get; set; }
        public string Fax { get; set; }
        public string WhatsAppNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string PhotoPath { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoExtension { get; set; }
        public int CitizenDocumentID { get; set; }
        public string CitizenOrFiscalDocNumber { get; set; }
        public int? AccountGeneralPlanID { get; set; }
        public virtual GeneralAccountPlan GeneralAccountPlan { get; set; }
        public virtual Country AddressCountry { get; set; }
        public virtual Province AddressProvince { get; set; }
        public virtual City City { get; set; }
        public virtual Commune DistrictCommune { get; set; }
        public virtual EntityPerson EntityPerson { get; set; }
        public virtual CitizenDocument CitizenDocument { get; set; }
        public virtual EntityEnterprise EntityEnterprise { get; set; }  
        public virtual User User { get; set; }
        public virtual ICollection<Product> ExternalEntityList { get; set; }
        public virtual ICollection<EntityDocumentation> EntityDocumentionList { get; set; }
        public virtual ICollection<Vehicle> VehiclesList { get; set; }
        public Entity()
        {
            AddressCountry = new Country();
            AddressProvince = new Province();
            City = new City();
            DistrictCommune = new Commune(); 
            User = new User();
            GeneralAccountPlan = new GeneralAccountPlan();
            EntityDocumentionList = new HashSet<EntityDocumentation>();
            CitizenDocument = new CitizenDocument();
            VehiclesList = new HashSet<Vehicle>(); 
        }

        public override bool IsValid()
        {
            return !ErrorList.Any();
        }

        protected bool IsValidEmailAddress(string pEmail)
        {
            if (!string.IsNullOrEmpty(pEmail))
            {
                return CheckEmailValidation(pEmail);
            }
            else
            {
                return true;
            }
        }

        protected bool CheckEmailValidation(string pEmail)
        {
            bool isValid = false;
            int indexArr = pEmail.IndexOf("@");
            if (indexArr > 0)
            {
                int indexDot = pEmail.LastIndexOf('.', indexArr);
                if (indexDot - 1 > indexArr)
                {
                    if (indexDot + 1 < pEmail.Length)
                    {
                        string indexDot2 = pEmail.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                        {
                            isValid = true;
                        }
                    }
                }
            }

            return isValid;
        }

        protected void ConfirmaValidacaoEmail()
        {
            if (!IsValidEmailAddress(Email)) ErrorList.Add(string.Format("O E-mail informado é inválido"));
        } 

    }
}
