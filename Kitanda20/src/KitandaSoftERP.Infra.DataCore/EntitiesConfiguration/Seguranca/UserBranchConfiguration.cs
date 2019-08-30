using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class UserBranchConfiguration : IEntityTypeConfiguration<UserProfileBranch>
    {
        public void Configure(EntityTypeBuilder<UserProfileBranch> builder)
        {
            builder.HasKey(e => new { e.BranchID, e.UserID })
                    .HasName("PRIMARY");

            builder.ToTable("sysBranchUsers");

            builder.HasIndex(e => e.UserID)
                .HasName("FK_USER_FILIAL_USER");

            builder.HasIndex(e => e.BranchID)
                .HasName("FK_USER_FILIAL_FILIAL");

            builder.Property(e => e.BranchID) 
                .HasColumnType("int(11)");

            builder.Property(e => e.UserID) 
                .HasColumnType("int(11)");

            builder.HasOne(d => d.User)
               .WithMany(p => p.UserBranchesList)
               .HasForeignKey(d => d.UserID)
               .HasConstraintName("FK_USER");

            builder.HasOne(d => d.Branch)
               .WithMany(p => p.UserProfileBranchesList)
               .HasForeignKey(d => d.BranchID)
               .HasConstraintName("FK_USER_BRANCH");

            builder.Ignore(t => t.ProfileID);
            builder.Ignore(t => t.ID);
            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.DesignationOtherLanguage);
            builder.Ignore(t => t.Designation);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.Status);
        }
    }
}
