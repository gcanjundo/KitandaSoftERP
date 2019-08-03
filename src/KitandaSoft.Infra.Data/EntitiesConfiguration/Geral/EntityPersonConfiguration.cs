using KitandaSoftERP.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitandaSoftERP.Infra.Data.EntitiesConfiguration.Geral
{
    public class EntityPersonConfiguration : IEntityTypeConfiguration<EntityPerson>
    {
        public void Configure(EntityTypeBuilder<EntityPerson> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.FirstName)
            .HasMaxLength(50)
            .IsRequired(true);

            builder.Property(p => p.MiddleName)
            .HasMaxLength(100)
            .IsRequired(false);

            builder.Property(p => p.LastName)
            .HasMaxLength(50)
            .IsRequired(true);

            builder.Property(p => p.NickName)
            .HasMaxLength(50)
            .IsRequired(false);

            builder.Property(p => p.Gender)
            .HasMaxLength(1)
            .IsRequired(true);

            builder.Property(p => p.CivilState)
            .HasMaxLength(1)
            .IsRequired(false);

            builder.Ignore(t => t.SearchName);
            builder.Ignore(t => t.Birthday);
            builder.Ignore(t => t.TaxRegistrationNumber);
            builder.Ignore(t => t.Address);
            builder.Ignore(t => t.EmailAddress);
            builder.Ignore(t => t.Telephone);
            builder.Ignore(t => t.OtherPhone);
            builder.Ignore(t => t.Fax);
            builder.Ignore(t => t.Mobile);
            builder.Ignore(t => t.WhatsAppNumber);
            builder.Ignore(t => t.Website);
            builder.Ignore(t => t.PhotoPath);
            builder.Ignore(t => t.Photo);
            builder.Ignore(t => t.SocialName);
            builder.Ignore(t => t.DesignationOtherLanguage);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.Status);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.AccountGeneralPlanID);
            builder.Ignore(t => t.ErrorList);
        }
    }
}
