using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using Microsoft.EntityFrameworkCore;
 

namespace KitandaSoftERP.Infra.Data.Context
{
    public class ContextApp: DbContext
    {
        public ContextApp(DbContextOptions options) : base(options)
        {

        }
        // Security Tables
        public DbSet<Profile> UserProfiles { get; set; } // Perfis de Utilizador
        public DbSet<User> Users { get; set; } // Utilizadores
        public DbSet<Module> Modules { get; set; } // Módulos do Sistema
        public DbSet<Page> Pages { get; set; } // Páginas
        public DbSet<UserProfilePermission> UserProfilePermissions { get; set; } // Permissoes
        public DbSet<CurrentSession> CurrentSessions { get; set; } // 
        
        public DbSet<AcademicSettings> AcademicSettings { get; set; }
        public DbSet<EmailMonitor> EmailMonitors { get; set; } 
        public DbSet<SystemDocument> SystemDocuments { get; set; }
        public DbSet<SentMessageNotification> SentMessageNotifications { get; set; }

        //GENERAL MODELS

        public DbSet<Entity> Entities { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<EntityEnterprise> EntityEnterprises { get; set; }
        public DbSet<EntityPerson> EntityPersons { get; set; }
        public DbSet<EntityDocumentation> EntityDocumentation { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Commune> Communes { get; set; }
        public DbSet<Language> Languages { get; set; } 
        public DbSet<CitzenDocument> CitzenDocuments { get; set; }
        public DbSet<BusinessActivity> BusinessActivities { get; set; }
        public DbSet<Holidays> Holidays { get; set; }
        public DbSet<Qualifications> Qualifications { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Graduation> Graduations { get; set; }

        // ACADEMIC TABLES
        public DbSet<AcademicPeriod> AcademicPeriods { get; set; }
        public DbSet<AcademicStatus> AcademicStatus { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<ClassRoom> ClassesRoom { get; set; }
        public DbSet<ClassRoomDirector> ClassesRoomDirector { get; set; }
        public DbSet<ClassRoomShift> ClassRoomShift { get; set; } // Configuração de Turnos
        public DbSet<ClassRoomTeachers> ClassesRoomTeachers { get; set; }
        public DbSet<Coordenation> Coordenation { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CurricularUnit> CurricularPlans { get; set; }
        public DbSet<CurricularYear> CurricularYears { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<RegistrationStatus> RegistrationStatus { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCardID> StudentCardID { get; set; }
        public DbSet<StudentDocumentOrder> StudentDocumentsOrder { get; set; } 
        public DbSet<StudentFamily> StudentFamilies { get; set; }
        public DbSet<StudentParent> StudentParents { get; set; }
        public DbSet<StudentRegistration> StudentRegistration { get; set; }
        public DbSet<Teacher> Teachers { get; set; } 
        public DbSet<TeacherPreference> TeacherPreferences { get; set; }
        public DbSet<UnitClassification> UnitClassification { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*var config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();
           optionsBuilder.UseMySql(config.GetConnectionString("AppDBConnection"));*/
        }

        public ContextApp Create(string pConnectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextApp>();
            optionsBuilder.UseMySql(pConnectionString);

            //Ensure database creation
            var context = new ContextApp(optionsBuilder.Options);
            context.Database.EnsureCreated(); 
            return context;
        }
    }
}
