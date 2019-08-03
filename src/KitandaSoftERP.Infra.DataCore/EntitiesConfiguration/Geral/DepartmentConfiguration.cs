using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(e => e.ID)
                   .HasName("PRIMARY");

            builder.ToTable("ger_Department");

            builder.Property(e => e.ID)
                .HasColumnName("CODIGO")
                .HasColumnType("int(11)");

            builder.Property(e => e.Designation)
                .HasColumnName("DESCRICAO")
                .HasColumnType("varchar(120)").IsRequired(true);

            builder.Property(e => e.DesignationOtherLanguage)
                .HasColumnName("DESIGNATION_OTHER_LANGUAGE")
                .HasColumnType("varchar(120)").IsRequired(false);

            builder.Property(e => e.Status)
                .HasColumnName("ESTADO")
                .HasColumnType("bit(1)");

            builder.Property(e => e.ShortName)
                .HasColumnName("SIGLA")
                .HasColumnType("varchar(10)"); 

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
