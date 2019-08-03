using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class SystemModuleConfiguration : IEntityTypeConfiguration<SystemModule>
    {
        public void Configure(EntityTypeBuilder<SystemModule> entity)
        {
            entity.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            entity.ToTable("sis_modulo"); 

            entity.Property(e => e.ID)
                .HasColumnName("mod_codigo")
                .HasColumnType("int(11)");

            entity.Property(e => e.ShortName)
                .HasColumnName("mod_abreviacao")
                .HasColumnType("varchar(50)");

            entity.Property(e => e.Designation)
                .HasColumnName("mod_descricao")
                .HasColumnType("varchar(120)");

            entity.Property(e => e.DesignationOtherLanguage)
                .HasColumnName("mod_descricaoOtherLanguage")
                .HasColumnType("varchar(120)");

            entity.Property(e => e.Imagem)
                .HasColumnName("mod_imagem")
                .HasColumnType("varchar(100)");

            entity.Property(e => e.Indice)
                .HasColumnName("mod_indice")
                .HasColumnType("int(11)");

            entity.Property(e => e.Link)
                .HasColumnName("mod_link")
                .HasColumnType("varchar(150)");

            entity.Property(e => e.Status)
                .HasColumnName("MOD_STATUS")
                .HasColumnType("bit(1)");

            entity.Property(e => e.TAG)
                .HasColumnName("mod_tag")
                .HasColumnType("int(11)");
        }
    }
}
