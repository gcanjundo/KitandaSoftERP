using KitandaSoftERP.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class EntityEnterpriseConfiguration : IEntityTypeConfiguration<EntityEnterprise>
    {
        public void Configure(EntityTypeBuilder<EntityEnterprise> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("ger_entidade_empresas");

            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.DesignationOtherLanguage);
            builder.Ignore(t => t.AddressDetail); 
            builder.Ignore(t => t.AccountGeneralPlanID);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.AddressCountry);
            builder.Ignore(t => t.AddressCountryID);
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.AddressDetail);
            builder.Ignore(t => t.AddressProvince);
            builder.Ignore(t => t.AddressProvinceID);
            builder.Ignore(t => t.Birthday);
            builder.Ignore(t => t.BuildingNumber);
            builder.Ignore(t => t.CitizenDocumentID);
            builder.Ignore(t => t.CitizenOrFiscalDocNumber);
            builder.Ignore(t => t.CityID);
            builder.Ignore(t => t.DistrictCommuneID);
            builder.Ignore(t => t.Email);
            builder.Ignore(t => t.EnterpriseBusinessActivityID);
            builder.Ignore(t => t.EntityID);
            builder.Ignore(t => t.Fax);
            builder.Ignore(t => t.Mobile);
            builder.Ignore(t => t.OtherPhone);
            builder.Ignore(t => t.Photo);
            builder.Ignore(t => t.PhotoExtension);
            builder.Ignore(t => t.PhotoPath);
            builder.Ignore(t => t.PostalCode);
            builder.Ignore(t => t.SearchName);
            builder.Ignore(t => t.SocialName);
            builder.Ignore(t => t.StreetName);
            builder.Ignore(t => t.TaxRegistrationNumber);
            builder.Ignore(t => t.Telephone);
            builder.Ignore(t => t.Website);
            builder.Ignore(t => t.WhatsAppNumber);
        }
    }
}
