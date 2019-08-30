using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class MarksConfiguration : IEntityTypeConfiguration<Marks>
    {
        public void Configure(EntityTypeBuilder<Marks> builder)
        {
            builder.HasKey(e => e.ID)
                   .HasName("PRIMARY");

            builder.ToTable("ger_Marks");

            builder.HasIndex(e => e.ModelMarkID)
                    .HasName("FK_MODEL_MARK");

            builder.Property(e => e.ID)
                .HasColumnName("MAR_CODIGO")
                .HasColumnType("int(11)");

            builder.Property(e => e.Designation)
                .IsRequired()
                .HasColumnName("MAR_DESCRICAO")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.DesignationOtherLanguage)
                .IsRequired()
                .HasColumnName("MAR_DESCRICAO_OTHER_LANGUAGE")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.ModelMarkID)
                .HasColumnName("MAR_MODEL_MARK_ID")
                .HasColumnType("int(11)");

            builder.Property(e => e.ShortName)
                .HasColumnName("MAR_SIGLA")
                .HasColumnType("varchar(10)");

            builder.Property(e => e.Status)
                .HasColumnName("MAR_STATUS")
                .HasColumnType("bit(1)");

            builder.HasOne(d => d.ModelMark)
                .WithMany(p => p.ModelMarkList)
                .HasForeignKey(d => d.ModelMarkID)
                .HasConstraintName("ger_marca_ibfk_1");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
