using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class SystemPagesConfiguration : IEntityTypeConfiguration<SystemPages>
    {
        public void Configure(EntityTypeBuilder<SystemPages> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("sysModulesPages");

            
            builder.HasIndex(e => e.ModuleID)
                .HasName("FK_FORMULARIO_MODULO");

            builder.Property(e => e.ID)
                .HasColumnName("FormID")
                .HasColumnType("int(11)");

            builder.Property(e => e.ModuleID) 
                .HasColumnType("int(11)");

            builder.Property(e => e.Imagem) 
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Indice) 
                .HasColumnType("int(11)");

            builder.Property(e => e.Link) 
                .HasColumnType("varchar(150)");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("FormName")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.Designation)
                .IsRequired()
                .HasColumnName("FormTitle")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.DesignationOtherLanguage) 
                .HasColumnName("FormTitleOtherDesignation")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.TAG) 
                .HasColumnType("int(11)");

            builder.Property(e => e.Status)
                .HasColumnType("bit(1)");

            builder.HasOne(d => d.Module)
                .WithMany(p => p.PagesList)
                .HasForeignKey(d => d.ModuleID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sis_formulario_ibfk_1");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.BranchID); 
            builder.Ignore(t => t.ShortName);
        }
    }
}
