using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class CommuneConfiguration : IEntityTypeConfiguration<Commune>
    {
        public void Configure(EntityTypeBuilder<Commune> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("ger_distritos");

            builder.HasIndex(e => e.DistrictCommuneID)
                .HasName("FK_DISTRITO_COMUNA");

            builder.HasIndex(e => e.CityID)
                .HasName("FK_DISTRITO_MUNICIPIO");

            builder.Property(e => e.ID)
                .HasColumnName("DIST_CODIGO")
                .HasColumnType("int(11)");

            builder.Property(e => e.DistrictCommuneID)
                .HasColumnName("DIST_COMUNA_ID")
                .HasColumnType("int(11)"); 
            
            builder.Property(e => e.Designation)
                .HasColumnName("DIST_DESCRICAO")
                .HasColumnType("varchar(120)").IsRequired(true); 

            builder.Property(e => e.CityID)
                .HasColumnName("DIST_MUNICIPIO_ID")
                .HasColumnType("int(11)");

            builder.Property(e => e.ShortName)
                .HasColumnName("DIST_SIGLA")
                .HasColumnType("varchar(10)");  

            builder.HasOne(d => d.DistrictCommune)
                .WithMany(p => p.DistrictCommuneList)
                .HasForeignKey(d => d.DistrictCommuneID)
                .HasConstraintName("FK_DISTRITO_COMUNA");

            builder.HasOne(d => d.City)
                .WithMany(p => p.CommunesDisctrictsList)
                .HasForeignKey(d => d.CityID)
                .HasConstraintName("FK_DISTRITO_MUNICIPIO");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
