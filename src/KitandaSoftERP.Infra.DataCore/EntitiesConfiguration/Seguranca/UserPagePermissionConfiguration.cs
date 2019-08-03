using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class UserPagePermissionConfiguration : IEntityTypeConfiguration<UserProfilePermission>
    {
        public void Configure(EntityTypeBuilder<UserProfilePermission> builder)
        {
            builder.HasKey(e => new { e.PageID, e.UserID })
                    .HasName("PRIMARY");

            builder.ToTable("sysUserPagesPermissions"); 
             

            builder.Property(e => e.Permission.AllowFullAccess)
                .HasColumnName("FullAccess").IsRequired(true)
                .HasColumnType("bit(1)");

            builder.Property(e => e.Permission.AllowInsert)
                .HasColumnName("AllowedInsert").IsRequired(true)
                .HasColumnType("bit(1)");

            builder.Property(e => e.Permission.AllowSelect)
                .HasColumnName("AllowedSearch").IsRequired(true)
                .HasColumnType("bit(1)");

            builder.Property(e => e.Permission.AllowDelete)
                .HasColumnName("AllowedDelete").IsRequired(true)
                .HasColumnType("bit(1)");

            builder.Property(e => e.Permission.AllowPrint)
                .HasColumnName("AllowedPrint").IsRequired(true)
                .HasColumnType("bit(1)");

            builder.Property(e => e.Permission.AllowUpdate)
                .HasColumnName("AllowedUpdate").IsRequired(true)
                .HasColumnType("bit(1)");

            builder.HasOne(d => d.User)
               .WithMany(p => p.UserPermissionsList)
               .HasForeignKey(d => d.UserID)
               .HasConstraintName("FK_USER_PERMISSION");

            builder.HasOne(d => d.Page)
               .WithMany(p => p.UserPermissionsList)
               .HasForeignKey(d => d.PageID)
               .HasConstraintName("FK_USER_PAGE_PERMISSION");

            builder.Ignore(t => t.ID);
            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.Designation);
            builder.Ignore(t => t.DesignationOtherLanguage);
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.ShortName);
            builder.Ignore(t => t.ProfileID);
        }
    }
}
