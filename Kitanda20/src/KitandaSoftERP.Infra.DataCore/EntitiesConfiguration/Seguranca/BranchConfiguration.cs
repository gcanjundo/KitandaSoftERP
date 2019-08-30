using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("SysBranchs");

            builder.HasIndex(e => e.CompanyID)
                .HasName("FK_BRANCH_COMPANY_ID");

            builder.Property(e => e.ID)
                .HasColumnName("BranchID")
                .HasColumnType("int(11)"); 

            builder.Property(e => e.EnterpriseID)
                .HasColumnName("EntityEnterpriseID")
                .HasColumnType("int(11)"); 

            builder.Property(e => e.CompanyID) 
                .HasColumnType("int(11)");

            builder.Property(e => e.CommercialName)
                .HasColumnType("varchar(120)");

            builder.Property(e => e.SocialCapital)
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.Conservatoria) 
                .HasColumnType("varchar(120)");

            builder.Property(e => e.NaturezaJuridica) 
                .HasColumnType("varchar(255)"); 

            builder.Property(e => e.EnterpriseCommericalRegistration) 
                .HasColumnType("varchar(20)");

            builder.Property(e => e.ShortName) 
                .HasColumnType("varchar(5)");

            builder.Property(e => e.TaxGroup) 
                .HasColumnType("varchar(5)");

            builder.Property(e => e.SoftwareDesignation) 
                .HasColumnType("varchar(255)");

            builder.Property(e => e.SoftwareNIF) 
                .HasColumnType("varchar(20)");

            builder.Property(e => e.SoftwareProductVersion) 
                .HasColumnType("varchar(30)");

            builder.Property(e => e.SoftwareValidationId) 
                .HasColumnType("int(11)");

            builder.Property(e => e.Status) 
                .HasColumnType("bit(1)");

            builder.HasOne(d => d.EntityEnterprise)
                .WithOne(p => p.Branch)
                .HasForeignKey<Branch>(d => d.ID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sis_empresa_ibfk_1");

            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.DesignationOtherLanguage); 
            builder.Ignore(t => t.AccountGeneralPlanID);
            builder.Ignore(t => t.Description); 
            builder.Ignore(t => t.AddressCountryID);
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.AddressDetail); 
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
            builder.Ignore(t => t.Description);

        }
    }
}
