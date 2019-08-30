using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("ger_pais");

            builder.Property(e => e.ID)
                .HasColumnName("PAI_CODIGO")
                .HasColumnType("int(11)");

            builder.Property(e => e.DailyCode)
                .HasColumnName("PAI_DAILING_CODE")
                .HasColumnType("varchar(10)"); 

            builder.Property(e => e.Designation)
                .HasColumnName("PAI_DESIGNACAO_OFICIAL").IsRequired(true)
                .HasColumnType("varchar(120)");

            builder.Property(e => e.DesignationOtherLanguage)
                .IsRequired()
                .HasColumnName("PAI_DESCRICAO")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.IsoCode3)
                .HasColumnName("PAI_ISO_CODE_3")
                .HasColumnType("varchar(10)");

            builder.Property(e => e.IsoNumeralCode)
                .HasColumnName("PAI_ISO_NUMERAL_CODE")
                .HasColumnType("varchar(10)"); 

            builder.Property(e => e.Nationality)
                .HasColumnName("PAI_NACIONALIDADE")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.ShortName)
                .HasColumnName("PAI_SIGLA")
                .HasColumnType("varchar(10)");

            builder.Property(e => e.Status)
                .HasColumnName("PAI_STATUS")
                .HasColumnType("bit(1)");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);

        }
    }
}
