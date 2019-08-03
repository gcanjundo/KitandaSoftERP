using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class SystemModuleConfiguration : IEntityTypeConfiguration<SystemModule>
    {
        public void Configure(EntityTypeBuilder<SystemModule> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("sysModules"); 

            builder.Property(e => e.ID)
                .HasColumnName("ModuleID")
                .HasColumnType("int(11)");

            builder.Property(e => e.ShortName) 
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Designation) 
                .HasColumnType("varchar(120)");

            builder.Property(e => e.DesignationOtherLanguage) 
                .HasColumnType("varchar(120)");

            builder.Property(e => e.Imagem) 
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Indice) 
                .HasColumnType("int(11)");

            builder.Property(e => e.Link) 
                .HasColumnType("varchar(150)");

            builder.Property(e => e.Status) 
                .HasColumnType("bit(1)");

            builder.Property(e => e.TAG) 
                .HasColumnType("int(11)");
             
            builder.Ignore(t => t.ErrorList); 
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.BranchID); 

        }
    }
}
