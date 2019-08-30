using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class TaxTableConfiguration : IEntityTypeConfiguration<TaxTable>
    {
        public void Configure(EntityTypeBuilder<TaxTable> entity)
        {
            entity.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            entity.ToTable("ger_TaxTable");

            entity.Property(e => e.ID)
                .HasColumnName("IMP_CODIGO")
                .HasColumnType("int(11)");

            entity.Property(e => e.TaxType)
                .HasColumnName("IMP_CATEGORIA")
                .HasColumnType("varchar(5)"); 

            entity.Property(e => e.Designation)
                .HasColumnName("IMP_DESIGNATION")
                .HasColumnType("varchar(120)");

            entity.Property(e => e.DesignationOtherLanguage)
                .HasColumnName("IMP_DESIGNATION_OTHER_LANGUAGE")
                .HasColumnType("varchar(120)"); 

            entity.Property(e => e.Description)
                .HasColumnName("IMP_NOTES")
                .HasColumnType("varchar(255)");

            entity.Property(e => e.TaxCode)
                .HasColumnName("IMP_SIGLA")
                .HasColumnType("varchar(10)");

            entity.Property(e => e.Status)
                .HasColumnName("IMP_STATUS")
                .HasColumnType("bit(1)");

            entity.Property(e => e.TaxExpirationDate)
                .HasColumnName("IMP_EXPIRATION_DATE")
                .HasColumnType("date");

            entity.Property(e => e.TaxPercentage)
                .HasColumnName("IMP_PERTAGEM")
                .HasColumnType("decimal(18,2)");

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("decimal(18,2)");
             

            entity.Ignore(t => t.ErrorList);
            entity.Ignore(t => t.Description);
            entity.Ignore(t => t.BranchID);
            entity.Ignore(t => t.Notes);
        }
    }
}
