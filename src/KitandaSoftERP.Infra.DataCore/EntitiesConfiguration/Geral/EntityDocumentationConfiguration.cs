using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class EntityDocumentationConfiguration : IEntityTypeConfiguration<EntityDocumentation>
    {
        public void Configure(EntityTypeBuilder<EntityDocumentation> builder)
        {
            builder.HasKey(e => new { e.EntityID, e.DocumentTypeID, e.DocumentCode })
                    .HasName("PRIMARY");

            builder.ToTable("ger_entidade_documentacao");

            builder.HasIndex(e => e.ID)
                .HasName("UK_ENTIDADE_DOCUMENTO")
                .IsUnique();

            builder.HasIndex(e => e.DocumentTypeID)
                .HasName("FK_ENTIDADE_DOCUMENTO_DOCUMENTO");

            builder.HasIndex(e => e.EntityID)
                .HasName("FK_ENTIDADE_ENTITY_ID");


            builder.Property(e => e.EntityID)
                .HasColumnName("ENT_DOC_CODIGO_ENTIDADE")
                .HasColumnType("int(11)");

            builder.Property(e => e.DocumentTypeID)
                .HasColumnName("ENT_DOC_CODIGO_DOCUMENTO")
                .HasColumnType("int(11)");

            builder.Property(e => e.DocumentCode)
                .HasColumnName("ENT_DOC_NUMERO")
                .HasColumnType("varchar(18)");

            builder.Property(e => e.ID)
                .HasColumnName("ENT_DOC_CODIGO")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.IssueDate)
                .HasColumnName("ENT_DOC_EMISSAO")
                .HasColumnType("date");

            builder.Property(e => e.IssueLocation)
                .HasColumnName("ENT_DOC_LOCAL_EMISSAO")
                .HasColumnType("varchar(30)");

            builder.Property(e => e.ValidateDate)
                .HasColumnName("ENT_DOC_VALIDADE")
                .HasColumnType("date");

            builder.HasOne(d => d.DocumentType)
                .WithMany(p => p.EntityDocumenationList)
                .HasForeignKey(d => d.DocumentTypeID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ger_entidade_documentacao_ibfk_1");

            builder.HasOne(d => d.Entity)
                .WithMany(p => p.EntityDocumentionList)
                .HasForeignKey(d => d.EntityID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ger_entidade_documentacao_ibfk_2");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.Designation);
            builder.Ignore(t => t.DesignationOtherLanguage);
            builder.Ignore(t => t.ShortName);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
