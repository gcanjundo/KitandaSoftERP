using KitandaSoftERP.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.itiesConfiguration.Geral
{
    public class EntityConfiguration : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("ger_entidade");

            builder.HasIndex(e => e.AddressCountryID)
                .HasName("FK_PAIS_MORADA");

            builder.HasIndex(e => e.AddressProvinceID)
                .HasName("FK_PROVINCIA_MORADA");

            builder.HasIndex(e => e.CityID)
                .HasName("FK_MUNICIPIO_MORADA");

            builder.HasIndex(e => e.DistrictCommuneID)
                .HasName("FK_DISTRITO_MORADA");

            builder.HasIndex(e => e.CitizenDocumentID)
                .HasName("FK_CITIZEN_DOCUMENT");

            builder.HasIndex(e => e.AccountGeneralPlanID)
                .HasName("FK_CITIZEN_DOCUMENT");

            builder.Property(e => e.ID)
                .HasColumnName("ENT_CODIGO")
                .HasColumnType("int(11)");  
            
            builder.Property(e => e.Designation)
                .HasColumnName("ENT_NOME_COMPLETO")
                .HasColumnType("varchar(120)").IsRequired(true);

            builder.Property(e => e.Birthday)
                .HasColumnName("ENT_DATA_NASCIMENTO")
                .HasColumnType("date");

            builder.Property(e => e.Photo).HasColumnName("ENT_FOTOGRAFIA");

            builder.Property(e => e.PhotoExtension)
                .HasColumnName("ENT_FOTOGRAFIA_EXTENSAO")
                .HasColumnType("varchar(10)");

            builder.Property(e => e.PhotoPath)
                .HasColumnName("ENT_FOTOGRAFIA_PATH")
                .HasColumnType("varchar(255)");

            builder.Property(e => e.CitizenOrFiscalDocNumber)
                .HasColumnName("ENT_IDENTIFICACAO")
                .HasColumnType("varchar(18)").IsRequired(true); 

            builder.Property(e => e.StreetName)
                .HasColumnName("ENT_RUA")
                .HasColumnType("varchar(120)"); 

            builder.Property(e => e.BuildingNumber)
                .HasColumnName("ENT_BAIRRO")
                .HasColumnType("varchar(120)"); 

            builder.Property(e => e.Telephone)
                .HasColumnName("ENT_TELEFONE")
                .HasColumnType("varchar(18)");

            builder.Property(e => e.OtherPhone)
                .HasColumnName("ENT_TELEFONE_ALTERNATIVO")
                .HasColumnType("varchar(18)");

            builder.Property(e => e.Fax)
                .HasColumnName("ENT_TELEFONE_FAX")
                .HasColumnType("varchar(18)");

            builder.Property(e => e.Mobile)
                .HasColumnName("ENT_MOBILE_PHONENUMBER")
                .HasColumnType("varchar(18)");

            builder.Property(e => e.WhatsAppNumber)
                .HasColumnName("ENT_WHATSAPP_PHONENUMBER")
                .HasColumnType("varchar(18)");

            builder.Property(e => e.Email)
                .HasColumnName("ENT_EMAIL")
                .HasColumnType("varchar(120)"); 

            builder.Property(e => e.Website)
                .HasColumnName("ENT_WEBSITE")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.Status)
                .HasColumnName("ENT_STATUS")
                .HasColumnType("bit(1)");

            builder.HasOne(d => d.AddressCountry)
                .WithMany(p => p.EntitiesCountryAddressList)
                .HasForeignKey(d => d.AddressCountryID)
                .HasConstraintName("ger_entidade_ibfk_1");

            builder.HasOne(d => d.AddressProvince)
                .WithMany(p => p.EntitiesProvincesAddressList)
                .HasForeignKey(d => d.AddressProvinceID)
                .HasConstraintName("ger_entidade_ibfk_2");

            builder.HasOne(d => d.City)
                .WithMany(p => p.EntitiesCityAddressList)
                .HasForeignKey(d => d.CityID)
                .HasConstraintName("ger_entidade_ibfk_3");

            builder.HasOne(d => d.DistrictCommune)
                .WithMany(p => p.EntitiesCommuneAddressList)
                .HasForeignKey(d => d.DistrictCommuneID)
                .HasConstraintName("ger_entidade_ibfk_4");

            builder.HasOne(d => d.CitizenDocument)
                .WithMany(p => p.EntityCitizenDocumentList)
                .HasForeignKey(d => d.CitizenDocumentID)
                .HasConstraintName("ger_entidade_ibfk_5"); 

            builder.HasOne(d => d.GeneralAccountPlan)
                .WithMany(p => p.EntitiesList)
                .HasForeignKey(d => d.AccountGeneralPlanID)
                .HasConstraintName("ger_entidade_ibfk_6");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
