using KitandaSoftERP.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitandaSoftERP.Infra.DataCore.EntitiesConfiguration.Geral
{
    public class EntityPersonConfiguration : IEntityTypeConfiguration<EntityPerson>
    {
        public void Configure(EntityTypeBuilder<EntityPerson> builder)
        {
            builder.HasKey(e => e.ID)
                    .HasName("PRIMARY");

            builder.ToTable("ger_entidade_pessoa");

            builder.HasIndex(e => e.NationalityID)
                .HasName("FK_NACIONALIDADE");

            builder.HasIndex(e => e.BloodGroupID)
                .HasName("FK_PESSOA_GRUPO_SANGUINEO");

            builder.HasIndex(e => e.AcademicQuanlificationID)
                .HasName("FK_PESSOA_HABILITACOES");

            builder.HasIndex(e => e.OccupationID)
                .HasName("FK_PESSOA_PROFISSAO");

            builder.HasIndex(e => e.CountryOfBirthID)
                .HasName("FK_PESSOA_COUNTRY");

            builder.HasIndex(e => e.ProvinceOfBirthID)
                .HasName("FK_PESSOA_PROVINCE");

            builder.HasIndex(e => e.CityID)
                .HasName("FK_PESSOA_CITY"); 

            builder.HasIndex(e => e.CommuneOfBirthID)
                .HasName("FK_PESSOA_COMMUNE");

            builder.HasIndex(e => e.EntityID)
                .HasName("FK_PESSOA_BLOOD_GROUP"); 

            builder.Property(e => e.ID)
                .HasColumnName("PES_ID")
                .HasColumnType("int(11)").IsRequired(true);

            builder.Property(e => e.EntityID)
                .HasColumnName("PES_ENTITY_ID")
                .HasColumnType("int(11)").IsRequired(true);

            builder.Property(e => e.NationalityID)
                .HasColumnName("PES_NACIONALITY_ID")
                .HasColumnType("int(11)"); 

            builder.Property(e => e.CountryOfBirthID)
                .HasColumnName("PES_BIRTH_COUNTRY_ID")
                .HasColumnType("int(11)");

            builder.Property(e => e.ProvinceOfBirthID)
                .HasColumnName("PES_BIRTH_PROVINCE_ID")
                .HasColumnType("int(11)");

            builder.Property(e => e.CityOfBirthID)
                .HasColumnName("PES_BIRTH_CITY_ID")
                .HasColumnType("int(11)");

            builder.Property(e => e.CommuneOfBirthID)
                .HasColumnName("PES_BIRTH_COMMUNE_ID")
                .HasColumnType("int(11)");  

            builder.Property(e => e.BloodGroupID)
                .HasColumnName("PES_BLOOD_GROUP_ID")
                .HasColumnType("int(11)");

            builder.Property(e => e.AcademicQuanlificationID)
                .HasColumnName("PES_CODIGO_HABILITACOES")
                .HasColumnType("int(11)");

            builder.Property(e => e.OccupationID)
                .HasColumnName("PES_CODIGO_PROFISSAO")
                .HasColumnType("int(11)");

            builder.Property(e => e.CivilState)
                .HasColumnName("PES_ESTADO_CIVIL")
                .HasColumnType("varchar(2)"); 
             
            builder.Property(e => e.FirstName)
                .HasColumnName("PES_FIRST_NAME")
                .HasColumnType("varchar(50)");

            builder.Property(e => e.MiddleName)
                .HasColumnName("PES_MIDDLE_NAME")
                .HasColumnType("varchar(50)");

            builder.Property(e => e.LastName)
                .HasColumnName("PES_LAST_NAME")
                .HasColumnType("varchar(50)");

            builder.Property(e => e.SearchName)
                .HasColumnName("PES_SEARCH_NAME")
                .HasColumnType("varchar(45)");

            builder.Property(e => e.NickName)
                .HasColumnName("PES_NICK_NAME")
                .HasColumnType("varchar(45)");

             
            builder.Property(e => e.Gender)
                .HasColumnName("PES_SEXO")
                .HasColumnType("varchar(1)"); 

            builder.HasOne(d => d.Entity)
                .WithOne(p => p.EntityPerson)
                .HasForeignKey<Entity>(d => d.EntityID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ger_entidade_pessoa_ibfk_1");

            builder.HasOne(d => d.BloodGroup)
                .WithMany(p => p.EntityPersonsList)
                .HasForeignKey(d => d.BloodGroupID)
                .HasConstraintName("ger_entidade_pessoa_ibfk_2");

            builder.HasOne(d => d.Occupation)
                .WithMany(p => p.EntityPersonsList)
                .HasForeignKey(d => d.OccupationID)
                .HasConstraintName("ger_entidade_pessoa_ibfk_3");

            builder.HasOne(d => d.AcademicQualification)
                .WithMany(p => p.EntityPersonsList)
                .HasForeignKey(d => d.AcademicQuanlificationID)
                .HasConstraintName("ger_entidade_pessoa_ibfk_4");

            builder.HasOne(d => d.CommuneOfBirth)
                .WithMany(p => p.EntityPersonsBirthCommuneList)
                .HasForeignKey(d => d.CommuneOfBirthID)
                .HasConstraintName("ger_entidade_pessoa_ibfk_5");

            builder.HasOne(d => d.CityOfBirth)
                .WithMany(p => p.EntityPersonsBirthCityList)
                .HasForeignKey(d => d.CityOfBirthID)
                .HasConstraintName("ger_entidade_ibfk_6");

            builder.HasOne(d => d.CountryOfBirth)
                .WithMany(p => p.EntitiesBirthCountryList)
                .HasForeignKey(d => d.CountryOfBirthID)
                .HasConstraintName("ger_entidade_ibfk_7");

            builder.HasOne(d => d.Nationality)
                .WithMany(p => p.EntitiesNationalityList)
                .HasForeignKey(d => d.NationalityID)
                .HasConstraintName("ger_entidade_ibfk_8");

            builder.HasOne(d => d.ProvinceOfBirth)
                .WithMany(p => p.EntitiesBirthProvinceList)
                .HasForeignKey(d => d.ProvinceOfBirthID)
                .HasConstraintName("ger_entidade_ibfk_9");


            builder.Ignore(t => t.BranchID);
            builder.Ignore(t => t.ErrorList);
            builder.Ignore(t => t.DesignationOtherLanguage); 
            builder.Ignore(t => t.AccountGeneralPlanID);
            builder.Ignore(t => t.Description); 
            builder.Ignore(t => t.AddressCountryID);
            builder.Ignore(t => t.Notes);
            builder.Ignore(t => t.AddressDetail); 
            builder.Ignore(t => t.AddressProvinceID);
            builder.Ignore(t => t.Birthday);
            builder.Ignore(t => t.BuildingNumber);
            builder.Ignore(t => t.CitizenDocumentID);
            builder.Ignore(t => t.CitizenOrFiscalDocNumber);
            builder.Ignore(t => t.CityID);
            builder.Ignore(t => t.DistrictCommuneID);
            builder.Ignore(t => t.Email); 
            builder.Ignore(t => t.EntityID);
            builder.Ignore(t => t.Fax);
            builder.Ignore(t => t.Mobile);
            builder.Ignore(t => t.OtherPhone);
            builder.Ignore(t => t.Photo);
            builder.Ignore(t => t.PhotoExtension);
            builder.Ignore(t => t.PhotoPath);
            builder.Ignore(t => t.PostalCode); 
            builder.Ignore(t => t.SocialName);
            builder.Ignore(t => t.StreetName);
            builder.Ignore(t => t.TaxRegistrationNumber);
            builder.Ignore(t => t.Telephone);
            builder.Ignore(t => t.Website);
            builder.Ignore(t => t.WhatsAppNumber);
        }
    }
}
