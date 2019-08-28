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

            builder.ToTable("sis_perfil");

            builder.HasIndex(e => e.ID)
                .HasName("sis_perfil_PK_sis_PERFIL_ndx");

            builder.Property(e => e.ID)
                .HasColumnName("per_codigo")
                .HasColumnType("int(11)"); 

            builder.Property(e => e.Description)
                .HasColumnName("per_descricao")
                .HasColumnType("varchar(255)");

            builder.Property(e => e.Email)
                .HasColumnName("per_email")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.Designation)
                .IsRequired()
                .HasColumnName("per_nome")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.DesignationOtherLanguage)
                .IsRequired()
                .HasColumnName("per_nome")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("per_status")
                .HasColumnType("bit(1)");

            builder.Property(e => e.IsSupervisorPOS)
                .HasColumnName("per_supervisor")
                .HasColumnType("bit(1)");

            builder.Ignore(t => t.ErrorList); 
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
