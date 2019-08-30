using KitandaSoftERP.Domain.Entities.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Seguranca
{
    public class CurrentSessionConfiguration : IEntityTypeConfiguration<CurrentSession>
    {
        public void Configure(EntityTypeBuilder<CurrentSession> entity)
        {
            entity.HasKey(e => e.SessionID)
                    .HasName("PRIMARY");

            entity.ToTable("sysCurrentSession");
             

            entity.Property(e => e.SessionID) 
                .HasColumnType("int(11)");

            entity.Property(e => e.LoginDate).IsRequired(true);

            entity.Ignore(t => t.CurrentPassword); 
        }
    }
}
