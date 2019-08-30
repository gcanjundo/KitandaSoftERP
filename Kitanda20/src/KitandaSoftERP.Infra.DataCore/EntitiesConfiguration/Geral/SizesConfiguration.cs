using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class SizesConfiguration : IEntityTypeConfiguration<Sizes>
    {
        public void Configure(EntityTypeBuilder<Sizes> builder)
        {
            builder.HasKey(e => e.ID)
                   .HasName("PRIMARY");

            builder.ToTable("ger_Sizes");

            builder.Property(e => e.ID)
                .HasColumnName("SIZE_CODIGO")
                .HasColumnType("int(11)");

            builder.Property(e => e.Designation)
                .HasColumnName("SIZE_DESCRICAO")
                .HasColumnType("varchar(120)").IsRequired(true);

            builder.Property(e => e.DesignationOtherLanguage)
                .HasColumnName("SIZE_DESIGNATION_OTHER_LANGUAGE")
                .HasColumnType("varchar(120)").IsRequired(false);

            builder.Property(e => e.Status)
                .HasColumnName("SIZE_ESTADO")
                .HasColumnType("bit(1)");

            builder.Property(e => e.ShortName)
                .HasColumnName("SIZE_SIGLA")
                .HasColumnType("varchar(10)"); 

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
