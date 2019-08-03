using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public partial class ProfileBranchConfiguration : IEntityTypeConfiguration<UserProfileBranch>
    {
        public void Configure(EntityTypeBuilder<UserProfileBranch> builder)
        {
            builder.HasKey(e => new { e.BranchID, e.ProfileID })
                    .HasName("PRIMARY");

            builder.ToTable("SysBranchProfiles");

            builder.HasIndex(e => e.ProfileID)
                .HasName("FK_PERFIL_FILIAL_PERFIL");

            builder.HasIndex(e => e.BranchID)
                .HasName("FK_PERFIL_FILIAL_FILIAL");

            builder.Property(e => e.BranchID) 
                .HasColumnType("int(11)");

            builder.Property(e => e.ProfileID) 
                .HasColumnType("int(11)");

            builder.HasOne(d => d.Profile)
               .WithMany(p => p.ProfileBranchsList)
               .HasForeignKey(d => d.ProfileID)
               .HasConstraintName("FK_PROFILE");

            builder.HasOne(d => d.Branch)
               .WithMany(p => p.UserProfileBranchesList)
               .HasForeignKey(d => d.BranchID)
               .HasConstraintName("FK_BRANCH");

            builder.Ignore(t => t.UserID);
            builder.Ignore(t => t.ErrorList); 
            builder.Ignore(t => t.DesignationOtherLanguage);
            builder.Ignore(t => t.Designation);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.Status);
        }
    }
}
