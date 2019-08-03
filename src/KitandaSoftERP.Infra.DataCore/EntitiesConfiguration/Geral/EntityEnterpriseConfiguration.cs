using KitandaSoftERP.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class EntityEnterpriseConfiguration : IEntityTypeConfiguration<EntityEnterprise>
    {
        public void Configure(EntityTypeBuilder<EntityEnterprise> builder)
        {
            
        }
    }
}
