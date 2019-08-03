using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.ModelConfiguration;

namespace KitandaSoftERP.Infra.Data.EntitiesConfiguration.Geral
{
    public class BusinessActivityConfiguration: IEntityTypeConfiguration<BusinessActivity>
    {
        public void Configure(EntityTypeBuilder<BusinessActivity> builder)
        {
            builder.HasKey( p=> p.ID);
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


            builder.Ignore(p => p.ErrorList);
            builder.Ignore(p => p.SocialName);
            builder.Ignore(p => p.BranchID);
            builder.Ignore(p => p.ErrorList);
            builder.Ignore(p => p.Notes);

            builder.ToTable("GER_BUSINESS_ACTIVITIES");

        }
    }
}
