using KitandaSoftERP.Domain.Entities.Geral;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("ger_viatura");

            builder.HasIndex(e => e.VehicleCategoryID)
                .HasName("FK_VIATURA_CATEGORIA_ID");

            builder.HasIndex(e => e.FuelID)
                .HasName("FK_VIATURA_COMBUSTIVEL_ID");

            builder.HasIndex(e => e.VehicleColorId)
                .HasName("FK_VIATURA_COR_ID");

            builder.HasIndex(e => e.LicenseId)
                .HasName("UK_LICENSE_ID")
                .IsUnique();

            builder.HasIndex(e => e.MarkID)
                .HasName("FK_VIATURA_MARCA_ID");

            builder.HasIndex(e => e.OwnerId)
                .HasName("FK_VIATURA_OWNER");

            builder.Property(e => e.ID)
                .HasColumnName("VIA_CODIGO")
                .HasColumnType("int(11)");

            builder.Property(e => e.NextIntervention)
                .HasColumnName("NEXT_INTERVENTION")
                .HasColumnType("datetime");

            builder.Property(e => e.ManufactureYear)
                .HasColumnName("VIA_ANO")
                .HasColumnType("int(11)");

            builder.Property(e => e.GearBox)
                .HasColumnName("VIA_CAIXA")
                .HasColumnType("varchar(1)");

            builder.Property(e => e.VehicleCategoryID)
                .HasColumnName("VIA_CATEGORY_ID")
                .HasColumnType("int(11)");

            builder.Property(e => e.ChassiNumber)
                .HasColumnName("VIA_CHASSI_NUMBER")
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Cylinders)
                .HasColumnName("VIA_CILINDRADA")
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.CylindersNumber)
                .HasColumnName("VIA_CILINDROS")
                .HasColumnType("int(11)");

            builder.Property(e => e.VehicleType)
                .HasColumnName("VIA_CLASSE")
                .HasColumnType("varchar(1)");

            builder.Property(e => e.FuelID)
                .HasColumnName("VIA_COMBUSTIVEL")
                .HasColumnType("int(11)");

            builder.Property(e => e.VehicleColorId)
                .HasColumnName("VIA_COR_ID")
                .HasColumnType("int(11)"); 

            builder.Property(e => e.Designation)
                .HasColumnName("VIA_DESIGNATION")
                .HasColumnType("varchar(120)");

            builder.Property(e => e.Eixos)
                .HasColumnName("VIA_EIXOS")
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.LastIntervention)
                .HasColumnName("VIA_LAST_INTERVENTION")
                .HasColumnType("datetime");

            builder.Property(e => e.LicenseId)
                .HasColumnName("VIA_LICENSE_ID")
                .HasColumnType("varchar(20)");

            builder.Property(e => e.MarkID)
                .HasColumnName("VIA_MARCA_ID")
                .HasColumnType("int(11)");

            builder.Property(e => e.EngineNumber)
                .HasColumnName("VIA_MOTOR_NUMBER")
                .HasColumnType("varchar(50)");

            builder.Property(e => e.OwnerId)
                .HasColumnName("VIA_OWNER_ID")
                .HasColumnType("int(11)");

            builder.Property(e => e.PathImage)
                .HasColumnName("VIA_PATH_IMAGE")
                .HasColumnType("varchar(255)");

            builder.Property(e => e.Weight)
                .HasColumnName("VIA_PESO")
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.Pneumatic)
                .HasColumnName("VIA_PNEUMATICOS")
                .HasColumnType("varchar(12)");

            builder.Property(e => e.DoorNumber)
                .HasColumnName("VIA_PORTAS")
                .HasColumnType("int(11)");
             
            builder.Property(e => e.Tara)
                .HasColumnName("VIA_TARA")
                .HasColumnType("decimal(18,2)");
             

            builder.Property(e => e.Valves)
                .HasColumnName("VIA_VALVULAS")
                .HasColumnType("varchar(255)");

            builder.HasOne(d => d.VehicleCategory)
                .WithMany(p => p.VehicleList)
                .HasForeignKey(d => d.VehicleCategoryID)
                .HasConstraintName("FK_VIATURA_CATEGORIA_ID");

            builder.HasOne(d => d.VehicleColor)
                .WithMany(p => p.VehicleList)
                .HasForeignKey(d => d.VehicleColorId)
                .HasConstraintName("FK_VIATURA_COR_ID");

            builder.HasOne(d => d.Mark)
                .WithMany(p => p.VehicleList)
                .HasForeignKey(d => d.MarkID)
                .HasConstraintName("FK_VIATURA_MARCA_ID");

            builder.HasOne(d => d.Owner)
                .WithMany(p => p.VehiclesList)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_VIATURA_OWNER");

            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.Description);
            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.Notes);
        }
    }
}
