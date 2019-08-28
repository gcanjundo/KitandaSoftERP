using KitandaSoftERP.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.Data.EntitiesConfiguration.Geral
{
    public class EntityConfiguration: IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Designation)
            .HasMaxLength(120)
            .IsRequired(true);

            builder.Property(p => p.DesignationOtherLanguage)
            .HasMaxLength(120)
            .IsRequired(false);

            builder.Property(p => p.SearchName)
            .HasMaxLength(50)
            .IsRequired(false);

            builder.OwnsOne(p => p.Address, address =>
            {
                 address.Property(t => t.BuildingNumber)
                .HasMaxLength(50);

                 address.Property(t => t.StreetName)
                .HasMaxLength(50);

                 address.Property(t => t.BuildingNumber)
                .HasMaxLength(120)
                .IsRequired(true); 

                 address.Property(t => t.PostalCode)
                .HasMaxLength(10);

                 address.Ignore(t => t.Province);
                 address.Ignore(t => t.Country);
             }
            );

            builder.OwnsOne(p => p.EmailAddress, email => email.Property(t => t.AddressEmail).HasMaxLength(120));
            builder.Property(p => p.Website).HasMaxLength(120);
            builder.Property(p => p.Photo).HasColumnName("Picture_Logo").HasColumnType("longblob");

            builder.Ignore(t => t.SocialName);
            builder.Ignore(t => t.DesignationOtherLanguage);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.ErrorList);
        }

    }
}
