using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class SystemPagesConfiguration : IEntityTypeConfiguration<SystemPages>
    {
        public void Configure(EntityTypeBuilder<SystemPages> entity)
        {
            entity.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            entity.ToTable("sis_formulario");

            entity.HasIndex(e => e.ID)
                .HasName("sys_formulario_PK_SYS_FORMULARIO_ndx");

            entity.HasIndex(e => e.ModuleID)
                .HasName("FK_FORMULARIO_MODULO");

            entity.Property(e => e.ID)
                .HasColumnName("form_codigo")
                .HasColumnType("int(11)");

            entity.Property(e => e.ModuleID)
                .HasColumnName("form_codigo_modulo")
                .HasColumnType("int(11)");

            entity.Property(e => e.Imagem)
                .HasColumnName("form_imagem")
                .HasColumnType("varchar(100)");

            entity.Property(e => e.Indice)
                .HasColumnName("form_indice")
                .HasColumnType("int(11)");

            entity.Property(e => e.Link)
                .HasColumnName("form_link")
                .HasColumnType("varchar(150)");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("form_nome")
                .HasColumnType("varchar(120)");

            entity.Property(e => e.Designation)
                .IsRequired()
                .HasColumnName("form_titulo")
                .HasColumnType("varchar(120)");

            entity.Property(e => e.DesignationOtherLanguage) 
                .HasColumnName("form_tituloOtherDesignation")
                .HasColumnType("varchar(120)");

            entity.Property(e => e.TAG)
                .HasColumnName("form_tag")
                .HasColumnType("int(11)"); 

            entity.HasOne(d => d.Module)
                .WithMany(p => p.PagesList)
                .HasForeignKey(d => d.ModuleID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sis_formulario_ibfk_1");
        }
    }
}
