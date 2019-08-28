using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("ger_municipio");

            builder.HasIndex(e => e.ProvinceID)
                .HasName("FK_PROVINCIA_MUNICIPIO");

            builder.Property(e => e.ID)
                .HasColumnName("MUN_CODIGO")
                .HasColumnType("int(11)");

            builder.Property(e => e.ProvinceID)
                .HasColumnName("MUN_CODIGO_PROVINCIA")
                .HasColumnType("int(11)");

            builder.Property(e => e.Designation)
                .HasColumnName("MUN_DESCRICAO")
                .HasColumnType("varchar(120)").IsRequired(true);

            builder.Property(e => e.DesignationOtherLanguage)
                .HasColumnName("MUN_OTHER_LANGUAGE")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.Status)
                .HasColumnName("MUN_STATUS")
                .HasColumnType("bit(1)");

            builder.HasOne(d => d.Province)
                .WithMany(p => p.CitiesList)
                .HasForeignKey(d => d.ProvinceID)
                .HasConstraintName("ger_municipio_ibfk_1");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
