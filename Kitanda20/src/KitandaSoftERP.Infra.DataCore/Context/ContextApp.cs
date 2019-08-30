using Dapper;
using KitandaSoftERP.Domain.Entities.Academica;
using KitandaSoftERP.Domain.Entities.Comercial;
using KitandaSoftERP.Domain.Entities.Contabilidade;
using KitandaSoftERP.Domain.Entities.Geral;
using KitandaSoftERP.Domain.Entities.Seguranca;
using KitandaSoftERP.Domain.Entities.Shared;
using KitandaSoftERP.Domain.Entities.Stock;
using KitandaSoftERP.Domain.Entities.Treasure;
using Microsoft.EntityFrameworkCore;
 

namespace KitandaSoftERP.Infra.DataCore.Context
{
    public class ContextApp: DbContext
    {
        private CommandDefinition comando;
        public ContextApp(DbContextOptions options) : base(options)
        {

        } 

        public DbSet<Branch> Branch { get; set; }
        public DbSet<CurrentSession> CurrentSession { get; set; }
        public DbSet<Document> SystemDocument { get; set; }
        public DbSet<EmailMonitor> EmailMonitor { get; set; }  
        public DbSet<SystemModule > Module { get; set; } // Módulos do Sistema
        public DbSet<SystemPages > Page { get; set; } // Páginas
        public DbSet<SentMessageNotification> SentMessageNotification { get; set; }
        public DbSet<Profile> Profile { get; set; } // Perfis de Utilizador
        public DbSet<User> User { get; set; } // Utilizadores
        public DbSet<UserProfileBranch> UserProfileBranch { get; set; }
        public DbSet<UserProfilePermission> UserProfilePermission { get; set; }

        // ACADEMIC TABLES 
        public DbSet<AcademicDocumentTemplate> AcademicDocumentTemplate { get; set; }
        public DbSet<AcademicPeriod> AcademicPeriod { get; set; }
        public DbSet<AcademicSettings> AcademicSetting { get; set; }
        public DbSet<AcademicStatus> AcademicStatus { get; set; }
        public DbSet<AcademicYear> AcademicYear { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<ClassRoom> ClassesRoom { get; set; }
        public DbSet<ClassRoomDirector> ClassesRoomDirector { get; set; }
        public DbSet<ClassRoomShift> ClassRoomShift { get; set; } // Configuração de Turnos
        public DbSet<ClassRoomTeachers> ClassesRoomTeacher { get; set; }
        public DbSet<Coordenation> Coordenation { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CurricularUnit> CurricularUnit { get; set; }
        public DbSet<CurricularUnitEvaluationResult> CurricularUnitEvaluationResult { get; set; } // MINI PAUTA
        public DbSet<CurricularYear> CurricularYear { get; set; }
        public DbSet<Discipline> Discipline { get; set; }
        public DbSet<EvaluationResult> EvaluationResult { get; set; } // PAUTA FINAL
        public DbSet<RegistrationStatus> RegistrationStatus { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentCardID> StudentCardID { get; set; }
        public DbSet<StudentDocumentOrder> StudentDocumentOrder { get; set; }
        public DbSet<StudentFamily> StudentFamily { get; set; } 
        public DbSet<StudentRegistration> StudentRegistration { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TeacherPreference> TeacherPreference { get; set; }
        public DbSet<UnitClassification> UnitClassification { get; set; }

        public DbSet<Entity> Entity { get; set; } 
        public DbSet<EntityEnterprise> EntityEnterprise { get; set; }
        public DbSet<EntityPerson> EntityPerson { get; set; }
        public DbSet<BloodGroup> BloodGroup { get; set; }
        public DbSet<BusinessActivity> BusinessActivity { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<CitizenDocument> CitzenDocument { get; set; }
        public DbSet<Commune> Commune { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Commune> Departament { get; set; }
        public DbSet<EntityDocumentation> EntityDocumentation { get; set; }
        public DbSet<Graduation> Graduation { get; set; }
        public DbSet<Holidays> Holiday { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Mail> Mail { get; set; }
        public DbSet<Occupation> Occupation { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Qualifications> Qualification { get; set; }
        public DbSet<RelationshipType> RelationShipType { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<TaxTable> TaxTable { get; set; }

        // Commercial
        public DbSet<AcademicProduct> AcademicProduct { get; set; }
        public DbSet<CashRegister> CashRegister { get; set; }
        public DbSet<CashRegisterMoviment> CashRegisterMoviment { get; set; }
        public DbSet<ClinicalProduct> ClinicalProduct { get; set; }
        public DbSet<CommercialDocuments> CommercialDocuments { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<FeeManagement> FeeManagement { get; set; }
        public DbSet<FeeManagementBillingSchedule> FeeManagementBillingSchedule { get; set; }
        public DbSet<FeeManagementItems> FeeManagementItems { get; set; }
        public DbSet<PaymentTerms> PaymentTerms { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductComposed> ProductComposed { get; set; }
        public DbSet<ProductPriceList> ProductPriceList { get; set; }
        public DbSet<SalesInvoice> SalesInvoice { get; set; }
        public DbSet<SalesInvoiceLines> SalesInvoiceLines { get; set; }
        public DbSet<SerialCommercialDocuments> SerialCommercialDocuments { get; set; }
        public DbSet<StatusDocument> StatusDocument { get; set; }
        public DbSet<StatusPayment> StatusPayment { get; set; }
        public DbSet<TablePrice> TablePrice { get; set; }
        public DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }
        public DbSet<WorshopProduct> WorshopProduct { get; set; }

        // Stock
        public DbSet<ProductLots> ProductLot { get; set; }
        public DbSet<ProductSerialNumbers> ProductSerialNumbers { get; set; }
        public DbSet<StockItem> StockItem { get; set; }
        public DbSet<StockMovimentItems> StockMoviment { get; set; }
        public DbSet<StockMovimentItems> StockMovimentItems { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<WarehousePermission> WarehousePermission { get; set; }

        //Accounts
        public DbSet<GeneralAccountPlan> GeneralAccountPlan { get; set; }

        //Tresure
        public DbSet<BankEntities> Banks { get; set; }
        public DbSet<BankAccounts> BankAccounts { get; set; }
        public DbSet<CashBookMoviment> CashBookMoviment { get; set; }
        public DbSet<CashBookMovimentSalesPayment> CashBookMovimentSalesPayment { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }  


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
            optionsBuilder.UseMySql(pConnectionString).UseLazyLoadingProxies();

            //Ensure database creation
            var context = new ContextApp(optionsBuilder.Options);
            context.Database.EnsureCreated(); 
            return context;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
