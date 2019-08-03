using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.ModelConfiguration;

namespace KitandaSoftERP.Infra.Data.EntitiesConfiguration.Geral
{
    public class CommuneConfiguration : IEntityTypeConfiguration<Commune>
    {
        public void Configure(EntityTypeBuilder<Commune> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Designation)
            .HasMaxLength(120)

            .IsRequired(true);
            builder.Property(p => p.DesignationOtherLanguage)
            .HasMaxLength(120)
            .IsRequired(false);

            builder.Property(p => p.Description)
            .HasMaxLength(255)
            .IsRequired(false);

            builder.Property(p => p.ShortName)
            .HasMaxLength(10)
            .IsRequired(false);

            builder.Property(p => p.Status)
            .IsRequired(true);

            builder.Property(p => p.CreatedBy)
           .HasMaxLength(50)
           .IsRequired(false);

            builder.Property(p => p.UpdatedBy)
            .HasMaxLength(50)
            .IsRequired(true);

            builder.Property(p => p.UpdatedDate)
            .IsRequired(true);

            builder.HasOne<City>(p => p.City)
           .WithMany(p => p.CommunesList)
           .HasForeignKey(p => p.CityID);


            builder.Ignore(p => p.ErrorList);
            builder.Ignore(p => p.SocialName);
            builder.Ignore(p => p.BranchID);
            builder.Ignore(p => p.ErrorList);
            builder.Ignore(p => p.Notes);

            builder.ToTable("GER_COMMUNE_DISCTRICT");

        }
    }
}
