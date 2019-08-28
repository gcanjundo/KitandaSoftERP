using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.EntityID)
                    .HasName("PRIMARY");

            builder.ToTable("sis_utilizador");

            builder.HasIndex(e => e.EntityID)
                .HasName("uti_codigo")
                .IsUnique();

            builder.HasIndex(e => e.ProfileID)
                .HasName("FK_UTILIZADOR_PERIFL");

            builder.HasIndex(e => e.LanguageID)
               .HasName("FK_UTILIZADOR_LANGUAGE");

            builder.HasIndex(e => e.UserName)
                .HasName("sis_utilizador_UK").IsUnique(true);

            builder.Property(e => e.UserName)
                .HasColumnName("uti_utilizador")
                .IsRequired(true)
                .HasColumnType("varchar(20)");

            builder.Property(e => e.EntityID)
                .HasColumnName("uti_codigo")
                .HasColumnType("int(11)").IsRequired(true);

            builder.Property(e => e.ProfileID)
                .HasColumnName("uti_codigo_perfil")
                .HasColumnType("int(11)");

            builder.Property(e => e.LanguageID)
                .HasColumnName("uti_language_Id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Email)
                .HasColumnName("uti_email")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.AccountStatus)
                .HasColumnName("uti_estado")
                .HasColumnType("varchar(1)");

            builder.Property(e => e.AccouExpiratioDate)
                .HasColumnName("uti_expiration_date")
                .HasColumnType("date");   
            builder.Property(e => e.Password)
                .HasColumnName("uti_senha")
                .HasColumnType("varchar(200)");

            builder.Property(e => e.IsSupervisorPOS)
                .HasColumnName("uti_supervisor")
                .HasColumnType("bit(1)");

            builder.HasOne(d => d.UserProfile)
                .WithMany(p => p.UsersList)
                .HasForeignKey(d => d.ProfileID)
                .HasConstraintName("FK_USER_PROFILE");

            builder.HasOne(d => d.Entity)
                .WithOne(p => p.User)
                .HasForeignKey<Entity>(d => d.EntityID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ger_entidade_pessoa_ibfk_1");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            //builder.Ignore(t => t.Notes);
        }
    }
}
