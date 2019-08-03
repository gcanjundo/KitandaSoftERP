using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserName)
                    .HasName("PRIMARY");

            builder.ToTable("sysUsers");

            builder.HasIndex(e => e.EntityID)
                .HasName("UK_USER_ID")
                .IsUnique();

            builder.HasIndex(e => e.ProfileID)
                .HasName("FK_UTILIZADOR_PERIFL");

            builder.HasIndex(e => e.LanguageID)
               .HasName("FK_UTILIZADOR_LANGUAGE");  

            builder.Property(e => e.UserName) 
                .IsRequired(true)
                .HasColumnType("varchar(120)");

            builder.Property(e => e.EntityID)
                .HasColumnName("EntityID")
                .HasColumnType("int(11)").IsRequired(true);

            builder.Property(e => e.ProfileID) 
                .HasColumnType("int(11)");

            builder.Property(e => e.LanguageID) 
                .HasColumnType("int(11)"); 

            builder.Property(e => e.AccountStatus) 
                .HasColumnType("varchar(1)");

            builder.Property(e => e.AccouExpiratioDate) 
                .HasColumnType("date");   

            builder.Property(e => e.Password) 
                .HasColumnType("varchar(200)");

            builder.Property(e => e.IsSupervisorPOS) 
                .HasColumnType("bit(1)");

            builder.HasOne(d => d.UserProfile)
                .WithMany(p => p.UsersList)
                .HasForeignKey(d => d.ProfileID)
                .HasConstraintName("FK_USER_PROFILE");

            builder.HasOne(d => d.Entity)
                .WithOne(p => p.User)
                .HasForeignKey<Entity>(d => d.EntityID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ger_entidade_pessoa_ibfk_1");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.ID); 
            builder.Ignore(t => t.Email); 
            builder.Ignore(t => t.DesignationOtherLanguage);
            builder.Ignore(t => t.AddressDetail);
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
