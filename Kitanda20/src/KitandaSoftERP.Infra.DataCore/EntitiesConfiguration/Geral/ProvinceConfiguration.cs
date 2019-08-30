using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasKey(e => e.ID)
                  .HasName("PRIMARY");

            builder.ToTable("ger_provincia");

            builder.HasIndex(e => e.CountryID)
                .HasName("FK_PAIS_PROVINCIA");

            builder.Property(e => e.ID)
                .HasColumnName("PROV_CODIGO")
                .HasColumnType("int(11)");

            builder.Property(e => e.CountryID)
                .HasColumnName("PROV_CODIGO_PAIS")
                .HasColumnType("int(11)");

            builder.Property(e => e.Designation)
                .IsRequired()
                .HasColumnName("PROV_DESCRICAO")
                .HasColumnType("varchar(120)").IsRequired(true);

            builder.Property(e => e.DesignationOtherLanguage)
                .IsRequired()
                .HasColumnName("PROV_OTHER_LANGUAGE")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.IsoCode2)
                .HasColumnName("PROV_ISO_CODE")
                .HasColumnType("varchar(10)");

            builder.Property(e => e.IsoCode2)
                .HasColumnName("PROV_SHORTNAME")
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Status)
                .HasColumnName("PROV_STATUS")
                .HasColumnType("bit(1)");

            builder.HasOne(d => d.Country)
                .WithMany(p => p.ProvincesList)
                .HasForeignKey(d => d.ID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ger_provincia_ibfk_1");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
