using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("sysProfiles");
             

            builder.Property(e => e.ID)
                .HasColumnName("ProfileID")
                .HasColumnType("int(11)"); 

            builder.Property(e => e.Description) 
                .HasColumnType("varchar(255)");

            builder.Property(e => e.Email) 
                .HasColumnType("varchar(120)");

            builder.Property(e => e.Designation)
                .IsRequired() 
                .HasColumnType("varchar(120)");

            builder.Property(e => e.DesignationOtherLanguage)  
                .HasColumnType("varchar(120)");

            builder.Property(e => e.Status) 
                .HasColumnType("bit(1)");

            builder.Property(e => e.IsSupervisorPOS) 
                .HasColumnType("bit(1)");

            builder.Ignore(t => t.ErrorList); 
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
