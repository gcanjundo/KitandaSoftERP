using KitandaSoftERP.Domain.Entities.Worshop;
using Microsoft.EntityFrameworkCore;
using KitandaSoftERP.Domain.Entities.Geral;

namespace KitandaSoftERP.Infra.DataCore.DBModels
{
    public partial class base_lucan_erpContext : DbContext
    {
        public base_lucan_erpContext()
        {
        }

        public base_lucan_erpContext(DbContextOptions<base_lucan_erpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WorshopProduct> AutoArtigos { get; set; }
        public virtual DbSet<VehicleCategory> AutoCategoria { get; set; }
        public virtual DbSet<WorshopBooking> AutoMarcacao { get; set; }
        public virtual DbSet<WorshopWorkorder> AutoOrdemServico { get; set; }
        public virtual DbSet<WorshopWorkorderAttachment> AutoOrdemServicoAnexos { get; set; }
        public virtual DbSet<WorshopWorkorderChecklist> AutoOrdemServicoChecklist { get; set; }
        public virtual DbSet<WorshopWorkorderDetails> AutoOrdemServicoDetails { get; set; }
        public virtual DbSet<WorshopWorkorderServiceNotes> AutoOrdemServicoNotas { get; set; }
        public virtual DbSet<WorshopWorkorderOccurrences> AutoOrdemServicoOcorrencias { get; set; }
        public virtual DbSet<ClinicalAttendance> CliAtendimento { get; set; }
        public virtual DbSet<CliAtendimentoConsulta> CliAtendimentoConsulta { get; set; }
        public virtual DbSet<CliAtendimentoConvenio> CliAtendimentoConvenio { get; set; }
        public virtual DbSet<CliAtendimentoMedico> CliAtendimentoMedico { get; set; }
        public virtual DbSet<CliAtendimentoProcedimento> CliAtendimentoProcedimento { get; set; }
        public virtual DbSet<CliAtendimentoSituacao> CliAtendimentoSituacao { get; set; }
        public virtual DbSet<CliAtendimentoTriagem> CliAtendimentoTriagem { get; set; }
        public virtual DbSet<CliCategoriaAcomodacoes> CliCategoriaAcomodacoes { get; set; }
        public virtual DbSet<CliCategoriaProcedimento> CliCategoriaProcedimento { get; set; }
        public virtual DbSet<CliConsultaDiagnostico> CliConsultaDiagnostico { get; set; }
        public virtual DbSet<CliConsultaReceita> CliConsultaReceita { get; set; }
        public virtual DbSet<CliConsultaReceitaMedicamento> CliConsultaReceitaMedicamento { get; set; }
        public virtual DbSet<CliDoenca> CliDoenca { get; set; }
        public virtual DbSet<CliEscalaMedico> CliEscalaMedico { get; set; }
        public virtual DbSet<CliEspecialidade> CliEspecialidade { get; set; }
        public virtual DbSet<CliInternamento> CliInternamento { get; set; }
        public virtual DbSet<CliInternamentoAcomodacao> CliInternamentoAcomodacao { get; set; }
        public virtual DbSet<CliMedico> CliMedico { get; set; }
        public virtual DbSet<CliPacienteConvenio> CliPacienteConvenio { get; set; }
        public virtual DbSet<CliPlanoConvenio> CliPlanoConvenio { get; set; }
        public virtual DbSet<CliPlanoConvenioCobertura> CliPlanoConvenioCobertura { get; set; }
        public virtual DbSet<CliProcessoClinico> CliProcessoClinico { get; set; }
        public virtual DbSet<CliServico> CliServico { get; set; }
        public virtual DbSet<CliStatus> CliStatus { get; set; }
        public virtual DbSet<CliUtente> CliUtente { get; set; }
        public virtual DbSet<ComAnoFaturacao> ComAnoFaturacao { get; set; }
        public virtual DbSet<ComArtigoFornecedor> ComArtigoFornecedor { get; set; }
        public virtual DbSet<ComArtigoPrinters> ComArtigoPrinters { get; set; }
        public virtual DbSet<ComCambio> ComCambio { get; set; }
        public virtual DbSet<ComCatalogoDocumentoAcao> ComCatalogoDocumentoAcao { get; set; }
        public virtual DbSet<ComCatalogoDocumentos> ComCatalogoDocumentos { get; set; }
        public virtual DbSet<ComCobrancaDocumentos> ComCobrancaDocumentos { get; set; }
        public virtual DbSet<ComCondicaoPagamento> ComCondicaoPagamento { get; set; }
        public virtual DbSet<ComContratos> ComContratos { get; set; }
        public virtual DbSet<ComDocumento> ComDocumento { get; set; }
        public virtual DbSet<ComDocumentoConversao> ComDocumentoConversao { get; set; }
        public virtual DbSet<ComDocumentoUtilizadorAcesso> ComDocumentoUtilizadorAcesso { get; set; }
        public virtual DbSet<ComExpedicao> ComExpedicao { get; set; }
        public virtual DbSet<ComFatSuspensa> ComFatSuspensa { get; set; }
        public virtual DbSet<ComFaturaCliente> ComFaturaCliente { get; set; }
        public virtual DbSet<ComFaturaClienteItem> ComFaturaClienteItem { get; set; }
        public virtual DbSet<ComFaturaFornecedor> ComFaturaFornecedor { get; set; }
        public virtual DbSet<ComFaturaFornecedorItem> ComFaturaFornecedorItem { get; set; }
        public virtual DbSet<ComFaturaReferenciaSuspender> ComFaturaReferenciaSuspender { get; set; }
        public virtual DbSet<ComFaturaSuspensa> ComFaturaSuspensa { get; set; }
        public virtual DbSet<ComGuiaEntrega> ComGuiaEntrega { get; set; }
        public virtual DbSet<ComMotivoIsencaoIva> ComMotivoIsencaoIva { get; set; }
        public virtual DbSet<ComPagamentoFornecedor> ComPagamentoFornecedor { get; set; }
        public virtual DbSet<ComPagamentoFornecedorDocumentos> ComPagamentoFornecedorDocumentos { get; set; }
        public virtual DbSet<ComPlanoPagamento> ComPlanoPagamento { get; set; }
        public virtual DbSet<ComPos> ComPos { get; set; }
        public virtual DbSet<ComPosConfiguracao> ComPosConfiguracao { get; set; }
        public virtual DbSet<ComPosMovimento> ComPosMovimento { get; set; }
        public virtual DbSet<ComPosStatus> ComPosStatus { get; set; }
        public virtual DbSet<PromotionsCustomer> ComPromocaoCliente { get; set; }
        public virtual DbSet<Promotions> ComPromocoes { get; set; }
        public virtual DbSet<PromotionsProducts> ComPromocoesArtigos { get; set; }
        public virtual DbSet<ComReciboCliente> ComReciboCliente { get; set; }
        public virtual DbSet<ComReciboClienteDocumentos> ComReciboClienteDocumentos { get; set; }
        public virtual DbSet<ComRegimeIva> ComRegimeIva { get; set; }
        public virtual DbSet<ComSeguradoras> ComSeguradoras { get; set; }
        public virtual DbSet<ComSerieDocumentacao> ComSerieDocumentacao { get; set; }
        public virtual DbSet<ComSerieFaturacao> ComSerieFaturacao { get; set; }
        public virtual DbSet<ComSeriePermissoes> ComSeriePermissoes { get; set; }
        public virtual DbSet<ComStock> ComStock { get; set; }
        public virtual DbSet<StockInventory> ComStockInventario { get; set; }
        public virtual DbSet<StockInventoryItems> ComStockInventarioArtigos { get; set; }
        public virtual DbSet<ComTabelaPreco> ComTabelaPreco { get; set; }
        public virtual DbSet<ComTabelaPrecoArtigos> ComTabelaPrecoArtigos { get; set; }
        public virtual DbSet<FarMedicamento> FarMedicamento { get; set; }
        public virtual DbSet<FinBanco> FinBanco { get; set; }
        public virtual DbSet<FinCambio> FinCambio { get; set; }
        public virtual DbSet<FinContaBancaria> FinContaBancaria { get; set; }
        public virtual DbSet<FinContasTesouraria> FinContasTesouraria { get; set; }
        public virtual DbSet<FinMoeda> FinMoeda { get; set; }
        public virtual DbSet<FinMovimentoCaixa> FinMovimentoCaixa { get; set; }
        public virtual DbSet<FinMovimentoFatura> FinMovimentoFatura { get; set; }
        public virtual DbSet<FinMovimentosPeriodicos> FinMovimentosPeriodicos { get; set; }
        public virtual DbSet<FinPlanoContas> FinPlanoContas { get; set; }
        public virtual DbSet<GerArmazem> GerArmazem { get; set; }
        public virtual DbSet<GerArmazemPermissoes> GerArmazemPermissoes { get; set; }
        public virtual DbSet<GerArtigo> GerArtigo { get; set; }
        public virtual DbSet<GerArtigoComposicao> GerArtigoComposicao { get; set; }
        public virtual DbSet<GerArtigoDimensoes> GerArtigoDimensoes { get; set; }
        public virtual DbSet<GerArtigoLote> GerArtigoLote { get; set; }
        public virtual DbSet<GerArtigoSemelhanca> GerArtigoSemelhanca { get; set; }
        public virtual DbSet<GerArtigoSerialNumber> GerArtigoSerialNumber { get; set; }
        public virtual DbSet<GerCategoria> GerCategoria { get; set; }
        public virtual DbSet<GerCores> GerCores { get; set; }
        public virtual DbSet<GerDepartamento> GerDepartamento { get; set; }
        public virtual DbSet<GerDistritos> GerDistritos { get; set; }
        public virtual DbSet<GerDocumento> GerDocumento { get; set; }
        public virtual DbSet<GerDocumentosRelacionados> GerDocumentosRelacionados { get; set; }
        public virtual DbSet<GerEntidade> GerEntidade { get; set; }
        public virtual DbSet<GerEntidadeAssociada> GerEntidadeAssociada { get; set; }
        public virtual DbSet<GerEntidadeDocumentacao> GerEntidadeDocumentacao { get; set; }
        public virtual DbSet<GerEntidadeMorada> GerEntidadeMorada { get; set; }
        public virtual DbSet<GerEntidadePessoa> GerEntidadePessoa { get; set; }
        public virtual DbSet<GerFabricante> GerFabricante { get; set; }
        public virtual DbSet<GerGrupoClientes> GerGrupoClientes { get; set; }
        public virtual DbSet<GerGrupoSanguineo> GerGrupoSanguineo { get; set; }
        public virtual DbSet<GerHabilitacoes> GerHabilitacoes { get; set; }
        public virtual DbSet<GerImpostos> GerImpostos { get; set; }
        public virtual DbSet<GerItem> GerItem { get; set; }
        public virtual DbSet<GerMarca> GerMarca { get; set; }
        public virtual DbSet<GerMeioPagamento> GerMeioPagamento { get; set; }
        public virtual DbSet<GerModelo> GerModelo { get; set; }
        public virtual DbSet<GerMunicipio> GerMunicipio { get; set; }
        public virtual DbSet<GerPais> GerPais { get; set; }
        public virtual DbSet<GerProfissao> GerProfissao { get; set; }
        public virtual DbSet<GerProvincia> GerProvincia { get; set; }
        public virtual DbSet<GerRaca> GerRaca { get; set; }
        public virtual DbSet<GerReligiao> GerReligiao { get; set; }
        public virtual DbSet<GerStatus> GerStatus { get; set; }
        public virtual DbSet<GerSubCategoria> GerSubCategoria { get; set; }
        public virtual DbSet<ProductSizes> GerTamanho { get; set; }
        public virtual DbSet<Tasks> GerTask { get; set; }
        public virtual DbSet<GerTerceiros> GerTerceiros { get; set; }
        public virtual DbSet<GerTerceirosContacto> GerTerceirosContacto { get; set; }
        public virtual DbSet<GerTipo> GerTipo { get; set; }
        public virtual DbSet<GerTipoActividade> GerTipoActividade { get; set; }
        public virtual DbSet<GerTipoMorada> GerTipoMorada { get; set; }
        public virtual DbSet<GerTurnos> GerTurnos { get; set; }
        public virtual DbSet<GerUnidadeMedicao> GerUnidadeMedicao { get; set; }
        public virtual DbSet<Vehicle> GerViatura { get; set; }
        public virtual DbSet<LabAmostra> LabAmostra { get; set; }
        public virtual DbSet<LabCategoriaExame> LabCategoriaExame { get; set; }
        public virtual DbSet<LabCategoriaMaterial> LabCategoriaMaterial { get; set; }
        public virtual DbSet<LabExame> LabExame { get; set; }
        public virtual DbSet<LabExameItem> LabExameItem { get; set; }
        public virtual DbSet<LabExameMaterial> LabExameMaterial { get; set; }
        public virtual DbSet<LabMaterial> LabMaterial { get; set; }
        public virtual DbSet<LabPrecoExame> LabPrecoExame { get; set; }
        public virtual DbSet<LabResultado> LabResultado { get; set; }
        public virtual DbSet<LabTecnico> LabTecnico { get; set; }
        public virtual DbSet<LabUnidadeMaterial> LabUnidadeMaterial { get; set; }
        public virtual DbSet<RestAtendimento> RestAtendimento { get; set; }
        public virtual DbSet<RestAtendimentoConsultaConta> RestAtendimentoConsultaConta { get; set; }
        public virtual DbSet<RestAtendimentoPedido> RestAtendimentoPedido { get; set; }
        public virtual DbSet<RestAtendimentoSala> RestAtendimentoSala { get; set; }
        public virtual DbSet<RestComissaoVenda> RestComissaoVenda { get; set; }
        public virtual DbSet<RestFuncionarios> RestFuncionarios { get; set; }
        public virtual DbSet<RestLocalizacao> RestLocalizacao { get; set; }
        public virtual DbSet<RestMesa> RestMesa { get; set; }
        public virtual DbSet<RestPratoDia> RestPratoDia { get; set; }
        public virtual DbSet<RestReserva> RestReserva { get; set; }
        public virtual DbSet<RhAlteracoesMensais> RhAlteracoesMensais { get; set; }
        public virtual DbSet<RhBeneficioCargo> RhBeneficioCargo { get; set; }
        public virtual DbSet<RhBeneficios> RhBeneficios { get; set; }
        public virtual DbSet<RhCargo> RhCargo { get; set; }
        public virtual DbSet<RhCategoriaColaborador> RhCategoriaColaborador { get; set; }
        public virtual DbSet<RhContratos> RhContratos { get; set; }
        public virtual DbSet<RhDiasDescansoSemanal> RhDiasDescansoSemanal { get; set; }
        public virtual DbSet<RhEscaloesIrt> RhEscaloesIrt { get; set; }
        public virtual DbSet<RhFuncionario> RhFuncionario { get; set; }
        public virtual DbSet<RhFuncionarioAgregadoFamiliar> RhFuncionarioAgregadoFamiliar { get; set; }
        public virtual DbSet<RhFuncionarioCoordenadasBancarias> RhFuncionarioCoordenadasBancarias { get; set; }
        public virtual DbSet<RhFuncionarioGrupoHorarioTrabalho> RhFuncionarioGrupoHorarioTrabalho { get; set; }
        public virtual DbSet<RhGrupoHorarioTrabalho> RhGrupoHorarioTrabalho { get; set; }
        public virtual DbSet<RhGrupoSalarial> RhGrupoSalarial { get; set; }
        public virtual DbSet<RhHorarioTabalho> RhHorarioTabalho { get; set; }
        public virtual DbSet<RhHorarioTrabalhoSemana> RhHorarioTrabalhoSemana { get; set; }
        public virtual DbSet<RhMotivo> RhMotivo { get; set; }
        public virtual DbSet<RhMotivoLicenca> RhMotivoLicenca { get; set; }
        public virtual DbSet<RhOperacoesMensais> RhOperacoesMensais { get; set; }
        public virtual DbSet<RhProcessamento> RhProcessamento { get; set; }
        public virtual DbSet<RhProcessamentoFuncionarios> RhProcessamentoFuncionarios { get; set; }
        public virtual DbSet<RhRegimeLaboral> RhRegimeLaboral { get; set; }
        public virtual DbSet<RhRegistoFalta> RhRegistoFalta { get; set; }
        public virtual DbSet<RhRegsitoFerias> RhRegsitoFerias { get; set; }
        public virtual DbSet<RhRescisaoContratual> RhRescisaoContratual { get; set; }
        public virtual DbSet<RhTipoProcessamento> RhTipoProcessamento { get; set; }
        public virtual DbSet<RhTipoSalarioItem> RhTipoSalarioItem { get; set; }
        public virtual DbSet<RhVencimento> RhVencimento { get; set; }
        public virtual DbSet<RhVinculoContratual> RhVinculoContratual { get; set; }
        public virtual DbSet<SaftHeader> SaftHeader { get; set; }
        public virtual DbSet<SatFolhaObra> SatFolhaObra { get; set; }
        public virtual DbSet<SatViaturas> SatViaturas { get; set; }
        public virtual DbSet<SisAcesso> SisAcesso { get; set; }
        public virtual DbSet<SisConfiguracao> SisConfiguracao { get; set; }
        public virtual DbSet<SisCore> SisCore { get; set; }
        public virtual DbSet<SisDocumentsFormate> SisDocumentsFormate { get; set; }
        public virtual DbSet<SisEmailMonitor> SisEmailMonitor { get; set; }
        public virtual DbSet<SisEmpresa> SisEmpresa { get; set; }
        public virtual DbSet<SisFormulario> SisFormulario { get; set; }
        public virtual DbSet<SisFormularioPermissao> SisFormularioPermissao { get; set; }
        public virtual DbSet<SisHistorico> SisHistorico { get; set; }
        public virtual DbSet<SisImportacao> SisImportacao { get; set; }
        public virtual DbSet<SisLogs> SisLogs { get; set; }
        public virtual DbSet<SisMensagemErro> SisMensagemErro { get; set; }
        public virtual DbSet<SisModulo> SisModulo { get; set; }
        public virtual DbSet<SisModuloPermissao> SisModuloPermissao { get; set; }
        public virtual DbSet<SisPerfil> SisPerfil { get; set; }
        public virtual DbSet<SisPerfilFilial> SisPerfilFilial { get; set; }
        public virtual DbSet<SisPosFormularioPermissao> SisPosFormularioPermissao { get; set; }
        public virtual DbSet<SisPosFormularios> SisPosFormularios { get; set; }
        public virtual DbSet<SisPrinters> SisPrinters { get; set; }
        public virtual DbSet<SisRestFormularioPermissao> SisRestFormularioPermissao { get; set; }
        public virtual DbSet<SisRestFormularios> SisRestFormularios { get; set; }
        public virtual DbSet<SisSaftAoExport> SisSaftAoExport { get; set; }
        public virtual DbSet<SisSubscricoes> SisSubscricoes { get; set; }
        public virtual DbSet<SisSystemInfo> SisSystemInfo { get; set; }
        public virtual DbSet<SisUtilizador> SisUtilizador { get; set; }
        public virtual DbSet<SisUtilizadorFilial> SisUtilizadorFilial { get; set; }
        public virtual DbSet<SisUtilizadorPermissaoFormulario> SisUtilizadorPermissaoFormulario { get; set; }
        public virtual DbSet<StockEntrada> StockEntrada { get; set; }
        public virtual DbSet<StockExtratoArtigo> StockExtratoArtigo { get; set; }
        public virtual DbSet<StockFaturaCompra> StockFaturaCompra { get; set; }
        public virtual DbSet<StockMovimentoDirectos> StockMovimentoDirectos { get; set; }
        public virtual DbSet<StockMovimentosDirectosArtigos> StockMovimentosDirectosArtigos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost; port=3306; database=base_lucan_erp; user=root; password=klb@@13%; default command timeout=120");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorshopProduct>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PRIMARY");

                entity.ToTable("auto_artigos");

                entity.Property(e => e.ID)
                    .HasColumnName("OFI_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");
                /*
                entity.HasOne(d => d.Product)
                    .WithOne(p => p.ProductID)
                    .HasForeignKey<Product>(d => d.ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OFICINA_ARTIGO");*/
            });

            modelBuilder.Entity<WorkshopCategory>(entity =>
            {
                entity.HasKey(e => e.CatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("auto_categoria");

                entity.Property(e => e.CatCodigo)
                    .HasColumnName("CAT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatDescricao)
                    .HasColumnName("CAT_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.CatSigla)
                    .HasColumnName("CAT_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CatStatus)
                    .HasColumnName("CAT_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<AutoMarcacao>(entity =>
            {
                entity.HasKey(e => e.MarCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("auto_marcacao");

                entity.HasIndex(e => e.MarBillingEntityId)
                    .HasName("FK_MARCACAO_BILLING_ENTITY_ID");

                entity.HasIndex(e => e.MarCarId)
                    .HasName("FK_MARCACAO_CAR_ID");

                entity.HasIndex(e => e.MarDocumentId)
                    .HasName("FK_MARCACAO_DOCUMENT_ID");

                entity.HasIndex(e => e.MarServiceId)
                    .HasName("FK_MARCACAO_ARTIGO_ID");

                entity.Property(e => e.MarCodigo)
                    .HasColumnName("MAR_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarBillingEntityId)
                    .HasColumnName("MAR_BILLING_ENTITY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarCancelNotes)
                    .HasColumnName("MAR_CANCEL_NOTES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MarCanceledBy)
                    .HasColumnName("MAR_CANCELED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MarCanceledDate)
                    .HasColumnName("MAR_CANCELED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MarCarId)
                    .HasColumnName("MAR_CAR_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarCheckIn)
                    .HasColumnName("MAR_CHECK_IN")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.MarCheckinCompanyId)
                    .HasColumnName("MAR_CHECKIN_COMPANY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarCreatedBy)
                    .HasColumnName("MAR_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MarCreatedCompanyId)
                    .HasColumnName("MAR_CREATED_COMPANY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarCreatedDate)
                    .HasColumnName("MAR_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MarDocumentId)
                    .HasColumnName("MAR_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarNotes)
                    .HasColumnName("MAR_NOTES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MarServiceId)
                    .HasColumnName("MAR_SERVICE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarStatus)
                    .HasColumnName("MAR_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarUpdatedBy)
                    .HasColumnName("MAR_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MarUpdatedDate)
                    .HasColumnName("MAR_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MarBillingEntity)
                    .WithMany(p => p.AutoMarcacao)
                    .HasForeignKey(d => d.MarBillingEntityId)
                    .HasConstraintName("FK_MARCACAO_BILLING_ENTITY_ID");

                entity.HasOne(d => d.MarCar)
                    .WithMany(p => p.AutoMarcacao)
                    .HasForeignKey(d => d.MarCarId)
                    .HasConstraintName("FK_MARCACAO_CAR_ID");

                entity.HasOne(d => d.MarDocument)
                    .WithMany(p => p.AutoMarcacao)
                    .HasForeignKey(d => d.MarDocumentId)
                    .HasConstraintName("FK_MARCACAO_DOCUMENT_ID");

                entity.HasOne(d => d.MarService)
                    .WithMany(p => p.AutoMarcacao)
                    .HasForeignKey(d => d.MarServiceId)
                    .HasConstraintName("FK_MARCACAO_ARTIGO_ID");
            });

            modelBuilder.Entity<AutoOrdemServico>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PRIMARY");

                entity.ToTable("auto_ordem_servico");

                entity.HasIndex(e => e.BillingEntityId)
                    .HasName("FK_OS_BILLING_ENTITY");

                entity.HasIndex(e => e.BranchId)
                    .HasName("FK_OS_FILIAL");

                entity.HasIndex(e => e.CarId)
                    .HasName("FK_OS_CAR");

                entity.HasIndex(e => e.CheckinTechnicianId)
                    .HasName("FK_CHECKIN_TECHNICIAN");

                entity.HasIndex(e => e.CheckoutTechnicianId)
                    .HasName("FK_CHECKOUT_TECHNICIAN_ID");

                entity.HasIndex(e => e.DocumentId)
                    .HasName("FK_FOLHA_OBRA_DOCUMENT_TYPE");

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("FK_OS_INVOICE");

                entity.HasIndex(e => e.MarcacaoId)
                    .HasName("FK_OS_MARCACAO");

                entity.HasIndex(e => e.SerieId)
                    .HasName("FK_FOLHA_OBRA_SERIE");

                entity.HasIndex(e => e.TechnicianId)
                    .HasName("FK_FOLHA_WORKER_ID");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Actived)
                    .HasColumnName("ACTIVED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.BillingEntityId)
                    .HasColumnName("BILLING_ENTITY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BookBy)
                    .HasColumnName("BOOK_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.BookDate)
                    .HasColumnName("BOOK_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BRANCH_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarId)
                    .HasColumnName("CAR_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarKm)
                    .HasColumnName("CAR_KM")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.CheckinDate)
                    .HasColumnName("CHECKIN_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckinTechnicianId)
                    .HasColumnName("CHECKIN_TECHNICIAN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CheckoutDate)
                    .HasColumnName("CHECKOUT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckoutTechnicianId)
                    .HasColumnName("CHECKOUT_TECHNICIAN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("DOCUMENT_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocumentReference)
                    .HasColumnName("DOCUMENT_REFERENCE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DocumentStatus)
                    .HasColumnName("DOCUMENT_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DriverContact)
                    .HasColumnName("DRIVER_CONTACT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DriverPeople)
                    .HasColumnName("DRIVER_PEOPLE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("INVOICE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarcacaoId)
                    .HasColumnName("MARCACAO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("longtext");

                entity.Property(e => e.OsStatusId)
                    .HasColumnName("OS_STATUS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OsType)
                    .HasColumnName("OS_TYPE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PredictionClosing)
                    .HasColumnName("PREDICTION_CLOSING")
                    .HasColumnType("date");

                entity.Property(e => e.SerieId)
                    .HasColumnName("SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TechnicianId)
                    .HasColumnName("TECHNICIAN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .();

                entity.Property(e => e.WorkFinishDate)
                    .HasColumnName("WORK_FINISH_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkStartDate)
                    .HasColumnName("WORK_START_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.BillingEntity)
                    .WithMany(p => p.AutoOrdemServico)
                    .HasForeignKey(d => d.BillingEntityId)
                    .HasConstraintName("FK_OS_BILLING_ENTITY");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AutoOrdemServico)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_OS_FILIAL");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.AutoOrdemServico)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_OS_CAR");

                entity.HasOne(d => d.CheckinTechnician)
                    .WithMany(p => p.AutoOrdemServicoCheckinTechnician)
                    .HasForeignKey(d => d.CheckinTechnicianId)
                    .HasConstraintName("FK_CHECKIN_TECHNICIAN_ID");

                entity.HasOne(d => d.CheckoutTechnician)
                    .WithMany(p => p.AutoOrdemServicoCheckoutTechnician)
                    .HasForeignKey(d => d.CheckoutTechnicianId)
                    .HasConstraintName("FK_CHECKOUT_TECHNICIAN_ID");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.AutoOrdemServico)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_FOLHA_OBRA_DOCUMENT_TYPE");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.AutoOrdemServico)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_OS_INVOICE");

                entity.HasOne(d => d.Marcacao)
                    .WithMany(p => p.AutoOrdemServico)
                    .HasForeignKey(d => d.MarcacaoId)
                    .HasConstraintName("FK_OS_MARCACAO");

                entity.HasOne(d => d.Serie)
                    .WithMany(p => p.AutoOrdemServico)
                    .HasForeignKey(d => d.SerieId)
                    .HasConstraintName("FK_FOLHA_OBRA_SERIE");

                entity.HasOne(d => d.Technician)
                    .WithMany(p => p.AutoOrdemServicoTechnician)
                    .HasForeignKey(d => d.TechnicianId)
                    .HasConstraintName("FK_FOLHA_WORKER_ID");
            });

            modelBuilder.Entity<AutoOrdemServicoAnexos>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.OrderId })
                    .HasName("PRIMARY");

                entity.ToTable("auto_ordem_servico_anexos");

                entity.HasIndex(e => e.OrderId)
                    .HasName("FK_ORDER_ATTACHMENT");

                entity.Property(e => e.FileId)
                    .HasColumnName("FILE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FilePath)
                    .HasColumnName("FILE_PATH")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Phisical).HasColumnName("PHISICAL");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.AutoOrdemServicoAnexos)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDER_ATTACHMENT");
            });

            modelBuilder.Entity<AutoOrdemServicoChecklist>(entity =>
            {
                entity.HasKey(e => e.ServiceOrderId)
                    .HasName("PRIMARY");

                entity.ToTable("auto_ordem_servico_checklist");

                entity.HasIndex(e => e.TechnicianId)
                    .HasName("FK_CHECKLIST_TECHNICIAN");

                entity.Property(e => e.ServiceOrderId)
                    .HasColumnName("SERVICE_ORDER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChaveRodas)
                    .HasColumnName("CHAVE_RODAS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Colete)
                    .HasColumnName("COLETE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ElevadorFld)
                    .HasColumnName("ELEVADOR_FLD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ElevadorFle)
                    .HasColumnName("ELEVADOR_FLE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ElevadorTld)
                    .HasColumnName("ELEVADOR_TLD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ElevadorTle)
                    .HasColumnName("ELEVADOR_TLE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FarolLd)
                    .HasColumnName("FAROL_LD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FarolLe)
                    .HasColumnName("FAROL_LE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FluelLevel)
                    .HasColumnName("FLUEL_LEVEL")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Isqueiro)
                    .HasColumnName("ISQUEIRO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Macaco)
                    .HasColumnName("MACACO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Manivela)
                    .HasColumnName("MANIVELA")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PiscaFld)
                    .HasColumnName("PISCA_FLD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PiscaFle)
                    .HasColumnName("PISCA_FLE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PiscaTld)
                    .HasColumnName("PISCA_TLD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PiscaTle)
                    .HasColumnName("PISCA_TLE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PneusSocorro)
                    .HasColumnName("PNEUS_SOCORRO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RadioCd)
                    .HasColumnName("RADIO_CD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RetrovisorInterior)
                    .HasColumnName("RETROVISOR_INTERIOR")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RetrovisorLd)
                    .HasColumnName("RETROVISOR_LD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RetrovisorLe)
                    .HasColumnName("RETROVISOR_LE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SimboloFrontal)
                    .HasColumnName("SIMBOLO_FRONTAL")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SimboloTraseiro)
                    .HasColumnName("SIMBOLO_TRASEIRO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.StopLd)
                    .HasColumnName("STOP_LD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.StopLe)
                    .HasColumnName("STOP_LE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TapeteFld)
                    .HasColumnName("TAPETE_FLD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TapeteFle)
                    .HasColumnName("TAPETE_FLE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TapeteTld)
                    .HasColumnName("TAPETE_TLD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TapeteTle)
                    .HasColumnName("TAPETE_TLE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TapeteTmeio)
                    .HasColumnName("TAPETE_TMEIO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TechnicianId)
                    .HasColumnName("TECHNICIAN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Triangulo)
                    .HasColumnName("TRIANGULO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.ServiceOrder)
                    .WithOne(p => p.AutoOrdemServicoChecklist)
                    .HasForeignKey<AutoOrdemServicoChecklist>(d => d.ServiceOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CHECKLIST_ORDER");

                entity.HasOne(d => d.Technician)
                    .WithMany(p => p.AutoOrdemServicoChecklist)
                    .HasForeignKey(d => d.TechnicianId)
                    .HasConstraintName("FK_CHECKLIST_TECHNICIAN");
            });

            modelBuilder.Entity<AutoOrdemServicoDetails>(entity =>
            {
                entity.HasKey(e => new { e.ServiceOrderId, e.OrderDetailId })
                    .HasName("PRIMARY");

                entity.ToTable("auto_ordem_servico_details");

                entity.HasIndex(e => e.DetailId)
                    .HasName("UK_DETAILS")
                    .IsUnique();

                entity.HasIndex(e => e.OrderDetailId)
                    .HasName("FK_DETAILS_PRODUCT");

                entity.HasIndex(e => e.ServiceOrderId)
                    .HasName("FK_DETAILS_OS");

                entity.HasIndex(e => e.TechnicianId)
                    .HasName("FK_DETAILS_TECHNICIAN");

                entity.Property(e => e.ServiceOrderId)
                    .HasColumnName("SERVICE_ORDER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderDetailId)
                    .HasColumnName("ORDER_DETAIL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Actived)
                    .HasColumnName("ACTIVED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.CostPrice)
                    .HasColumnName("COST_PRICE")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.DetailId)
                    .HasColumnName("DETAIL_ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DetailWarehouseId)
                    .HasColumnName("DETAIL_WAREHOUSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DetailWorshopLocationId)
                    .HasColumnName("DETAIL_WORSHOP_LOCATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("INVOICE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.OrderNro)
                    .HasColumnName("ORDER_NRO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrevisionDate)
                    .HasColumnName("PREVISION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ServiceStatus)
                    .HasColumnName("SERVICE_STATUS")
                    .HasColumnType("int(1)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("SUBTOTAL")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.Tax)
                    .HasColumnName("TAX")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TechnicianId)
                    .HasColumnName("TECHNICIAN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.AutoOrdemServicoDetails)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETAILS_PRODUCT");

                entity.HasOne(d => d.ServiceOrder)
                    .WithMany(p => p.AutoOrdemServicoDetails)
                    .HasForeignKey(d => d.ServiceOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETAILS_OS");

                entity.HasOne(d => d.Technician)
                    .WithMany(p => p.AutoOrdemServicoDetails)
                    .HasForeignKey(d => d.TechnicianId)
                    .HasConstraintName("FK_DETAILS_TECHNICIAN");
            });

            modelBuilder.Entity<AutoOrdemServicoNotas>(entity =>
            {
                entity.HasKey(e => e.NoteId)
                    .HasName("PRIMARY");

                entity.ToTable("auto_ordem_servico_notas");

                entity.HasIndex(e => e.NoteAuthorId)
                    .HasName("FK_NOTE_AUTHOR");

                entity.HasIndex(e => e.OrderId)
                    .HasName("FK_NOTE_WORK_ORDER");

                entity.Property(e => e.NoteId)
                    .HasColumnName("NOTE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoteAuthorId)
                    .HasColumnName("NOTE_AUTHOR_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoteCode)
                    .HasColumnName("NOTE_CODE")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.NoteCreatedBy)
                    .HasColumnName("NOTE_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NoteCreatedDate)
                    .HasColumnName("NOTE_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoteDescription)
                    .HasColumnName("NOTE_DESCRIPTION")
                    .HasColumnType("longtext");

                entity.Property(e => e.NoteUpdatedBy)
                    .HasColumnName("NOTE_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NoteUpdatedDate)
                    .HasColumnName("NOTE_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Private)
                    .HasColumnName("PRIVATE")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.NoteAuthor)
                    .WithMany(p => p.AutoOrdemServicoNotas)
                    .HasForeignKey(d => d.NoteAuthorId)
                    .HasConstraintName("FK_NOTE_AUTHOR");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.AutoOrdemServicoNotas)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_NOTE_WORK_ORDER");
            });

            modelBuilder.Entity<AutoOrdemServicoOcorrencias>(entity =>
            {
                entity.HasKey(e => e.IncidentId)
                    .HasName("PRIMARY");

                entity.ToTable("auto_ordem_servico_ocorrencias");

                entity.HasIndex(e => e.IncidentTechnician)
                    .HasName("FK_INCIDENT_TECHNICIAN");

                entity.HasIndex(e => e.OrderId)
                    .HasName("FK_INCIDENT_ORDER");

                entity.Property(e => e.IncidentId)
                    .HasColumnName("INCIDENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.IncidentDate)
                    .HasColumnName("INCIDENT_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.IncidentDescription)
                    .HasColumnName("INCIDENT_DESCRIPTION")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IncidentTechnician)
                    .HasColumnName("INCIDENT_TECHNICIAN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IncidentType)
                    .HasColumnName("INCIDENT_TYPE")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.InicidentStatus)
                    .HasColumnName("INICIDENT_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.IncidentTechnicianNavigation)
                    .WithMany(p => p.AutoOrdemServicoOcorrencias)
                    .HasForeignKey(d => d.IncidentTechnician)
                    .HasConstraintName("FK_INCIDENT_TECHNICIAN");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.AutoOrdemServicoOcorrencias)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_INCIDENT_ORDER");
            });

            modelBuilder.Entity<ClinicalAttendance>(entity =>
            {
                entity.HasKey(e => e.AtenCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_atendimento");

                entity.HasIndex(e => e.AtenCodigoMedico)
                    .HasName("FK_ATENDIMENTO_MEDICO_idx");

                entity.HasIndex(e => e.AtenCodigoProcesso)
                    .HasName("FK_ATENDIMENTO_PROCESSO");

                entity.HasIndex(e => e.AtenCodigoServico)
                    .HasName("FK_ATENDIMENTO_ESPECIALIDADE");

                entity.HasIndex(e => e.AtenCodigoUnidade)
                    .HasName("FK_ATENDIMENTO_UNIDADE_HOSPITALAR_idx");

                entity.Property(e => e.AtenCodigo)
                    .HasColumnName("ATEN_CODIGO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.AtenClassificacao)
                    .HasColumnName("ATEN_CLASSIFICACAO")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.AtenClassificacaoManchester)
                    .HasColumnName("ATEN_CLASSIFICACAO_MANCHESTER")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.AtenCodigoDepartamento)
                    .HasColumnName("ATEN_CODIGO_DEPARTAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtenCodigoMedico)
                    .HasColumnName("ATEN_CODIGO_MEDICO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtenCodigoProcesso)
                    .HasColumnName("ATEN_CODIGO_PROCESSO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.AtenCodigoServico)
                    .HasColumnName("ATEN_CODIGO_SERVICO")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AtenCodigoUnidade)
                    .HasColumnName("ATEN_CODIGO_UNIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtenCreatedBy)
                    .HasColumnName("ATEN_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AtenCreatedDate)
                    .HasColumnName("ATEN_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.AtenDataAtendimento)
                    .HasColumnName("ATEN_DATA_ATENDIMENTO")
                    .HasColumnType("date");

                entity.Property(e => e.AtenDataRegisto)
                    .HasColumnName("ATEN_DATA_REGISTO")
                    .HasColumnType("date");

                entity.Property(e => e.AtenDataTermino)
                    .HasColumnName("ATEN_DATA_TERMINO")
                    .HasColumnType("datetime");

                entity.Property(e => e.AtenHoraAtendimento)
                    .HasColumnName("ATEN_HORA_ATENDIMENTO")
                    .HasColumnType("time");

                entity.Property(e => e.AtenHoraTermino)
                    .HasColumnName("ATEN_HORA_TERMINO")
                    .HasColumnType("datetime");

                entity.Property(e => e.AtenStatus)
                    .HasColumnName("ATEN_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtenStatusTriagem)
                    .HasColumnName("ATEN_STATUS_TRIAGEM")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.AtenTipo)
                    .HasColumnName("ATEN_TIPO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.AtenUpdatedBy)
                    .HasColumnName("ATEN_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AtenUpdatedDate)
                    .HasColumnName("ATEN_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.AtenCodigoMedicoNavigation)
                    .WithMany(p => p.CliAtendimento)
                    .HasForeignKey(d => d.AtenCodigoMedico)
                    .HasConstraintName("cli_atendimento_ibfk_2");

                entity.HasOne(d => d.AtenCodigoProcessoNavigation)
                    .WithMany(p => p.CliAtendimento)
                    .HasForeignKey(d => d.AtenCodigoProcesso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_ibfk_3");

                entity.HasOne(d => d.AtenCodigoServicoNavigation)
                    .WithMany(p => p.CliAtendimento)
                    .HasForeignKey(d => d.AtenCodigoServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_ibfk_1");

                entity.HasOne(d => d.AtenCodigoUnidadeNavigation)
                    .WithMany(p => p.CliAtendimento)
                    .HasForeignKey(d => d.AtenCodigoUnidade)
                    .HasConstraintName("cli_atendimento_ibfk_4");
            });

            modelBuilder.Entity<CliAtendimentoConsulta>(entity =>
            {
                entity.HasKey(e => e.ConsCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_atendimento_consulta");

                entity.HasIndex(e => e.ConsCodigoProcesso)
                    .HasName("FK_CONSULTA_PROCESSO_CLINICO");

                entity.Property(e => e.ConsCodigo)
                    .HasColumnName("cons_codigo")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ConsCodigoProcesso)
                    .HasColumnName("cons_codigo_processo")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ConsMotivo)
                    .HasColumnName("CONS_MOTIVO")
                    .HasColumnType("text");

                entity.Property(e => e.ConsObservacoes)
                    .HasColumnName("CONS_OBSERVACOES")
                    .HasColumnType("text");

                entity.HasOne(d => d.ConsCodigoNavigation)
                    .WithOne(p => p.CliAtendimentoConsulta)
                    .HasForeignKey<CliAtendimentoConsulta>(d => d.ConsCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_consulta_ibfk_1");
            });

            modelBuilder.Entity<CliAtendimentoConvenio>(entity =>
            {
                entity.HasKey(e => e.CodigoAtendimento)
                    .HasName("PRIMARY");

                entity.ToTable("cli_atendimento_convenio");

                entity.HasIndex(e => e.CodigoApolice)
                    .HasName("FK_ATENDIMENTO_APOLICE_idx");

                entity.HasIndex(e => e.CodigoAtendimento)
                    .HasName("FK_ATENDIMENTO_CONVENIO_idx");

                entity.Property(e => e.CodigoAtendimento)
                    .HasColumnName("CODIGO_ATENDIMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoApolice)
                    .HasColumnName("CODIGO_APOLICE")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.CodigoAtendimentoNavigation)
                    .WithOne(p => p.CliAtendimentoConvenio)
                    .HasForeignKey<CliAtendimentoConvenio>(d => d.CodigoAtendimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_convenio_ibfk_2");
            });

            modelBuilder.Entity<CliAtendimentoMedico>(entity =>
            {
                entity.HasKey(e => new { e.AtenCodigoAtendimento, e.AtenCodigoMedicoIndicado })
                    .HasName("PRIMARY");

                entity.ToTable("cli_atendimento_medico");

                entity.HasIndex(e => e.AtenCodigoMedicoIndicado)
                    .HasName("FK_ATENDIMENTO_MEDICO_INDICADO");

                entity.HasIndex(e => e.AtenCodigoMedicoIndicador)
                    .HasName("FK_ATENDIMENTO_MEDICO_INDICAOR");

                entity.Property(e => e.AtenCodigoAtendimento)
                    .HasColumnName("ATEN_CODIGO_ATENDIMENTO")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AtenCodigoMedicoIndicado)
                    .HasColumnName("ATEN_CODIGO_MEDICO_INDICADO")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AtenCodigoMedicoIndicador)
                    .HasColumnName("ATEN_CODIGO_MEDICO_INDICADOR")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.AtenCodigoAtendimentoNavigation)
                    .WithMany(p => p.CliAtendimentoMedico)
                    .HasForeignKey(d => d.AtenCodigoAtendimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_medico_ibfk_1");

                entity.HasOne(d => d.AtenCodigoMedicoIndicadoNavigation)
                    .WithMany(p => p.CliAtendimentoMedicoAtenCodigoMedicoIndicadoNavigation)
                    .HasForeignKey(d => d.AtenCodigoMedicoIndicado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_medico_ibfk_2");

                entity.HasOne(d => d.AtenCodigoMedicoIndicadorNavigation)
                    .WithMany(p => p.CliAtendimentoMedicoAtenCodigoMedicoIndicadorNavigation)
                    .HasForeignKey(d => d.AtenCodigoMedicoIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_medico_ibfk_3");
            });

            modelBuilder.Entity<CliAtendimentoProcedimento>(entity =>
            {
                entity.HasKey(e => e.AtendActoCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_atendimento_procedimento");

                entity.Property(e => e.AtendActoCodigo)
                    .HasColumnName("ATEND_ACTO_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendActoAtendimento)
                    .HasColumnName("ATEND_ACTO_ATENDIMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendActoCodigoProfissional)
                    .HasColumnName("ATEND_ACTO_CODIGO_PROFISSIONAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendActoData)
                    .HasColumnName("ATEND_ACTO_DATA")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.AtendActoProcedimento)
                    .HasColumnName("ATEND_ACTO_PROCEDIMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendActoStatus)
                    .HasColumnName("ATEND_ACTO_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.AtendCreatedBy)
                    .HasColumnName("ATEND_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AtendCreatedDate)
                    .HasColumnName("ATEND_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.AtendUpdatedBy)
                    .HasColumnName("ATEND_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AtendUpdatedDate)
                    .HasColumnName("ATEND_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<CliAtendimentoSituacao>(entity =>
            {
                entity.HasKey(e => e.SitCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_atendimento_situacao");

                entity.HasIndex(e => e.SitCodigoAtendimento)
                    .HasName("FK_ATENDIMENTO_SITUACAO");

                entity.HasIndex(e => e.SitCodigoStatus)
                    .HasName("FK_ATENDIMENTO_SITUACAO_STATUS");

                entity.Property(e => e.SitCodigo)
                    .HasColumnName("SIT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SitAccao)
                    .HasColumnName("SIT_ACCAO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.SitCodigoAtendimento)
                    .HasColumnName("SIT_CODIGO_ATENDIMENTO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.SitCodigoStatus)
                    .HasColumnName("SIT_CODIGO_STATUS")
                    .HasColumnType("int(10)");

                entity.Property(e => e.SitData)
                    .HasColumnName("SIT_DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.SitDescricao)
                    .HasColumnName("SIT_DESCRICAO")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SitUtilizador)
                    .IsRequired()
                    .HasColumnName("SIT_UTILIZADOR")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.SitCodigoAtendimentoNavigation)
                    .WithMany(p => p.CliAtendimentoSituacao)
                    .HasForeignKey(d => d.SitCodigoAtendimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_situacao_ibfk_1");

                entity.HasOne(d => d.SitCodigoStatusNavigation)
                    .WithMany(p => p.CliAtendimentoSituacao)
                    .HasForeignKey(d => d.SitCodigoStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_situacao_ibfk_2");
            });

            modelBuilder.Entity<CliAtendimentoTriagem>(entity =>
            {
                entity.HasKey(e => e.TriCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_atendimento_triagem");

                entity.HasIndex(e => e.TriCodigoAtendimento)
                    .HasName("FK_ATENDIMENTO_TRIAGEM");

                entity.Property(e => e.TriCodigo)
                    .HasColumnName("TRI_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TriAltura)
                    .HasColumnName("tri_altura")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TriCodigoAtendimento)
                    .HasColumnName("tri_codigo_atendimento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TriCreatedBy)
                    .HasColumnName("TRI_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TriCreatedDate)
                    .HasColumnName("TRI_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.TriData)
                    .HasColumnName("tri_data")
                    .HasColumnType("datetime");

                entity.Property(e => e.TriFrequenciaRespiratoria)
                    .HasColumnName("tri_frequencia_respiratoria")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TriPeso)
                    .HasColumnName("tri_peso")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TriPulso)
                    .HasColumnName("tri_pulso")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TriQueixa)
                    .HasColumnName("TRI_QUEIXA")
                    .HasColumnType("longtext");

                entity.Property(e => e.TriSaturacaoOxigenio)
                    .HasColumnName("tri_saturacao_oxigenio")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TriTemperatura)
                    .HasColumnName("tri_temperatura")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TriTensao)
                    .HasColumnName("tri_tensao")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TriUpdatedBy)
                    .HasColumnName("TRI_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TriUpdatedDate)
                    .HasColumnName("TRI_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.TriCodigoAtendimentoNavigation)
                    .WithMany(p => p.CliAtendimentoTriagem)
                    .HasForeignKey(d => d.TriCodigoAtendimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_atendimento_triagem_ibfk_1");
            });

            modelBuilder.Entity<CliCategoriaAcomodacoes>(entity =>
            {
                entity.HasKey(e => e.SubCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_categoria_acomodacoes");

                entity.HasIndex(e => e.SubCodigoCategoria)
                    .HasName("FK_CATGEORIA_SUB_CATEGORIA");

                entity.Property(e => e.SubCodigo)
                    .HasColumnName("SUB_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubCodigoCategoria)
                    .HasColumnName("SUB_CODIGO_CATEGORIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubDescricao)
                    .HasColumnName("SUB_DESCRICAO")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.SubStatus)
                    .HasColumnName("SUB_STATUS")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.SubCodigoCategoriaNavigation)
                    .WithMany(p => p.CliCategoriaAcomodacoes)
                    .HasForeignKey(d => d.SubCodigoCategoria)
                    .HasConstraintName("cli_categoria_acomodacoes_ibfk_1");
            });

            modelBuilder.Entity<CliCategoriaProcedimento>(entity =>
            {
                entity.HasKey(e => e.ProcCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_categoria_procedimento");

                entity.Property(e => e.ProcCodigo)
                    .HasColumnName("PROC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcDescricao)
                    .HasColumnName("PROC_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ProcSigla)
                    .HasColumnName("PROC_SIGLA")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ProcStatus)
                    .HasColumnName("PROC_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<CliConsultaDiagnostico>(entity =>
            {
                entity.HasKey(e => new { e.DiaCodigoConsulta, e.DiaCodigoDoenca })
                    .HasName("PRIMARY");

                entity.ToTable("cli_consulta_diagnostico");

                entity.HasIndex(e => e.DiaCodigoDoenca)
                    .HasName("FK_DIAGNOSTICO_DOENCA");

                entity.Property(e => e.DiaCodigoConsulta)
                    .HasColumnName("dia_codigo_consulta")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DiaCodigoDoenca)
                    .HasColumnName("dia_codigo_doenca")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DiaDescricao)
                    .HasColumnName("dia_descricao")
                    .HasColumnType("text");

                entity.HasOne(d => d.DiaCodigoConsultaNavigation)
                    .WithMany(p => p.CliConsultaDiagnostico)
                    .HasForeignKey(d => d.DiaCodigoConsulta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_consulta_diagnostico_ibfk_1");

                entity.HasOne(d => d.DiaCodigoDoencaNavigation)
                    .WithMany(p => p.CliConsultaDiagnostico)
                    .HasForeignKey(d => d.DiaCodigoDoenca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_consulta_diagnostico_ibfk_2");
            });

            modelBuilder.Entity<CliConsultaReceita>(entity =>
            {
                entity.HasKey(e => e.RecCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_consulta_receita");

                entity.HasIndex(e => e.RecAtendimentoId)
                    .HasName("FK_CONSULTA_RECEITA");

                entity.HasIndex(e => e.RecPacientId)
                    .HasName("CLI_RECEITA_PACIENTE");

                entity.HasIndex(e => e.RecProfissonalId)
                    .HasName("CLI_RECEITA_PROFISSIONAL");

                entity.Property(e => e.RecCodigo)
                    .HasColumnName("REC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecAtendimentoId)
                    .HasColumnName("REC_ATENDIMENTO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecCreatedBy)
                    .HasColumnName("REC_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecCreatedDate)
                    .HasColumnName("REC_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.RecData)
                    .HasColumnName("REC_DATA")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.RecDeletedBy)
                    .HasColumnName("REC_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecDeletedDate)
                    .HasColumnName("REC_DELETED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.RecMotivo)
                    .HasColumnName("REC_MOTIVO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RecNumeracao)
                    .HasColumnName("REC_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecPacientId)
                    .HasColumnName("REC_PACIENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecProfissonalId)
                    .HasColumnName("REC_PROFISSONAL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecReference)
                    .HasColumnName("REC_REFERENCE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecSerieId)
                    .HasColumnName("REC_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecStatus)
                    .HasColumnName("REC_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecUpdatedBy)
                    .HasColumnName("REC_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecUpdatedDate)
                    .HasColumnName("REC_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.RecAtendimento)
                    .WithMany(p => p.CliConsultaReceita)
                    .HasForeignKey(d => d.RecAtendimentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CLI_RECEITA_ATENDIMENTO");

                entity.HasOne(d => d.RecPacient)
                    .WithMany(p => p.CliConsultaReceita)
                    .HasForeignKey(d => d.RecPacientId)
                    .HasConstraintName("CLI_RECEITA_PACIENTE");

                entity.HasOne(d => d.RecProfissonal)
                    .WithMany(p => p.CliConsultaReceita)
                    .HasForeignKey(d => d.RecProfissonalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CLI_RECEITA_PROFISSIONAL");
            });

            modelBuilder.Entity<CliConsultaReceitaMedicamento>(entity =>
            {
                entity.HasKey(e => new { e.RecMedCodigoReceita, e.RecMedCodigoMedicamento })
                    .HasName("PRIMARY");

                entity.ToTable("cli_consulta_receita_medicamento");

                entity.HasIndex(e => e.RecMedCodigoMedicamento)
                    .HasName("FK_RECEITA_MEDICAMENTO");

                entity.Property(e => e.RecMedCodigoReceita)
                    .HasColumnName("rec_med_codigo_receita")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecMedCodigoMedicamento).HasColumnName("rec_med_codigo_medicamento");

                entity.Property(e => e.RecMedDescricao)
                    .HasColumnName("rec_med_descricao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RecMedDuracao)
                    .HasColumnName("REC_MED_DURACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecMedQtdEntregue)
                    .HasColumnName("REC_MED_QTD_ENTREGUE")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.RecMedQtdPedida)
                    .HasColumnName("REC_MED_QTD_PEDIDA")
                    .HasColumnType("decimal(18,5)");

                entity.HasOne(d => d.RecMedCodigoMedicamentoNavigation)
                    .WithMany(p => p.CliConsultaReceitaMedicamento)
                    .HasForeignKey(d => d.RecMedCodigoMedicamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_consulta_receita_medicamento_ibfk_2");

                entity.HasOne(d => d.RecMedCodigoReceitaNavigation)
                    .WithMany(p => p.CliConsultaReceitaMedicamento)
                    .HasForeignKey(d => d.RecMedCodigoReceita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_consulta_receita_medicamento_ibfk_1");
            });

            modelBuilder.Entity<CliDoenca>(entity =>
            {
                entity.HasKey(e => e.DoeCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_doenca");

                entity.HasIndex(e => e.DoeSigla)
                    .HasName("CID")
                    .IsUnique();

                entity.Property(e => e.DoeCodigo)
                    .HasColumnName("DOE_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DoeDescricao)
                    .IsRequired()
                    .HasColumnName("DOE_DESCRICAO")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.DoeEstado)
                    .HasColumnName("DOE_ESTADO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DoeSigla)
                    .IsRequired()
                    .HasColumnName("DOE_SIGLA")
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<CliEscalaMedico>(entity =>
            {
                entity.HasKey(e => new { e.EscDiaSemana, e.EscCodigoMedico, e.EscHoraInicio })
                    .HasName("PRIMARY");

                entity.ToTable("cli_escala_medico");

                entity.HasIndex(e => e.EscCodigo)
                    .HasName("UK_ESCALA")
                    .IsUnique();

                entity.HasIndex(e => e.EscCodigoMedico)
                    .HasName("FK_ESCALA_MEDICO");

                entity.HasIndex(e => new { e.EscDiaSemana, e.EscCodigoMedico, e.EscHoraInicio })
                    .HasName("esc_dia_semana_esc_codigo_medico_esc_hora_inicio")
                    .IsUnique();

                entity.Property(e => e.EscDiaSemana)
                    .HasColumnName("ESC_DIA_SEMANA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EscCodigoMedico)
                    .HasColumnName("ESC_CODIGO_MEDICO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EscHoraInicio)
                    .HasColumnName("ESC_HORA_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.EscCodigo)
                    .HasColumnName("ESC_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EscHoraTermino)
                    .HasColumnName("ESC_HORA_TERMINO")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.EscCodigoMedicoNavigation)
                    .WithMany(p => p.CliEscalaMedico)
                    .HasForeignKey(d => d.EscCodigoMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_escala_medico_ibfk_1");
            });

            modelBuilder.Entity<CliEspecialidade>(entity =>
            {
                entity.HasKey(e => e.EspCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_especialidade");

                entity.Property(e => e.EspCodigo)
                    .HasColumnName("esp_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EspDescricao)
                    .IsRequired()
                    .HasColumnName("esp_descricao")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EspEstado)
                    .HasColumnName("ESP_ESTADO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.EspSigla)
                    .HasColumnName("ESP_SIGLA")
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<CliInternamento>(entity =>
            {
                entity.HasKey(e => e.IntCodigoAtendimento)
                    .HasName("PRIMARY");

                entity.ToTable("cli_internamento");

                entity.HasIndex(e => e.IntCodigoMotivo)
                    .HasName("FK_INTERNAMENTO_MOTIVO");

                entity.Property(e => e.IntCodigoAtendimento)
                    .HasColumnName("INT_CODIGO_ATENDIMENTO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IntCodigoMotivo)
                    .HasColumnName("INT_CODIGO_MOTIVO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IntObservacao)
                    .HasColumnName("INT_OBSERVACAO")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<CliInternamentoAcomodacao>(entity =>
            {
                entity.HasKey(e => new { e.IntAcoCodigoInternamento, e.IntAcoCodigoAcomodacao })
                    .HasName("PRIMARY");

                entity.ToTable("cli_internamento_acomodacao");

                entity.HasIndex(e => e.IntAcoCodigoAcomodacao)
                    .HasName("FK_INT_ACO_ACOMODACAO");

                entity.Property(e => e.IntAcoCodigoInternamento)
                    .HasColumnName("INT_ACO_CODIGO_INTERNAMENTO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IntAcoCodigoAcomodacao)
                    .HasColumnName("INT_ACO_CODIGO_ACOMODACAO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IntDataEntrada)
                    .HasColumnName("INT_DATA_ENTRADA")
                    .HasColumnType("date");

                entity.Property(e => e.IntDataSaida)
                    .HasColumnName("INT_DATA_SAIDA")
                    .HasColumnType("date");

                entity.HasOne(d => d.IntAcoCodigoInternamentoNavigation)
                    .WithMany(p => p.CliInternamentoAcomodacao)
                    .HasForeignKey(d => d.IntAcoCodigoInternamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_internamento_acomodacao_ibfk_2");
            });

            modelBuilder.Entity<CliMedico>(entity =>
            {
                entity.HasKey(e => e.MedCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_medico");

                entity.HasIndex(e => e.MedCodigo)
                    .HasName("med_codigo")
                    .IsUnique();

                entity.HasIndex(e => e.MedCodigoEspecialidade)
                    .HasName("FK_MEDICO_ESPECIALIDADE");

                entity.HasIndex(e => e.MedNroOma)
                    .HasName("med_nro_oma")
                    .IsUnique();

                entity.Property(e => e.MedCodigo)
                    .HasColumnName("med_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MedCodigoEspecialidade)
                    .HasColumnName("med_codigo_especialidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MedNome)
                    .IsRequired()
                    .HasColumnName("med_nome")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MedNroOma)
                    .IsRequired()
                    .HasColumnName("med_nro_oma")
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.MedCodigoEspecialidadeNavigation)
                    .WithMany(p => p.CliMedico)
                    .HasForeignKey(d => d.MedCodigoEspecialidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_medico_ibfk_1");
            });

            modelBuilder.Entity<CliPacienteConvenio>(entity =>
            {
                entity.HasKey(e => new { e.PacConvCodigoPlano, e.PacConvCodigoPaciente })
                    .HasName("PRIMARY");

                entity.ToTable("cli_paciente_convenio");

                entity.HasIndex(e => e.PacConvCodigoPaciente)
                    .HasName("FK_ PACIENTE");

                entity.HasIndex(e => e.PacConvTitular)
                    .HasName("FK_PACIENTE_CONVENIO_TITULAR_idx");

                entity.Property(e => e.PacConvCodigoPlano)
                    .HasColumnName("PAC_CONV_CODIGO_PLANO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PacConvCodigoPaciente)
                    .HasColumnName("PAC_CONV_CODIGO_PACIENTE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PacConvApolice)
                    .IsRequired()
                    .HasColumnName("PAC_CONV_APOLICE")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PacConvInicio)
                    .HasColumnName("PAC_CONV_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.PacConvPs)
                    .HasColumnName("PAC_CONV_PS")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PacConvTitular)
                    .HasColumnName("PAC_CONV_TITULAR")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PacConvValidade)
                    .HasColumnName("PAC_CONV_VALIDADE")
                    .HasColumnType("date");

                entity.HasOne(d => d.PacConvCodigoPacienteNavigation)
                    .WithMany(p => p.CliPacienteConvenio)
                    .HasPrincipalKey(p => p.UteCodigoEntidade)
                    .HasForeignKey(d => d.PacConvCodigoPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_paciente_convenio_ibfk_1");

                entity.HasOne(d => d.PacConvCodigoPlanoNavigation)
                    .WithMany(p => p.CliPacienteConvenio)
                    .HasForeignKey(d => d.PacConvCodigoPlano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_paciente_convenio_ibfk_2");
            });

            modelBuilder.Entity<CliPlanoConvenio>(entity =>
            {
                entity.HasKey(e => e.ConvCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_plano_convenio");

                entity.HasIndex(e => e.ConvCodigoSeguradora)
                    .HasName("FK_CONVENIO_SEGURADORA");

                entity.Property(e => e.ConvCodigo)
                    .HasColumnName("CONV_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConvCodigoSeguradora)
                    .HasColumnName("CONV_CODIGO_SEGURADORA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConvCreatedBy)
                    .HasColumnName("CONV_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ConvCreatedDate)
                    .HasColumnName("CONV_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.ConvDescricao)
                    .IsRequired()
                    .HasColumnName("CONV_DESCRICAO")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ConvPercentual)
                    .HasColumnName("CONV_PERCENTUAL")
                    .HasColumnType("double(18,2)");

                entity.Property(e => e.ConvPercentualUtente)
                    .HasColumnName("CONV_PERCENTUAL_UTENTE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ConvStatus)
                    .HasColumnName("CONV_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ConvTipo)
                    .HasColumnName("CONV_TIPO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ConvUpdatedBy)
                    .HasColumnName("CONV_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ConvUpdatedDate)
                    .HasColumnName("CONV_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.ConvCodigoSeguradoraNavigation)
                    .WithMany(p => p.CliPlanoConvenio)
                    .HasForeignKey(d => d.ConvCodigoSeguradora)
                    .HasConstraintName("cli_plano_convenio_ibfk_1");
            });

            modelBuilder.Entity<CliPlanoConvenioCobertura>(entity =>
            {
                entity.HasKey(e => new { e.CobCodigoConvenio, e.CobCodigoServico })
                    .HasName("PRIMARY");

                entity.ToTable("cli_plano_convenio_cobertura");

                entity.HasIndex(e => e.CobCodigoServico)
                    .HasName("FK_CONVENIO_COBERTURA_SERVICO");

                entity.Property(e => e.CobCodigoConvenio)
                    .HasColumnName("COB_CODIGO_CONVENIO")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CobCodigoServico)
                    .HasColumnName("COB_CODIGO_SERVICO")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CobCreatedBy)
                    .HasColumnName("COB_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CobCreatedDate)
                    .HasColumnName("COB_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.CobStatus)
                    .HasColumnName("COB_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.CobUpdatedBy)
                    .HasColumnName("COB_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CobUpdatedDate)
                    .HasColumnName("COB_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.CobValorParceiro)
                    .HasColumnName("COB_VALOR_PARCEIRO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.CobValorUtente)
                    .HasColumnName("COB_VALOR_UTENTE")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.CobCodigoConvenioNavigation)
                    .WithMany(p => p.CliPlanoConvenioCobertura)
                    .HasForeignKey(d => d.CobCodigoConvenio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_plano_convenio_cobertura_ibfk_1");

                entity.HasOne(d => d.CobCodigoServicoNavigation)
                    .WithMany(p => p.CliPlanoConvenioCobertura)
                    .HasForeignKey(d => d.CobCodigoServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_plano_convenio_cobertura_ibfk_2");
            });

            modelBuilder.Entity<CliProcessoClinico>(entity =>
            {
                entity.HasKey(e => e.ProcCodigoPaciente)
                    .HasName("PRIMARY");

                entity.ToTable("cli_processo_clinico");

                entity.HasIndex(e => e.ProcCodigoPaciente)
                    .HasName("cli_processo_clinico_PK_CLI_PROCESSO_CLINICO_ndx");

                entity.Property(e => e.ProcCodigoPaciente)
                    .HasColumnName("proc_codigo_paciente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcCodigoStatus)
                    .HasColumnName("proc_codigo_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcDataAbertura)
                    .HasColumnName("proc_data_abertura")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcDataEncerramento)
                    .HasColumnName("proc_data_encerramento")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CliServico>(entity =>
            {
                entity.HasKey(e => e.SerCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_servico");

                entity.HasIndex(e => e.SerCodigoEspecialidade)
                    .HasName("FK_SERVICO_ESPECIALIDADE");

                entity.Property(e => e.SerCodigo)
                    .HasColumnName("SER_CODIGO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.SerCodigoEspecialidade)
                    .HasColumnName("SER_CODIGO_ESPECIALIDADE")
                    .HasColumnType("int(10)");

                entity.Property(e => e.SerDuracao)
                    .HasColumnName("SER_DURACAO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.SerStatus)
                    .HasColumnName("SER_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SerTipo)
                    .HasColumnName("SER_TIPO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.SerUnidade)
                    .HasColumnName("SER_UNIDADE")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.SerValor).HasColumnName("SER_VALOR");

                entity.HasOne(d => d.SerCodigoEspecialidadeNavigation)
                    .WithMany(p => p.CliServico)
                    .HasForeignKey(d => d.SerCodigoEspecialidade)
                    .HasConstraintName("cli_servico_ibfk_1");
            });

            modelBuilder.Entity<CliStatus>(entity =>
            {
                entity.HasKey(e => e.StaCodigoStatus)
                    .HasName("PRIMARY");

                entity.ToTable("cli_status");

                entity.HasIndex(e => e.StaCodigoStatus)
                    .HasName("FK_CLI_STATUS_idx");

                entity.Property(e => e.StaCodigoStatus)
                    .HasColumnName("STA_CODIGO_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StaAccao)
                    .HasColumnName("STA_ACCAO")
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.StaCodigoStatusNavigation)
                    .WithOne(p => p.CliStatus)
                    .HasForeignKey<CliStatus>(d => d.StaCodigoStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_status_ibfk_1");
            });

            modelBuilder.Entity<CliUtente>(entity =>
            {
                entity.HasKey(e => e.UteCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("cli_utente");

                entity.HasIndex(e => e.UteCodigoEntidade)
                    .HasName("UK_ENTIDADE_UTENTE")
                    .IsUnique();

                entity.Property(e => e.UteCodigo)
                    .HasColumnName("UTE_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UteCodigoDeficiencia)
                    .HasColumnName("UTE_CODIGO_DEFICIENCIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UteCodigoEntidade)
                    .HasColumnName("UTE_CODIGO_ENTIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UteCreatedBy)
                    .HasColumnName("UTE_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UteCreatedDate)
                    .HasColumnName("UTE_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.UteDataAbertura)
                    .HasColumnName("UTE_DATA_ABERTURA")
                    .HasColumnType("date");

                entity.Property(e => e.UteStatus)
                    .HasColumnName("UTE_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.UteUpdateBy)
                    .HasColumnName("UTE_UPDATE_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UteUpdatedDate)
                    .HasColumnName("UTE_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<ComAnoFaturacao>(entity =>
            {
                entity.HasKey(e => new { e.AnoAno, e.AnoCodigoFilial })
                    .HasName("PRIMARY");

                entity.ToTable("com_ano_faturacao");

                entity.HasIndex(e => e.AnoCodigoFilial)
                    .HasName("FK_SERIE_FATURACAO_FILIAL");

                entity.Property(e => e.AnoAno)
                    .HasColumnName("ANO_ANO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnoCodigoFilial)
                    .HasColumnName("ANO_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnoCreatedBy)
                    .HasColumnName("ANO_CREATED_BY")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.AnoCreatedDate)
                    .HasColumnName("ANO_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.AnoDeleted)
                    .HasColumnName("ANO_DELETED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.AnoDescricao)
                    .HasColumnName("ANO_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.AnoInicio)
                    .HasColumnName("ANO_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.AnoIsActive)
                    .HasColumnName("ANO_IS_ACTIVE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.AnoTermino)
                    .HasColumnName("ANO_TERMINO")
                    .HasColumnType("date");

                entity.Property(e => e.AnoUpdatedBy)
                    .HasColumnName("ANO_UPDATED_BY")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.AnoUpdatedDate)
                    .HasColumnName("ANO_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AnoCodigoFilialNavigation)
                    .WithMany(p => p.ComAnoFaturacao)
                    .HasForeignKey(d => d.AnoCodigoFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_ano_faturacao_ibfk_1");
            });

            modelBuilder.Entity<ComArtigoFornecedor>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.SupplierId })
                    .HasName("PRIMARY");

                entity.ToTable("com_artigo_fornecedor");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("FK_PRODUCT_SUPPLIER_SUPPLIER");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SUPPLIER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Main)
                    .HasColumnName("MAIN")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ComArtigoFornecedor)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCT_SUPPLIER_PRODUCT");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ComArtigoFornecedor)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUCT_SUPPLIER_SUPPLIER");
            });

            modelBuilder.Entity<ComArtigoPrinters>(entity =>
            {
                entity.HasKey(e => new { e.PrintProductId, e.PrintId })
                    .HasName("PRIMARY");

                entity.ToTable("com_artigo_printers");

                entity.Property(e => e.PrintProductId)
                    .HasColumnName("PRINT_PRODUCT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrintId)
                    .HasColumnName("PRINT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CopyNumber)
                    .HasColumnName("COPY_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ComCambio>(entity =>
            {
                entity.HasKey(e => e.CamCodigoMoeda)
                    .HasName("PRIMARY");

                entity.ToTable("com_cambio");

                entity.Property(e => e.CamCodigoMoeda)
                    .HasColumnName("CAM_CODIGO_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CamData)
                    .HasColumnName("CAM_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.CamValor)
                    .HasColumnName("CAM_VALOR")
                    .HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<ComCatalogoDocumentoAcao>(entity =>
            {
                entity.HasKey(e => e.DocMovCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_catalogo_documento_acao");

                entity.Property(e => e.DocMovCodigo)
                    .HasColumnName("DOC_MOV_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocMovAccao)
                    .HasColumnName("DOC_MOV_ACCAO")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.DocMovCodigoDocumento)
                    .HasColumnName("DOC_MOV_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocMovDescricao)
                    .IsRequired()
                    .HasColumnName("DOC_MOV_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.DocStatus)
                    .HasColumnName("DOC_STATUS")
                    .HasColumnType("smallint(1)");
            });

            modelBuilder.Entity<ComCatalogoDocumentos>(entity =>
            {
                entity.HasKey(e => e.CatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_catalogo_documentos");

                entity.Property(e => e.CatCodigo)
                    .HasColumnName("CAT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatDescricao)
                    .HasColumnName("CAT_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.CatSigla)
                    .HasColumnName("CAT_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.CatStatus)
                    .HasColumnName("CAT_STATUS")
                    .HasColumnType("smallint(1)");
            });

            modelBuilder.Entity<ComCobrancaDocumentos>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.TaskDocId })
                    .HasName("PRIMARY");

                entity.ToTable("com_cobranca_documentos");

                entity.HasIndex(e => e.TaskDocId)
                    .HasName("FK_COBRANCA_DOCUMENT");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TASK_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskDocId)
                    .HasColumnName("TASK_DOC_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.TaskDoc)
                    .WithMany(p => p.ComCobrancaDocumentos)
                    .HasForeignKey(d => d.TaskDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COBRANCA_DOCUMENT");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ComCobrancaDocumentos)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COBRANCA_TAREFA_ID");
            });

            modelBuilder.Entity<ComCondicaoPagamento>(entity =>
            {
                entity.HasKey(e => e.PagCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_condicao_pagamento");

                entity.Property(e => e.PagCodigo)
                    .HasColumnName("PAG_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PagCondicao)
                    .HasColumnName("PAG_CONDICAO")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.PagCreatedBy)
                    .HasColumnName("PAG_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PagCreatedDate)
                    .HasColumnName("PAG_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PagDeletedBy)
                    .HasColumnName("PAG_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PagDeletedDate)
                    .HasColumnName("PAG_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PagDescontoFinanceiro)
                    .HasColumnName("PAG_DESCONTO_FINANCEIRO")
                    .HasColumnType("decimal(18,0)");

                entity.Property(e => e.PagDescricao)
                    .HasColumnName("PAG_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PagEntradaInicial)
                    .HasColumnName("PAG_ENTRADA_INICIAL")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.PagPeriodicidade)
                    .HasColumnName("PAG_PERIODICIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PagPrestacoes)
                    .HasColumnName("PAG_PRESTACOES")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.PagSigla)
                    .HasColumnName("PAG_SIGLA")
                    .HasColumnType("int(10)");

                entity.Property(e => e.PagStatus)
                    .HasColumnName("PAG_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PagUpdatedBy)
                    .HasColumnName("PAG_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PagUpdatedDate)
                    .HasColumnName("PAG_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PagVencimento)
                    .HasColumnName("PAG_VENCIMENTO")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ComContratos>(entity =>
            {
                entity.HasKey(e => e.ContCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_contratos");

                entity.HasIndex(e => e.ContEntidadeId)
                    .HasName("FK_CONTRATO_ENTIDADE");

                entity.HasIndex(e => e.ContSerieId)
                    .HasName("FK_CONTRATO_SERIE");

                entity.Property(e => e.ContCodigo)
                    .HasColumnName("CONT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContCambio)
                    .HasColumnName("CONT_CAMBIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ContCreatedBy)
                    .HasColumnName("CONT_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ContCreatedDate)
                    .HasColumnName("CONT_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContData)
                    .HasColumnName("CONT_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.ContDescontoComercial)
                    .HasColumnName("CONT_DESCONTO_COMERCIAL")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ContDescontoFinaceiro)
                    .HasColumnName("CONT_DESCONTO_FINACEIRO")
                    .HasColumnType("double(18,5)");

                entity.Property(e => e.ContEntidadeId)
                    .HasColumnName("CONT_ENTIDADE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContEstado)
                    .HasColumnName("CONT_ESTADO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContMoedaId)
                    .HasColumnName("CONT_MOEDA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContNumeracao)
                    .HasColumnName("CONT_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContPaymentMethodId)
                    .HasColumnName("CONT_PAYMENT_METHOD_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContPaymentTermsId)
                    .HasColumnName("CONT_PAYMENT_TERMS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContReferencia)
                    .HasColumnName("CONT_REFERENCIA")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ContRenovavel)
                    .HasColumnName("CONT_RENOVAVEL")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ContSerieId)
                    .HasColumnName("CONT_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContUpdatedBy)
                    .HasColumnName("CONT_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ContUpdatedDate)
                    .HasColumnName("CONT_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContValidadeAte)
                    .HasColumnName("CONT_VALIDADE_ATE")
                    .HasColumnType("date");

                entity.Property(e => e.ContValidadeDe)
                    .HasColumnName("CONT_VALIDADE_DE")
                    .HasColumnType("date");

                entity.Property(e => e.ContValor)
                    .HasColumnName("CONT_VALOR")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ContVersao)
                    .HasColumnName("CONT_VERSAO")
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.ContEntidade)
                    .WithMany(p => p.ComContratos)
                    .HasForeignKey(d => d.ContEntidadeId)
                    .HasConstraintName("FK_CONTRATO_ENTIDADE");

                entity.HasOne(d => d.ContSerie)
                    .WithMany(p => p.ComContratos)
                    .HasForeignKey(d => d.ContSerieId)
                    .HasConstraintName("FK_CONTRATO_SERIE");
            });

            modelBuilder.Entity<ComDocumento>(entity =>
            {
                entity.HasKey(e => e.DocCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_documento");

                entity.HasIndex(e => e.DocCodigoParent)
                    .HasName("FK_DOCUMEN_PARENT");

                entity.HasIndex(e => e.DocFormato)
                    .HasName("fk_com_documento_format_type");

                entity.Property(e => e.DocCodigo)
                    .HasColumnName("DOC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocCaixa)
                    .HasColumnName("DOC_CAIXA")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.DocCategoria)
                    .HasColumnName("DOC_CATEGORIA")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.DocCc)
                    .HasColumnName("DOC_CC")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.DocCodigoParent)
                    .HasColumnName("DOC_CODIGO_PARENT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocCreatedBy)
                    .HasColumnName("DOC_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DocCreatedDate)
                    .HasColumnName("DOC_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocDeleted)
                    .HasColumnName("DOC_DELETED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DocDeletedBy)
                    .HasColumnName("DOC_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DocDeletedDate)
                    .HasColumnName("DOC_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocDescricao)
                    .IsRequired()
                    .HasColumnName("DOC_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.DocEstado)
                    .HasColumnName("DOC_ESTADO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DocFormato)
                    .HasColumnName("DOC_FORMATO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.DocLink)
                    .HasColumnName("DOC_LINK")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DocSigla)
                    .HasColumnName("DOC_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.DocStock)
                    .HasColumnName("DOC_STOCK")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.DocTemplate)
                    .HasColumnName("DOC_TEMPLATE")
                    .HasColumnType("longtext");

                entity.Property(e => e.DocTipo)
                    .HasColumnName("DOC_TIPO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.DocUpdatedBy)
                    .HasColumnName("DOC_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DocUpdatedDate)
                    .HasColumnName("DOC_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.DocCodigoParentNavigation)
                    .WithMany(p => p.InverseDocCodigoParentNavigation)
                    .HasForeignKey(d => d.DocCodigoParent)
                    .HasConstraintName("com_documento_parent_id");

                entity.HasOne(d => d.DocFormatoNavigation)
                    .WithMany(p => p.ComDocumento)
                    .HasForeignKey(d => d.DocFormato)
                    .HasConstraintName("fk_com_documento_format_type");
            });

            modelBuilder.Entity<ComDocumentoConversao>(entity =>
            {
                entity.HasKey(e => new { e.DocOriginalId, e.DocConvertId })
                    .HasName("PRIMARY");

                entity.ToTable("com_documento_conversao");

                entity.HasIndex(e => e.DocConvertId)
                    .HasName("FK_CONVERT_DOCUMENT");

                entity.Property(e => e.DocOriginalId)
                    .HasColumnName("DOC_ORIGINAL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocConvertId)
                    .HasColumnName("DOC_CONVERT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocConvertableType)
                    .HasColumnName("DOC_CONVERTABLE_TYPE")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DocOriginalType)
                    .HasColumnName("DOC_ORIGINAL_TYPE")
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.DocConvert)
                    .WithMany(p => p.ComDocumentoConversaoDocConvert)
                    .HasForeignKey(d => d.DocConvertId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONVERT_DOCUMENT");

                entity.HasOne(d => d.DocOriginal)
                    .WithMany(p => p.ComDocumentoConversaoDocOriginal)
                    .HasForeignKey(d => d.DocOriginalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORIGINAL_DOCUMENT");
            });

            modelBuilder.Entity<ComDocumentoUtilizadorAcesso>(entity =>
            {
                entity.HasKey(e => e.DocAceCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_documento_utilizador_acesso");

                entity.Property(e => e.DocAceCodigo)
                    .HasColumnName("DOC_ACE_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocAceCodigoDocumento)
                    .HasColumnName("DOC_ACE_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocAceCodigoPerfil)
                    .HasColumnName("DOC_ACE_CODIGO_PERFIL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocAceDelete)
                    .HasColumnName("DOC_ACE_DELETE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DocAceInsert)
                    .HasColumnName("DOC_ACE_INSERT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DocAceSelect)
                    .HasColumnName("DOC_ACE_SELECT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DocAceUpdate)
                    .HasColumnName("DOC_ACE_UPDATE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DocAceUtilizador)
                    .HasColumnName("DOC_ACE_UTILIZADOR")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<ComExpedicao>(entity =>
            {
                entity.HasKey(e => e.ExpCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_expedicao");

                entity.Property(e => e.ExpCodigo)
                    .HasColumnName("EXP_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExpDescricao)
                    .HasColumnName("EXP_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ExpSigla)
                    .HasColumnName("EXP_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ExpStatus)
                    .HasColumnName("EXP_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<ComFatSuspensa>(entity =>
            {
                entity.HasKey(e => e.ComFatSuspCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_fat_suspensa");

                entity.Property(e => e.ComFatSuspCodigo)
                    .HasColumnName("COM_FAT_SUSP_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatSuspArtigo)
                    .HasColumnName("COM_FAT_SUSP_ARTIGO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ComFatSuspData)
                    .HasColumnName("COM_FAT_SUSP_DATA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ComFatSuspDesconto)
                    .HasColumnName("COM_FAT_SUSP_DESCONTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspImposto)
                    .HasColumnName("COM_FAT_SUSP_IMPOSTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspPrecoUnitario)
                    .HasColumnName("COM_FAT_SUSP_PRECO_UNITARIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspQuantidade)
                    .HasColumnName("COM_FAT_SUSP_QUANTIDADE")
                    .HasColumnType("decimal(18,1)");

                entity.Property(e => e.ComFatSuspRefArtigo)
                    .HasColumnName("COM_FAT_SUSP_REF_ARTIGO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ComFatSuspReferencia)
                    .HasColumnName("COM_FAT_SUSP_REFERENCIA")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ComFatSuspTotallinha)
                    .HasColumnName("COM_FAT_SUSP_TOTALLINHA")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspUtilizador)
                    .IsRequired()
                    .HasColumnName("COM_FAT_SUSP_UTILIZADOR")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<ComFaturaCliente>(entity =>
            {
                entity.HasKey(e => e.FatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_fatura_cliente");

                entity.HasIndex(e => e.FatCodigoArmazem)
                    .HasName("FK_FATURA_CLIENTE_ARMAZEM");

                entity.HasIndex(e => e.FatCodigoCliente)
                    .HasName("FK_FATURA_CLIENTE_CLIENTE");

                entity.HasIndex(e => e.FatCodigoDocumento)
                    .HasName("FK_FATURA_CLIENTE_DOCUMENTO");

                entity.HasIndex(e => e.FatCodigoExpedicao)
                    .HasName("FK_FATURA_CLIENTE_EXPEDICAO");

                entity.HasIndex(e => e.FatCodigoFilial)
                    .HasName("FK_FATURA_CLIENTE_FILIAL");

                entity.HasIndex(e => e.FatCodigoMoeda)
                    .HasName("FK_FATURA_CLIENTE_MOEDA");

                entity.HasIndex(e => e.FatCodigoSerie)
                    .HasName("FK_FATURA_CLIENTE_SERIE");

                entity.HasIndex(e => e.FatCondicaoPagamento)
                    .HasName("FK_FATURA_CLIENTE_PRAZO_PAGAMENTO");

                entity.HasIndex(e => e.FatEntityBillId)
                    .HasName("FK_FATURA_CLIENTE_ENTIDADE_FATURAR");

                entity.Property(e => e.FatCodigo)
                    .HasColumnName("FAT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatAgtSent)
                    .HasColumnName("FAT_AGT_SENT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FatAgtSentBy)
                    .HasColumnName("FAT_AGT_SENT_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatAgtSentDate)
                    .HasColumnName("FAT_AGT_SENT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatBarcode)
                    .HasColumnName("FAT_BARCODE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FatCambio)
                    .HasColumnName("FAT_CAMBIO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatCodigoArmazem)
                    .HasColumnName("FAT_CODIGO_ARMAZEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoCliente)
                    .HasColumnName("FAT_CODIGO_CLIENTE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoDocumento)
                    .HasColumnName("FAT_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoExpedicao)
                    .HasColumnName("FAT_CODIGO_EXPEDICAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoFilial)
                    .HasColumnName("FAT_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoMoeda)
                    .HasColumnName("FAT_CODIGO_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoSerie)
                    .HasColumnName("FAT_CODIGO_SERIE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoVendedor)
                    .HasColumnName("FAT_CODIGO_VENDEDOR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCondicaoPagamento)
                    .HasColumnName("FAT_CONDICAO_PAGAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatContactoDestino)
                    .HasColumnName("FAT_CONTACTO_DESTINO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatContactoDestinoAlt)
                    .HasColumnName("FAT_CONTACTO_DESTINO_ALT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatCreatedBy)
                    .HasColumnName("FAT_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatCreatedDate)
                    .HasColumnName("FAT_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatCustomerCredit)
                    .HasColumnName("FAT_CUSTOMER_CREDIT")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatCustomerSent)
                    .HasColumnName("FAT_CUSTOMER_SENT")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.FatCustomerSentBy)
                    .HasColumnName("FAT_CUSTOMER_SENT_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatCustomerSentDate)
                    .HasColumnName("FAT_CUSTOMER_SENT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatCustomerVat)
                    .HasColumnName("FAT_CUSTOMER_VAT")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.FatDataCarga)
                    .HasColumnName("FAT_DATA_CARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDataDescarga)
                    .HasColumnName("FAT_DATA_DESCARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDataEmissao)
                    .HasColumnName("FAT_DATA_EMISSAO")
                    .HasColumnType("date");

                entity.Property(e => e.FatDataEntrega)
                    .HasColumnName("FAT_DATA_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDataLiquidacao)
                    .HasColumnName("FAT_DATA_LIQUIDACAO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDataValidade)
                    .HasColumnName("FAT_DATA_VALIDADE")
                    .HasColumnType("date");

                entity.Property(e => e.FatDeletedBy)
                    .HasColumnName("FAT_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatDeletedDate)
                    .HasColumnName("FAT_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDesconto)
                    .HasColumnName("FAT_DESCONTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatDescontoCliente)
                    .HasColumnName("FAT_DESCONTO_CLIENTE")
                    .HasColumnType("decimal(18,0)");

                entity.Property(e => e.FatDocumentoOrigem)
                    .HasColumnName("FAT_DOCUMENTO_ORIGEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatEntityBillId)
                    .HasColumnName("FAT_ENTITY_BILL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatHashTag)
                    .HasColumnName("FAT_HASH_TAG")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FatLocalCarga)
                    .HasColumnName("FAT_LOCAL_CARGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatLocalDescarga)
                    .HasColumnName("FAT_LOCAL_DESCARGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatMatriculaCarga)
                    .HasColumnName("FAT_MATRICULA_CARGA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatMoradaCarga)
                    .HasColumnName("FAT_MORADA_CARGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatMoradaDescarga)
                    .HasColumnName("FAT_MORADA_DESCARGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatMotivoAnulacao)
                    .HasColumnName("FAT_MOTIVO_ANULACAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FatNomeCliente)
                    .HasColumnName("FAT_NOME_CLIENTE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatNotasComerciais)
                    .HasColumnName("FAT_NOTAS_COMERCIAIS")
                    .HasColumnType("longtext");

                entity.Property(e => e.FatNotasInternas)
                    .HasColumnName("FAT_NOTAS_INTERNAS")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FatNumeracao)
                    .HasColumnName("FAT_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatNumeroDocOrigem)
                    .HasColumnName("FAT_NUMERO_DOC_ORIGEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatObservacoes)
                    .HasColumnName("FAT_OBSERVACOES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FatPaid)
                    .HasColumnName("FAT_PAID")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.FatParcela)
                    .HasColumnName("FAT_PARCELA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatRecepcao)
                    .HasColumnName("FAT_RECEPCAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatRectified)
                    .HasColumnName("FAT_RECTIFIED")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.FatRectifierDocumentId)
                    .HasColumnName("FAT_RECTIFIER_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatReferencia)
                    .HasColumnName("FAT_REFERENCIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatResponsavelCarga)
                    .HasColumnName("FAT_RESPONSAVEL_CARGA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatResponsavelEntrega)
                    .HasColumnName("FAT_RESPONSAVEL_ENTREGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatSaftSourceBilling)
                    .HasColumnName("FAT_SAFT_SOURCE_BILLING")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.FatSaftStatus)
                    .HasColumnName("FAT_SAFT_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.FatStatus)
                    .HasColumnName("FAT_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatStatusComercial)
                    .HasColumnName("FAT_STATUS_COMERCIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatStatusDocumento)
                    .HasColumnName("FAT_STATUS_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatStatusPagamento)
                    .HasColumnName("FAT_STATUS_PAGAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatTotalDescontos)
                    .HasColumnName("FAT_TOTAL_DESCONTOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatTotalImpostos)
                    .HasColumnName("FAT_TOTAL_IMPOSTOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatTotalLiquido)
                    .HasColumnName("FAT_TOTAL_LIQUIDO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatTroco)
                    .HasColumnName("FAT_TROCO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatUpdateBy)
                    .HasColumnName("FAT_UPDATE_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatUpdatedDate)
                    .HasColumnName("FAT_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatValorBruto)
                    .HasColumnName("FAT_VALOR_BRUTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorCiva)
                    .HasColumnName("FAT_VALOR_CIVA")
                    .HasColumnType("decimal(18,5)")
                    .HasDefaultValueSql("'0.00000'");

                entity.Property(e => e.FatValorComissoes)
                    .HasColumnName("FAT_VALOR_COMISSOES")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorPago)
                    .HasColumnName("FAT_VALOR_PAGO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorRetencao)
                    .HasColumnName("FAT_VALOR_RETENCAO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorSaldo)
                    .HasColumnName("FAT_VALOR_SALDO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorSiva)
                    .HasColumnName("FAT_VALOR_SIVA")
                    .HasColumnType("decimal(18,5)")
                    .HasDefaultValueSql("'0.00000'");

                entity.Property(e => e.FatValorTotal)
                    .HasColumnName("FAT_VALOR_TOTAL")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.FatCodigoArmazemNavigation)
                    .WithMany(p => p.ComFaturaCliente)
                    .HasForeignKey(d => d.FatCodigoArmazem)
                    .HasConstraintName("com_fatura_cliente_ibfk_1");

                entity.HasOne(d => d.FatCodigoClienteNavigation)
                    .WithMany(p => p.ComFaturaClienteFatCodigoClienteNavigation)
                    .HasForeignKey(d => d.FatCodigoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_cliente_ibfk_2");

                entity.HasOne(d => d.FatCodigoDocumentoNavigation)
                    .WithMany(p => p.ComFaturaCliente)
                    .HasForeignKey(d => d.FatCodigoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_cliente_ibfk_3");

                entity.HasOne(d => d.FatCodigoExpedicaoNavigation)
                    .WithMany(p => p.ComFaturaCliente)
                    .HasForeignKey(d => d.FatCodigoExpedicao)
                    .HasConstraintName("com_fatura_cliente_ibfk_4");

                entity.HasOne(d => d.FatCodigoFilialNavigation)
                    .WithMany(p => p.ComFaturaCliente)
                    .HasForeignKey(d => d.FatCodigoFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_cliente_ibfk_5");

                entity.HasOne(d => d.FatCodigoMoedaNavigation)
                    .WithMany(p => p.ComFaturaCliente)
                    .HasForeignKey(d => d.FatCodigoMoeda)
                    .HasConstraintName("com_fatura_cliente_ibfk_6");

                entity.HasOne(d => d.FatCodigoSerieNavigation)
                    .WithMany(p => p.ComFaturaCliente)
                    .HasForeignKey(d => d.FatCodigoSerie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_cliente_ibfk_8");

                entity.HasOne(d => d.FatCondicaoPagamentoNavigation)
                    .WithMany(p => p.ComFaturaCliente)
                    .HasForeignKey(d => d.FatCondicaoPagamento)
                    .HasConstraintName("com_fatura_cliente_ibfk_7");

                entity.HasOne(d => d.FatEntityBill)
                    .WithMany(p => p.ComFaturaClienteFatEntityBill)
                    .HasForeignKey(d => d.FatEntityBillId)
                    .HasConstraintName("FK_FATURA_CLIENTE_ENTIDADE_FATURAR");
            });

            modelBuilder.Entity<ComFaturaClienteItem>(entity =>
            {
                entity.HasKey(e => new { e.FatItemCodigoArtigo, e.FatItemCodigoFatura })
                    .HasName("PRIMARY");

                entity.ToTable("com_fatura_cliente_item");

                entity.HasIndex(e => e.FatItemCodigo)
                    .HasName("UK_FATURA_ITEM")
                    .IsUnique();

                entity.HasIndex(e => e.FatItemCodigoFatura)
                    .HasName("FK_FATURA_ITEM");

                entity.HasIndex(e => e.FatItemImpostoId)
                    .HasName("FK_FATURA_CLIENTE_IMPOSTO");

                entity.Property(e => e.FatItemCodigoArtigo)
                    .HasColumnName("FAT_ITEM_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemCodigoFatura)
                    .HasColumnName("FAT_ITEM_CODIGO_FATURA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemCodigo)
                    .HasColumnName("FAT_ITEM_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FatItemComentarios)
                    .HasColumnName("FAT_ITEM_COMENTARIOS")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FatItemComposicao)
                    .HasColumnName("FAT_ITEM_COMPOSICAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemCreatedBy)
                    .HasColumnName("FAT_ITEM_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatItemCreatedDate)
                    .HasColumnName("FAT_ITEM_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FatItemDataEntrega)
                    .HasColumnName("FAT_ITEM_DATA_ENTREGA")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FatItemDeletedBy)
                    .HasColumnName("FAT_ITEM_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatItemDeletedDate)
                    .HasColumnName("FAT_ITEM_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatItemDescontoFatura)
                    .HasColumnName("FAT_ITEM_DESCONTO_FATURA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemDescontoFinanceiro)
                    .HasColumnName("FAT_ITEM_DESCONTO_FINANCEIRO")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatItemDescontoLinha)
                    .HasColumnName("FAT_ITEM_DESCONTO_LINHA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemDescontoNumerarioLinha)
                    .HasColumnName("FAT_ITEM_DESCONTO_NUMERARIO_LINHA")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatItemDimensaoId)
                    .HasColumnName("FAT_ITEM_DIMENSAO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemDocOrigemId)
                    .HasColumnName("FAT_ITEM_DOC_ORIGEM_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemDocOrigemLinha)
                    .HasColumnName("FAT_ITEM_DOC_ORIGEM_LINHA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemEnvioDocId)
                    .HasColumnName("FAT_ITEM_ENVIO_DOC_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemEnvioDocLinha)
                    .HasColumnName("FAT_ITEM_ENVIO_DOC_LINHA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemImposto)
                    .HasColumnName("FAT_ITEM_IMPOSTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemImpostoId)
                    .HasColumnName("FAT_ITEM_IMPOSTO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemLoteId)
                    .HasColumnName("FAT_ITEM_LOTE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemPreco)
                    .HasColumnName("FAT_ITEM_PRECO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemPrecoCusto)
                    .HasColumnName("FAT_ITEM_PRECO_CUSTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatItemPriorStock)
                    .HasColumnName("FAT_ITEM_PRIOR_STOCK")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatItemQuantidade)
                    .HasColumnName("FAT_ITEM_QUANTIDADE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemReservada)
                    .HasColumnName("FAT_ITEM_RESERVADA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemSatisfeita)
                    .HasColumnName("FAT_ITEM_SATISFEITA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemSerialnumberId)
                    .HasColumnName("FAT_ITEM_SERIALNUMBER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemStatus)
                    .HasColumnName("FAT_ITEM_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemTotal)
                    .HasColumnName("FAT_ITEM_TOTAL")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemUpdatedBy)
                    .HasColumnName("FAT_ITEM_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatItemUpdatedDate)
                    .HasColumnName("FAT_ITEM_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FatItemValorDescontoFinanceiro)
                    .HasColumnName("FAT_ITEM_VALOR_DESCONTO_FINANCEIRO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatItemValorDescontos)
                    .HasColumnName("FAT_ITEM_VALOR_DESCONTOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemValorImpostos)
                    .HasColumnName("FAT_ITEM_VALOR_IMPOSTOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemWarehouseId)
                    .HasColumnName("FAT_ITEM_WAREHOUSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatOrdem)
                    .HasColumnName("FAT_ORDEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatRetencao)
                    .HasColumnName("FAT_RETENCAO")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.FatItemCodigoArtigoNavigation)
                    .WithMany(p => p.ComFaturaClienteItem)
                    .HasForeignKey(d => d.FatItemCodigoArtigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_cliente_item_ibfk_1");

                entity.HasOne(d => d.FatItemCodigoFaturaNavigation)
                    .WithMany(p => p.ComFaturaClienteItem)
                    .HasForeignKey(d => d.FatItemCodigoFatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_cliente_item_ibfk_2");

                entity.HasOne(d => d.FatItemImpostoNavigation)
                    .WithMany(p => p.ComFaturaClienteItem)
                    .HasForeignKey(d => d.FatItemImpostoId)
                    .HasConstraintName("FK_FATURA_CLIENTE_IMPOSTO");
            });

            modelBuilder.Entity<ComFaturaFornecedor>(entity =>
            {
                entity.HasKey(e => e.FatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_fatura_fornecedor");

                entity.HasIndex(e => e.FatCodigoArmazem)
                    .HasName("FK_FATURA_CLIENTE_ARMAZEM");

                entity.HasIndex(e => e.FatCodigoDocumento)
                    .HasName("FK_FATURA_CLIENTE_DOCUMENTO");

                entity.HasIndex(e => e.FatCodigoExpedicao)
                    .HasName("FK_FATURA_CLIENTE_EXPEDICAO");

                entity.HasIndex(e => e.FatCodigoFilial)
                    .HasName("FK_FATURA_CLIENTE_FILIAL");

                entity.HasIndex(e => e.FatCodigoFornecedor)
                    .HasName("FK_FATURA_CLIENTE_CLIENTE");

                entity.HasIndex(e => e.FatCodigoMoeda)
                    .HasName("FK_FATURA_CLIENTE_MOEDA");

                entity.HasIndex(e => e.FatCodigoSerie)
                    .HasName("FK_FATURA_CLIENTE_SERIE");

                entity.HasIndex(e => e.FatCondicaoPagamento)
                    .HasName("FK_FATURA_CLIENTE_PRAZO_PAGAMENTO");

                entity.HasIndex(e => e.FatEntityBillId)
                    .HasName("FK_FATURA_CLIENTE_ENTIDADE_FATURAR");

                entity.Property(e => e.FatCodigo)
                    .HasColumnName("FAT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatAgtSent)
                    .HasColumnName("FAT_AGT_SENT")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.FatAgtSentBy)
                    .HasColumnName("FAT_AGT_SENT_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FatAgtSentDate)
                    .HasColumnName("FAT_AGT_SENT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatBarcode)
                    .HasColumnName("FAT_BARCODE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FatCambio)
                    .HasColumnName("FAT_CAMBIO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatCodigoArmazem)
                    .HasColumnName("FAT_CODIGO_ARMAZEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoComprador)
                    .HasColumnName("FAT_CODIGO_COMPRADOR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoDocumento)
                    .HasColumnName("FAT_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoExpedicao)
                    .HasColumnName("FAT_CODIGO_EXPEDICAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoFilial)
                    .HasColumnName("FAT_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoFornecedor)
                    .HasColumnName("FAT_CODIGO_FORNECEDOR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoMoeda)
                    .HasColumnName("FAT_CODIGO_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCodigoSerie)
                    .HasColumnName("FAT_CODIGO_SERIE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatCondicaoPagamento)
                    .HasColumnName("FAT_CONDICAO_PAGAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatContactoDestino)
                    .HasColumnName("FAT_CONTACTO_DESTINO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatContactoDestinoAlt)
                    .HasColumnName("FAT_CONTACTO_DESTINO_ALT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatCreatedBy)
                    .HasColumnName("FAT_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatCreatedDate)
                    .HasColumnName("FAT_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatCustomerCredit)
                    .HasColumnName("FAT_CUSTOMER_CREDIT")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatCustomerVat)
                    .HasColumnName("FAT_CUSTOMER_VAT")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.FatDataCarga)
                    .HasColumnName("FAT_DATA_CARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDataDescarga)
                    .HasColumnName("FAT_DATA_DESCARGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDataEmissao)
                    .HasColumnName("FAT_DATA_EMISSAO")
                    .HasColumnType("date");

                entity.Property(e => e.FatDataEntrega)
                    .HasColumnName("FAT_DATA_ENTREGA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDataLiquidacao)
                    .HasColumnName("FAT_DATA_LIQUIDACAO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDataValidade)
                    .HasColumnName("FAT_DATA_VALIDADE")
                    .HasColumnType("date");

                entity.Property(e => e.FatDeletedBy)
                    .HasColumnName("FAT_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatDeletedDate)
                    .HasColumnName("FAT_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatDesconto)
                    .HasColumnName("FAT_DESCONTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatDescontoFornecedor)
                    .HasColumnName("FAT_DESCONTO_FORNECEDOR")
                    .HasColumnType("decimal(18,0)");

                entity.Property(e => e.FatDocumentoOrigem)
                    .HasColumnName("FAT_DOCUMENTO_ORIGEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatEmailSent)
                    .HasColumnName("FAT_EMAIL_SENT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FatEmailSentBy)
                    .HasColumnName("FAT_EMAIL_SENT_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatEmailSentDate)
                    .HasColumnName("FAT_EMAIL_SENT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatEntityBillId)
                    .HasColumnName("FAT_ENTITY_BILL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatHashTag)
                    .HasColumnName("FAT_HASH_TAG")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.FatLocalCarga)
                    .HasColumnName("FAT_LOCAL_CARGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatLocalDescarga)
                    .HasColumnName("FAT_LOCAL_DESCARGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatMatriculaCarga)
                    .HasColumnName("FAT_MATRICULA_CARGA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatMoradaCarga)
                    .HasColumnName("FAT_MORADA_CARGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatMoradaDescarga)
                    .HasColumnName("FAT_MORADA_DESCARGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatMotivoAnulacao)
                    .HasColumnName("FAT_MOTIVO_ANULACAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FatNomeFornecedor)
                    .HasColumnName("FAT_NOME_FORNECEDOR")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatNotasComerciais)
                    .HasColumnName("FAT_NOTAS_COMERCIAIS")
                    .HasColumnType("longtext");

                entity.Property(e => e.FatNotasInternas)
                    .HasColumnName("FAT_NOTAS_INTERNAS")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FatNumeracao)
                    .HasColumnName("FAT_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatNumeroDocOrigem)
                    .HasColumnName("FAT_NUMERO_DOC_ORIGEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatObservacoes)
                    .HasColumnName("FAT_OBSERVACOES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FatPaid)
                    .HasColumnName("FAT_PAID")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.FatParcela)
                    .HasColumnName("FAT_PARCELA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatRecepcao)
                    .HasColumnName("FAT_RECEPCAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatRectified)
                    .HasColumnName("FAT_RECTIFIED")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.FatRectifierDocumentId)
                    .HasColumnName("FAT_RECTIFIER_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatReferencia)
                    .HasColumnName("FAT_REFERENCIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatReferenciaFornecedor)
                    .HasColumnName("FAT_REFERENCIA_FORNECEDOR")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FatResponsavelCarga)
                    .HasColumnName("FAT_RESPONSAVEL_CARGA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatResponsavelEntrega)
                    .HasColumnName("FAT_RESPONSAVEL_ENTREGA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FatSaftSourceBilling)
                    .HasColumnName("FAT_SAFT_SOURCE_BILLING")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FatSaftStatus)
                    .HasColumnName("FAT_SAFT_STATUS")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FatStatus)
                    .HasColumnName("FAT_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatStatusComercial)
                    .HasColumnName("FAT_STATUS_COMERCIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatStatusDocumento)
                    .HasColumnName("FAT_STATUS_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatStatusPagamento)
                    .HasColumnName("FAT_STATUS_PAGAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatTotalDescontos)
                    .HasColumnName("FAT_TOTAL_DESCONTOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatTotalImpostos)
                    .HasColumnName("FAT_TOTAL_IMPOSTOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatTotalLiquido)
                    .HasColumnName("FAT_TOTAL_LIQUIDO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatTroco)
                    .HasColumnName("FAT_TROCO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatUpdateBy)
                    .HasColumnName("FAT_UPDATE_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatUpdatedDate)
                    .HasColumnName("FAT_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatValorBruto)
                    .HasColumnName("FAT_VALOR_BRUTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorCiva)
                    .HasColumnName("FAT_VALOR_CIVA")
                    .HasColumnType("decimal(18,5)")
                    .HasDefaultValueSql("'0.00000'");

                entity.Property(e => e.FatValorComissoes)
                    .HasColumnName("FAT_VALOR_COMISSOES")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorPago)
                    .HasColumnName("FAT_VALOR_PAGO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorRetencao)
                    .HasColumnName("FAT_VALOR_RETENCAO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorSaldo)
                    .HasColumnName("FAT_VALOR_SALDO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatValorSiva)
                    .HasColumnName("FAT_VALOR_SIVA")
                    .HasColumnType("decimal(18,5)")
                    .HasDefaultValueSql("'0.00000'");

                entity.Property(e => e.FatValorTotal)
                    .HasColumnName("FAT_VALOR_TOTAL")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.FatCodigoArmazemNavigation)
                    .WithMany(p => p.ComFaturaFornecedor)
                    .HasForeignKey(d => d.FatCodigoArmazem)
                    .HasConstraintName("com_fatura_fornecedor_ibfk_2");

                entity.HasOne(d => d.FatCodigoDocumentoNavigation)
                    .WithMany(p => p.ComFaturaFornecedor)
                    .HasForeignKey(d => d.FatCodigoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_fornecedor_ibfk_4");

                entity.HasOne(d => d.FatCodigoExpedicaoNavigation)
                    .WithMany(p => p.ComFaturaFornecedor)
                    .HasForeignKey(d => d.FatCodigoExpedicao)
                    .HasConstraintName("com_fatura_fornecedor_ibfk_5");

                entity.HasOne(d => d.FatCodigoFilialNavigation)
                    .WithMany(p => p.ComFaturaFornecedor)
                    .HasForeignKey(d => d.FatCodigoFilial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_fornecedor_ibfk_6");

                entity.HasOne(d => d.FatCodigoFornecedorNavigation)
                    .WithMany(p => p.ComFaturaFornecedorFatCodigoFornecedorNavigation)
                    .HasForeignKey(d => d.FatCodigoFornecedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_fornecedor_ibfk_3");

                entity.HasOne(d => d.FatCodigoMoedaNavigation)
                    .WithMany(p => p.ComFaturaFornecedor)
                    .HasForeignKey(d => d.FatCodigoMoeda)
                    .HasConstraintName("com_fatura_fornecedor_ibfk_7");

                entity.HasOne(d => d.FatCodigoSerieNavigation)
                    .WithMany(p => p.ComFaturaFornecedor)
                    .HasForeignKey(d => d.FatCodigoSerie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_fornecedor_ibfk_9");

                entity.HasOne(d => d.FatCondicaoPagamentoNavigation)
                    .WithMany(p => p.ComFaturaFornecedor)
                    .HasForeignKey(d => d.FatCondicaoPagamento)
                    .HasConstraintName("com_fatura_fornecedor_ibfk_8");

                entity.HasOne(d => d.FatEntityBill)
                    .WithMany(p => p.ComFaturaFornecedorFatEntityBill)
                    .HasForeignKey(d => d.FatEntityBillId)
                    .HasConstraintName("com_fatura_fornecedor_ibfk_1");
            });

            modelBuilder.Entity<ComFaturaFornecedorItem>(entity =>
            {
                entity.HasKey(e => new { e.FatItemCodigoArtigo, e.FatItemCodigoCompra })
                    .HasName("PRIMARY");

                entity.ToTable("com_fatura_fornecedor_item");

                entity.HasIndex(e => e.FatItemCodigo)
                    .HasName("UK_FATURA_ITEM")
                    .IsUnique();

                entity.HasIndex(e => e.FatItemCodigoCompra)
                    .HasName("FK_FATURA_ITEM");

                entity.HasIndex(e => e.FatItemImpostoId)
                    .HasName("FK_COM_FATURA_FORNECEDOR_IMPOSTO");

                entity.Property(e => e.FatItemCodigoArtigo)
                    .HasColumnName("FAT_ITEM_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemCodigoCompra)
                    .HasColumnName("FAT_ITEM_CODIGO_COMPRA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemCodigo)
                    .HasColumnName("FAT_ITEM_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FatItemComentarios)
                    .HasColumnName("FAT_ITEM_COMENTARIOS")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FatItemComposicao)
                    .HasColumnName("FAT_ITEM_COMPOSICAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemCreatedBy)
                    .HasColumnName("FAT_ITEM_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatItemCreatedDate)
                    .HasColumnName("FAT_ITEM_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FatItemDataEntrega)
                    .HasColumnName("FAT_ITEM_DATA_ENTREGA")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FatItemDeletedBy)
                    .HasColumnName("FAT_ITEM_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatItemDeletedDate)
                    .HasColumnName("FAT_ITEM_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatItemDescontoCompra)
                    .HasColumnName("FAT_ITEM_DESCONTO_COMPRA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemDescontoFinanceiro)
                    .HasColumnName("FAT_ITEM_DESCONTO_FINANCEIRO")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatItemDescontoLinha)
                    .HasColumnName("FAT_ITEM_DESCONTO_LINHA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemDescontoNumerarioLinha)
                    .HasColumnName("FAT_ITEM_DESCONTO_NUMERARIO_LINHA")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatItemDimensaoId)
                    .HasColumnName("FAT_ITEM_DIMENSAO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemDocOrigemId)
                    .HasColumnName("FAT_ITEM_DOC_ORIGEM_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemDocOrigemLinha)
                    .HasColumnName("FAT_ITEM_DOC_ORIGEM_LINHA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemEncomendada)
                    .HasColumnName("FAT_ITEM_ENCOMENDADA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemEnvioDocId)
                    .HasColumnName("FAT_ITEM_ENVIO_DOC_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemEnvioDocLinha)
                    .HasColumnName("FAT_ITEM_ENVIO_DOC_LINHA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemImposto)
                    .HasColumnName("FAT_ITEM_IMPOSTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemImpostoId)
                    .HasColumnName("FAT_ITEM_IMPOSTO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemLoteId)
                    .HasColumnName("FAT_ITEM_LOTE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemPreco)
                    .HasColumnName("FAT_ITEM_PRECO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemPrecoCusto)
                    .HasColumnName("FAT_ITEM_PRECO_CUSTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatItemQuantidade)
                    .HasColumnName("FAT_ITEM_QUANTIDADE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemReservada)
                    .HasColumnName("FAT_ITEM_RESERVADA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemSerialnumberId)
                    .HasColumnName("FAT_ITEM_SERIALNUMBER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemStatus)
                    .HasColumnName("FAT_ITEM_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatItemTotal)
                    .HasColumnName("FAT_ITEM_TOTAL")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemUpdatedBy)
                    .HasColumnName("FAT_ITEM_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FatItemUpdatedDate)
                    .HasColumnName("FAT_ITEM_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FatItemValorDescontoFinanceiro)
                    .HasColumnName("FAT_ITEM_VALOR_DESCONTO_FINANCEIRO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatItemValorDescontos)
                    .HasColumnName("FAT_ITEM_VALOR_DESCONTOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemValorImpostos)
                    .HasColumnName("FAT_ITEM_VALOR_IMPOSTOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.FatItemValorTributavel)
                    .HasColumnName("FAT_ITEM_VALOR_TRIBUTAVEL")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.FatItemWarehouseId)
                    .HasColumnName("FAT_ITEM_WAREHOUSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatOrdem)
                    .HasColumnName("FAT_ORDEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FatRetencao)
                    .HasColumnName("FAT_RETENCAO")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.FatItemCodigoArtigoNavigation)
                    .WithMany(p => p.ComFaturaFornecedorItem)
                    .HasForeignKey(d => d.FatItemCodigoArtigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_fornecedor_item_ibfk_1");

                entity.HasOne(d => d.FatItemCodigoCompraNavigation)
                    .WithMany(p => p.ComFaturaFornecedorItem)
                    .HasForeignKey(d => d.FatItemCodigoCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_fornecedor_item_ibfk_2");

                entity.HasOne(d => d.FatItemImpostoNavigation)
                    .WithMany(p => p.ComFaturaFornecedorItem)
                    .HasForeignKey(d => d.FatItemImpostoId)
                    .HasConstraintName("FK_COM_FATURA_FORNECEDOR_IMPOSTO");
            });

            modelBuilder.Entity<ComFaturaReferenciaSuspender>(entity =>
            {
                entity.HasKey(e => e.ComFatRefSuspCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_fatura_referencia_suspender");

                entity.Property(e => e.ComFatRefSuspCodigo)
                    .HasColumnName("COM_FAT_REF_SUSP_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatRefSuspData)
                    .HasColumnName("COM_FAT_REF_SUSP_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.ComFatRefSuspDesignacao)
                    .HasColumnName("COM_FAT_REF_SUSP_DESIGNACAO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ComFatRefSuspFilial)
                    .HasColumnName("COM_FAT_REF_SUSP_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatRefSuspUtilizador)
                    .HasColumnName("COM_FAT_REF_SUSP_UTILIZADOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ComFatRefSuspValorTotal)
                    .HasColumnName("COM_FAT_REF_SUSP_VALOR_TOTAL")
                    .HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<ComFaturaSuspensa>(entity =>
            {
                entity.HasKey(e => e.ComFatSuspCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_fatura_suspensa");

                entity.HasIndex(e => e.ComFatSuspReferencia)
                    .HasName("FK_COM_FAT_SUSP_REFERENCIA");

                entity.Property(e => e.ComFatSuspCodigo)
                    .HasColumnName("COM_FAT_SUSP_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatSupNotes)
                    .HasColumnName("COM_FAT_SUP_NOTES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ComFatSupQuantidadeInicial)
                    .HasColumnName("COM_FAT_SUP_QUANTIDADE_INICIAL")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSupWarehouseId)
                    .HasColumnName("COM_FAT_SUP_WAREHOUSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatSupWarehouseName)
                    .HasColumnName("COM_FAT_SUP_WAREHOUSE_NAME")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ComFatSuspArtigo)
                    .HasColumnName("COM_FAT_SUSP_ARTIGO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ComFatSuspCodigoArtigo)
                    .HasColumnName("COM_FAT_SUSP_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatSuspDesconto)
                    .HasColumnName("COM_FAT_SUSP_DESCONTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspDescontoNumerario)
                    .HasColumnName("COM_FAT_SUSP_DESCONTO_NUMERARIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspDimensaoId)
                    .HasColumnName("COM_FAT_SUSP_DIMENSAO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatSuspImposto)
                    .HasColumnName("COM_FAT_SUSP_IMPOSTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspImpostoId)
                    .HasColumnName("COM_FAT_SUSP_IMPOSTO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatSuspLoteId)
                    .HasColumnName("COM_FAT_SUSP_LOTE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatSuspPrecoUnitario)
                    .HasColumnName("COM_FAT_SUSP_PRECO_UNITARIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspQuantidade)
                    .HasColumnName("COM_FAT_SUSP_QUANTIDADE")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspRefArtigo)
                    .HasColumnName("COM_FAT_SUSP_REF_ARTIGO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ComFatSuspReferencia)
                    .HasColumnName("COM_FAT_SUSP_REFERENCIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatSuspSerialnumberId)
                    .HasColumnName("COM_FAT_SUSP_SERIALNUMBER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComFatSuspSiglaUnidade)
                    .HasColumnName("COM_FAT_SUSP_SIGLA_UNIDADE")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ComFatSuspTotallinha)
                    .HasColumnName("COM_FAT_SUSP_TOTALLINHA")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ComFatSuspUnidadeId)
                    .HasColumnName("COM_FAT_SUSP_UNIDADE_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ComFatSuspReferenciaNavigation)
                    .WithMany(p => p.ComFaturaSuspensa)
                    .HasForeignKey(d => d.ComFatSuspReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_fatura_suspensa_ibfk_1");
            });

            modelBuilder.Entity<ComGuiaEntrega>(entity =>
            {
                entity.HasKey(e => e.GuiaCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_guia_entrega");

                entity.Property(e => e.GuiaCodigo)
                    .HasColumnName("GUIA_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuiaCodigoDocumento)
                    .HasColumnName("GUIA_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuiaCodigoFuncionario)
                    .HasColumnName("GUIA_CODIGO_FUNCIONARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuiaCodigoMotorista)
                    .HasColumnName("GUIA_CODIGO_MOTORISTA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuiaCodigoSerie)
                    .HasColumnName("GUIA_CODIGO_SERIE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuiaCreatedBy)
                    .HasColumnName("GUIA_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GuiaCreatedDate)
                    .HasColumnName("GUIA_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.GuiaData)
                    .HasColumnName("GUIA_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.GuiaDataEntrega)
                    .HasColumnName("GUIA_DATA_ENTREGA")
                    .HasColumnType("date");

                entity.Property(e => e.GuiaDocumentoOrigem)
                    .HasColumnName("GUIA_DOCUMENTO_ORIGEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuiaNumeracao)
                    .HasColumnName("GUIA_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuiaReferencia)
                    .HasColumnName("GUIA_REFERENCIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GuiaUpdatedBy)
                    .HasColumnName("GUIA_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GuiaUpdatedDate)
                    .HasColumnName("GUIA_UPDATED_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ComMotivoIsencaoIva>(entity =>
            {
                entity.HasKey(e => e.IsenCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_motivo_isencao_iva");

                entity.Property(e => e.IsenCodigo)
                    .HasColumnName("ISEN_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsenCreatedBy)
                    .HasColumnName("ISEN_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.IsenCreatedDate)
                    .HasColumnName("ISEN_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsenDescricao)
                    .HasColumnName("ISEN_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.IsenSigla)
                    .HasColumnName("ISEN_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.IsenStatus)
                    .HasColumnName("ISEN_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.IsenUpdatedBy)
                    .HasColumnName("ISEN_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.IsenUpdatedDate)
                    .HasColumnName("ISEN_UPDATED_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ComPagamentoFornecedor>(entity =>
            {
                entity.HasKey(e => e.RecCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_pagamento_fornecedor");

                entity.HasIndex(e => e.RecCodigoDocumento)
                    .HasName("com_recibo_fornecedor_ibfk_2");

                entity.HasIndex(e => e.RecCodigoEntidade)
                    .HasName("com_recibo_fornecedor_ibfk_1");

                entity.HasIndex(e => e.RecCodigoFilial)
                    .HasName("com_recibo_fornecedor_ibfk_3");

                entity.HasIndex(e => e.RecCodigoMoeda)
                    .HasName("com_recibo_fornecedor_ibfk_4");

                entity.HasIndex(e => e.RecCodigoSerie)
                    .HasName("com_recibo_fornecedor_ibfk_5");

                entity.Property(e => e.RecCodigo)
                    .HasColumnName("REC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecAbortedBy)
                    .HasColumnName("REC_ABORTED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RecAbortedDate)
                    .HasColumnName("REC_ABORTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecBarcode)
                    .HasColumnName("REC_BARCODE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RecCambio)
                    .HasColumnName("REC_CAMBIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.RecCodigoDocumento)
                    .HasColumnName("REC_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecCodigoEntidade)
                    .HasColumnName("REC_CODIGO_ENTIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecCodigoFilial)
                    .HasColumnName("REC_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecCodigoMoeda)
                    .HasColumnName("REC_CODIGO_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecCodigoSerie)
                    .HasColumnName("REC_CODIGO_SERIE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecContribuinte)
                    .HasColumnName("REC_CONTRIBUINTE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecCreatedBy)
                    .HasColumnName("REC_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecCreatedDate)
                    .HasColumnName("REC_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecDataEmissao)
                    .HasColumnName("REC_DATA_EMISSAO")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecDesconto)
                    .HasColumnName("REC_DESCONTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.RecDocFromNumber)
                    .HasColumnName("REC_DOC_FROM_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecDocFromType)
                    .HasColumnName("REC_DOC_FROM_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecFrom)
                    .HasColumnName("REC_FROM")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.RecMotivoAnulacao)
                    .HasColumnName("REC_MOTIVO_ANULACAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RecNomeFonecedor)
                    .HasColumnName("REC_NOME_FONECEDOR")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.RecNumeracao)
                    .HasColumnName("REC_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecObservacoes)
                    .HasColumnName("REC_OBSERVACOES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RecReferencia)
                    .IsRequired()
                    .HasColumnName("REC_REFERENCIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecStatus)
                    .HasColumnName("REC_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RecUpdatedBy)
                    .HasColumnName("REC_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecUpdatedDate)
                    .HasColumnName("REC_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecValorPago)
                    .HasColumnName("REC_VALOR_PAGO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.RecValorTotal)
                    .HasColumnName("REC_VALOR_TOTAL")
                    .HasColumnType("decimal(18,5)");
            });

            modelBuilder.Entity<ComPagamentoFornecedorDocumentos>(entity =>
            {
                entity.HasKey(e => new { e.PagDocReciboId, e.PagDocDocumentType, e.PagDocDocumentoId })
                    .HasName("PRIMARY");

                entity.ToTable("com_pagamento_fornecedor_documentos");

                entity.HasIndex(e => e.PagDocCodigo)
                    .HasName("UK_PAGAMENTO_DOCUMENTO")
                    .IsUnique();

                entity.HasIndex(e => e.PagDocDocumentType)
                    .HasName("FK_PAGAMENTO_DOCUMENTO_DOC");

                entity.HasIndex(e => e.PagDocDocumentoId)
                    .HasName("FK_COM_PAGAMENTO_FORNECEDOR");

                entity.Property(e => e.PagDocReciboId)
                    .HasColumnName("PAG_DOC_RECIBO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PagDocDocumentType)
                    .HasColumnName("PAG_DOC_DOCUMENT_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PagDocDocumentoId)
                    .HasColumnName("PAG_DOC_DOCUMENTO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PagDocAnulado)
                    .HasColumnName("PAG_DOC_ANULADO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PagDocCodigo)
                    .HasColumnName("PAG_DOC_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PagDocCreatedBy)
                    .HasColumnName("PAG_DOC_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PagDocCreatedDate)
                    .HasColumnName("PAG_DOC_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PagDocDesconto)
                    .HasColumnName("PAG_DOC_DESCONTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.PagDocJuros)
                    .HasColumnName("PAG_DOC_JUROS")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.PagDocNumeracao)
                    .HasColumnName("PAG_DOC_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PagDocOrdem)
                    .HasColumnName("PAG_DOC_ORDEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PagDocReferencia)
                    .HasColumnName("PAG_DOC_REFERENCIA")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.PagDocUpdatedBy)
                    .HasColumnName("PAG_DOC_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PagDocUpdatedDate)
                    .HasColumnName("PAG_DOC_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PagDocValorDocumento)
                    .HasColumnName("PAG_DOC_VALOR_DOCUMENTO")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.PagDocValorLiquidado)
                    .HasColumnName("PAG_DOC_VALOR_LIQUIDADO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.PagDocValorPedente)
                    .HasColumnName("PAG_DOC_VALOR_PEDENTE")
                    .HasColumnType("decimal(18,5)");

                entity.HasOne(d => d.PagDocDocumentTypeNavigation)
                    .WithMany(p => p.ComPagamentoFornecedorDocumentos)
                    .HasForeignKey(d => d.PagDocDocumentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_pagamento_fornecedor_documentos_ibfk_2");

                entity.HasOne(d => d.PagDocDocumento)
                    .WithMany(p => p.ComPagamentoFornecedorDocumentos)
                    .HasForeignKey(d => d.PagDocDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_pagamento_fornecedor_documentos_ibfk_1");

                entity.HasOne(d => d.PagDocRecibo)
                    .WithMany(p => p.ComPagamentoFornecedorDocumentos)
                    .HasForeignKey(d => d.PagDocReciboId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_pagamento_fornecedor_documentos_ibfk_3");
            });

            modelBuilder.Entity<ComPlanoPagamento>(entity =>
            {
                entity.HasKey(e => e.PlanCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_plano_pagamento");

                entity.HasIndex(e => e.PlanContratoId)
                    .HasName("FK_AVENCA_CONTRATO");

                entity.Property(e => e.PlanCodigo)
                    .HasColumnName("PLAN_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanAlertAfterExpired)
                    .HasColumnName("PLAN_ALERT_AFTER_EXPIRED")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanAlertBeforeExpired)
                    .HasColumnName("PLAN_ALERT_BEFORE_EXPIRED")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanContratoId)
                    .HasColumnName("PLAN_CONTRATO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanCreatedBy)
                    .HasColumnName("PLAN_CREATED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PlanCreatedDate)
                    .HasColumnName("PLAN_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanInicio)
                    .HasColumnName("PLAN_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.PlanNumeracao)
                    .HasColumnName("PLAN_NUMERACAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PlanPaymentDays)
                    .HasColumnName("PLAN_PAYMENT_DAYS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanSerieId)
                    .HasColumnName("PLAN_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanTermino)
                    .HasColumnName("PLAN_TERMINO")
                    .HasColumnType("date");

                entity.Property(e => e.PlanUpdatedBy)
                    .HasColumnName("PLAN_UPDATED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PlanUpdatedDate)
                    .HasColumnName("PLAN_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.PlanContrato)
                    .WithMany(p => p.ComPlanoPagamento)
                    .HasForeignKey(d => d.PlanContratoId)
                    .HasConstraintName("FK_AVENCA_CONTRATO");
            });

            modelBuilder.Entity<ComPos>(entity =>
            {
                entity.HasKey(e => e.PosCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_pos");

                entity.Property(e => e.PosCodigo)
                    .HasColumnName("POS_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosAllowCalendar)
                    .HasColumnName("POS_ALLOW_CALENDAR")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.PosCashRefundSerieId)
                    .HasColumnName("POS_CASH_REFUND_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosCreatedBy)
                    .HasColumnName("POS_CREATED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PosCreatedDate)
                    .HasColumnName("POS_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosCreditRefundSerieId)
                    .HasColumnName("POS_CREDIT_REFUND_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosDefaultCustomer)
                    .HasColumnName("POS_DEFAULT_CUSTOMER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosDefaultDocumentSerie)
                    .HasColumnName("POS_DEFAULT_DOCUMENT_SERIE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosDefaultWarehouse)
                    .HasColumnName("POS_DEFAULT_WAREHOUSE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosDescricao)
                    .IsRequired()
                    .HasColumnName("POS_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PosDesignacao)
                    .HasColumnName("POS_DESIGNACAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PosFundoManeio)
                    .HasColumnName("POS_FUNDO_MANEIO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.PosPaymentMethodId)
                    .HasColumnName("POS_PAYMENT_METHOD_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosPaymentTermsId)
                    .HasColumnName("POS_PAYMENT_TERMS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosPvpId)
                    .HasColumnName("POS_PVP_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosSigla)
                    .HasColumnName("POS_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PosStatus)
                    .HasColumnName("POS_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PosSuspenseSales)
                    .HasColumnName("POS_SUSPENSE_SALES")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.PosUpdatedBy)
                    .HasColumnName("POS_UPDATED_BY")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PosUpdatedDate)
                    .HasColumnName("POS_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.PosVendedorId)
                    .HasColumnName("POS_VENDEDOR_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ComPosConfiguracao>(entity =>
            {
                entity.HasKey(e => e.PosCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_pos_configuracao");

                entity.Property(e => e.PosCodigo)
                    .HasColumnName("POS_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosClosureDocumentId)
                    .HasColumnName("POS_CLOSURE_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigAccount)
                    .IsRequired()
                    .HasColumnName("POS_CONFIG_ACCOUNT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PosConfigCategory)
                    .HasColumnName("POS_CONFIG_CATEGORY")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigCodeConfirmation)
                    .HasColumnName("POS_CONFIG_CODE_CONFIRMATION")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.PosConfigCodigoFilial)
                    .HasColumnName("POS_CONFIG_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigControlMode)
                    .HasColumnName("POS_CONFIG_CONTROL_MODE")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PosConfigCustomer)
                    .HasColumnName("POS_CONFIG_CUSTOMER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigDocument)
                    .HasColumnName("POS_CONFIG_DOCUMENT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigDocumentStatus)
                    .HasColumnName("POS_CONFIG_DOCUMENT_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigExpedition)
                    .HasColumnName("POS_CONFIG_EXPEDITION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigKeyboard)
                    .HasColumnName("POS_CONFIG_KEYBOARD")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PosConfigMultiplesCloses)
                    .HasColumnName("POS_CONFIG_MULTIPLES_CLOSES")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PosConfigOperationMode)
                    .HasColumnName("POS_CONFIG_OPERATION_MODE")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PosConfigPageAfterSale)
                    .HasColumnName("POS_CONFIG_PAGE_AFTER_SALE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PosConfigPayment)
                    .HasColumnName("POS_CONFIG_PAYMENT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigPaymentStatus)
                    .HasColumnName("POS_CONFIG_PAYMENT_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigPrinterName)
                    .HasColumnName("POS_CONFIG_PRINTER_NAME")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PosConfigTotalProduct)
                    .HasColumnName("POS_CONFIG_TOTAL_PRODUCT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosConfigWarehouse)
                    .HasColumnName("POS_CONFIG_WAREHOUSE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosDefaultInDocumentId)
                    .HasColumnName("POS_DEFAULT_IN_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosDefaultOutDocumentId)
                    .HasColumnName("POS_DEFAULT_OUT_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosFundoDefault)
                    .HasColumnName("POS_FUNDO_DEFAULT")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.PosKitechenMonitor)
                    .HasColumnName("POS_KITECHEN_MONITOR")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PosKitechenPrinterName)
                    .HasColumnName("POS_KITECHEN_PRINTER_NAME")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PosOpeningDocumentId)
                    .HasColumnName("POS_OPENING_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosSupervisorCode)
                    .HasColumnName("POS_SUPERVISOR_CODE")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<ComPosMovimento>(entity =>
            {
                entity.HasKey(e => new { e.PosMovCodigoPos, e.PosMovCodigoMovimento })
                    .HasName("PRIMARY");

                entity.ToTable("com_pos_movimento");

                entity.HasIndex(e => e.PosMovCodigoMovimento)
                    .HasName("FK_POS_MOVIMENTO");

                entity.Property(e => e.PosMovCodigoPos)
                    .HasColumnName("POS_MOV_CODIGO_POS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosMovCodigoMovimento)
                    .HasColumnName("POS_MOV_CODIGO_MOVIMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosMovStatus)
                    .HasColumnName("POS_MOV_STATUS")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.PosMovCodigoMovimentoNavigation)
                    .WithMany(p => p.ComPosMovimento)
                    .HasForeignKey(d => d.PosMovCodigoMovimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_pos_movimento_ibfk_1");

                entity.HasOne(d => d.PosMovCodigoPosNavigation)
                    .WithMany(p => p.ComPosMovimento)
                    .HasForeignKey(d => d.PosMovCodigoPos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_pos_movimento_ibfk_2");
            });

            modelBuilder.Entity<ComPosStatus>(entity =>
            {
                entity.HasKey(e => e.PosStaCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_pos_status");

                entity.HasIndex(e => e.PosStaCodigo)
                    .HasName("UK_POS_STATUS");

                entity.HasIndex(e => e.PosStaCodigoFilial)
                    .HasName("FK_SESSAO_POS_FILIAL");

                entity.HasIndex(e => e.PosStaPosto)
                    .HasName("FK_SESSAO_POS_POSTO");

                entity.HasIndex(e => e.PosStaTurno)
                    .HasName("FK_SESSAO_POS_TURNO");

                entity.Property(e => e.PosStaCodigo)
                    .HasColumnName("POS_STA_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosIp)
                    .HasColumnName("POS_IP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PosStaAbertura)
                    .HasColumnName("POS_STA_ABERTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosStaCodigoFilial)
                    .HasColumnName("POS_STA_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosStaData)
                    .HasColumnName("POS_STA_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.PosStaFecho)
                    .HasColumnName("POS_STA_FECHO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosStaPosto)
                    .HasColumnName("POS_STA_POSTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosStaTurno)
                    .HasColumnName("POS_STA_TURNO")
                    .HasColumnType("int(1)");

                entity.Property(e => e.PosStaUtilizador)
                    .IsRequired()
                    .HasColumnName("POS_STA_UTILIZADOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PosStaValorFinal)
                    .HasColumnName("POS_STA_VALOR_FINAL")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.PosStaValorInicial)
                    .HasColumnName("POS_STA_VALOR_INICIAL")
                    .HasColumnType("decimal(18,5)");

                entity.HasOne(d => d.PosStaCodigoFilialNavigation)
                    .WithMany(p => p.ComPosStatus)
                    .HasForeignKey(d => d.PosStaCodigoFilial)
                    .HasConstraintName("com_pos_status_ibfk_1");

                entity.HasOne(d => d.PosStaPostoNavigation)
                    .WithMany(p => p.ComPosStatus)
                    .HasForeignKey(d => d.PosStaPosto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_pos_status_ibfk_2");

                entity.HasOne(d => d.PosStaTurnoNavigation)
                    .WithMany(p => p.ComPosStatus)
                    .HasForeignKey(d => d.PosStaTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_pos_status_ibfk_3");
            });

            modelBuilder.Entity<PromotionsCustomer>(entity =>
            {
                entity.HasKey(e => new { e.PromocaoId, e.PromocaoClienteId })
                    .HasName("PRIMARY");

                entity.ToTable("com_promocao_cliente");

                entity.Property(e => e.PromocaoId)
                    .HasColumnName("PROMOCAO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PromocaoClienteId)
                    .HasColumnName("PROMOCAO_CLIENTE_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Promotions>(entity =>
            {
                entity.HasKey(e => e.PromCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_promocoes");

                entity.Property(e => e.PromCodigo)
                    .HasColumnName("PROM_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PromAplicacao)
                    .HasColumnName("PROM_APLICACAO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PromCreatedBy)
                    .HasColumnName("PROM_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PromCreatedDate)
                    .HasColumnName("PROM_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PromDescontoFixo)
                    .HasColumnName("PROM_DESCONTO_FIXO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.PromDescricao)
                    .HasColumnName("PROM_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PromHoraInicio)
                    .HasColumnName("PROM_HORA_INICIO")
                    .HasColumnType("time");

                entity.Property(e => e.PromHoraTermino)
                    .HasColumnName("PROM_HORA_TERMINO")
                    .HasColumnType("time");

                entity.Property(e => e.PromInicio)
                    .HasColumnName("PROM_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PromPrecoUnitarioFixo)
                    .HasColumnName("PROM_PRECO_UNITARIO_FIXO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.PromQuantidade)
                    .HasColumnName("PROM_QUANTIDADE")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.PromRecorrencia)
                    .HasColumnName("PROM_RECORRENCIA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PromReducaoPrecoUnitario)
                    .HasColumnName("PROM_REDUCAO_PRECO_UNITARIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.PromStatus)
                    .HasColumnName("PROM_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PromTermino)
                    .HasColumnName("PROM_TERMINO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PromTipo)
                    .HasColumnName("PROM_TIPO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PromUnidadeDescontoFixo)
                    .HasColumnName("PROM_UNIDADE_DESCONTO_FIXO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PromUnidadePrecoFixo)
                    .HasColumnName("PROM_UNIDADE_PRECO_FIXO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PromUnidadeReducao)
                    .HasColumnName("PROM_UNIDADE_REDUCAO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PromUpdatedBy)
                    .HasColumnName("PROM_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PromUpdatedDate)
                    .HasColumnName("PROM_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<PromotionsProducts>(entity =>
            {
                entity.HasKey(e => new { e.PromoCodigoPromocao, e.PromoCodigoArtigo })
                    .HasName("PRIMARY");

                entity.ToTable("com_promocoes_artigos");

                entity.HasIndex(e => e.PromoCodigo)
                    .HasName("UK_PROMOCAO_CODIGO")
                    .IsUnique();

                entity.HasIndex(e => e.PromoCodigoArtigo)
                    .HasName("fk_promo_artigo_artigo");

                entity.Property(e => e.PromoCodigoPromocao)
                    .HasColumnName("PROMO_CODIGO_PROMOCAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PromoCodigoArtigo)
                    .HasColumnName("PROMO_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PromoCodigo)
                    .HasColumnName("PROMO_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PromoCreatedBy)
                    .HasColumnName("PROMO_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PromoCreatedDate)
                    .HasColumnName("PROMO_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PromoUnidade)
                    .HasColumnName("PROMO_UNIDADE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.PromoUpdatedBy)
                    .HasColumnName("PROMO_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PromoUpdatedDate)
                    .HasColumnName("PROMO_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.PromoValor)
                    .HasColumnName("PROMO_VALOR")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.PromoCodigoArtigoNavigation)
                    .WithMany(p => p.ComPromocoesArtigos)
                    .HasForeignKey(d => d.PromoCodigoArtigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_promocoes_artigos_ibfk_1");

                entity.HasOne(d => d.PromoCodigoPromocaoNavigation)
                    .WithMany(p => p.ComPromocoesArtigos)
                    .HasForeignKey(d => d.PromoCodigoPromocao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_promocoes_artigos_ibfk_2");
            });

            modelBuilder.Entity<ComReciboCliente>(entity =>
            {
                entity.HasKey(e => e.RecCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_recibo_cliente");

                entity.HasIndex(e => e.RecCodigoDocumento)
                    .HasName("FK_RECIBO_DOCUMENT_TYPE");

                entity.HasIndex(e => e.RecCodigoEntidade)
                    .HasName("FK_RECIBO");

                entity.HasIndex(e => e.RecCodigoFilial)
                    .HasName("FK_RECIBO_FILIAL");

                entity.HasIndex(e => e.RecCodigoMoeda)
                    .HasName("FK_RECIBO_MOEDA");

                entity.HasIndex(e => e.RecCodigoSerie)
                    .HasName("FK_RECIBO_SERIE");

                entity.Property(e => e.RecCodigo)
                    .HasColumnName("REC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecAbortedBy)
                    .HasColumnName("REC_ABORTED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecAbortedDate)
                    .HasColumnName("REC_ABORTED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecBarcode)
                    .HasColumnName("REC_BARCODE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RecCambio)
                    .HasColumnName("REC_CAMBIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.RecCodigoDocumento)
                    .HasColumnName("REC_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecCodigoEntidade)
                    .HasColumnName("REC_CODIGO_ENTIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecCodigoFilial)
                    .HasColumnName("REC_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecCodigoMoeda)
                    .HasColumnName("REC_CODIGO_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecCodigoSerie)
                    .HasColumnName("REC_CODIGO_SERIE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecContribuinte)
                    .HasColumnName("REC_CONTRIBUINTE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecCreatedBy)
                    .HasColumnName("REC_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecCreatedDate)
                    .HasColumnName("REC_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecDataEmissao)
                    .HasColumnName("REC_DATA_EMISSAO")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecDesconto)
                    .HasColumnName("REC_DESCONTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.RecDescontoNumerario)
                    .HasColumnName("REC_DESCONTO_NUMERARIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.RecDocFromNumber)
                    .HasColumnName("REC_DOC_FROM_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecDocFromType)
                    .HasColumnName("REC_DOC_FROM_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecFrom)
                    .HasColumnName("REC_FROM")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.RecMotivoAnulacao)
                    .HasColumnName("REC_MOTIVO_ANULACAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RecNomeCliente)
                    .HasColumnName("REC_NOME_CLIENTE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.RecNumeracao)
                    .HasColumnName("REC_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecObservacoes)
                    .HasColumnName("REC_OBSERVACOES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RecReferencia)
                    .IsRequired()
                    .HasColumnName("REC_REFERENCIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecStatus)
                    .HasColumnName("REC_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RecTaxId)
                    .HasColumnName("REC_TAX_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecUpdatedBy)
                    .HasColumnName("REC_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecUpdatedDate)
                    .HasColumnName("REC_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecValorPago)
                    .HasColumnName("REC_VALOR_PAGO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.RecValorTotal)
                    .HasColumnName("REC_VALOR_TOTAL")
                    .HasColumnType("decimal(18,5)");

                entity.HasOne(d => d.RecCodigoDocumentoNavigation)
                    .WithMany(p => p.ComReciboCliente)
                    .HasForeignKey(d => d.RecCodigoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_recibo_cliente_ibfk_2");

                entity.HasOne(d => d.RecCodigoEntidadeNavigation)
                    .WithMany(p => p.ComReciboCliente)
                    .HasForeignKey(d => d.RecCodigoEntidade)
                    .HasConstraintName("com_recibo_cliente_ibfk_1");

                entity.HasOne(d => d.RecCodigoFilialNavigation)
                    .WithMany(p => p.ComReciboCliente)
                    .HasForeignKey(d => d.RecCodigoFilial)
                    .HasConstraintName("com_recibo_cliente_ibfk_3");

                entity.HasOne(d => d.RecCodigoMoedaNavigation)
                    .WithMany(p => p.ComReciboCliente)
                    .HasForeignKey(d => d.RecCodigoMoeda)
                    .HasConstraintName("com_recibo_cliente_ibfk_4");

                entity.HasOne(d => d.RecCodigoSerieNavigation)
                    .WithMany(p => p.ComReciboCliente)
                    .HasForeignKey(d => d.RecCodigoSerie)
                    .HasConstraintName("com_recibo_cliente_ibfk_5");
            });

            modelBuilder.Entity<ComReciboClienteDocumentos>(entity =>
            {
                entity.HasKey(e => new { e.RecDocReciboId, e.RecDocDocumentType, e.RecDocDocumentoId })
                    .HasName("PRIMARY");

                entity.ToTable("com_recibo_cliente_documentos");

                entity.HasIndex(e => e.RecDocCodigo)
                    .HasName("UK_RECIBO_DOCUMENTO")
                    .IsUnique();

                entity.HasIndex(e => e.RecDocDocumentType)
                    .HasName("FK_RECIBO_DOCUMENTO_DOC");

                entity.HasIndex(e => e.RecDocDocumentoId)
                    .HasName("com_recibo_cliente");

                entity.Property(e => e.RecDocReciboId)
                    .HasColumnName("REC_DOC_RECIBO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecDocDocumentType)
                    .HasColumnName("REC_DOC_DOCUMENT_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecDocDocumentoId)
                    .HasColumnName("REC_DOC_DOCUMENTO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecDocAnulado)
                    .HasColumnName("REC_DOC_ANULADO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RecDocCodigo)
                    .HasColumnName("REC_DOC_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecDocCreatedBy)
                    .HasColumnName("REC_DOC_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecDocCreatedDate)
                    .HasColumnName("REC_DOC_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecDocDesconto)
                    .HasColumnName("REC_DOC_DESCONTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.RecDocJuros)
                    .HasColumnName("REC_DOC_JUROS")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.RecDocNumeracao)
                    .HasColumnName("REC_DOC_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecDocOrdem)
                    .HasColumnName("REC_DOC_ORDEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RecDocReferencia)
                    .HasColumnName("REC_DOC_REFERENCIA")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.RecDocUpdatedBy)
                    .HasColumnName("REC_DOC_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RecDocUpdatedDate)
                    .HasColumnName("REC_DOC_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecDocValorDocumento)
                    .HasColumnName("REC_DOC_VALOR_DOCUMENTO")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.RecDocValorLiquidado)
                    .HasColumnName("REC_DOC_VALOR_LIQUIDADO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.RecDocValorPedente)
                    .HasColumnName("REC_DOC_VALOR_PEDENTE")
                    .HasColumnType("decimal(18,5)");

                entity.HasOne(d => d.RecDocDocumentTypeNavigation)
                    .WithMany(p => p.ComReciboClienteDocumentos)
                    .HasForeignKey(d => d.RecDocDocumentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_recibo_cliente_documentos_ibfk_2");

                entity.HasOne(d => d.RecDocDocumento)
                    .WithMany(p => p.ComReciboClienteDocumentos)
                    .HasForeignKey(d => d.RecDocDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_recibo_cliente_documentos_ibfk_1");

                entity.HasOne(d => d.RecDocRecibo)
                    .WithMany(p => p.ComReciboClienteDocumentos)
                    .HasForeignKey(d => d.RecDocReciboId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_recibo_documento_recibo_id");
            });

            modelBuilder.Entity<ComRegimeIva>(entity =>
            {
                entity.HasKey(e => e.RegIvaCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_regime_iva");

                entity.Property(e => e.RegIvaCodigo)
                    .HasColumnName("REG_IVA_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegIvaCreatedBy)
                    .HasColumnName("REG_IVA_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RegIvaCreatedDate)
                    .HasColumnName("REG_IVA_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegIvaDescricao)
                    .HasColumnName("REG_IVA_DESCRICAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RegIvaDesignacao)
                    .HasColumnName("REG_IVA_DESIGNACAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.RegIvaSigla)
                    .HasColumnName("REG_IVA_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.RegIvaStatus)
                    .HasColumnName("REG_IVA_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.RegIvaUpdatedBy)
                    .HasColumnName("REG_IVA_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RegIvaUpdatedDate)
                    .HasColumnName("REG_IVA_UPDATED_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ComSeguradoras>(entity =>
            {
                entity.HasKey(e => new { e.SegCodigo, e.SegTerceiroId })
                    .HasName("PRIMARY");

                entity.ToTable("com_seguradoras");

                entity.HasIndex(e => e.SegTerceiroId)
                    .HasName("SEG_ENTIDADE_ID");

                entity.Property(e => e.SegCodigo)
                    .HasColumnName("SEG_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SegTerceiroId)
                    .HasColumnName("SEG_TERCEIRO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SegSegmento)
                    .HasColumnName("SEG_SEGMENTO")
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.SegTerceiro)
                    .WithMany(p => p.ComSeguradoras)
                    .HasForeignKey(d => d.SegTerceiroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEG_ENTIDADE_ID");
            });

            modelBuilder.Entity<ComSerieDocumentacao>(entity =>
            {
                entity.HasKey(e => e.SerCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_serie_documentacao");

                entity.HasIndex(e => e.SerAno)
                    .HasName("FK_SERIE_DOCUMENTACAO_ANO");

                entity.HasIndex(e => e.SerCodigoDocumento)
                    .HasName("FK_SERIE_DOCUMENTOS");

                entity.HasIndex(e => e.SerCodigoFilial)
                    .HasName("FK_SERIE_FILIAL");

                entity.HasIndex(e => e.SerEntidade)
                    .HasName("FK_SERIE_DOCUMENTACAO_FILIAL");

                entity.HasIndex(e => new { e.SerAno, e.SerEntidade })
                    .HasName("FK_SERIE_ANO");

                entity.Property(e => e.SerCodigo)
                    .HasColumnName("SER_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SerAno)
                    .HasColumnName("SER_ANO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SerCodigoDocumento)
                    .HasColumnName("SER_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SerCodigoFilial)
                    .HasColumnName("SER_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SerCreatedBy)
                    .HasColumnName("SER_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SerCreatedDate)
                    .HasColumnName("SER_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SerDeleted)
                    .HasColumnName("SER_DELETED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SerDeletedBy)
                    .HasColumnName("SER_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SerDeletedDate)
                    .HasColumnName("SER_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SerDescricao)
                    .IsRequired()
                    .HasColumnName("SER_DESCRICAO")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SerEntidade)
                    .HasColumnName("SER_ENTIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SerInicio)
                    .HasColumnName("SER_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.SerIsActive)
                    .HasColumnName("SER_IS_ACTIVE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SerNroCopias)
                    .HasColumnName("SER_NRO_COPIAS")
                    .HasColumnType("int(1)");

                entity.Property(e => e.SerNumeracao)
                    .HasColumnName("SER_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SerTermino)
                    .HasColumnName("SER_TERMINO")
                    .HasColumnType("date");

                entity.Property(e => e.SerUpdatedBy)
                    .HasColumnName("SER_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SerUpdatedDate)
                    .HasColumnName("SER_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.SerCodigoDocumentoNavigation)
                    .WithMany(p => p.ComSerieDocumentacao)
                    .HasForeignKey(d => d.SerCodigoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_serie_documentacao_ibfk_2");

                entity.HasOne(d => d.SerCodigoFilialNavigation)
                    .WithMany(p => p.ComSerieDocumentacao)
                    .HasForeignKey(d => d.SerCodigoFilial)
                    .HasConstraintName("com_serie_documentacao_ibfk_3");

                entity.HasOne(d => d.Ser)
                    .WithMany(p => p.ComSerieDocumentacao)
                    .HasForeignKey(d => new { d.SerAno, d.SerEntidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_serie_documentacao_ibfk_1");
            });

            modelBuilder.Entity<ComSerieFaturacao>(entity =>
            {
                entity.HasKey(e => e.SerAno)
                    .HasName("PRIMARY");

                entity.ToTable("com_serie_faturacao");

                entity.Property(e => e.SerAno)
                    .HasColumnName("SER_ANO")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SerDescricao)
                    .HasColumnName("SER_DESCRICAO")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SerInicio)
                    .HasColumnName("SER_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.SerIsActive)
                    .HasColumnName("SER_IS_ACTIVE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SerTermino)
                    .HasColumnName("SER_TERMINO")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<ComSeriePermissoes>(entity =>
            {
                entity.HasKey(e => e.PermCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_serie_permissoes");

                entity.Property(e => e.PermCodigo)
                    .HasColumnName("PERM_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermSerCreatedBy)
                    .HasColumnName("PERM_SER_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PermSerCreatedDate)
                    .HasColumnName("PERM_SER_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PermSerInsert)
                    .HasColumnName("PERM_SER_INSERT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PermSerPerfilId)
                    .HasColumnName("PERM_SER_PERFIL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermSerSelect)
                    .HasColumnName("PERM_SER_SELECT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PermSerSerieId)
                    .HasColumnName("PERM_SER_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermSerUpdate)
                    .HasColumnName("PERM_SER_UPDATE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PermSerUpdatedBy)
                    .HasColumnName("PERM_SER_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PermSerUpdatedDate)
                    .HasColumnName("PERM_SER_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PermSerUtilizadorId)
                    .HasColumnName("PERM_SER_UTILIZADOR_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ComStock>(entity =>
            {
                entity.HasKey(e => new { e.StockCodigoArmazem, e.StockCodigoArtigo })
                    .HasName("PRIMARY");

                entity.ToTable("com_stock");

                entity.HasIndex(e => e.StockCodigoArtigo)
                    .HasName("FK_STOCK_ARTIGO");

                entity.Property(e => e.StockCodigoArmazem)
                    .HasColumnName("STOCK_CODIGO_ARMAZEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StockCodigoArtigo)
                    .HasColumnName("STOCK_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StockContagem)
                    .HasColumnName("STOCK_CONTAGEM")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockCreatedBy)
                    .HasColumnName("STOCK_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.StockCreatedDate)
                    .HasColumnName("STOCK_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockCustoMedio)
                    .HasColumnName("STOCK_CUSTO_MEDIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockDataUltimaContagem)
                    .HasColumnName("STOCK_DATA_ULTIMA_CONTAGEM")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockDataUltimaEntrada)
                    .HasColumnName("STOCK_DATA_ULTIMA_ENTRADA")
                    .HasColumnType("date");

                entity.Property(e => e.StockDataUltimaSaida)
                    .HasColumnName("STOCK_DATA_ULTIMA_SAIDA")
                    .HasColumnType("date");

                entity.Property(e => e.StockLocalizacao)
                    .HasColumnName("STOCK_LOCALIZACAO")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StockQtdConsigCliente)
                    .HasColumnName("STOCK_QTD_CONSIG_CLIENTE")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockQtdConsigFornecedor)
                    .HasColumnName("STOCK_QTD_CONSIG_FORNECEDOR")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockQtdEncCliente)
                    .HasColumnName("STOCK_QTD_ENC_CLIENTE")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockQtdEncFornecedor)
                    .HasColumnName("STOCK_QTD_ENC_FORNECEDOR")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockQtdMaxima)
                    .HasColumnName("STOCK_QTD_MAXIMA")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockQtdMinima)
                    .HasColumnName("STOCK_QTD_MINIMA")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockQtdReposicao)
                    .HasColumnName("STOCK_QTD_REPOSICAO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockQuantidade)
                    .HasColumnName("STOCK_QUANTIDADE")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockUltimoPrecoCusto)
                    .HasColumnName("STOCK_ULTIMO_PRECO_CUSTO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.StockUpdatedBy)
                    .HasColumnName("STOCK_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.StockUpdatedDate)
                    .HasColumnName("STOCK_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.StockCodigoArmazemNavigation)
                    .WithMany(p => p.ComStock)
                    .HasForeignKey(d => d.StockCodigoArmazem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_stock_ibfk_1");

                entity.HasOne(d => d.StockCodigoArtigoNavigation)
                    .WithMany(p => p.ComStock)
                    .HasForeignKey(d => d.StockCodigoArtigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_stock_ibfk_2");
            });

            modelBuilder.Entity<StockInventory>(entity =>
            {
                entity.HasKey(e => e.InvCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_stock_inventario");

                entity.HasIndex(e => e.InvCodigoArmazem)
                    .HasName("FK_INVENTARIO_ARMAZEM");

                entity.HasIndex(e => e.InvDescricao)
                    .HasName("UK_INVENTORY_REFERENCE")
                    .IsUnique();

                entity.HasIndex(e => e.InvResponsavel)
                    .HasName("STOCk_INVENTORY_MANAGER");

                entity.Property(e => e.InvCodigo)
                    .HasColumnName("INV_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvCodigoArmazem)
                    .HasColumnName("INV_CODIGO_ARMAZEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvCodigoFilial)
                    .HasColumnName("INV_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvCreatedBy)
                    .HasColumnName("INV_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.InvCreatedDate)
                    .HasColumnName("INV_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvDataEncerramento)
                    .HasColumnName("INV_DATA_ENCERRAMENTO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.InvDataInicio)
                    .HasColumnName("INV_DATA_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvDescricao)
                    .IsRequired()
                    .HasColumnName("INV_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.InvResponsavel)
                    .HasColumnName("INV_RESPONSAVEL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvStatus)
                    .HasColumnName("INV_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.InvUpdatedBy)
                    .HasColumnName("INV_UPDATED_BY")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.InvUpdatedDate)
                    .HasColumnName("INV_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.InvCodigoArmazemNavigation)
                    .WithMany(p => p.ComStockInventario)
                    .HasForeignKey(d => d.InvCodigoArmazem)
                    .HasConstraintName("STOCK_INVENTORY_WAREHOUSE");

                entity.HasOne(d => d.InvResponsavelNavigation)
                    .WithMany(p => p.ComStockInventario)
                    .HasForeignKey(d => d.InvResponsavel)
                    .HasConstraintName("STOCk_INVENTORY_MANAGER");
            });

            modelBuilder.Entity<StockInventoryItems>(entity =>
            {
                entity.HasKey(e => new { e.InvCodigoInventario, e.InvCodigoArtigo })
                    .HasName("PRIMARY");

                entity.ToTable("com_stock_inventario_artigos");

                entity.HasIndex(e => e.InvCodigoArtigo)
                    .HasName("FK_STOCK_INVENTARIO_ARTIGO");

                entity.Property(e => e.InvCodigoInventario)
                    .HasColumnName("INV_CODIGO_INVENTARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvCodigoArtigo)
                    .HasColumnName("INV_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvAcerto)
                    .HasColumnName("INV_ACERTO")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.InvContagem)
                    .HasColumnName("INV_CONTAGEM")
                    .HasColumnType("double(18,2)");

                entity.Property(e => e.InvDiferenca)
                    .HasColumnName("INV_DIFERENCA")
                    .HasColumnType("double(18,2)");

                entity.Property(e => e.InvDimensaoId)
                    .HasColumnName("INV_DIMENSAO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvExistencia)
                    .HasColumnName("INV_EXISTENCIA")
                    .HasColumnType("double(18,2)");

                entity.Property(e => e.InvLoteId)
                    .HasColumnName("INV_LOTE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InvSerialId)
                    .HasColumnName("INV_SERIAL_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.InvCodigoArtigoNavigation)
                    .WithMany(p => p.ComStockInventarioArtigos)
                    .HasForeignKey(d => d.InvCodigoArtigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_stock_inventario_artigos_ibfk_1");

                entity.HasOne(d => d.InvCodigoInventarioNavigation)
                    .WithMany(p => p.ComStockInventarioArtigos)
                    .HasForeignKey(d => d.InvCodigoInventario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_stock_inventario_artigos_ibfk_2");
            });

            modelBuilder.Entity<ComTabelaPreco>(entity =>
            {
                entity.HasKey(e => e.PreCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("com_tabela_preco");

                entity.Property(e => e.PreCodigo)
                    .HasColumnName("PRE_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PreCreatedBy)
                    .HasColumnName("PRE_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PreCreatedDate)
                    .HasColumnName("PRE_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreDefault)
                    .HasColumnName("PRE_DEFAULT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PreDescricao)
                    .HasColumnName("PRE_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PreSigla)
                    .HasColumnName("PRE_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PreStatus)
                    .HasColumnName("PRE_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PreUpdatedBy)
                    .HasColumnName("PRE_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PreUpdatedDate)
                    .HasColumnName("PRE_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<ComTabelaPrecoArtigos>(entity =>
            {
                entity.HasKey(e => new { e.PvpArtigo, e.PvpTabela })
                    .HasName("PRIMARY");

                entity.ToTable("com_tabela_preco_artigos");

                entity.HasIndex(e => e.PvpTabela)
                    .HasName("PRECO_PRECO");

                entity.Property(e => e.PvpArtigo)
                    .HasColumnName("PVP_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PvpTabela)
                    .HasColumnName("PVP_TABELA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PvpCreatedBy)
                    .HasColumnName("PVP_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PvpCreatedDate)
                    .HasColumnName("PVP_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PvpImposto)
                    .HasColumnName("PVP_IMPOSTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.PvpImpostoId)
                    .HasColumnName("PVP_IMPOSTO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PvpImpostoIncluido)
                    .HasColumnName("PVP_IMPOSTO_INCLUIDO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PvpPreco)
                    .HasColumnName("PVP_PRECO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.PvpQtd)
                    .HasColumnName("PVP_QTD")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.PvpUnidadeId)
                    .HasColumnName("PVP_UNIDADE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PvpUpdatedBy)
                    .HasColumnName("PVP_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PvpUpdatedDate)
                    .HasColumnName("PVP_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PvpValorImposto)
                    .HasColumnName("PVP_VALOR_IMPOSTO")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.PvpArtigoNavigation)
                    .WithMany(p => p.ComTabelaPrecoArtigos)
                    .HasForeignKey(d => d.PvpArtigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_tabela_preco_artigos_ibfk_1");

                entity.HasOne(d => d.PvpTabelaNavigation)
                    .WithMany(p => p.ComTabelaPrecoArtigos)
                    .HasForeignKey(d => d.PvpTabela)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PRECO_PRECO");
            });

            modelBuilder.Entity<FarMedicamento>(entity =>
            {
                entity.HasKey(e => e.MedCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("far_medicamento");

                entity.HasIndex(e => e.MedCodigo)
                    .HasName("med_codigo")
                    .IsUnique();

                entity.Property(e => e.MedCodigo).HasColumnName("med_codigo");

                entity.Property(e => e.MedApresentacao)
                    .HasColumnName("med_apresentacao")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.MedCodigoBarras)
                    .HasColumnName("med_codigo_barras")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MedCodigoFabricante)
                    .HasColumnName("med_codigo_fabricante")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MedCodigoUnidade)
                    .HasColumnName("med_codigo_unidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MedFormaFarmaceutica)
                    .HasColumnName("med_forma_farmaceutica")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MedFormula)
                    .HasColumnName("med_formula")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MedNomeComercial)
                    .IsRequired()
                    .HasColumnName("med_nome_comercial")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.MedNomeQuimico)
                    .HasColumnName("med_nome_quimico")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MedPrescricao)
                    .HasColumnName("med_prescricao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MedTipo)
                    .HasColumnName("med_tipo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MedValidade)
                    .HasColumnName("med_validade")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<FinBanco>(entity =>
            {
                entity.HasKey(e => e.BancCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("fin_banco");

                entity.Property(e => e.BancCodigo)
                    .HasColumnName("BANC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BancCodigoFilial)
                    .HasColumnName("BANC_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BancSigla)
                    .IsRequired()
                    .HasColumnName("BANC_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.HasOne(d => d.BancCodigoNavigation)
                    .WithOne(p => p.FinBanco)
                    .HasForeignKey<FinBanco>(d => d.BancCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fin_banco_ibfk_1");
            });

            modelBuilder.Entity<FinCambio>(entity =>
            {
                entity.HasKey(e => new { e.CamCodigoMoeda, e.CamInicio, e.CamFilial })
                    .HasName("PRIMARY");

                entity.ToTable("fin_cambio");

                entity.HasIndex(e => e.CamCodigo)
                    .HasName("UK_CODIGO_CAMBIO")
                    .IsUnique();

                entity.Property(e => e.CamCodigoMoeda)
                    .HasColumnName("CAM_CODIGO_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CamInicio)
                    .HasColumnName("CAM_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.CamFilial)
                    .HasColumnName("CAM_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CamCambio)
                    .HasColumnName("CAM_CAMBIO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.CamCodigo)
                    .HasColumnName("CAM_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CamData)
                    .HasColumnName("CAM_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.CamMoedaBase)
                    .HasColumnName("CAM_MOEDA_BASE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CamTermino)
                    .HasColumnName("CAM_TERMINO")
                    .HasColumnType("date");

                entity.HasOne(d => d.CamCodigoNavigation)
                    .WithOne(p => p.FinCambio)
                    .HasForeignKey<FinCambio>(d => d.CamCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fin_cambio_ibfk_1");
            });

            modelBuilder.Entity<FinContaBancaria>(entity =>
            {
                entity.HasKey(e => new { e.ContNumero, e.ContFilial })
                    .HasName("PRIMARY");

                entity.ToTable("fin_conta_bancaria");

                entity.HasIndex(e => e.ContCodigoBanco)
                    .HasName("fin_conta_bancaria_BANCO");

                entity.HasIndex(e => e.ContCodigoMoeda)
                    .HasName("fin_conta_bancaria_MOEDA");

                entity.HasIndex(e => e.ContFilial)
                    .HasName("FK_CONTA_FILIAL");

                entity.HasIndex(e => e.ContId)
                    .HasName("CONT_ID_UK")
                    .IsUnique();

                entity.HasIndex(e => e.ContNumero)
                    .HasName("CONT_NUMERO");

                entity.Property(e => e.ContNumero)
                    .HasColumnName("CONT_NUMERO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ContFilial)
                    .HasColumnName("CONT_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContCodigoBanco)
                    .HasColumnName("CONT_CODIGO_BANCO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContCodigoMoeda)
                    .HasColumnName("CONT_CODIGO_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContCorrente)
                    .HasColumnName("CONT_CORRENTE")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ContCreatedBy)
                    .HasColumnName("CONT_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ContCreatedDate)
                    .HasColumnName("CONT_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContDescricao)
                    .HasColumnName("CONT_DESCRICAO")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.ContEntityId)
                    .HasColumnName("CONT_ENTITY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContIban)
                    .HasColumnName("CONT_IBAN")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ContId)
                    .HasColumnName("CONT_ID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContNib)
                    .HasColumnName("CONT_NIB")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ContPlanoContas)
                    .HasColumnName("CONT_PLANO_CONTAS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContSaldo)
                    .HasColumnName("CONT_SALDO")
                    .HasColumnType("double(18,0)");

                entity.Property(e => e.ContStatus)
                    .HasColumnName("CONT_STATUS")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ContSwift)
                    .HasColumnName("CONT_SWIFT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ContTipo)
                    .HasColumnName("CONT_TIPO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ContUpdatedBy)
                    .HasColumnName("CONT_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ContUpdatedDate)
                    .HasColumnName("CONT_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.ContCodigoBancoNavigation)
                    .WithMany(p => p.FinContaBancaria)
                    .HasForeignKey(d => d.ContCodigoBanco)
                    .HasConstraintName("fin_conta_bancaria_ibfk_1");

                entity.HasOne(d => d.ContCodigoMoedaNavigation)
                    .WithMany(p => p.FinContaBancaria)
                    .HasForeignKey(d => d.ContCodigoMoeda)
                    .HasConstraintName("fin_conta_bancaria_ibfk_2");
            });

            modelBuilder.Entity<FinContasTesouraria>(entity =>
            {
                entity.HasKey(e => e.RubCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("fin_contas_tesouraria");

                entity.HasIndex(e => e.RubCodigoPlanoContas)
                    .HasName("FK_RUBRICA_TESOURARIA_PLANO_CONTAS");

                entity.HasIndex(e => e.RubRubricaId)
                    .HasName("FK_RUBRICA_TESOURARIA");

                entity.Property(e => e.RubCodigo)
                    .HasColumnName("RUB_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RubAgrupamento)
                    .HasColumnName("RUB_AGRUPAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RubClassificacao)
                    .HasColumnName("RUB_CLASSIFICACAO")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RubCodigoPlanoContas)
                    .HasColumnName("RUB_CODIGO_PLANO_CONTAS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RubCreatedBy)
                    .HasColumnName("RUB_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RubCreatedDate)
                    .HasColumnName("RUB_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RubDescricao)
                    .HasColumnName("RUB_DESCRICAO")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RubDestino)
                    .HasColumnName("RUB_DESTINO")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RubIncidenciaDre)
                    .HasColumnName("RUB_INCIDENCIA_DRE")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.RubIsfixa)
                    .HasColumnName("RUB_ISFIXA")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.RubMovimento)
                    .HasColumnName("RUB_MOVIMENTO")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RubNatureza)
                    .HasColumnName("RUB_NATUREZA")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RubRubricaId)
                    .HasColumnName("RUB_RUBRICA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RubUpdatedBy)
                    .HasColumnName("RUB_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RubUpdatedDate)
                    .HasColumnName("RUB_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.RubCodigoPlanoContasNavigation)
                    .WithMany(p => p.FinContasTesouraria)
                    .HasForeignKey(d => d.RubCodigoPlanoContas)
                    .HasConstraintName("FK_RUBRICA_TESOURARIA_PLANO_CONTAS");

                entity.HasOne(d => d.RubRubrica)
                    .WithMany(p => p.InverseRubRubrica)
                    .HasForeignKey(d => d.RubRubricaId)
                    .HasConstraintName("FK_RUBRICA_TESOURARIA");
            });

            modelBuilder.Entity<FinMoeda>(entity =>
            {
                entity.HasKey(e => e.MoeCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("fin_moeda");

                entity.Property(e => e.MoeCodigo)
                    .HasColumnName("MOE_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MoeCasaDecimais)
                    .HasColumnName("MOE_CASA_DECIMAIS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MoeCreatedBy)
                    .HasColumnName("MOE_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MoeCreatedDate)
                    .HasColumnName("MOE_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MoeDescricao)
                    .IsRequired()
                    .HasColumnName("MOE_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.MoeIsoCode)
                    .HasColumnName("MOE_ISO_CODE")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.MoeMoeda)
                    .HasColumnName("MOE_MOEDA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.MoePrecosDecimais)
                    .HasColumnName("MOE_PRECOS_DECIMAIS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MoeSigla)
                    .HasColumnName("MOE_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.MoeStatus)
                    .HasColumnName("MOE_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.MoeUnidade)
                    .HasColumnName("MOE_UNIDADE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.MoeUpdatedBy)
                    .HasColumnName("MOE_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MoeUpdatedDate)
                    .HasColumnName("MOE_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<FinMovimentoCaixa>(entity =>
            {
                entity.HasKey(e => e.MovCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("fin_movimento_caixa");

                entity.HasIndex(e => e.MovCodigoFilial)
                    .HasName("FK_MOVIMENTO_FILIAL");

                entity.HasIndex(e => e.MovCodigoMoeda)
                    .HasName("FK_MOVIMENTO_MOEDA");

                entity.HasIndex(e => e.MovContaBancaria)
                    .HasName("FK_MOVIMENTO_CONTA");

                entity.HasIndex(e => e.MovEntidade)
                    .HasName("FK_MOVIMENTO_ENTIDADE");

                entity.HasIndex(e => e.MovFluxoCaixa)
                    .HasName("FIN_movimento_caixa_rubrica");

                entity.HasIndex(e => e.MovMeioPagamento)
                    .HasName("FK_MOVIMENTO_METODO");

                entity.HasIndex(e => e.MovTreasureSerieId)
                    .HasName("FIN_MOVIMENTO_SERIE");

                entity.Property(e => e.MovCodigo)
                    .HasColumnName("MOV_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovCodigoFilial)
                    .HasColumnName("MOV_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovCodigoMoeda)
                    .HasColumnName("MOV_CODIGO_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovConciliada)
                    .HasColumnName("MOV_CONCILIADA")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.MovContaBancaria)
                    .HasColumnName("MOV_CONTA_BANCARIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MovData)
                    .HasColumnName("MOV_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.MovDataLancamanto)
                    .HasColumnName("MOV_DATA_LANCAMANTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MovDescricao)
                    .HasColumnName("MOV_DESCRICAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MovDocumentId)
                    .HasColumnName("MOV_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovDocumentType)
                    .HasColumnName("MOV_DOCUMENT_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovEntidade)
                    .HasColumnName("MOV_ENTIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovFluxoCaixa)
                    .HasColumnName("MOV_FLUXO_CAIXA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovMeioPagamento)
                    .HasColumnName("MOV_MEIO_PAGAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovNumDocPagto)
                    .HasColumnName("MOV_NUM_DOC_PAGTO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MovNumeracao)
                    .HasColumnName("MOV_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovObservacoes)
                    .HasColumnName("MOV_OBSERVACOES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MovReal)
                    .HasColumnName("MOV_REAL")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.MovReferencia)
                    .HasColumnName("MOV_REFERENCIA")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MovStatus)
                    .HasColumnName("MOV_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovTransacao)
                    .HasColumnName("MOV_TRANSACAO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.MovTreasureSerieId)
                    .HasColumnName("MOV_TREASURE_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovUtilizador)
                    .HasColumnName("MOV_UTILIZADOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MovValor)
                    .HasColumnName("MOV_VALOR")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.MovCodigoFilialNavigation)
                    .WithMany(p => p.FinMovimentoCaixa)
                    .HasForeignKey(d => d.MovCodigoFilial)
                    .HasConstraintName("fin_movimento_caixa_ibfk_3");

                entity.HasOne(d => d.MovCodigoMoedaNavigation)
                    .WithMany(p => p.FinMovimentoCaixa)
                    .HasForeignKey(d => d.MovCodigoMoeda)
                    .HasConstraintName("fin_movimento_caixa_ibfk_5");

                entity.HasOne(d => d.MovEntidadeNavigation)
                    .WithMany(p => p.FinMovimentoCaixa)
                    .HasForeignKey(d => d.MovEntidade)
                    .HasConstraintName("fin_movimento_caixa_ibfk_2");

                entity.HasOne(d => d.MovFluxoCaixaNavigation)
                    .WithMany(p => p.FinMovimentoCaixa)
                    .HasForeignKey(d => d.MovFluxoCaixa)
                    .HasConstraintName("FIN_movimento_caixa_rubrica");

                entity.HasOne(d => d.MovMeioPagamentoNavigation)
                    .WithMany(p => p.FinMovimentoCaixa)
                    .HasForeignKey(d => d.MovMeioPagamento)
                    .HasConstraintName("fin_movimento_caixa_ibfk_4");

                entity.HasOne(d => d.MovTreasureSerie)
                    .WithMany(p => p.FinMovimentoCaixa)
                    .HasForeignKey(d => d.MovTreasureSerieId)
                    .HasConstraintName("FIN_MOVIMENTO_SERIE");
            });

            modelBuilder.Entity<FinMovimentoFatura>(entity =>
            {
                entity.HasKey(e => new { e.MovCodigoMovimento, e.MovCodigoFatura })
                    .HasName("PRIMARY");

                entity.ToTable("fin_movimento_fatura");

                entity.HasIndex(e => e.MovCodigoFatura)
                    .HasName("FK_MOVIMENTO_FATURA_FATURA");

                entity.Property(e => e.MovCodigoMovimento)
                    .HasColumnName("MOV_CODIGO_MOVIMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovCodigoFatura)
                    .HasColumnName("MOV_CODIGO_FATURA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovFatStatus)
                    .HasColumnName("MOV_FAT_STATUS")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.HasOne(d => d.MovCodigoFaturaNavigation)
                    .WithMany(p => p.FinMovimentoFatura)
                    .HasForeignKey(d => d.MovCodigoFatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fin_movimento_fatura_ibfk_1");

                entity.HasOne(d => d.MovCodigoMovimentoNavigation)
                    .WithMany(p => p.FinMovimentoFatura)
                    .HasForeignKey(d => d.MovCodigoMovimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fin_movimento_fatura_ibfk_2");
            });

            modelBuilder.Entity<FinMovimentosPeriodicos>(entity =>
            {
                entity.HasKey(e => e.ProgCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("fin_movimentos_periodicos");

                entity.Property(e => e.ProgCodigo)
                    .HasColumnName("PROG_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgAccountId)
                    .HasColumnName("PROG_ACCOUNT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgCambio)
                    .HasColumnName("PROG_CAMBIO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ProgCreatedBy)
                    .HasColumnName("PROG_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ProgCreatedDate)
                    .HasColumnName("PROG_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProgDeletedBy)
                    .HasColumnName("PROG_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ProgDeletedDate)
                    .HasColumnName("PROG_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProgDescricao)
                    .HasColumnName("PROG_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ProgDias)
                    .HasColumnName("PROG_DIAS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgDocumentId)
                    .HasColumnName("PROG_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgEntidadeId)
                    .HasColumnName("PROG_ENTIDADE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgFrom)
                    .HasColumnName("PROG_FROM")
                    .HasColumnType("date");

                entity.Property(e => e.ProgMoedaId)
                    .HasColumnName("PROG_MOEDA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgNatureza)
                    .HasColumnName("PROG_NATUREZA")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ProgPeriodicidade)
                    .HasColumnName("PROG_PERIODICIDADE")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProgRubricaId)
                    .HasColumnName("PROG_RUBRICA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgStatus)
                    .HasColumnName("PROG_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ProgUntil)
                    .HasColumnName("PROG_UNTIL")
                    .HasColumnType("date");

                entity.Property(e => e.ProgUpdatedBy)
                    .HasColumnName("PROG_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ProgUpdatedDate)
                    .HasColumnName("PROG_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProgValor)
                    .HasColumnName("PROG_VALOR")
                    .HasColumnType("decimal(18,5)");
            });

            modelBuilder.Entity<FinPlanoContas>(entity =>
            {
                entity.HasKey(e => e.PlanCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("fin_plano_contas");

                entity.HasIndex(e => e.PlanCodigoPai)
                    .HasName("FK_PLANO_CONTA");

                entity.Property(e => e.PlanCodigo)
                    .HasColumnName("PLAN_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanClasse)
                    .HasColumnName("PLAN_CLASSE")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PlanCodigoPai)
                    .HasColumnName("PLAN_CODIGO_PAI")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlanConta)
                    .HasColumnName("PLAN_CONTA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PlanDescricao)
                    .HasColumnName("PLAN_DESCRICAO")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PlanEstado)
                    .HasColumnName("PLAN_ESTADO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PlanNivel)
                    .HasColumnName("PLAN_NIVEL")
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.PlanCodigoPaiNavigation)
                    .WithMany(p => p.InversePlanCodigoPaiNavigation)
                    .HasForeignKey(d => d.PlanCodigoPai)
                    .HasConstraintName("fin_plano_contas_ibfk_1");
            });

            modelBuilder.Entity<GerArmazem>(entity =>
            {
                entity.HasKey(e => e.ArmCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_armazem");

                entity.HasIndex(e => e.ArmCodigoFilial)
                    .HasName("FK_FILIAL_STOCK");

                entity.Property(e => e.ArmCodigo)
                    .HasColumnName("ARM_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArmAlertaNegativo)
                    .HasColumnName("ARM_ALERTA_NEGATIVO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ArmAlertaSm)
                    .HasColumnName("ARM_ALERTA_SM")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ArmCodigoFilial)
                    .HasColumnName("ARM_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArmCreatedBy)
                    .HasColumnName("ARM_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ArmCreatedDate)
                    .HasColumnName("ARM_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ArmDeletedBy)
                    .HasColumnName("ARM_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ArmDeletedDate)
                    .HasColumnName("ARM_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ArmDescricao)
                    .HasColumnName("ARM_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ArmInStatus)
                    .HasColumnName("ARM_IN_STATUS")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.ArmOutStatus)
                    .HasColumnName("ARM_OUT_STATUS")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.ArmPermiteNegativo)
                    .HasColumnName("ARM_PERMITE_NEGATIVO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ArmPos)
                    .HasColumnName("ARM_POS")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.ArmSigla)
                    .HasColumnName("ARM_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.ArmStatus)
                    .HasColumnName("ARM_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ArmTipo)
                    .HasColumnName("ARM_TIPO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ArmUpdatedBy)
                    .HasColumnName("ARM_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ArmUpdatedDate)
                    .HasColumnName("ARM_UPDATED_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<GerArmazemPermissoes>(entity =>
            {
                entity.HasKey(e => e.WarPermCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_armazem_permissoes");

                entity.HasIndex(e => e.WarPermArmazemId)
                    .HasName("FK_ARMAZEM_PERMISSAO_ARMAZEM");

                entity.HasIndex(e => e.WarPermPerfilId)
                    .HasName("FK_ARMAZEM_PERMISSAO_PERFIL");

                entity.HasIndex(e => e.WarPermUtilizadorId)
                    .HasName("FK_ARMAZEM_PERMISSAO_UTILIZADOR");

                entity.Property(e => e.WarPermCodigo)
                    .HasColumnName("WAR_PERM_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WarPermArmazemId)
                    .HasColumnName("WAR_PERM_ARMAZEM_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WarPermCreatedBy)
                    .HasColumnName("WAR_PERM_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.WarPermCreatedDate)
                    .HasColumnName("WAR_PERM_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarPermDelete)
                    .HasColumnName("WAR_PERM_DELETE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.WarPermInsert)
                    .HasColumnName("WAR_PERM_INSERT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.WarPermPerfilId)
                    .HasColumnName("WAR_PERM_PERFIL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WarPermPrint)
                    .HasColumnName("WAR_PERM_PRINT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.WarPermSelect)
                    .HasColumnName("WAR_PERM_SELECT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.WarPermStatus)
                    .HasColumnName("WAR_PERM_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.WarPermUpdate)
                    .HasColumnName("WAR_PERM_UPDATE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.WarPermUpdatedBy)
                    .HasColumnName("WAR_PERM_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.WarPermUpdatedDate)
                    .HasColumnName("WAR_PERM_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarPermUtilizadorId)
                    .HasColumnName("WAR_PERM_UTILIZADOR_ID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.WarPermArmazem)
                    .WithMany(p => p.GerArmazemPermissoes)
                    .HasForeignKey(d => d.WarPermArmazemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ger_armazem_permissoes_ibfk_1");

                entity.HasOne(d => d.WarPermPerfil)
                    .WithMany(p => p.GerArmazemPermissoes)
                    .HasForeignKey(d => d.WarPermPerfilId)
                    .HasConstraintName("ger_armazem_permissoes_ibfk_2");

                entity.HasOne(d => d.WarPermUtilizador)
                    .WithMany(p => p.GerArmazemPermissoes)
                    .HasPrincipalKey(p => p.UtiCodigo)
                    .HasForeignKey(d => d.WarPermUtilizadorId)
                    .HasConstraintName("ger_armazem_permissoes_ibfk_3");
            });

            modelBuilder.Entity<GerArtigo>(entity =>
            {
                entity.HasKey(e => e.ArtCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_artigo");

                entity.HasIndex(e => e.ArtCategoria)
                    .HasName("FK_ARTIGO_CATEGORIA");

                entity.HasIndex(e => e.ArtCodigoFabricante)
                    .HasName("FK_ARTIGO_FABRICANTE");

                entity.HasIndex(e => e.ArtCodigoFilial)
                    .HasName("FK_ARTIGO_FILIAL");

                entity.HasIndex(e => e.ArtCodigoImposto)
                    .HasName("FK_ARTIGO_IMPOSTO");

                entity.HasIndex(e => e.ArtMarca)
                    .HasName("FK_ARTIGO_MARCA");

                entity.HasIndex(e => e.ArtUnidadeVenda)
                    .HasName("FK_ARTIGO_UNIDADE");

                entity.Property(e => e.ArtCodigo)
                    .HasColumnName("ART_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtAlertaRuptura)
                    .HasColumnName("ART_ALERTA_RUPTURA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtAllowDimensoes)
                    .HasColumnName("ART_ALLOW_DIMENSOES")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtAllowDownStock)
                    .HasColumnName("ART_ALLOW_DOWN_STOCK")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtAllowLote)
                    .HasColumnName("ART_ALLOW_LOTE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtAllowReserveStock)
                    .HasColumnName("ART_ALLOW_RESERVE_STOCK")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ArtAnoFabrico)
                    .HasColumnName("ART_ANO_FABRICO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtArtigoBase)
                    .HasColumnName("ART_ARTIGO_BASE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtCadastro)
                    .HasColumnName("ART_CADASTRO")
                    .HasColumnType("date");

                entity.Property(e => e.ArtCalorias)
                    .HasColumnName("ART_CALORIAS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtCarbohidratos)
                    .HasColumnName("ART_CARBOHIDRATOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtCategoria)
                    .HasColumnName("ART_CATEGORIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtCodigoBarras)
                    .HasColumnName("ART_CODIGO_BARRAS")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArtCodigoFabricante)
                    .HasColumnName("ART_CODIGO_FABRICANTE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtCodigoFilial)
                    .HasColumnName("ART_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtCodigoImposto)
                    .HasColumnName("ART_CODIGO_IMPOSTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtComissao)
                    .HasColumnName("ART_COMISSAO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtComposePrice)
                    .HasColumnName("ART_COMPOSE_PRICE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtComposeType)
                    .HasColumnName("ART_COMPOSE_TYPE")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.ArtComposto)
                    .HasColumnName("ART_COMPOSTO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtContaPurchase)
                    .HasColumnName("ART_CONTA_PURCHASE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtContaSales)
                    .HasColumnName("ART_CONTA_SALES")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtContaStock)
                    .HasColumnName("ART_CONTA_STOCK")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtCreatedBy)
                    .HasColumnName("ART_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ArtCreatedDate)
                    .HasColumnName("ART_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.ArtDescontinuado)
                    .HasColumnName("ART_DESCONTINUADO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtDesconto)
                    .HasColumnName("ART_DESCONTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtDescricaoComercial)
                    .HasColumnName("ART_DESCRICAO_COMERCIAL")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ArtDescricaoCurta)
                    .HasColumnName("ART_DESCRICAO_CURTA")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArtDesignacao)
                    .HasColumnName("ART_DESIGNACAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ArtDevolucao)
                    .HasColumnName("ART_DEVOLUCAO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtDevolucaoPurchase)
                    .HasColumnName("ART_DEVOLUCAO_PURCHASE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtDevolucaoSales)
                    .HasColumnName("ART_DEVOLUCAO_SALES")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtDiscountType)
                    .HasColumnName("ART_DISCOUNT_TYPE")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ArtDurcaoCam)
                    .HasColumnName("ART_DURCAO_CAM")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ArtExterno)
                    .HasColumnName("ART_EXTERNO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtGorduras)
                    .HasColumnName("ART_GORDURAS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtImagem)
                    .HasColumnName("ART_IMAGEM")
                    .HasColumnType("text");

                entity.Property(e => e.ArtImpostoIncluido)
                    .HasColumnName("ART_IMPOSTO_INCLUIDO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtInterno)
                    .HasColumnName("ART_INTERNO")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.ArtIscam)
                    .HasColumnName("ART_ISCAM")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.ArtIsencaoId)
                    .HasColumnName("ART_ISENCAO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtIsgriftCard)
                    .HasColumnName("ART_ISGRIFT_CARD")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.ArtLoteManagment)
                    .HasColumnName("ART_LOTE_MANAGMENT")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ArtMainFornecedorId)
                    .HasColumnName("ART_MAIN_FORNECEDOR_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtMainVendedor)
                    .HasColumnName("ART_MAIN_VENDEDOR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtMarca)
                    .HasColumnName("ART_MARCA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtMargemLucro)
                    .HasColumnName("ART_MARGEM_LUCRO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtMotivoIsencao)
                    .HasColumnName("ART_MOTIVO_ISENCAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ArtMovimentaStock)
                    .HasColumnName("ART_MOVIMENTA_STOCK")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ArtObservacoes)
                    .HasColumnName("ART_OBSERVACOES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ArtOnlyOrder)
                    .HasColumnName("ART_ONLY_ORDER")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtParcela)
                    .HasColumnName("ART_PARCELA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtPcmCalculado)
                    .HasColumnName("ART_PCM_CALCULADO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ArtPcmPadrao)
                    .HasColumnName("ART_PCM_PADRAO")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.ArtPedidoCozinha)
                    .HasColumnName("ART_PEDIDO_COZINHA")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtPercentImposto)
                    .HasColumnName("ART_PERCENT_IMPOSTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtPeso)
                    .HasColumnName("ART_PESO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtPesoLiquido)
                    .HasColumnName("ART_PESO_LIQUIDO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtPos)
                    .HasColumnName("ART_POS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtPrazoEntrega)
                    .HasColumnName("ART_PRAZO_ENTREGA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtPrecoCusto)
                    .HasColumnName("ART_PRECO_CUSTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtPrecoVenda)
                    .HasColumnName("ART_PRECO_VENDA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtProteinas)
                    .HasColumnName("ART_PROTEINAS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtProvideCam)
                    .HasColumnName("ART_PROVIDE_CAM")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.ArtQtdBalanca)
                    .HasColumnName("ART_QTD_BALANCA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtQtdCompra)
                    .HasColumnName("ART_QTD_COMPRA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtQtdEntrada)
                    .HasColumnName("ART_QTD_ENTRADA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtQtdReferencia)
                    .HasColumnName("ART_QTD_REFERENCIA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtQtdSaida)
                    .HasColumnName("ART_QTD_SAIDA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtQtdVenda)
                    .HasColumnName("ART_QTD_VENDA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtReferencia)
                    .HasColumnName("ART_REFERENCIA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ArtRestpos)
                    .HasColumnName("ART_RESTPOS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtRetailId)
                    .HasColumnName("ART_RETAIL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtRetencaoId)
                    .HasColumnName("ART_RETENCAO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtStatus)
                    .HasColumnName("ART_STATUS")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.ArtTabelaPreco)
                    .HasColumnName("ART_TABELA_PRECO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ArtTempoPreparacao)
                    .HasColumnName("ART_TEMPO_PREPARACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtTipo)
                    .HasColumnName("ART_TIPO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ArtUltimaEntrada)
                    .HasColumnName("ART_ULTIMA_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.ArtUltimaSaida)
                    .HasColumnName("ART_ULTIMA_SAIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.ArtUnidadeCompra)
                    .HasColumnName("ART_UNIDADE_COMPRA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtUnidadeEntrada)
                    .HasColumnName("ART_UNIDADE_ENTRADA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtUnidadeReferencia)
                    .HasColumnName("ART_UNIDADE_REFERENCIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtUnidadeSaida)
                    .HasColumnName("ART_UNIDADE_SAIDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtUnidadeVenda)
                    .HasColumnName("ART_UNIDADE_VENDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtUpdatedBy)
                    .HasColumnName("ART_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ArtUpdatedDate)
                    .HasColumnName("ART_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.ArtValidade)
                    .HasColumnName("ART_VALIDADE")
                    .HasColumnType("date");

                entity.Property(e => e.ArtValorImposto)
                    .HasColumnName("ART_VALOR_IMPOSTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ArtVasilhameId)
                    .HasColumnName("ART_VASILHAME_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArtVideo)
                    .HasColumnName("ART_VIDEO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ArtVolume)
                    .HasColumnName("ART_VOLUME")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.ArtCategoriaNavigation)
                    .WithMany(p => p.GerArtigo)
                    .HasForeignKey(d => d.ArtCategoria)
                    .HasConstraintName("ger_artigo_ibfk_1");

                entity.HasOne(d => d.ArtCodigoFilialNavigation)
                    .WithMany(p => p.GerArtigo)
                    .HasForeignKey(d => d.ArtCodigoFilial)
                    .HasConstraintName("ger_artigo_ibfk_2");

                entity.HasOne(d => d.ArtCodigoImpostoNavigation)
                    .WithMany(p => p.GerArtigo)
                    .HasForeignKey(d => d.ArtCodigoImposto)
                    .HasConstraintName("ger_artigo_ibfk_3");

                entity.HasOne(d => d.ArtMarcaNavigation)
                    .WithMany(p => p.GerArtigo)
                    .HasForeignKey(d => d.ArtMarca)
                    .HasConstraintName("ger_artigo_ibfk_4");

                entity.HasOne(d => d.ArtUnidadeVendaNavigation)
                    .WithMany(p => p.GerArtigo)
                    .HasForeignKey(d => d.ArtUnidadeVenda)
                    .HasConstraintName("ger_artigo_ibfk_5");
            });

            modelBuilder.Entity<GerArtigoComposicao>(entity =>
            {
                entity.HasKey(e => new { e.CompCodigoArtigo, e.CompCodigoComponente })
                    .HasName("PRIMARY");

                entity.ToTable("ger_artigo_composicao");

                entity.HasIndex(e => e.CompCodigoComponente)
                    .HasName("FK_ARTIGO_COMPOSICAO_COMPONENTE");

                entity.Property(e => e.CompCodigoArtigo)
                    .HasColumnName("COMP_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompCodigoComponente)
                    .HasColumnName("COMP_CODIGO_COMPONENTE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompPrecoUnitario)
                    .HasColumnName("COMP_PRECO_UNITARIO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.CompQuantidade)
                    .HasColumnName("COMP_QUANTIDADE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.CompValor)
                    .HasColumnName("COMP_VALOR")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.CompCodigoArtigoNavigation)
                    .WithMany(p => p.GerArtigoComposicaoCompCodigoArtigoNavigation)
                    .HasForeignKey(d => d.CompCodigoArtigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ger_artigo_composicao_ibfk_1");

                entity.HasOne(d => d.CompCodigoComponenteNavigation)
                    .WithMany(p => p.GerArtigoComposicaoCompCodigoComponenteNavigation)
                    .HasForeignKey(d => d.CompCodigoComponente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ger_artigo_composicao_ibfk_2");
            });

            modelBuilder.Entity<GerArtigoDimensoes>(entity =>
            {
                entity.HasKey(e => e.DimCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_artigo_dimensoes");

                entity.Property(e => e.DimCodigo)
                    .HasColumnName("DIM_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DimCodigoArtigo)
                    .HasColumnName("DIM_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DimCodigoBarras)
                    .HasColumnName("DIM_CODIGO_BARRAS")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DimCodigoCor)
                    .HasColumnName("DIM_CODIGO_COR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DimCodigoTamanho)
                    .HasColumnName("DIM_CODIGO_TAMANHO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DimCreatedBy)
                    .HasColumnName("DIM_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DimCreatedDate)
                    .HasColumnName("DIM_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DimCustoPonderado)
                    .HasColumnName("DIM_CUSTO_PONDERADO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.DimDataLimiteFaturacao)
                    .HasColumnName("DIM_DATA_LIMITE_FATURACAO")
                    .HasColumnType("date");

                entity.Property(e => e.DimDataUltimaEntrada)
                    .HasColumnName("DIM_DATA_ULTIMA_ENTRADA")
                    .HasColumnType("date");

                entity.Property(e => e.DimDataValidade)
                    .HasColumnName("DIM_DATA_VALIDADE")
                    .HasColumnType("date");

                entity.Property(e => e.DimDeletedBy)
                    .HasColumnName("DIM_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DimDeletedDate)
                    .HasColumnName("DIM_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DimRefFornecedor)
                    .HasColumnName("DIM_REF_FORNECEDOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DimReferencia)
                    .HasColumnName("DIM_REFERENCIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DimStockActual)
                    .HasColumnName("DIM_STOCK_ACTUAL")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.DimStockEntrada)
                    .HasColumnName("DIM_STOCK_ENTRADA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.DimStockSaida)
                    .HasColumnName("DIM_STOCK_SAIDA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.DimUltimoPrecoCusto)
                    .HasColumnName("DIM_ULTIMO_PRECO_CUSTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.DimUpdatedBy)
                    .HasColumnName("DIM_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DimUpdatedDate)
                    .HasColumnName("DIM_UPDATED_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<GerArtigoLote>(entity =>
            {
                entity.HasKey(e => e.LotCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_artigo_lote");

                entity.Property(e => e.LotCodigo)
                    .HasColumnName("LOT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LotCodigoArtigo)
                    .HasColumnName("LOT_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LotCodigoBarras)
                    .HasColumnName("LOT_CODIGO_BARRAS")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.LotCreatedBy)
                    .HasColumnName("LOT_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LotCreatedDate)
                    .HasColumnName("LOT_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotCustoPonderado)
                    .HasColumnName("LOT_CUSTO_PONDERADO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.LotDataFabrico)
                    .HasColumnName("LOT_DATA_FABRICO")
                    .HasColumnType("date");

                entity.Property(e => e.LotDataLimiteFaturacao)
                    .HasColumnName("LOT_DATA_LIMITE_FATURACAO")
                    .HasColumnType("date");

                entity.Property(e => e.LotDataUltimaEntrada)
                    .HasColumnName("LOT_DATA_ULTIMA_ENTRADA")
                    .HasColumnType("date");

                entity.Property(e => e.LotDataValidade)
                    .HasColumnName("LOT_DATA_VALIDADE")
                    .HasColumnType("date");

                entity.Property(e => e.LotIncomeUnit)
                    .HasColumnName("LOT_INCOME_UNIT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LotOutcomeUnit)
                    .HasColumnName("LOT_OUTCOME_UNIT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LotPurchageUnit)
                    .HasColumnName("LOT_PURCHAGE_UNIT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LotReferencia)
                    .IsRequired()
                    .HasColumnName("LOT_REFERENCIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LotSalesUnit)
                    .HasColumnName("LOT_SALES_UNIT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LotStatus)
                    .HasColumnName("LOT_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.LotStockActual)
                    .HasColumnName("LOT_STOCK_ACTUAL")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.LotStockEntrada)
                    .HasColumnName("LOT_STOCK_ENTRADA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.LotStockRecepcao)
                    .HasColumnName("LOT_STOCK_RECEPCAO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.LotStockSaida)
                    .HasColumnName("LOT_STOCK_SAIDA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.LotStockUnit)
                    .HasColumnName("LOT_STOCK_UNIT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LotSupplierId)
                    .HasColumnName("LOT_SUPPLIER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LotUltimoPrecoCusto)
                    .HasColumnName("LOT_ULTIMO_PRECO_CUSTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.LotUpdatedBy)
                    .HasColumnName("LOT_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LotUpdatedDate)
                    .HasColumnName("LOT_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<GerArtigoSemelhanca>(entity =>
            {
                entity.HasKey(e => new { e.SemCodigoArtigoA, e.SemCodigoArtigoB })
                    .HasName("PRIMARY");

                entity.ToTable("ger_artigo_semelhanca");

                entity.HasIndex(e => e.SemCodigoArtigoB)
                    .HasName("FK_ARTIGO_SEMELHANTE_B");

                entity.Property(e => e.SemCodigoArtigoA)
                    .HasColumnName("SEM_CODIGO_ARTIGO_A")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SemCodigoArtigoB)
                    .HasColumnName("SEM_CODIGO_ARTIGO_B")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.SemCodigoArtigoANavigation)
                    .WithMany(p => p.GerArtigoSemelhancaSemCodigoArtigoANavigation)
                    .HasForeignKey(d => d.SemCodigoArtigoA)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ger_artigo_semelhanca_ibfk_1");

                entity.HasOne(d => d.SemCodigoArtigoBNavigation)
                    .WithMany(p => p.GerArtigoSemelhancaSemCodigoArtigoBNavigation)
                    .HasForeignKey(d => d.SemCodigoArtigoB)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ger_artigo_semelhanca_ibfk_2");
            });

            modelBuilder.Entity<GerArtigoSerialNumber>(entity =>
            {
                entity.HasKey(e => new { e.SerialArtigoId, e.SerialSerialNumber })
                    .HasName("PRIMARY");

                entity.ToTable("ger_artigo_serial_number");

                entity.HasIndex(e => e.SerialCodigo)
                    .HasName("UK_SERIAL_NUMBER")
                    .IsUnique();

                entity.Property(e => e.SerialArtigoId)
                    .HasColumnName("SERIAL_ARTIGO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SerialSerialNumber)
                    .HasColumnName("SERIAL_SERIAL_NUMBER")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SerialBarcode)
                    .HasColumnName("SERIAL_BARCODE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SerialCodigo)
                    .HasColumnName("SERIAL_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SerialCreatedBy)
                    .HasColumnName("SERIAL_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SerialCreatedDate)
                    .HasColumnName("SERIAL_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SerialStatus)
                    .HasColumnName("SERIAL_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SerialUpdatedBy)
                    .HasColumnName("SERIAL_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SerialUpdatedDate)
                    .HasColumnName("SERIAL_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.SerialArtigo)
                    .WithMany(p => p.GerArtigoSerialNumber)
                    .HasForeignKey(d => d.SerialArtigoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SERIAL_PRODUCT_ID");
            });

            modelBuilder.Entity<GerCategoria>(entity =>
            {
                entity.HasKey(e => e.CatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_categoria");

                entity.Property(e => e.CatCodigo)
                    .HasColumnName("CAT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatCategoria)
                    .HasColumnName("CAT_CATEGORIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatDescricao)
                    .IsRequired()
                    .HasColumnName("CAT_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.CatImagem)
                    .HasColumnName("CAT_IMAGEM")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CatSigla)
                    .IsRequired()
                    .HasColumnName("CAT_SIGLA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CatStatus)
                    .HasColumnName("CAT_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<GerCores>(entity =>
            {
                entity.HasKey(e => e.CorCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_cores");

                entity.Property(e => e.CorCodigo)
                    .HasColumnName("COR_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorDescricao)
                    .IsRequired()
                    .HasColumnName("COR_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.CorSigla)
                    .HasColumnName("COR_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.CorStatus)
                    .HasColumnName("COR_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerDepartamento>(entity =>
            {
                entity.HasKey(e => e.DepCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_departamento");

                entity.Property(e => e.DepCodigo)
                    .HasColumnName("DEP_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DepDescricao)
                    .IsRequired()
                    .HasColumnName("DEP_DESCRICAO")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.DepSigla)
                    .HasColumnName("DEP_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.DepStatus)
                    .HasColumnName("DEP_STATUS")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<GerDistritos>(entity =>
            {
                entity.HasKey(e => e.DistCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_distritos");

                entity.HasIndex(e => e.DistComunaId)
                    .HasName("FK_DISTRITO_COMUNA");

                entity.HasIndex(e => e.DistMunicipioId)
                    .HasName("FK_DISTRITO_MUNICIPIO");

                entity.Property(e => e.DistCodigo)
                    .HasColumnName("DIST_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DistComunaId)
                    .HasColumnName("DIST_COMUNA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DistCreatedBy)
                    .HasColumnName("DIST_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DistCreatedDate)
                    .HasColumnName("DIST_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DistDescricao)
                    .HasColumnName("DIST_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.DistMunicipioId)
                    .HasColumnName("DIST_MUNICIPIO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DistSigla)
                    .HasColumnName("DIST_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.DistUpdatedBy)
                    .HasColumnName("DIST_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DistUpdatedDate)
                    .HasColumnName("DIST_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.DistComuna)
                    .WithMany(p => p.InverseDistComuna)
                    .HasForeignKey(d => d.DistComunaId)
                    .HasConstraintName("FK_DISTRITO_COMUNA");

                entity.HasOne(d => d.DistMunicipio)
                    .WithMany(p => p.GerDistritos)
                    .HasForeignKey(d => d.DistMunicipioId)
                    .HasConstraintName("FK_DISTRITO_MUNICIPIO");
            });

            modelBuilder.Entity<GerDocumento>(entity =>
            {
                entity.HasKey(e => e.DocCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_documento");

                entity.Property(e => e.DocCodigo)
                    .HasColumnName("DOC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocDescricao)
                    .HasColumnName("DOC_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.DocEstado)
                    .HasColumnName("DOC_ESTADO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.DocSigla)
                    .HasColumnName("DOC_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.DocTipo)
                    .HasColumnName("DOC_TIPO")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerDocumentosRelacionados>(entity =>
            {
                entity.HasKey(e => new { e.DocMainDocumentId, e.DocRelatedDocumentId })
                    .HasName("PRIMARY");

                entity.ToTable("ger_documentos_relacionados");

                entity.HasIndex(e => e.DocRelatedDocumentId)
                    .HasName("FK_RELATED_SALES_DOCUMENT");

                entity.Property(e => e.DocMainDocumentId)
                    .HasColumnName("DOC_MAIN_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocRelatedDocumentId)
                    .HasColumnName("DOC_RELATED_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocCreatedBy)
                    .HasColumnName("DOC_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DocCreatedDate)
                    .HasColumnName("DOC_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocMainDocumentType)
                    .HasColumnName("DOC_MAIN_DOCUMENT_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocRelatedDocumentType)
                    .HasColumnName("DOC_RELATED_DOCUMENT_TYPE")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.DocMainDocument)
                    .WithMany(p => p.GerDocumentosRelacionadosDocMainDocument)
                    .HasForeignKey(d => d.DocMainDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAIN_SALES_DOCUMENT");

                entity.HasOne(d => d.DocRelatedDocument)
                    .WithMany(p => p.GerDocumentosRelacionadosDocRelatedDocument)
                    .HasForeignKey(d => d.DocRelatedDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RELATED_SALES_DOCUMENT");
            });

            modelBuilder.Entity<GerEntidade>(entity =>
            {
                entity.HasKey(e => e.EntCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_entidade");

                entity.HasIndex(e => e.EntCodigoPais)
                    .HasName("FK_PAIS_ENTIDADE");

                entity.HasIndex(e => e.EntLocalMorada)
                    .HasName("FK_MUNICIPIO_MORADA");

                entity.HasIndex(e => e.EntLocalNascimento)
                    .HasName("FK_MUNICIPIO_NASCIMENTO");

                entity.HasIndex(e => e.EntNacionalidade)
                    .HasName("FK_NACIONALIDADE");

                entity.Property(e => e.EntCodigo)
                    .HasColumnName("ENT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntBairro)
                    .HasColumnName("ENT_BAIRRO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.EntCodigoDocumento)
                    .HasColumnName("ENT_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntCodigoPais)
                    .HasColumnName("ENT_CODIGO_PAIS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntCreatedBy)
                    .HasColumnName("ENT_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.EntDataInclusao)
                    .HasColumnName("ENT_DATA_INCLUSAO")
                    .HasColumnType("date");

                entity.Property(e => e.EntDataNascimento)
                    .HasColumnName("ENT_DATA_NASCIMENTO")
                    .HasColumnType("date");

                entity.Property(e => e.EntDistrito)
                    .HasColumnName("ENT_DISTRITO")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EntEmail)
                    .HasColumnName("ENT_EMAIL")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.EntFotografia).HasColumnName("ENT_FOTOGRAFIA");

                entity.Property(e => e.EntFotografiaExtensao)
                    .HasColumnName("ENT_FOTOGRAFIA_EXTENSAO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.EntFotografiaPath)
                    .HasColumnName("ENT_FOTOGRAFIA_PATH")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.EntIdentificacao)
                    .HasColumnName("ENT_IDENTIFICACAO")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.EntLocalMorada)
                    .HasColumnName("ENT_LOCAL_MORADA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntLocalNascimento)
                    .HasColumnName("ENT_LOCAL_NASCIMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntNacionalidade)
                    .HasColumnName("ENT_NACIONALIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntNomeCompleto)
                    .HasColumnName("ENT_NOME_COMPLETO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.EntRua)
                    .HasColumnName("ENT_RUA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.EntStatus)
                    .HasColumnName("ENT_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.EntTelefone)
                    .HasColumnName("ENT_TELEFONE")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.EntTelefoneAlternativo)
                    .HasColumnName("ENT_TELEFONE_ALTERNATIVO")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.EntTelefoneFax)
                    .HasColumnName("ENT_TELEFONE_FAX")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.EntUpdatedBy)
                    .HasColumnName("ENT_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.EntUpdatedDate)
                    .HasColumnName("ENT_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntWebsite)
                    .HasColumnName("ENT_WEBSITE")
                    .HasColumnType("varchar(120)");

                entity.HasOne(d => d.EntCodigoPaisNavigation)
                    .WithMany(p => p.GerEntidadeEntCodigoPaisNavigation)
                    .HasForeignKey(d => d.EntCodigoPais)
                    .HasConstraintName("ger_entidade_ibfk_4");

                entity.HasOne(d => d.EntLocalMoradaNavigation)
                    .WithMany(p => p.GerEntidadeEntLocalMoradaNavigation)
                    .HasForeignKey(d => d.EntLocalMorada)
                    .HasConstraintName("ger_entidade_ibfk_1");

                entity.HasOne(d => d.EntLocalNascimentoNavigation)
                    .WithMany(p => p.GerEntidadeEntLocalNascimentoNavigation)
                    .HasForeignKey(d => d.EntLocalNascimento)
                    .HasConstraintName("ger_entidade_ibfk_2");

                entity.HasOne(d => d.EntNacionalidadeNavigation)
                    .WithMany(p => p.GerEntidadeEntNacionalidadeNavigation)
                    .HasForeignKey(d => d.EntNacionalidade)
                    .HasConstraintName("ger_entidade_ibfk_3");
            });

            modelBuilder.Entity<GerEntidadeAssociada>(entity =>
            {
                entity.HasKey(e => new { e.MainEntityId, e.AssociedEntityId })
                    .HasName("PRIMARY");

                entity.ToTable("ger_entidade_associada");

                entity.Property(e => e.MainEntityId)
                    .HasColumnName("MAIN_ENTITY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssociedEntityId)
                    .HasColumnName("ASSOCIED_ENTITY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssociationType)
                    .HasColumnName("ASSOCIATION_TYPE")
                    .HasColumnType("varchar(2)");
            });

            modelBuilder.Entity<GerEntidadeDocumentacao>(entity =>
            {
                entity.HasKey(e => new { e.EntDocCodigoEntidade, e.EntDocCodigoDocumento, e.EntDocNumero })
                    .HasName("PRIMARY");

                entity.ToTable("ger_entidade_documentacao");

                entity.HasIndex(e => e.EntDocCodigo)
                    .HasName("UK_ENTIDADE_DOCUMENTO")
                    .IsUnique();

                entity.HasIndex(e => e.EntDocCodigoDocumento)
                    .HasName("FK_ENTIDADE_DOCUMENTO_DOCUMENTO");

                entity.Property(e => e.EntDocCodigoEntidade)
                    .HasColumnName("ENT_DOC_CODIGO_ENTIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntDocCodigoDocumento)
                    .HasColumnName("ENT_DOC_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntDocNumero)
                    .HasColumnName("ENT_DOC_NUMERO")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.EntDocCodigo)
                    .HasColumnName("ENT_DOC_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EntDocEmissao)
                    .HasColumnName("ENT_DOC_EMISSAO")
                    .HasColumnType("date");

                entity.Property(e => e.EntDocLocalEmissao)
                    .HasColumnName("ENT_DOC_LOCAL_EMISSAO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.EntDocValidade)
                    .HasColumnName("ENT_DOC_VALIDADE")
                    .HasColumnType("date");

                entity.HasOne(d => d.EntDocCodigoDocumentoNavigation)
                    .WithMany(p => p.GerEntidadeDocumentacao)
                    .HasForeignKey(d => d.EntDocCodigoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ger_entidade_documentacao_ibfk_1");

                entity.HasOne(d => d.EntDocCodigoEntidadeNavigation)
                    .WithMany(p => p.GerEntidadeDocumentacao)
                    .HasForeignKey(d => d.EntDocCodigoEntidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ger_entidade_documentacao_ibfk_2");
            });

            modelBuilder.Entity<GerEntidadeMorada>(entity =>
            {
                entity.HasKey(e => e.EntMorEntidadeId)
                    .HasName("PRIMARY");

                entity.ToTable("ger_entidade_morada");

                entity.HasIndex(e => e.EntMorMoradaId)
                    .HasName("FK_MORADA_TIPO_MORADA");

                entity.HasIndex(e => e.EntMorMunicipioId)
                    .HasName("FK_MORADA_MUNICIPIO");

                entity.Property(e => e.EntMorEntidadeId)
                    .HasColumnName("ENT_MOR_ENTIDADE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntMorDistrito)
                    .HasColumnName("ENT_MOR_DISTRITO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.EntMorMorada)
                    .HasColumnName("ENT_MOR_MORADA")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.EntMorMoradaId)
                    .HasColumnName("ENT_MOR_MORADA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntMorMunicipioId)
                    .HasColumnName("ENT_MOR_MUNICIPIO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntMorTelefax)
                    .HasColumnName("ENT_MOR_TELEFAX")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.EntMorTelefone)
                    .HasColumnName("ENT_MOR_TELEFONE")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.EntMorEntidade)
                    .WithOne(p => p.GerEntidadeMorada)
                    .HasForeignKey<GerEntidadeMorada>(d => d.EntMorEntidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MORADA_ENTIDADE");

                entity.HasOne(d => d.EntMorMoradaNavigation)
                    .WithMany(p => p.GerEntidadeMorada)
                    .HasForeignKey(d => d.EntMorMoradaId)
                    .HasConstraintName("FK_MORADA_TIPO_MORADA");

                entity.HasOne(d => d.EntMorMunicipio)
                    .WithMany(p => p.GerEntidadeMorada)
                    .HasForeignKey(d => d.EntMorMunicipioId)
                    .HasConstraintName("FK_MORADA_MUNICIPIO");
            });

            modelBuilder.Entity<GerEntidadePessoa>(entity =>
            {
                entity.HasKey(e => e.PesCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_entidade_pessoa");

                entity.HasIndex(e => e.PesCodigoGrupoSanguineo)
                    .HasName("FK_PESSOA_GRUPO_SANGUINEO");

                entity.HasIndex(e => e.PesCodigoHabilitacoes)
                    .HasName("FK_PESSOA_HABILITACOES");

                entity.HasIndex(e => e.PesCodigoProfissao)
                    .HasName("FK_PESSOA_PROFISSAO");

                entity.HasIndex(e => e.PesNaturalidade)
                    .HasName("FK_PESSOA_NATURALIDADE");

                entity.Property(e => e.PesCodigo)
                    .HasColumnName("PES_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PesCodigoGrupoSanguineo)
                    .HasColumnName("PES_CODIGO_GRUPO_SANGUINEO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PesCodigoHabilitacoes)
                    .HasColumnName("PES_CODIGO_HABILITACOES")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PesCodigoProfissao)
                    .HasColumnName("PES_CODIGO_PROFISSAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PesEstadoCivil)
                    .HasColumnName("PES_ESTADO_CIVIL")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.PesFotoExtensao)
                    .HasColumnName("PES_FOTO_EXTENSAO")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.PesFotoPath)
                    .HasColumnName("PES_FOTO_PATH")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.PesFotografia).HasColumnName("PES_FOTOGRAFIA");

                entity.Property(e => e.PesNaturalidade)
                    .HasColumnName("PES_NATURALIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PesNome)
                    .HasColumnName("PES_NOME")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PesNomeMae)
                    .HasColumnName("PES_NOME_MAE")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.PesNomePai)
                    .HasColumnName("PES_NOME_PAI")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.PesRaca)
                    .HasColumnName("PES_RACA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PesReligiao)
                    .HasColumnName("PES_RELIGIAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PesResponsavel)
                    .HasColumnName("PES_RESPONSAVEL")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PesSexo)
                    .HasColumnName("PES_SEXO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PesSobrenome)
                    .HasColumnName("PES_SOBRENOME")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.PesTratamento)
                    .HasColumnName("PES_TRATAMENTO")
                    .HasColumnType("varchar(4)");

                entity.HasOne(d => d.PesCodigoNavigation)
                    .WithOne(p => p.GerEntidadePessoa)
                    .HasForeignKey<GerEntidadePessoa>(d => d.PesCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ger_entidade_pessoa_ibfk_1");

                entity.HasOne(d => d.PesCodigoGrupoSanguineoNavigation)
                    .WithMany(p => p.GerEntidadePessoa)
                    .HasForeignKey(d => d.PesCodigoGrupoSanguineo)
                    .HasConstraintName("ger_entidade_pessoa_ibfk_2");

                entity.HasOne(d => d.PesCodigoHabilitacoesNavigation)
                    .WithMany(p => p.GerEntidadePessoa)
                    .HasForeignKey(d => d.PesCodigoHabilitacoes)
                    .HasConstraintName("ger_entidade_pessoa_ibfk_3");

                entity.HasOne(d => d.PesCodigoProfissaoNavigation)
                    .WithMany(p => p.GerEntidadePessoa)
                    .HasForeignKey(d => d.PesCodigoProfissao)
                    .HasConstraintName("ger_entidade_pessoa_ibfk_5");

                entity.HasOne(d => d.PesNaturalidadeNavigation)
                    .WithMany(p => p.GerEntidadePessoa)
                    .HasForeignKey(d => d.PesNaturalidade)
                    .HasConstraintName("ger_entidade_pessoa_ibfk_4");
            });

            modelBuilder.Entity<GerFabricante>(entity =>
            {
                entity.HasKey(e => e.FabCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_fabricante");

                entity.Property(e => e.FabCodigo)
                    .HasColumnName("FAB_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FabDescricao)
                    .HasColumnName("FAB_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FabSigla)
                    .HasColumnName("FAB_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.FabStatus)
                    .HasColumnName("FAB_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerGrupoClientes>(entity =>
            {
                entity.HasKey(e => e.GruCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_grupo_clientes");

                entity.Property(e => e.GruCodigo)
                    .HasColumnName("GRU_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GruDescricao)
                    .IsRequired()
                    .HasColumnName("GRU_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.GruSigla)
                    .HasColumnName("GRU_SIGLA")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GruStatus)
                    .HasColumnName("GRU_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerGrupoSanguineo>(entity =>
            {
                entity.HasKey(e => e.SangCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_grupo_sanguineo");

                entity.HasIndex(e => e.SangCodigo)
                    .HasName("sang_codigo")
                    .IsUnique();

                entity.Property(e => e.SangCodigo)
                    .HasColumnName("sang_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SangDescricao)
                    .HasColumnName("sang_descricao")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.SangEstado)
                    .HasColumnName("SANG_ESTADO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.SangSigla)
                    .HasColumnName("SANG_SIGLA")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<GerHabilitacoes>(entity =>
            {
                entity.HasKey(e => e.HabCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_habilitacoes");

                entity.Property(e => e.HabCodigo)
                    .HasColumnName("HAB_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HabDescricao)
                    .IsRequired()
                    .HasColumnName("HAB_DESCRICAO")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.HabSigla)
                    .HasColumnName("HAB_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.HabStatus)
                    .HasColumnName("HAB_STATUS")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<GerImpostos>(entity =>
            {
                entity.HasKey(e => e.ImpCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_impostos");

                entity.Property(e => e.ImpCodigo)
                    .HasColumnName("IMP_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImpCategoria)
                    .HasColumnName("IMP_CATEGORIA")
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ImpDescricao)
                    .HasColumnName("IMP_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ImpIncluido)
                    .HasColumnName("IMP_INCLUIDO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ImpObservacoes)
                    .HasColumnName("IMP_OBSERVACOES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ImpSigla)
                    .HasColumnName("IMP_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ImpStatus)
                    .HasColumnName("IMP_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ImpTipo)
                    .HasColumnName("IMP_TIPO")
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ImpValor)
                    .HasColumnName("IMP_VALOR")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ImpValorizacao)
                    .HasColumnName("IMP_VALORIZACAO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ImpZonaFiscal)
                    .HasColumnName("IMP_ZONA_FISCAL")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<GerItem>(entity =>
            {
                entity.HasKey(e => e.ItemCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_item");

                entity.HasIndex(e => e.ItemCodigoSubcategoria)
                    .HasName("FK_SUBCATEGORIA_ITEM_idx");

                entity.Property(e => e.ItemCodigo)
                    .HasColumnName("ITEM_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemCodigoSubcategoria)
                    .HasColumnName("ITEM_CODIGO_SUBCATEGORIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemNome)
                    .HasColumnName("ITEM_NOME")
                    .HasColumnType("varchar(45)");

                entity.HasOne(d => d.ItemCodigoSubcategoriaNavigation)
                    .WithMany(p => p.GerItem)
                    .HasForeignKey(d => d.ItemCodigoSubcategoria)
                    .HasConstraintName("ger_item_ibfk_1");
            });

            modelBuilder.Entity<GerMarca>(entity =>
            {
                entity.HasKey(e => e.MarCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_marca");

                entity.HasIndex(e => e.MarRoot)
                    .HasName("FK_MARCA_RAIZ");

                entity.Property(e => e.MarCodigo)
                    .HasColumnName("MAR_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarDescricao)
                    .IsRequired()
                    .HasColumnName("MAR_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.MarRoot)
                    .HasColumnName("MAR_ROOT")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarSigla)
                    .HasColumnName("MAR_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.MarStatus)
                    .HasColumnName("MAR_STATUS")
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.MarRootNavigation)
                    .WithMany(p => p.InverseMarRootNavigation)
                    .HasForeignKey(d => d.MarRoot)
                    .HasConstraintName("ger_marca_ibfk_1");
            });

            modelBuilder.Entity<GerMeioPagamento>(entity =>
            {
                entity.HasKey(e => e.PagCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_meio_pagamento");

                entity.Property(e => e.PagCodigo)
                    .HasColumnName("PAG_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PagAccount)
                    .HasColumnName("PAG_ACCOUNT")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PagAction)
                    .HasColumnName("PAG_ACTION")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PagCreatedBy)
                    .HasColumnName("PAG_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PagCreatedDate)
                    .HasColumnName("PAG_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PagDescricao)
                    .HasColumnName("PAG_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PagDescricaoOutcome)
                    .HasColumnName("PAG_DESCRICAO_OUTCOME")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PagImage)
                    .HasColumnName("PAG_IMAGE")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PagPosVisible)
                    .HasColumnName("PAG_POS_VISIBLE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PagShortname)
                    .HasColumnName("PAG_SHORTNAME")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PagSigla)
                    .HasColumnName("PAG_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PagStatus)
                    .HasColumnName("PAG_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PagTroco)
                    .HasColumnName("PAG_TROCO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PagUpdatedBy)
                    .HasColumnName("PAG_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PagUpdatedDate)
                    .HasColumnName("PAG_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<GerModelo>(entity =>
            {
                entity.HasKey(e => e.ModCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_modelo");

                entity.HasIndex(e => e.ModCodigoMarca)
                    .HasName("FK_MARCA_MODELO");

                entity.Property(e => e.ModCodigo)
                    .HasColumnName("MOD_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModCodigoMarca)
                    .HasColumnName("MOD_CODIGO_MARCA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModDescricao)
                    .IsRequired()
                    .HasColumnName("MOD_DESCRICAO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ModStatus)
                    .HasColumnName("MOD_STATUS")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.ModCodigoMarcaNavigation)
                    .WithMany(p => p.GerModelo)
                    .HasForeignKey(d => d.ModCodigoMarca)
                    .HasConstraintName("ger_modelo_ibfk_1");
            });

            modelBuilder.Entity<GerMunicipio>(entity =>
            {
                entity.HasKey(e => e.MunCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_municipio");

                entity.HasIndex(e => e.MunCodigoProvincia)
                    .HasName("FK_PROVINCIA_MUNICIPIO");

                entity.Property(e => e.MunCodigo)
                    .HasColumnName("MUN_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MunCodigoProvincia)
                    .HasColumnName("MUN_CODIGO_PROVINCIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MunDescricao)
                    .HasColumnName("MUN_DESCRICAO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.MunStatus)
                    .HasColumnName("MUN_STATUS")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.MunCodigoProvinciaNavigation)
                    .WithMany(p => p.GerMunicipio)
                    .HasForeignKey(d => d.MunCodigoProvincia)
                    .HasConstraintName("ger_municipio_ibfk_1");
            });

            modelBuilder.Entity<GerPais>(entity =>
            {
                entity.HasKey(e => e.PaiCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_pais");

                entity.Property(e => e.PaiCodigo)
                    .HasColumnName("PAI_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PaiDailingCode)
                    .HasColumnName("PAI_DAILING_CODE")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PaiDescricao)
                    .IsRequired()
                    .HasColumnName("PAI_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PaiDesignacaoOficial)
                    .HasColumnName("PAI_DESIGNACAO_OFICIAL")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PaiIsoCode3)
                    .HasColumnName("PAI_ISO_CODE_3")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PaiIsoNumeralCode)
                    .HasColumnName("PAI_ISO_NUMERAL_CODE")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PaiMoeda)
                    .HasColumnName("PAI_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PaiNacionalidade)
                    .HasColumnName("PAI_NACIONALIDADE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PaiSigla)
                    .HasColumnName("PAI_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PaiStatus)
                    .HasColumnName("PAI_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerProfissao>(entity =>
            {
                entity.HasKey(e => e.ProfCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_profissao");

                entity.HasIndex(e => e.ProfCodigo)
                    .HasName("prof_codigo")
                    .IsUnique();

                entity.Property(e => e.ProfCodigo)
                    .HasColumnName("prof_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProfDescricao)
                    .HasColumnName("prof_descricao")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ProfSigla)
                    .HasColumnName("PROF_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ProfStatus)
                    .HasColumnName("PROF_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerProvincia>(entity =>
            {
                entity.HasKey(e => e.ProvCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_provincia");

                entity.HasIndex(e => e.ProvCodigoPais)
                    .HasName("FK_PAIS_PROVINCIA");

                entity.Property(e => e.ProvCodigo)
                    .HasColumnName("PROV_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvCodigoPais)
                    .HasColumnName("PROV_CODIGO_PAIS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvDescricao)
                    .IsRequired()
                    .HasColumnName("PROV_DESCRICAO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ProvIsoCode)
                    .HasColumnName("PROV_ISO_CODE")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ProvStatus)
                    .HasColumnName("PROV_STATUS")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.ProvCodigoPaisNavigation)
                    .WithMany(p => p.GerProvincia)
                    .HasForeignKey(d => d.ProvCodigoPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ger_provincia_ibfk_1");
            });

            modelBuilder.Entity<GerRaca>(entity =>
            {
                entity.HasKey(e => e.RacCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_raca");

                entity.HasIndex(e => e.RacCodigo)
                    .HasName("rac_codigo")
                    .IsUnique();

                entity.Property(e => e.RacCodigo)
                    .HasColumnName("rac_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RacDescricao)
                    .IsRequired()
                    .HasColumnName("rac_descricao")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.RacSigla)
                    .HasColumnName("RAC_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.RacStatus)
                    .HasColumnName("RAC_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerReligiao>(entity =>
            {
                entity.HasKey(e => e.RelCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_religiao");

                entity.HasIndex(e => e.RelCodigo)
                    .HasName("rel_codigo")
                    .IsUnique();

                entity.Property(e => e.RelCodigo)
                    .HasColumnName("REL_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RelDescricao)
                    .IsRequired()
                    .HasColumnName("REL_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.RelSigla)
                    .HasColumnName("REL_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.RelStatus)
                    .HasColumnName("REL_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerStatus>(entity =>
            {
                entity.HasKey(e => e.StaCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_status");

                entity.Property(e => e.StaCodigo)
                    .HasColumnName("STA_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StaAborted)
                    .HasColumnName("STA_ABORTED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.StaClosed)
                    .HasColumnName("STA_CLOSED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.StaDescricao)
                    .HasColumnName("STA_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.StaSigla)
                    .HasColumnName("STA_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.StaStatus)
                    .HasColumnName("STA_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerSubCategoria>(entity =>
            {
                entity.HasKey(e => e.SubCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_sub_categoria");

                entity.HasIndex(e => e.SubCodigoCategoria)
                    .HasName("FK_CATGEORIA_SUB_CATEGORIA");

                entity.Property(e => e.SubCodigo)
                    .HasColumnName("SUB_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubCodigoCategoria)
                    .HasColumnName("SUB_CODIGO_CATEGORIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubDescricao)
                    .HasColumnName("SUB_DESCRICAO")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.SubStatus)
                    .HasColumnName("SUB_STATUS")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.SubCodigoCategoriaNavigation)
                    .WithMany(p => p.GerSubCategoria)
                    .HasForeignKey(d => d.SubCodigoCategoria)
                    .HasConstraintName("ger_sub_categoria_ibfk_1");
            });

            modelBuilder.Entity<ProductSizes>(entity =>
            {
                entity.HasKey(e => e.TamCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_tamanho");

                entity.Property(e => e.TamCodigo)
                    .HasColumnName("TAM_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TamDescricao)
                    .IsRequired()
                    .HasColumnName("TAM_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TamSigla)
                    .HasColumnName("TAM_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.TamStatus)
                    .HasColumnName("TAM_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PRIMARY");

                entity.ToTable("ger_task");

                entity.HasIndex(e => e.TaskActividadeId)
                    .HasName("FK_TASK_ACTIDADE_ID");

                entity.HasIndex(e => e.TaskExecutorId)
                    .HasName("FK_TASK_EXECUTOR_ID");

                entity.HasIndex(e => e.TaskTargetId)
                    .HasName("FK_TASK_TARGET_ID");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TASK_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskActividadeId)
                    .HasColumnName("TASK_ACTIVIDADE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskAllday)
                    .HasColumnName("TASK_ALLDAY")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.TaskContact)
                    .HasColumnName("TASK_CONTACT")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskContactPerson)
                    .HasColumnName("TASK_CONTACT_PERSON")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskCreatedBy)
                    .HasColumnName("TASK_CREATED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskCreatedDate)
                    .HasColumnName("TASK_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskDeleted)
                    .HasColumnName("TASK_DELETED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TaskDeletedBy)
                    .HasColumnName("TASK_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TaskDeletedDate)
                    .HasColumnName("TASK_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskDesignation)
                    .HasColumnName("TASK_DESIGNATION")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskDetails)
                    .HasColumnName("TASK_DETAILS")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskEndImplementationDate)
                    .HasColumnName("TASK_END_IMPLEMENTATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskExecutorId)
                    .HasColumnName("TASK_EXECUTOR_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskExecutorUserId)
                    .HasColumnName("TASK_EXECUTOR_USER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskImplementationDate)
                    .HasColumnName("TASK_IMPLEMENTATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskInternalNotes)
                    .HasColumnName("TASK_INTERNAL_NOTES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.TaskOwnerUserId)
                    .HasColumnName("TASK_OWNER_USER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskPrioridadeId)
                    .HasColumnName("TASK_PRIORIDADE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskRecurrence)
                    .HasColumnName("TASK_RECURRENCE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskReport)
                    .HasColumnName("TASK_REPORT")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskScheduleDate)
                    .HasColumnName("TASK_SCHEDULE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskStatus)
                    .HasColumnName("TASK_STATUS")
                    .HasColumnType("bit(11)");

                entity.Property(e => e.TaskTargetId)
                    .HasColumnName("TASK_TARGET_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TaskUpdatedBy)
                    .HasColumnName("TASK_UPDATED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaskUpdatedDate)
                    .HasColumnName("TASK_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.TaskActividade)
                    .WithMany(p => p.GerTask)
                    .HasForeignKey(d => d.TaskActividadeId)
                    .HasConstraintName("FK_TASK_ACTIDADE_ID");

                entity.HasOne(d => d.TaskExecutor)
                    .WithMany(p => p.GerTaskTaskExecutor)
                    .HasForeignKey(d => d.TaskExecutorId)
                    .HasConstraintName("FK_TASK_EXECUTOR_ID");

                entity.HasOne(d => d.TaskTarget)
                    .WithMany(p => p.GerTaskTaskTarget)
                    .HasForeignKey(d => d.TaskTargetId)
                    .HasConstraintName("FK_TASK_TARGET_ID");
            });

            modelBuilder.Entity<GerTerceiros>(entity =>
            {
                entity.HasKey(e => e.TerCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_terceiros");

                entity.HasIndex(e => e.TerCodigoCategoria)
                    .HasName("FK_TERCEIROS_CATEGORIA");

                entity.HasIndex(e => e.TerCodigoEntidade)
                    .HasName("FK_TERCEIROS_ENTIDADE");

                entity.HasIndex(e => e.TerCodigoFilial)
                    .HasName("FK_TERCEIROS_FILIAL");

                entity.HasIndex(e => e.TerRegimeIvaId)
                    .HasName("GER_TERCEIRO_REGIME_IVA");

                entity.Property(e => e.TerCodigo)
                    .HasColumnName("TER_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerAccountCustomerId)
                    .HasColumnName("TER_ACCOUNT_CUSTOMER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerAccountNumber)
                    .HasColumnName("TER_ACCOUNT_NUMBER")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TerAccountSupplierId)
                    .HasColumnName("TER_ACCOUNT_SUPPLIER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerAdministrativeEmail)
                    .HasColumnName("TER_ADMINISTRATIVE_EMAIL")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerAdministrativeFunction)
                    .HasColumnName("TER_ADMINISTRATIVE_FUNCTION")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerAdministrativePeople)
                    .HasColumnName("TER_ADMINISTRATIVE_PEOPLE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerAdministrativePhone)
                    .HasColumnName("TER_ADMINISTRATIVE_PHONE")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.TerAlertDays)
                    .HasColumnName("TER_ALERT_DAYS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerAlertPeddingValue)
                    .HasColumnName("TER_ALERT_PEDDING_VALUE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerAllowAlert)
                    .HasColumnName("TER_ALLOW_ALERT")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TerAngariadorId)
                    .HasColumnName("TER_ANGARIADOR_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerBankId)
                    .HasColumnName("TER_BANK_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerChargesEmail)
                    .HasColumnName("TER_CHARGES_EMAIL")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerChargesFunction)
                    .HasColumnName("TER_CHARGES_FUNCTION")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerChargesPeople)
                    .HasColumnName("TER_CHARGES_PEOPLE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerChargesPhone)
                    .HasColumnName("TER_CHARGES_PHONE")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.TerChargesmanId)
                    .HasColumnName("TER_CHARGESMAN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerCodigoCategoria)
                    .HasColumnName("TER_CODIGO_CATEGORIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerCodigoEntidade)
                    .HasColumnName("TER_CODIGO_ENTIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerCodigoFilial)
                    .HasColumnName("TER_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerComercialEmail)
                    .HasColumnName("TER_COMERCIAL_EMAIL")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerComercialFunction)
                    .HasColumnName("TER_COMERCIAL_FUNCTION")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerComercialPeople)
                    .HasColumnName("TER_COMERCIAL_PEOPLE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerComercialPhonenumber)
                    .HasColumnName("TER_COMERCIAL_PHONENUMBER")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.TerCurrencyId)
                    .HasColumnName("TER_CURRENCY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerDeadline)
                    .HasColumnName("TER_DEADLINE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerDesconto)
                    .HasColumnName("TER_DESCONTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TerExpeditionId)
                    .HasColumnName("TER_EXPEDITION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerExported)
                    .HasColumnName("TER_EXPORTED")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TerIban)
                    .HasColumnName("TER_IBAN")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TerImpostoIncluido)
                    .HasColumnName("TER_IMPOSTO_INCLUIDO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TerLimiteCredito)
                    .HasColumnName("TER_LIMITE_CREDITO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TerLineDiscount)
                    .HasColumnName("TER_LINE_DISCOUNT")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TerManagementId)
                    .HasColumnName("TER_MANAGEMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerMaturityDays)
                    .HasColumnName("TER_MATURITY_DAYS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerMoedaId)
                    .HasColumnName("TER_MOEDA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerNomeComercial)
                    .HasColumnName("TER_NOME_COMERCIAL")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TerPaymentMethodId)
                    .HasColumnName("TER_PAYMENT_METHOD_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerPaymentTermsId)
                    .HasColumnName("TER_PAYMENT_TERMS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerRegimeIvaId)
                    .HasColumnName("TER_REGIME_IVA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerRetencao)
                    .HasColumnName("TER_RETENCAO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TerSaldo)
                    .HasColumnName("TER_SALDO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TerSalesmanId)
                    .HasColumnName("TER_SALESMAN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerSelfbilling)
                    .IsRequired()
                    .HasColumnName("TER_SELFBILLING")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.TerSujeitoPassivo)
                    .HasColumnName("TER_SUJEITO_PASSIVO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.TerSwift)
                    .HasColumnName("TER_SWIFT")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.TerTablePriceId)
                    .HasColumnName("TER_TABLE_PRICE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TerTipo)
                    .HasColumnName("TER_TIPO")
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.TerCodigoCategoriaNavigation)
                    .WithMany(p => p.GerTerceiros)
                    .HasForeignKey(d => d.TerCodigoCategoria)
                    .HasConstraintName("ger_terceiros_ibfk_1");

                entity.HasOne(d => d.TerCodigoEntidadeNavigation)
                    .WithMany(p => p.GerTerceiros)
                    .HasForeignKey(d => d.TerCodigoEntidade)
                    .HasConstraintName("ger_terceiros_ibfk_2");

                entity.HasOne(d => d.TerCodigoFilialNavigation)
                    .WithMany(p => p.GerTerceiros)
                    .HasForeignKey(d => d.TerCodigoFilial)
                    .HasConstraintName("ger_terceiros_ibfk_3");

                entity.HasOne(d => d.TerRegimeIva)
                    .WithMany(p => p.GerTerceiros)
                    .HasForeignKey(d => d.TerRegimeIvaId)
                    .HasConstraintName("GER_TERCEIRO_REGIME_IVA");
            });

            modelBuilder.Entity<GerTerceirosContacto>(entity =>
            {
                entity.HasKey(e => e.PartContactId)
                    .HasName("PRIMARY");

                entity.ToTable("ger_terceiros_contacto");

                entity.HasIndex(e => e.PartPatnerId)
                    .HasName("FK_CONTACT_ENTITY");

                entity.Property(e => e.PartContactId)
                    .HasColumnName("PART_CONTACT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartAdministrativo)
                    .HasColumnName("PART_ADMINISTRATIVO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PartCobranca)
                    .HasColumnName("PART_COBRANCA")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PartComercial)
                    .HasColumnName("PART_COMERCIAL")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PartContactName)
                    .HasColumnName("PART_CONTACT_NAME")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PartCreatedBy)
                    .HasColumnName("PART_CREATED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PartCreatedDate)
                    .HasColumnName("PART_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartDepartment)
                    .HasColumnName("PART_DEPARTMENT")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PartEmail)
                    .HasColumnName("PART_EMAIL")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PartFax)
                    .HasColumnName("PART_FAX")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PartFunction)
                    .HasColumnName("PART_FUNCTION")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PartMobile)
                    .HasColumnName("PART_MOBILE")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PartPatnerId)
                    .HasColumnName("PART_PATNER_ID")
                    .HasColumnType("int(1)");

                entity.Property(e => e.PartPhone)
                    .HasColumnName("PART_PHONE")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PartStatus)
                    .HasColumnName("PART_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PartUpdatedBy)
                    .HasColumnName("PART_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PartUpdatedDate)
                    .HasColumnName("PART_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.PartPatner)
                    .WithMany(p => p.GerTerceirosContacto)
                    .HasForeignKey(d => d.PartPatnerId)
                    .HasConstraintName("FK_CONTACT_ENTITY");
            });

            modelBuilder.Entity<GerTipo>(entity =>
            {
                entity.HasKey(e => e.TipCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_tipo");

                entity.Property(e => e.TipCodigo)
                    .HasColumnName("TIP_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipDescricao)
                    .HasColumnName("TIP_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TipSigla)
                    .HasColumnName("TIP_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TipStatus)
                    .HasColumnName("TIP_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerTipoActividade>(entity =>
            {
                entity.HasKey(e => e.ActCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_tipo_actividade");

                entity.Property(e => e.ActCodigo)
                    .HasColumnName("ACT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActCreatedBy)
                    .HasColumnName("ACT_CREATED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ActCreatedDate)
                    .HasColumnName("ACT_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActDescricao)
                    .HasColumnName("ACT_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ActSigla)
                    .HasColumnName("ACT_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ActStatus)
                    .HasColumnName("ACT_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ActUpdatedBy)
                    .HasColumnName("ACT_UPDATED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ActUpdatedDate)
                    .HasColumnName("ACT_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<GerTipoMorada>(entity =>
            {
                entity.HasKey(e => e.MorCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_tipo_morada");

                entity.Property(e => e.MorCodigo)
                    .HasColumnName("MOR_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MorCreatedBy)
                    .HasColumnName("MOR_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MorCreatedDate)
                    .HasColumnName("MOR_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MorDescricao)
                    .HasColumnName("MOR_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.MorSigla)
                    .HasColumnName("MOR_SIGLA")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MorStatus)
                    .HasColumnName("MOR_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.MorUpdatedBy)
                    .HasColumnName("MOR_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MorUpdatedDate)
                    .HasColumnName("MOR_UPDATED_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<GerTurnos>(entity =>
            {
                entity.HasKey(e => e.TurCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_turnos");

                entity.Property(e => e.TurCodigo)
                    .HasColumnName("TUR_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.TurBegin)
                    .HasColumnName("TUR_BEGIN")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.TurDescricao)
                    .HasColumnName("TUR_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TurEnd)
                    .HasColumnName("TUR_END")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.TurSigla)
                    .HasColumnName("TUR_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TurStatus)
                    .HasColumnName("TUR_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<GerUnidadeMedicao>(entity =>
            {
                entity.HasKey(e => e.UniCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_unidade_medicao");

                entity.Property(e => e.UniCodigo)
                    .HasColumnName("UNI_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UniDescricao)
                    .HasColumnName("UNI_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.UniQuantidade)
                    .HasColumnName("UNI_QUANTIDADE")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.UniSigla)
                    .HasColumnName("UNI_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.UniStatus)
                    .HasColumnName("UNI_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<GerViatura>(entity =>
            {
                entity.HasKey(e => e.ViaCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("ger_viatura");

                entity.HasIndex(e => e.ViaCategoryId)
                    .HasName("FK_VIATURA_CATEGORIA_ID");

                entity.HasIndex(e => e.ViaCombustivel)
                    .HasName("FK_VIATURA_COMBUSTIVEL_ID");

                entity.HasIndex(e => e.ViaCorId)
                    .HasName("FK_VIATURA_COR_ID");

                entity.HasIndex(e => e.ViaLicenseId)
                    .HasName("UK_LICENSE_ID")
                    .IsUnique();

                entity.HasIndex(e => e.ViaMarcaId)
                    .HasName("FK_VIATURA_MARCA_ID");

                entity.HasIndex(e => e.ViaOwnerId)
                    .HasName("FK_VIATURA_OWNER");

                entity.Property(e => e.ViaCodigo)
                    .HasColumnName("VIA_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NextIntervention)
                    .HasColumnName("NEXT_INTERVENTION")
                    .HasColumnType("datetime");

                entity.Property(e => e.ViaAno)
                    .HasColumnName("VIA_ANO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaCaixa)
                    .HasColumnName("VIA_CAIXA")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ViaCategoryId)
                    .HasColumnName("VIA_CATEGORY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaChassiNumber)
                    .HasColumnName("VIA_CHASSI_NUMBER")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ViaCilindrada)
                    .HasColumnName("VIA_CILINDRADA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ViaCilindros)
                    .HasColumnName("VIA_CILINDROS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaClasse)
                    .HasColumnName("VIA_CLASSE")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ViaCombustivel)
                    .HasColumnName("VIA_COMBUSTIVEL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaCorId)
                    .HasColumnName("VIA_COR_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaCreatedBy)
                    .HasColumnName("VIA_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ViaCreatedDate)
                    .HasColumnName("VIA_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.ViaDesignation)
                    .HasColumnName("VIA_DESIGNATION")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ViaEixos)
                    .HasColumnName("VIA_EIXOS")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ViaLastIntervention)
                    .HasColumnName("VIA_LAST_INTERVENTION")
                    .HasColumnType("datetime");

                entity.Property(e => e.ViaLicenseId)
                    .HasColumnName("VIA_LICENSE_ID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ViaMarcaId)
                    .HasColumnName("VIA_MARCA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaMotorNumber)
                    .HasColumnName("VIA_MOTOR_NUMBER")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ViaOwnerId)
                    .HasColumnName("VIA_OWNER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaPathImage)
                    .HasColumnName("VIA_PATH_IMAGE")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ViaPeso)
                    .HasColumnName("VIA_PESO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ViaPneumaticos)
                    .HasColumnName("VIA_PNEUMATICOS")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.ViaPortas)
                    .HasColumnName("VIA_PORTAS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaStatus)
                    .HasColumnName("VIA_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaTara)
                    .HasColumnName("VIA_TARA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ViaUpdatedBy)
                    .HasColumnName("VIA_UPDATED_BY")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ViaUpdatedDate)
                    .HasColumnName("VIA_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.ViaValvulas)
                    .HasColumnName("VIA_VALVULAS")
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.ViaCategory)
                    .WithMany(p => p.GerViatura)
                    .HasForeignKey(d => d.ViaCategoryId)
                    .HasConstraintName("FK_VIATURA_CATEGORIA_ID");

                entity.HasOne(d => d.ViaCor)
                    .WithMany(p => p.GerViatura)
                    .HasForeignKey(d => d.ViaCorId)
                    .HasConstraintName("FK_VIATURA_COR_ID");

                entity.HasOne(d => d.ViaMarca)
                    .WithMany(p => p.GerViatura)
                    .HasForeignKey(d => d.ViaMarcaId)
                    .HasConstraintName("FK_VIATURA_MARCA_ID");

                entity.HasOne(d => d.ViaOwner)
                    .WithMany(p => p.GerViatura)
                    .HasForeignKey(d => d.ViaOwnerId)
                    .HasConstraintName("FK_VIATURA_OWNER");
            });

            modelBuilder.Entity<LabAmostra>(entity =>
            {
                entity.HasKey(e => e.AmoCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("lab_amostra");

                entity.HasIndex(e => e.AmoCodigo)
                    .HasName("lab_amostra_PK_LAB_MATERIAL_ndx");

                entity.Property(e => e.AmoCodigo)
                    .HasColumnName("amo_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AmoDescricao)
                    .IsRequired()
                    .HasColumnName("amo_descricao")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<LabCategoriaExame>(entity =>
            {
                entity.HasKey(e => e.CatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("lab_categoria_exame");

                entity.HasIndex(e => e.CatCodigo)
                    .HasName("lab_categoria_exame_PK_LAB_CATEGORIA_ANALISE_ndx");

                entity.Property(e => e.CatCodigo)
                    .HasColumnName("cat_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatDescricao)
                    .IsRequired()
                    .HasColumnName("cat_descricao")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<LabCategoriaMaterial>(entity =>
            {
                entity.HasKey(e => e.CatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("lab_categoria_material");

                entity.HasIndex(e => e.CatCodigo)
                    .HasName("cat_codigo")
                    .IsUnique();

                entity.Property(e => e.CatCodigo)
                    .HasColumnName("cat_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatDescricao)
                    .IsRequired()
                    .HasColumnName("cat_descricao")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<LabExame>(entity =>
            {
                entity.HasKey(e => e.ExaCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("lab_exame");

                entity.HasIndex(e => e.ExaCodigo)
                    .HasName("lab_exame_PK_LAB_EXAME_ndx");

                entity.HasIndex(e => e.ExaCodigoAmostra)
                    .HasName("FK_EXAME_AMOSTRA");

                entity.Property(e => e.ExaCodigo)
                    .HasColumnName("exa_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExaCategoria)
                    .HasColumnName("exa_categoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExaCodigoAmostra)
                    .HasColumnName("exa_codigo_amostra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExaDescricao)
                    .IsRequired()
                    .HasColumnName("exa_descricao")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ExaPeriodoEntrega)
                    .HasColumnName("exa_periodo_entrega")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExaSigla)
                    .HasColumnName("exa_sigla")
                    .HasColumnType("char(10)");

                entity.HasOne(d => d.ExaCodigoAmostraNavigation)
                    .WithMany(p => p.LabExame)
                    .HasForeignKey(d => d.ExaCodigoAmostra)
                    .HasConstraintName("lab_exame_ibfk_1");
            });

            modelBuilder.Entity<LabExameItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemCodigoExame, e.ItemNome })
                    .HasName("PRIMARY");

                entity.ToTable("lab_exame_item");

                entity.HasIndex(e => new { e.ItemCodigoExame, e.ItemNome })
                    .HasName("lab_exame_item_PK_LAB_EXAME_ITEM_ndx");

                entity.Property(e => e.ItemCodigoExame)
                    .HasColumnName("item_codigo_exame")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemNome)
                    .HasColumnName("item_nome")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ItemReferencia)
                    .HasColumnName("item_referencia")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ItemTipo)
                    .HasColumnName("item_tipo")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ItemUnidade)
                    .HasColumnName("item_unidade")
                    .HasColumnType("char(10)");

                entity.Property(e => e.ItemVariavel)
                    .HasColumnName("item_variavel")
                    .HasColumnType("char(10)");

                entity.HasOne(d => d.ItemCodigoExameNavigation)
                    .WithMany(p => p.LabExameItem)
                    .HasForeignKey(d => d.ItemCodigoExame)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lab_exame_item_ibfk_1");
            });

            modelBuilder.Entity<LabExameMaterial>(entity =>
            {
                entity.HasKey(e => new { e.ExaMatCodigoExame, e.ExaMatCodigoMaterial })
                    .HasName("PRIMARY");

                entity.ToTable("lab_exame_material");

                entity.HasIndex(e => e.ExaMatCodigoMaterial)
                    .HasName("FK_EXAME_MATERIAL");

                entity.HasIndex(e => new { e.ExaMatCodigoExame, e.ExaMatCodigoMaterial })
                    .HasName("lab_exame_material_PK_LAB_EXAME_PRODUTO_ndx");

                entity.Property(e => e.ExaMatCodigoExame)
                    .HasColumnName("exa_mat_codigo_exame")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExaMatCodigoMaterial)
                    .HasColumnName("exa_mat_codigo_material")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ExaMatCodigoExameNavigation)
                    .WithMany(p => p.LabExameMaterial)
                    .HasForeignKey(d => d.ExaMatCodigoExame)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lab_exame_material_ibfk_1");

                entity.HasOne(d => d.ExaMatCodigoMaterialNavigation)
                    .WithMany(p => p.LabExameMaterial)
                    .HasForeignKey(d => d.ExaMatCodigoMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lab_exame_material_ibfk_2");
            });

            modelBuilder.Entity<LabMaterial>(entity =>
            {
                entity.HasKey(e => e.MatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("lab_material");

                entity.HasIndex(e => e.MatCodigo)
                    .HasName("lab_material_PK_LAB_PRODUTO_ndx");

                entity.HasIndex(e => e.MatCodigoCategoria)
                    .HasName("FK_MATERIAL_CATEGORIA");

                entity.Property(e => e.MatCodigo)
                    .HasColumnName("mat_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MatCodigoCategoria)
                    .HasColumnName("mat_codigo_categoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MatMedicao)
                    .HasColumnName("mat_medicao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MatNome)
                    .IsRequired()
                    .HasColumnName("mat_nome")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.MatCodigoCategoriaNavigation)
                    .WithMany(p => p.LabMaterial)
                    .HasForeignKey(d => d.MatCodigoCategoria)
                    .HasConstraintName("lab_material_ibfk_1");
            });

            modelBuilder.Entity<LabPrecoExame>(entity =>
            {
                entity.HasKey(e => e.PreCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("lab_preco_exame");

                entity.HasIndex(e => e.PreCodigo)
                    .HasName("lab_preco_exame_PK_LAB_PRECO_EXAME_ndx");

                entity.HasIndex(e => e.PreCodigoExame)
                    .HasName("FK_PRECO_EXAME");

                entity.Property(e => e.PreCodigo)
                    .HasColumnName("pre_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PreCodigoExame)
                    .HasColumnName("pre_codigo_exame")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PreDataFim)
                    .HasColumnName("pre_data_fim")
                    .HasColumnType("date");

                entity.Property(e => e.PreDataInicio)
                    .HasColumnName("pre_data_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.PrePreco).HasColumnName("pre_preco");

                entity.HasOne(d => d.PreCodigoExameNavigation)
                    .WithMany(p => p.LabPrecoExame)
                    .HasForeignKey(d => d.PreCodigoExame)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lab_preco_exame_ibfk_1");
            });

            modelBuilder.Entity<LabResultado>(entity =>
            {
                entity.HasKey(e => e.ResCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("lab_resultado");

                entity.HasIndex(e => e.ResCodigo)
                    .HasName("res_codigo")
                    .IsUnique();

                entity.Property(e => e.ResCodigo)
                    .HasColumnName("res_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResDescricao)
                    .IsRequired()
                    .HasColumnName("res_descricao")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<LabTecnico>(entity =>
            {
                entity.HasKey(e => e.TecCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("lab_tecnico");

                entity.HasIndex(e => e.TecCodigo)
                    .HasName("tec_codigo")
                    .IsUnique();

                entity.Property(e => e.TecCodigo)
                    .HasColumnName("tec_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TecCodigoFuncionario)
                    .HasColumnName("tec_codigo_funcionario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TecNome)
                    .IsRequired()
                    .HasColumnName("tec_nome")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<LabUnidadeMaterial>(entity =>
            {
                entity.HasKey(e => e.UniCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("lab_unidade_material");

                entity.HasIndex(e => e.UniCodigo)
                    .HasName("uni_codigo")
                    .IsUnique();

                entity.Property(e => e.UniCodigo)
                    .HasColumnName("uni_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UniDescricao)
                    .IsRequired()
                    .HasColumnName("uni_descricao")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<RestAtendimento>(entity =>
            {
                entity.HasKey(e => e.AtendCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rest_atendimento");

                entity.HasIndex(e => e.AtendAtendente)
                    .HasName("FK_ATENDIMENTO_FUNCIONARIO");

                entity.HasIndex(e => e.AtendCliente)
                    .HasName("FK_ATENDIMENTO_CLIENTE");

                entity.HasIndex(e => e.AtendCodigoFatura)
                    .HasName("FK_ATENDIMENTO_FATURA");

                entity.HasIndex(e => e.AtendCodigoFilial)
                    .HasName("FK_ATENDIMENTO_FILIAL");

                entity.Property(e => e.AtendCodigo)
                    .HasColumnName("ATEND_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendAnuladoPor)
                    .HasColumnName("ATEND_ANULADO_POR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AtendAtendente)
                    .HasColumnName("ATEND_ATENDENTE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendCancelDate)
                    .HasColumnName("ATEND_CANCEL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.AtendCliente)
                    .HasColumnName("ATEND_CLIENTE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendCodigoFatura)
                    .HasColumnName("ATEND_CODIGO_FATURA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendCodigoFilial)
                    .HasColumnName("ATEND_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendConta)
                    .HasColumnName("ATEND_CONTA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.AtendCriadoPor)
                    .HasColumnName("ATEND_CRIADO_POR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AtendData)
                    .HasColumnName("ATEND_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.AtendDataFecho)
                    .HasColumnName("ATEND_DATA_FECHO")
                    .HasColumnType("datetime");

                entity.Property(e => e.AtendDestino)
                    .HasColumnName("ATEND_DESTINO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.AtendDocumentId)
                    .HasColumnName("ATEND_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendFechadoPor)
                    .HasColumnName("ATEND_FECHADO_POR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AtendInicio)
                    .HasColumnName("ATEND_INICIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.AtendMotivoAnulacao)
                    .HasColumnName("ATEND_MOTIVO_ANULACAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AtendNumeracao)
                    .HasColumnName("ATEND_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendRefrencia)
                    .HasColumnName("ATEND_REFRENCIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AtendSerieId)
                    .HasColumnName("ATEND_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendStatus)
                    .HasColumnName("ATEND_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.AtendTermino)
                    .HasColumnName("ATEND_TERMINO")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AtendCodigoFaturaNavigation)
                    .WithMany(p => p.RestAtendimento)
                    .HasForeignKey(d => d.AtendCodigoFatura)
                    .HasConstraintName("rest_atendimento_ibfk_2");

                entity.HasOne(d => d.AtendCodigoFilialNavigation)
                    .WithMany(p => p.RestAtendimento)
                    .HasForeignKey(d => d.AtendCodigoFilial)
                    .HasConstraintName("rest_atendimento_ibfk_3");
            });

            modelBuilder.Entity<RestAtendimentoConsultaConta>(entity =>
            {
                entity.HasKey(e => e.ConsCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rest_atendimento_consulta_conta");

                entity.Property(e => e.ConsCodigo)
                    .HasColumnName("CONS_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConsAtendimentoId)
                    .HasColumnName("CONS_ATENDIMENTO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConsDocumentId)
                    .HasColumnName("CONS_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConsNumeracao)
                    .HasColumnName("CONS_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConsReference)
                    .HasColumnName("CONS_REFERENCE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ConsSerie)
                    .HasColumnName("CONS_SERIE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<RestAtendimentoPedido>(entity =>
            {
                entity.HasKey(e => e.RestPedidoId)
                    .HasName("PRIMARY");

                entity.ToTable("rest_atendimento_pedido");

                entity.Property(e => e.RestPedidoId)
                    .HasColumnName("REST_PEDIDO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RestMesaId)
                    .HasColumnName("REST_MESA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RestPedidoAtendimentoId)
                    .HasColumnName("REST_PEDIDO_ATENDIMENTO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RestPedidoFilial)
                    .HasColumnName("REST_PEDIDO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RestPedidoSalemanId)
                    .HasColumnName("REST_PEDIDO_SALEMAN_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<RestAtendimentoSala>(entity =>
            {
                entity.HasKey(e => e.AtendMesaCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rest_atendimento_sala");

                entity.Property(e => e.AtendMesaCodigo)
                    .HasColumnName("ATEND_MESA_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendMesaAtendimento)
                    .HasColumnName("ATEND_MESA_ATENDIMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendMesaCodigoMesa)
                    .HasColumnName("ATEND_MESA_CODIGO_MESA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtendMesaStatus)
                    .HasColumnName("ATEND_MESA_STATUS")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RestComissaoVenda>(entity =>
            {
                entity.HasKey(e => e.ComCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rest_comissao_venda");

                entity.Property(e => e.ComCodigo)
                    .HasColumnName("COM_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComComissao)
                    .HasColumnName("COM_COMISSAO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ComCreatedBy)
                    .HasColumnName("COM_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ComCreatedDate)
                    .HasColumnName("COM_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ComDescricao)
                    .IsRequired()
                    .HasColumnName("COM_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ComStatus)
                    .HasColumnName("COM_STATUS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComUpdatedBy)
                    .HasColumnName("COM_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ComUpdatedDate)
                    .HasColumnName("COM_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<RestFuncionarios>(entity =>
            {
                entity.HasKey(e => e.GarCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rest_funcionarios");

                entity.HasIndex(e => e.GarCodigoEntidade)
                    .HasName("FK_REST_FUNCIONARIO");

                entity.HasIndex(e => e.GarComissao)
                    .HasName("FK_REST_FUNCIONARIO_COMISSAO");

                entity.HasIndex(e => e.GarFilial)
                    .HasName("FK_REST_FUNCIONARIO_FILIAL");

                entity.HasIndex(e => e.GarGroupId)
                    .HasName("FK_TECHNICIAN_GROUP");

                entity.Property(e => e.GarCodigo)
                    .HasColumnName("GAR_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GarCodigoEntidade)
                    .HasColumnName("GAR_CODIGO_ENTIDADE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GarComissao)
                    .HasColumnName("GAR_COMISSAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GarComissaoLiquidacao)
                    .HasColumnName("GAR_COMISSAO_LIQUIDACAO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.GarComissaoVenda)
                    .HasColumnName("GAR_COMISSAO_VENDA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.GarCreatedBy)
                    .HasColumnName("GAR_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GarCreatedDate)
                    .HasColumnName("GAR_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.GarFilial)
                    .HasColumnName("GAR_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GarGroupDesignation)
                    .HasColumnName("GAR_GROUP_DESIGNATION")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.GarGroupId)
                    .HasColumnName("GAR_GROUP_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GarStatus)
                    .HasColumnName("GAR_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.GarTipo)
                    .HasColumnName("GAR_TIPO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.GarUpdatedBy)
                    .HasColumnName("GAR_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GarUpdatedDate)
                    .HasColumnName("GAR_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.GarUtilizador)
                    .HasColumnName("GAR_UTILIZADOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.GarValorComissao)
                    .HasColumnName("GAR_VALOR_COMISSAO")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.GarCodigoEntidadeNavigation)
                    .WithMany(p => p.RestFuncionarios)
                    .HasForeignKey(d => d.GarCodigoEntidade)
                    .HasConstraintName("rest_funcionarios_ibfk_1");

                entity.HasOne(d => d.GarComissaoNavigation)
                    .WithMany(p => p.RestFuncionarios)
                    .HasForeignKey(d => d.GarComissao)
                    .HasConstraintName("rest_funcionarios_ibfk_2");

                entity.HasOne(d => d.GarFilialNavigation)
                    .WithMany(p => p.RestFuncionarios)
                    .HasForeignKey(d => d.GarFilial)
                    .HasConstraintName("rest_funcionarios_ibfk_3");

                entity.HasOne(d => d.GarGroup)
                    .WithMany(p => p.InverseGarGroup)
                    .HasForeignKey(d => d.GarGroupId)
                    .HasConstraintName("FK_TECHNICIAN_GROUP");
            });

            modelBuilder.Entity<RestLocalizacao>(entity =>
            {
                entity.HasKey(e => e.LocCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rest_localizacao");

                entity.Property(e => e.LocCodigo)
                    .HasColumnName("LOC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LocDescricao)
                    .HasColumnName("LOC_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.LocSigla)
                    .HasColumnName("LOC_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.LocStatus)
                    .HasColumnName("LOC_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<RestMesa>(entity =>
            {
                entity.HasKey(e => e.MesCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rest_mesa");

                entity.HasIndex(e => e.MesCodigoLocalizacao)
                    .HasName("FK_MESA_LOCALIZACAO");

                entity.Property(e => e.MesCodigo)
                    .HasColumnName("MES_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MesCliente)
                    .HasColumnName("MES_CLIENTE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MesCodigoLocalizacao)
                    .HasColumnName("MES_CODIGO_LOCALIZACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MesDescricao)
                    .HasColumnName("MES_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.MesLugares)
                    .HasColumnName("MES_LUGARES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MesSigla)
                    .HasColumnName("MES_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.MesStatus)
                    .HasColumnName("MES_STATUS")
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.MesCodigoLocalizacaoNavigation)
                    .WithMany(p => p.RestMesa)
                    .HasForeignKey(d => d.MesCodigoLocalizacao)
                    .HasConstraintName("rest_mesa_ibfk_1");
            });

            modelBuilder.Entity<RestPratoDia>(entity =>
            {
                entity.HasKey(e => new { e.PraCodigoArtigo, e.PraDia })
                    .HasName("PRIMARY");

                entity.ToTable("rest_prato_dia");

                entity.HasIndex(e => e.PraCodigo)
                    .HasName("UK_PRATO_DIA_ID")
                    .IsUnique();

                entity.Property(e => e.PraCodigoArtigo)
                    .HasColumnName("PRA_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PraDia)
                    .HasColumnName("PRA_DIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PraCodigo)
                    .HasColumnName("PRA_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.PraCodigoArtigoNavigation)
                    .WithMany(p => p.RestPratoDia)
                    .HasForeignKey(d => d.PraCodigoArtigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rest_prato_dia_ibfk_1");
            });

            modelBuilder.Entity<RestReserva>(entity =>
            {
                entity.HasKey(e => e.ResCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rest_reserva");

                entity.HasIndex(e => e.ResCodigoCliente)
                    .HasName("FK_RESERVA_CLIENTE");

                entity.HasIndex(e => e.ResCodigoMesa)
                    .HasName("FK_RESERVA_MESA");

                entity.Property(e => e.ResCodigo)
                    .HasColumnName("RES_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResBooking)
                    .HasColumnName("RES_BOOKING")
                    .HasColumnType("date");

                entity.Property(e => e.ResCodigoCliente)
                    .HasColumnName("RES_CODIGO_CLIENTE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResCodigoMesa)
                    .HasColumnName("RES_CODIGO_MESA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResCustomerName)
                    .HasColumnName("RES_CUSTOMER_NAME")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ResHoraPrevista)
                    .HasColumnName("RES_HORA_PREVISTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResLugares)
                    .HasColumnName("RES_LUGARES")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResObs)
                    .HasColumnName("RES_OBS")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ResPhoneNumber)
                    .HasColumnName("RES_PHONE_NUMBER")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ResStatus)
                    .HasColumnName("RES_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.ResCodigoClienteNavigation)
                    .WithMany(p => p.RestReserva)
                    .HasForeignKey(d => d.ResCodigoCliente)
                    .HasConstraintName("rest_reserva_ibfk_1");

                entity.HasOne(d => d.ResCodigoMesaNavigation)
                    .WithMany(p => p.RestReserva)
                    .HasForeignKey(d => d.ResCodigoMesa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rest_reserva_ibfk_2");
            });

            modelBuilder.Entity<RhAlteracoesMensais>(entity =>
            {
                entity.HasKey(e => e.AltCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_alteracoes_mensais");

                entity.Property(e => e.AltCodigo)
                    .HasColumnName("ALT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AltCodigoFuncionario)
                    .HasColumnName("ALT_CODIGO_FUNCIONARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AltCodigoOperacao)
                    .HasColumnName("ALT_CODIGO_OPERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AltData)
                    .HasColumnName("ALT_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.AltDuracao)
                    .HasColumnName("ALT_DURACAO")
                    .HasColumnType("decimal(18,0)");

                entity.Property(e => e.AltInicio)
                    .HasColumnName("ALT_INICIO")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.AltStatus)
                    .HasColumnName("ALT_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.AltTermino)
                    .HasColumnName("ALT_TERMINO")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.AltUnidade)
                    .HasColumnName("ALT_UNIDADE")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<RhBeneficioCargo>(entity =>
            {
                entity.HasKey(e => new { e.CarBenCodigoCargo, e.CarBenCodigoBeneficio, e.CarBenInicio })
                    .HasName("PRIMARY");

                entity.ToTable("rh_beneficio_cargo");

                entity.Property(e => e.CarBenCodigoCargo)
                    .HasColumnName("CAR_BEN_CODIGO_CARGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarBenCodigoBeneficio)
                    .HasColumnName("CAR_BEN_CODIGO_BENEFICIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CarBenInicio)
                    .HasColumnName("CAR_BEN_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.CarBenTermino)
                    .HasColumnName("CAR_BEN_TERMINO")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<RhBeneficios>(entity =>
            {
                entity.HasKey(e => e.BenCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_beneficios");

                entity.HasIndex(e => e.BenCodigo)
                    .HasName("Uk_CODIGO_BENEFICIO")
                    .IsUnique();

                entity.Property(e => e.BenCodigo)
                    .HasColumnName("BEN_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BenCategoria)
                    .HasColumnName("BEN_CATEGORIA")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.BenDescricao)
                    .IsRequired()
                    .HasColumnName("BEN_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.BenSigla)
                    .HasColumnName("BEN_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.BenStatus)
                    .HasColumnName("BEN_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<RhCargo>(entity =>
            {
                entity.HasKey(e => e.CrgCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_cargo");

                entity.Property(e => e.CrgCodigo)
                    .HasColumnName("CRG_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CrgDescricao)
                    .IsRequired()
                    .HasColumnName("CRG_DESCRICAO")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.CrgSigla)
                    .HasColumnName("CRG_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.CrgStatus)
                    .HasColumnName("CRG_STATUS")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<RhCategoriaColaborador>(entity =>
            {
                entity.HasKey(e => e.CatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_categoria_colaborador");

                entity.Property(e => e.CatCodigo)
                    .HasColumnName("CAT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatDescricao)
                    .HasColumnName("CAT_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.CatSigla)
                    .HasColumnName("CAT_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CatStatus)
                    .HasColumnName("CAT_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<RhContratos>(entity =>
            {
                entity.HasKey(e => e.ContCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_contratos");

                entity.Property(e => e.ContCodigo)
                    .HasColumnName("CONT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContAvisoPrevio)
                    .HasColumnName("CONT_AVISO_PREVIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContCategoria)
                    .HasColumnName("CONT_CATEGORIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContDescricao)
                    .HasColumnName("CONT_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ContDuracao)
                    .HasColumnName("CONT_DURACAO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ContRenovacoes)
                    .HasColumnName("CONT_RENOVACOES")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RhDiasDescansoSemanal>(entity =>
            {
                entity.HasKey(e => new { e.DescFilialId, e.DescDia })
                    .HasName("PRIMARY");

                entity.ToTable("rh_dias_descanso_semanal");

                entity.Property(e => e.DescFilialId)
                    .HasColumnName("DESC_FILIAL_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DescDia)
                    .HasColumnName("DESC_DIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DescActivo)
                    .HasColumnName("DESC_ACTIVO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.DescCreatedBy)
                    .HasColumnName("DESC_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DescCreatedDate)
                    .HasColumnName("DESC_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.DescDeletedBy)
                    .HasColumnName("DESC_DELETED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DescDeletedDate)
                    .HasColumnName("DESC_DELETED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.DescUpdatedBy)
                    .HasColumnName("DESC_UPDATED_BY")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DescUpdatedDate)
                    .HasColumnName("DESC_UPDATED_DATE")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<RhEscaloesIrt>(entity =>
            {
                entity.HasKey(e => e.IrtCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_escaloes_irt");

                entity.Property(e => e.IrtCodigo)
                    .HasColumnName("IRT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IrtCreatedBy)
                    .HasColumnName("IRT_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.IrtCreatedDate)
                    .HasColumnName("IRT_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IrtDescricaoEscalao)
                    .HasColumnName("IRT_DESCRICAO_ESCALAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.IrtExcesso)
                    .HasColumnName("IRT_EXCESSO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.IrtPercentualDesconto)
                    .HasColumnName("IRT_PERCENTUAL_DESCONTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.IrtSalarioAte)
                    .HasColumnName("IRT_SALARIO_ATE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.IrtSalarioDe)
                    .HasColumnName("IRT_SALARIO_DE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.IrtUpdatedBy)
                    .HasColumnName("IRT_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.IrtUpdatedDate)
                    .HasColumnName("IRT_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IrtValorMinimo)
                    .HasColumnName("IRT_VALOR_MINIMO")
                    .HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<RhFuncionario>(entity =>
            {
                entity.HasKey(e => e.FunCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_funcionario");

                entity.HasIndex(e => e.FunCodigoBanco)
                    .HasName("FK_FUNCIONARIO_BANCO");

                entity.HasIndex(e => e.FunCodigoCargo)
                    .HasName("RH_FUNCIONARIO_CARGO");

                entity.HasIndex(e => e.FunCodigoDepartamento)
                    .HasName("FK_FUNCIONARIO_DEPARTAMENTO");

                entity.HasIndex(e => e.FunCodigoFilial)
                    .HasName("FK_FUNCIONARIO_FILIAL");

                entity.HasIndex(e => e.FunCodigoFormacao)
                    .HasName("FK_FUNCIONARIO_FORMACAO");

                entity.HasIndex(e => e.FunCodigoGrupoSalarial)
                    .HasName("FK_FUNCIONARIO_GRUPO_SALARIAL");

                entity.HasIndex(e => e.FunCodigoHabilitacao)
                    .HasName("FK_FUNCIONARIO_HABILITACOES");

                entity.HasIndex(e => e.FunCodigoProfissao)
                    .HasName("FK_FUNCIONARIO_PROFISSAO");

                entity.HasIndex(e => e.FunCodigoRegime)
                    .HasName("RH_FUNCIONARIO_REGIME");

                entity.HasIndex(e => e.FunCodigoVinculo)
                    .HasName("FK_FUNCIONARIO_VINCULO");

                entity.HasIndex(e => e.FunMotivoAdmissao)
                    .HasName("FK_FUNCIONARIO_ADMISSAO");

                entity.HasIndex(e => e.FunMotivoDemissao)
                    .HasName("FK_FUNCIONARIO_DEMISSAO");

                entity.HasIndex(e => e.FunNumFuncionario)
                    .HasName("UK_FUNCIONARIO_ID")
                    .IsUnique();

                entity.HasIndex(e => e.FunTipoSalario)
                    .HasName("FK_FUNCIONARIO_VENCIMENTO");

                entity.Property(e => e.FunCodigo)
                    .HasColumnName("FUN_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCargaMensal)
                    .HasColumnName("FUN_CARGA_MENSAL")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.FunCargaSemanal)
                    .HasColumnName("FUN_CARGA_SEMANAL")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.FunCodigoBanco)
                    .HasColumnName("FUN_CODIGO_BANCO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCodigoCargo)
                    .HasColumnName("FUN_CODIGO_CARGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCodigoDepartamento)
                    .HasColumnName("FUN_CODIGO_DEPARTAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCodigoFilial)
                    .HasColumnName("FUN_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCodigoFormacao)
                    .HasColumnName("FUN_CODIGO_FORMACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCodigoGrupoSalarial)
                    .HasColumnName("FUN_CODIGO_GRUPO_SALARIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCodigoHabilitacao)
                    .HasColumnName("FUN_CODIGO_HABILITACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCodigoProfissao)
                    .HasColumnName("FUN_CODIGO_PROFISSAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCodigoRegime)
                    .HasColumnName("FUN_CODIGO_REGIME")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunCodigoVinculo)
                    .HasColumnName("FUN_CODIGO_VINCULO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunContaBancaria)
                    .HasColumnName("FUN_CONTA_BANCARIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FunDataAdmissao)
                    .HasColumnName("FUN_DATA_ADMISSAO")
                    .HasColumnType("date");

                entity.Property(e => e.FunDataAvisoPrevio)
                    .HasColumnName("FUN_DATA_AVISO_PREVIO")
                    .HasColumnType("date");

                entity.Property(e => e.FunDataDemissao)
                    .HasColumnName("FUN_DATA_DEMISSAO")
                    .HasColumnType("date");

                entity.Property(e => e.FunDataObtencaoFormacao)
                    .HasColumnName("FUN_DATA_OBTENCAO_FORMACAO")
                    .HasColumnType("date");

                entity.Property(e => e.FunEmail)
                    .HasColumnName("FUN_EMAIL")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FunExtensao)
                    .HasColumnName("FUN_EXTENSAO")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.FunIban)
                    .HasColumnName("FUN_IBAN")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FunInicioContrato)
                    .HasColumnName("FUN_INICIO_CONTRATO")
                    .HasColumnType("date");

                entity.Property(e => e.FunMotivoAdmissao)
                    .HasColumnName("FUN_MOTIVO_ADMISSAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunMotivoDemissao)
                    .HasColumnName("FUN_MOTIVO_DEMISSAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunNib)
                    .HasColumnName("FUN_NIB")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FunNomeMae)
                    .HasColumnName("FUN_NOME_MAE")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FunNomePai)
                    .HasColumnName("FUN_NOME_PAI")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FunNumFuncionario)
                    .HasColumnName("FUN_NUM_FUNCIONARIO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FunPeriodoExperimental)
                    .HasColumnName("FUN_PERIODO_EXPERIMENTAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunSalarioBase).HasColumnName("FUN_SALARIO_BASE");

                entity.Property(e => e.FunStatus)
                    .HasColumnName("FUN_STATUS")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.FunSwift)
                    .HasColumnName("FUN_SWIFT")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.FunTerminoContrato)
                    .HasColumnName("FUN_TERMINO_CONTRATO")
                    .HasColumnType("date");

                entity.Property(e => e.FunTipoSalario)
                    .HasColumnName("FUN_TIPO_SALARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunTurno)
                    .HasColumnName("FUN_TURNO")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.FunUltimaRevisaoSalarial)
                    .HasColumnName("FUN_ULTIMA_REVISAO_SALARIAL")
                    .HasColumnType("date");

                entity.Property(e => e.FunUtilizador)
                    .HasColumnName("FUN_UTILIZADOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FunVigenciaContrato)
                    .HasColumnName("FUN_VIGENCIA_CONTRATO")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FunCodigoNavigation)
                    .WithOne(p => p.RhFuncionario)
                    .HasForeignKey<RhFuncionario>(d => d.FunCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rh_funcionario_ibfk_8");

                entity.HasOne(d => d.FunCodigoBancoNavigation)
                    .WithMany(p => p.RhFuncionario)
                    .HasForeignKey(d => d.FunCodigoBanco)
                    .HasConstraintName("rh_funcionario_ibfk_4");

                entity.HasOne(d => d.FunCodigoCargoNavigation)
                    .WithMany(p => p.RhFuncionario)
                    .HasForeignKey(d => d.FunCodigoCargo)
                    .HasConstraintName("rh_funcionario_ibfk_5");

                entity.HasOne(d => d.FunCodigoDepartamentoNavigation)
                    .WithMany(p => p.RhFuncionario)
                    .HasForeignKey(d => d.FunCodigoDepartamento)
                    .HasConstraintName("rh_funcionario_ibfk_7");

                entity.HasOne(d => d.FunCodigoFilialNavigation)
                    .WithMany(p => p.RhFuncionario)
                    .HasForeignKey(d => d.FunCodigoFilial)
                    .HasConstraintName("rh_funcionario_ibfk_9");

                entity.HasOne(d => d.FunCodigoGrupoSalarialNavigation)
                    .WithMany(p => p.RhFuncionario)
                    .HasForeignKey(d => d.FunCodigoGrupoSalarial)
                    .HasConstraintName("rh_funcionario_ibfk_11");

                entity.HasOne(d => d.FunCodigoHabilitacaoNavigation)
                    .WithMany(p => p.RhFuncionario)
                    .HasForeignKey(d => d.FunCodigoHabilitacao)
                    .HasConstraintName("rh_funcionario_ibfk_12");

                entity.HasOne(d => d.FunCodigoRegimeNavigation)
                    .WithMany(p => p.RhFuncionario)
                    .HasForeignKey(d => d.FunCodigoRegime)
                    .HasConstraintName("rh_funcionario_ibfk_14");

                entity.HasOne(d => d.FunCodigoVinculoNavigation)
                    .WithMany(p => p.RhFuncionario)
                    .HasForeignKey(d => d.FunCodigoVinculo)
                    .HasConstraintName("rh_funcionario_ibfk_3");

                entity.HasOne(d => d.FunMotivoAdmissaoNavigation)
                    .WithMany(p => p.RhFuncionarioFunMotivoAdmissaoNavigation)
                    .HasForeignKey(d => d.FunMotivoAdmissao)
                    .HasConstraintName("rh_funcionario_ibfk_1");

                entity.HasOne(d => d.FunMotivoDemissaoNavigation)
                    .WithMany(p => p.RhFuncionarioFunMotivoDemissaoNavigation)
                    .HasForeignKey(d => d.FunMotivoDemissao)
                    .HasConstraintName("rh_funcionario_ibfk_6");

                entity.HasOne(d => d.FunTipoSalarioNavigation)
                    .WithMany(p => p.RhFuncionario)
                    .HasForeignKey(d => d.FunTipoSalario)
                    .HasConstraintName("rh_funcionario_ibfk_2");
            });

            modelBuilder.Entity<RhFuncionarioAgregadoFamiliar>(entity =>
            {
                entity.HasKey(e => e.AgreIdentificacao)
                    .HasName("PRIMARY");

                entity.ToTable("rh_funcionario_agregado_familiar");

                entity.HasIndex(e => e.AgreCodigoFuncionario)
                    .HasName("FK_AGREGADO_FUNCIONARIO");

                entity.Property(e => e.AgreIdentificacao)
                    .HasColumnName("AGRE_IDENTIFICACAO")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.AgreCodigoFuncionario)
                    .HasColumnName("AGRE_CODIGO_FUNCIONARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgreDataNascimento)
                    .HasColumnName("AGRE_DATA_NASCIMENTO")
                    .HasColumnType("date");

                entity.Property(e => e.AgreNome)
                    .HasColumnName("AGRE_NOME")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.AgreParentesco)
                    .HasColumnName("AGRE_PARENTESCO")
                    .HasColumnType("varchar(5)");

                entity.HasOne(d => d.AgreCodigoFuncionarioNavigation)
                    .WithMany(p => p.RhFuncionarioAgregadoFamiliar)
                    .HasPrincipalKey(p => p.FunNumFuncionario)
                    .HasForeignKey(d => d.AgreCodigoFuncionario)
                    .HasConstraintName("rh_funcionario_agregado_familiar_ibfk_1");
            });

            modelBuilder.Entity<RhFuncionarioCoordenadasBancarias>(entity =>
            {
                entity.HasKey(e => new { e.FunContaCodigoFuncionario, e.FunContaCodigoBanco, e.FunContaNumero })
                    .HasName("PRIMARY");

                entity.ToTable("rh_funcionario_coordenadas_bancarias");

                entity.HasIndex(e => e.FunContaCodigoBanco)
                    .HasName("FK_COORDENADAS_BANCO");

                entity.Property(e => e.FunContaCodigoFuncionario)
                    .HasColumnName("FUN_CONTA_CODIGO_FUNCIONARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunContaCodigoBanco)
                    .HasColumnName("FUN_CONTA_CODIGO_BANCO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FunContaNumero)
                    .HasColumnName("FUN_CONTA_NUMERO")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FunContaIban)
                    .HasColumnName("FUN_CONTA_IBAN")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FunContaNib)
                    .HasColumnName("FUN_CONTA_NIB")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FunContaSwift)
                    .HasColumnName("FUN_CONTA_SWIFT")
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.FunContaCodigoBancoNavigation)
                    .WithMany(p => p.RhFuncionarioCoordenadasBancarias)
                    .HasForeignKey(d => d.FunContaCodigoBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rh_funcionario_coordenadas_bancarias_ibfk_1");

                entity.HasOne(d => d.FunContaCodigoFuncionarioNavigation)
                    .WithMany(p => p.RhFuncionarioCoordenadasBancarias)
                    .HasPrincipalKey(p => p.FunNumFuncionario)
                    .HasForeignKey(d => d.FunContaCodigoFuncionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rh_funcionario_coordenadas_bancarias_ibfk_2");
            });

            modelBuilder.Entity<RhFuncionarioGrupoHorarioTrabalho>(entity =>
            {
                entity.HasKey(e => e.GruHorCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_funcionario_grupo_horario_trabalho");

                entity.Property(e => e.GruHorCodigo)
                    .HasColumnName("GRU_HOR_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GruHorDescricao)
                    .HasColumnName("GRU_HOR_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.GruHorEstado)
                    .HasColumnName("GRU_HOR_ESTADO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.GruHorSigla)
                    .HasColumnName("GRU_HOR_SIGLA")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<RhGrupoHorarioTrabalho>(entity =>
            {
                entity.HasKey(e => e.GruHorCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_grupo_horario_trabalho");

                entity.Property(e => e.GruHorCodigo)
                    .HasColumnName("GRU_HOR_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GruHorDescricao)
                    .HasColumnName("GRU_HOR_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.GruHorEstado)
                    .HasColumnName("GRU_HOR_ESTADO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.GruHorSigla)
                    .HasColumnName("GRU_HOR_SIGLA")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<RhGrupoSalarial>(entity =>
            {
                entity.HasKey(e => e.SalCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_grupo_salarial");

                entity.HasIndex(e => e.SalCodigoMoeda)
                    .HasName("FK_GRUPO_SALARIAL_MOEDA");

                entity.Property(e => e.SalCodigo)
                    .HasColumnName("SAL_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SalCodigoMoeda)
                    .HasColumnName("SAL_CODIGO_MOEDA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SalDescricao)
                    .HasColumnName("SAL_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.SalSalario)
                    .HasColumnName("SAL_SALARIO")
                    .HasColumnType("double(18,0)");

                entity.Property(e => e.SalSigla)
                    .HasColumnName("SAL_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.SalStatus)
                    .HasColumnName("SAL_STATUS")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.SalCodigoMoedaNavigation)
                    .WithMany(p => p.RhGrupoSalarial)
                    .HasForeignKey(d => d.SalCodigoMoeda)
                    .HasConstraintName("rh_grupo_salarial_ibfk_1");
            });

            modelBuilder.Entity<RhHorarioTabalho>(entity =>
            {
                entity.HasKey(e => e.HorCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_horario_tabalho");

                entity.Property(e => e.HorCodigo)
                    .HasColumnName("HOR_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HorCargaMensal)
                    .HasColumnName("HOR_CARGA_MENSAL")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.HorCargaSemanal)
                    .HasColumnName("HOR_CARGA_SEMANAL")
                    .HasColumnType("decimal(18,0)");

                entity.Property(e => e.HorDescricao)
                    .HasColumnName("HOR_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.HorModRecolha)
                    .HasColumnName("HOR_MOD_RECOLHA")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.HorUnidade)
                    .HasColumnName("HOR_UNIDADE")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<RhHorarioTrabalhoSemana>(entity =>
            {
                entity.HasKey(e => e.JornCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_horario_trabalho_semana");

                entity.Property(e => e.JornCodigo)
                    .HasColumnName("JORN_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JornDia)
                    .HasColumnName("JORN_DIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JornEntrada1)
                    .HasColumnName("JORN_ENTRADA1")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.JornEntrada2)
                    .HasColumnName("JORN_ENTRADA2")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.JornEntrada3)
                    .HasColumnName("JORN_ENTRADA3")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.JornSaida1)
                    .HasColumnName("JORN_SAIDA1")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.JornSaida2)
                    .HasColumnName("JORN_SAIDA2")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.JornSaida3)
                    .HasColumnName("JORN_SAIDA3")
                    .HasColumnType("varchar(5)");

                entity.HasOne(d => d.JornCodigoNavigation)
                    .WithOne(p => p.RhHorarioTrabalhoSemana)
                    .HasForeignKey<RhHorarioTrabalhoSemana>(d => d.JornCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rh_horario_trabalho_semana_ibfk_1");
            });

            modelBuilder.Entity<RhMotivo>(entity =>
            {
                entity.HasKey(e => e.MotCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_motivo");

                entity.Property(e => e.MotCodigo)
                    .HasColumnName("MOT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MotCategoria)
                    .HasColumnName("MOT_CATEGORIA")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.MotDescricao)
                    .HasColumnName("MOT_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.MotEstado)
                    .HasColumnName("MOT_ESTADO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.MotSigla)
                    .HasColumnName("MOT_SIGLA")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<RhMotivoLicenca>(entity =>
            {
                entity.HasKey(e => e.LicCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_motivo_licenca");

                entity.Property(e => e.LicCodigo)
                    .HasColumnName("LIC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LicDescontoDecimoTerceiro)
                    .HasColumnName("LIC_DESCONTO_DECIMO_TERCEIRO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.LicDescontoDiasFerias)
                    .HasColumnName("LIC_DESCONTO_DIAS_FERIAS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.LicDescricao)
                    .HasColumnName("LIC_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.LicDiasRemunerar)
                    .HasColumnName("LIC_DIAS_REMUNERAR")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RhOperacoesMensais>(entity =>
            {
                entity.HasKey(e => e.OpeCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_operacoes_mensais");

                entity.Property(e => e.OpeCodigo)
                    .HasColumnName("OPE_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpeDescricao)
                    .HasColumnName("OPE_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.OpeOperacao)
                    .HasColumnName("OPE_OPERACAO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.OpeStatus)
                    .HasColumnName("OPE_STATUS")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.OpeTipo)
                    .HasColumnName("OPE_TIPO")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<RhProcessamento>(entity =>
            {
                entity.HasKey(e => e.ProcCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_processamento");

                entity.Property(e => e.ProcCodigo)
                    .HasColumnName("PROC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcCodigoGrupo)
                    .HasColumnName("PROC_CODIGO_GRUPO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcCodigoPeriodo)
                    .HasColumnName("PROC_CODIGO_PERIODO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcCodigoProcessamento)
                    .HasColumnName("PROC_CODIGO_PROCESSAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcData)
                    .HasColumnName("PROC_DATA")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<RhProcessamentoFuncionarios>(entity =>
            {
                entity.HasKey(e => e.ProcFunCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_processamento_funcionarios");

                entity.Property(e => e.ProcFunCodigo)
                    .HasColumnName("PROC_FUN_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcFunCodigoFuncionario)
                    .HasColumnName("PROC_FUN_CODIGO_FUNCIONARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcFunCodigoProcessamento)
                    .HasColumnName("PROC_FUN_CODIGO_PROCESSAMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcFunData)
                    .HasColumnName("PROC_FUN_DATA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<RhRegimeLaboral>(entity =>
            {
                entity.HasKey(e => e.RegCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_regime_laboral");

                entity.Property(e => e.RegCodigo)
                    .HasColumnName("REG_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegDescricao)
                    .HasColumnName("REG_DESCRICAO")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.RegSigla)
                    .HasColumnName("REG_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.RegStatus)
                    .HasColumnName("REG_STATUS")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<RhRegistoFalta>(entity =>
            {
                entity.HasKey(e => e.FaltCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_registo_falta");

                entity.HasIndex(e => e.FaltCodigoFunicionario)
                    .HasName("FK_REGISTO_FALTA_FUNCIONARIO");

                entity.Property(e => e.FaltCodigo)
                    .HasColumnName("FALT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FaltCodigoFunicionario)
                    .HasColumnName("FALT_CODIGO_FUNICIONARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FaltData)
                    .HasColumnName("FALT_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.FaltInicio)
                    .HasColumnName("FALT_INICIO")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FaltJustificacada)
                    .HasColumnName("FALT_JUSTIFICACADA")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FaltMotivo)
                    .HasColumnName("FALT_MOTIVO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FaltTermino)
                    .HasColumnName("FALT_TERMINO")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.FaltCodigoFunicionarioNavigation)
                    .WithMany(p => p.RhRegistoFalta)
                    .HasForeignKey(d => d.FaltCodigoFunicionario)
                    .HasConstraintName("rh_registo_falta_ibfk_1");
            });

            modelBuilder.Entity<RhRegsitoFerias>(entity =>
            {
                entity.HasKey(e => e.FerCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_regsito_ferias");

                entity.HasIndex(e => e.FerCodigoFuncionario)
                    .HasName("FK_FERIAS_FUNCIONARIO");

                entity.Property(e => e.FerCodigo)
                    .HasColumnName("FER_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FerCodigoFuncionario)
                    .HasColumnName("FER_CODIGO_FUNCIONARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FerDataAviso)
                    .HasColumnName("FER_DATA_AVISO")
                    .HasColumnType("date");

                entity.Property(e => e.FerDataPagto)
                    .HasColumnName("FER_DATA_PAGTO")
                    .HasColumnType("date");

                entity.Property(e => e.FerDataVencimento)
                    .HasColumnName("FER_DATA_VENCIMENTO")
                    .HasColumnType("date");

                entity.Property(e => e.FerDecimoTerceiro)
                    .HasColumnName("FER_DECIMO_TERCEIRO")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FerGozada)
                    .HasColumnName("FER_GOZADA")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FerInicio)
                    .HasColumnName("FER_INICIO")
                    .HasColumnType("date");

                entity.Property(e => e.FerNroDias)
                    .HasColumnName("FER_NRO_DIAS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FerTermino)
                    .HasColumnName("FER_TERMINO")
                    .HasColumnType("date");

                entity.HasOne(d => d.FerCodigoFuncionarioNavigation)
                    .WithMany(p => p.RhRegsitoFerias)
                    .HasForeignKey(d => d.FerCodigoFuncionario)
                    .HasConstraintName("rh_regsito_ferias_ibfk_1");
            });

            modelBuilder.Entity<RhRescisaoContratual>(entity =>
            {
                entity.HasKey(e => e.ResCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_rescisao_contratual");

                entity.Property(e => e.ResCodigo)
                    .HasColumnName("RES_CODIGO")
                    .HasColumnType("int(1)");

                entity.Property(e => e.ResDescricao)
                    .HasColumnName("RES_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ResDetalhes)
                    .HasColumnName("RES_DETALHES")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ResEstado)
                    .HasColumnName("RES_ESTADO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ResSigla)
                    .HasColumnName("RES_SIGLA")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<RhTipoProcessamento>(entity =>
            {
                entity.HasKey(e => e.TipProcCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_tipo_processamento");

                entity.Property(e => e.TipProcCodigo)
                    .HasColumnName("TIP_PROC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipProcDescricao)
                    .HasColumnName("TIP_PROC_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TipProcSigla)
                    .HasColumnName("TIP_PROC_SIGLA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TipProcStatus)
                    .HasColumnName("TIP_PROC_STATUS")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<RhTipoSalarioItem>(entity =>
            {
                entity.HasKey(e => new { e.ParCodigoVencimento, e.ParCodigoBeneficio })
                    .HasName("PRIMARY");

                entity.ToTable("rh_tipo_salario_item");

                entity.HasIndex(e => e.ParCodigoBeneficio)
                    .HasName("FK_TIPO_SALARIO_ITEM_BENEFICIO");

                entity.Property(e => e.ParCodigoVencimento)
                    .HasColumnName("PAR_CODIGO_VENCIMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParCodigoBeneficio)
                    .HasColumnName("PAR_CODIGO_BENEFICIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParIncidencia)
                    .HasColumnName("PAR_INCIDENCIA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.ParTipo)
                    .HasColumnName("PAR_TIPO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ParValor).HasColumnName("PAR_VALOR");

                entity.HasOne(d => d.ParCodigoBeneficioNavigation)
                    .WithMany(p => p.RhTipoSalarioItem)
                    .HasForeignKey(d => d.ParCodigoBeneficio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rh_tipo_salario_item_ibfk_2");

                entity.HasOne(d => d.ParCodigoVencimentoNavigation)
                    .WithMany(p => p.RhTipoSalarioItem)
                    .HasForeignKey(d => d.ParCodigoVencimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rh_tipo_salario_item_ibfk_1");
            });

            modelBuilder.Entity<RhVencimento>(entity =>
            {
                entity.HasKey(e => e.VencCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_vencimento");

                entity.Property(e => e.VencCodigo)
                    .HasColumnName("VENC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VencDescricao)
                    .HasColumnName("VENC_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.VencEstado)
                    .HasColumnName("VENC_ESTADO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.VencHoras)
                    .HasColumnName("VENC_HORAS")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VencSigla)
                    .HasColumnName("VENC_SIGLA")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<RhVinculoContratual>(entity =>
            {
                entity.HasKey(e => e.VincCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("rh_vinculo_contratual");

                entity.Property(e => e.VincCodigo)
                    .HasColumnName("VINC_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VincDescricao)
                    .HasColumnName("VINC_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.VincEstado)
                    .HasColumnName("VINC_ESTADO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.VincSigla)
                    .HasColumnName("VINC_SIGLA")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<SaftHeader>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("saft_header");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddressDetail)
                    .HasColumnType("varchar(210)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AuditFileVersion).HasColumnType("varchar(10)");

                entity.Property(e => e.BuildingNumber)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BusinessName)
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CompanyName)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Country).HasColumnType("varchar(2)");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("'AOA'");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Fax)
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FiscalYear).HasColumnType("int(11)");

                entity.Property(e => e.HeaderComment)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PostalCode)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProductCompanyTaxId)
                    .HasColumnName("ProductCompanyTaxID")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProductVersion)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Province)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SoftwareValidationNumber).HasColumnType("int(11)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.StreetName)
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaxAccountingBasis).HasColumnType("varchar(1)");

                entity.Property(e => e.TaxEntity)
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaxRegistrationNumber).HasColumnType("varchar(15)");

                entity.Property(e => e.Telephone)
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TransactionType).HasColumnType("varchar(1)");

                entity.Property(e => e.Website)
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<SatFolhaObra>(entity =>
            {
                entity.HasKey(e => e.FolCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sat_folha_obra");

                entity.HasIndex(e => e.FolDocumentId)
                    .HasName("FK_FOLHA_OBRA_DOCUMENT_TYPE");

                entity.HasIndex(e => e.FolFuncionarioIn)
                    .HasName("FK_FOLHA_FUNCIONARIO");

                entity.HasIndex(e => e.FolSerieDocumento)
                    .HasName("FK_FOLHA_OBRA_SERIE");

                entity.Property(e => e.FolCodigo)
                    .HasColumnName("FOL_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FolCreatedBy)
                    .HasColumnName("FOL_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FolCreatedDate)
                    .HasColumnName("FOL_CREATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FolData)
                    .HasColumnName("FOL_DATA")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FolDataInicio)
                    .HasColumnName("FOL_DATA_INICIO")
                    .HasColumnType("datetime")
                    .();

                entity.Property(e => e.FolDataTermino)
                    .HasColumnName("FOL_DATA_TERMINO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FolDocumentId)
                    .HasColumnName("FOL_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FolDocumentNumber)
                    .HasColumnName("FOL_DOCUMENT_NUMBER")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FolDocumentReference)
                    .HasColumnName("FOL_DOCUMENT_REFERENCE")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.FolFuncionarioIn)
                    .HasColumnName("FOL_FUNCIONARIO_IN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FolSerieDocumento)
                    .HasColumnName("FOL_SERIE_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FolServicoPrincipal)
                    .HasColumnName("FOL_SERVICO_PRINCIPAL")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FolStatus)
                    .HasColumnName("FOL_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FolUpdatedBy)
                    .HasColumnName("FOL_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FolUpdatedDate)
                    .HasColumnName("FOL_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();

                entity.HasOne(d => d.FolDocument)
                    .WithMany(p => p.SatFolhaObra)
                    .HasForeignKey(d => d.FolDocumentId)
                    .HasConstraintName("sat_folha_obra_ibfk_2");

                entity.HasOne(d => d.FolFuncionarioInNavigation)
                    .WithMany(p => p.SatFolhaObra)
                    .HasForeignKey(d => d.FolFuncionarioIn)
                    .HasConstraintName("sat_folha_obra_ibfk_1");

                entity.HasOne(d => d.FolSerieDocumentoNavigation)
                    .WithMany(p => p.SatFolhaObra)
                    .HasForeignKey(d => d.FolSerieDocumento)
                    .HasConstraintName("sat_folha_obra_ibfk_3");
            });

            modelBuilder.Entity<SatViaturas>(entity =>
            {
                entity.HasKey(e => e.ViaMatricula)
                    .HasName("PRIMARY");

                entity.ToTable("sat_viaturas");

                entity.HasIndex(e => e.ViaCodigo)
                    .HasName("UK_VIATURA")
                    .IsUnique();

                entity.HasIndex(e => e.ViaCor)
                    .HasName("FK_COR");

                entity.HasIndex(e => e.ViaMarca)
                    .HasName("FK_MARCA");

                entity.Property(e => e.ViaMatricula)
                    .HasColumnName("VIA_MATRICULA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ViaCategoria)
                    .HasColumnName("VIA_CATEGORIA")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ViaCodigo)
                    .HasColumnName("VIA_CODIGO")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ViaCor)
                    .HasColumnName("VIA_COR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaMarca)
                    .HasColumnName("VIA_MARCA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ViaNumeroSerie)
                    .HasColumnName("VIA_NUMERO_SERIE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ViaProprietario)
                    .HasColumnName("VIA_PROPRIETARIO")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ViaCorNavigation)
                    .WithMany(p => p.SatViaturas)
                    .HasForeignKey(d => d.ViaCor)
                    .HasConstraintName("sat_viaturas_ibfk_1");

                entity.HasOne(d => d.ViaMarcaNavigation)
                    .WithMany(p => p.SatViaturas)
                    .HasForeignKey(d => d.ViaMarca)
                    .HasConstraintName("sat_viaturas_ibfk_2");
            });

            modelBuilder.Entity<SisAcesso>(entity =>
            {
                entity.HasKey(e => e.AceCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_acesso");

                entity.HasIndex(e => e.AceCodigo)
                    .HasName("sys_acesso_PK_SYS_ACESSO_ndx");

                entity.Property(e => e.AceCodigo)
                    .HasColumnName("ace_codigo")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AceDataLogin)
                    .HasColumnName("ace_data_login")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AceDataLogout)
                    .HasColumnName("ace_data_logout")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AceHoraLogin)
                    .HasColumnName("ace_hora_login")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.AceHoraLogout)
                    .HasColumnName("ace_hora_logout")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.AceIp)
                    .HasColumnName("ace_ip")
                    .HasColumnType("char(20)");

                entity.Property(e => e.AceMaquina)
                    .HasColumnName("ace_maquina")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AceStatus)
                    .HasColumnName("ace_status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AceUtilizador)
                    .HasColumnName("ace_utilizador")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<SisConfiguracao>(entity =>
            {
                entity.HasKey(e => e.SisCodigoFilial)
                    .HasName("PRIMARY");

                entity.ToTable("sis_configuracao");

                entity.Property(e => e.SisCodigoFilial)
                    .HasColumnName("SIS_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SisChangePvpOnpurchage)
                    .HasColumnName("SIS_CHANGE_PVP_ONPURCHAGE")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SisCodigoIdioma)
                    .HasColumnName("SIS_CODIGO_IDIOMA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SisDefaultPaymentMethod)
                    .HasColumnName("SIS_DEFAULT_PAYMENT_METHOD")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SisEnderecoRecibo)
                    .HasColumnName("SIS_ENDERECO_RECIBO")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.SisMoedaPadrao)
                    .HasColumnName("SIS_MOEDA_PADRAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SisPaisPadrao)
                    .HasColumnName("SIS_PAIS_PADRAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SisRestModalidade)
                    .HasColumnName("SIS_REST_MODALIDADE")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.SisStockAllowSalesValidLotes)
                    .HasColumnName("SIS_STOCK_ALLOW_SALES_VALID_LOTES")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SisStockExpireDateNotification)
                    .HasColumnName("SIS_STOCK_EXPIRE_DATE_NOTIFICATION")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SisStockIncomeSerieId)
                    .HasColumnName("SIS_STOCK_INCOME_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SisStockLevelNotification)
                    .HasColumnName("SIS_STOCK_LEVEL_NOTIFICATION")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.SisStockLoteMode)
                    .HasColumnName("SIS_STOCK_LOTE_MODE")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.SisStockOutcomeSerieId)
                    .HasColumnName("SIS_STOCK_OUTCOME_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SisStockStartAlertExpire)
                    .HasColumnName("SIS_STOCK_START_ALERT_EXPIRE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SisWarehouseDefault)
                    .HasColumnName("SIS_WAREHOUSE_DEFAULT")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SisCore>(entity =>
            {
                entity.HasKey(e => e.SisId)
                    .HasName("PRIMARY");

                entity.ToTable("sis_core");

                entity.Property(e => e.SisId)
                    .HasColumnName("SIS_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SisCode)
                    .HasColumnName("SIS_CODE")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.SisDesignation)
                    .HasColumnName("SIS_DESIGNATION")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.SisStatus)
                    .HasColumnName("SIS_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.SisUrl)
                    .HasColumnName("SIS_URL")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<SisDocumentsFormate>(entity =>
            {
                entity.HasKey(e => e.TypId)
                    .HasName("PRIMARY");

                entity.ToTable("sis_documents_formate");

                entity.Property(e => e.TypId)
                    .HasColumnName("TYP_ID")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.TypDescription)
                    .HasColumnName("TYP_DESCRIPTION")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.TypDocument)
                    .HasColumnName("TYP_DOCUMENT")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<SisEmailMonitor>(entity =>
            {
                entity.HasKey(e => e.EmailCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_email_monitor");

                entity.HasIndex(e => e.EmailCodigoFilial)
                    .HasName("FK_EMAIL_FILIAL");

                entity.Property(e => e.EmailCodigo)
                    .HasColumnName("EMAIL_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailCodigoFilial)
                    .HasColumnName("EMAIL_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailEnableSsl)
                    .HasColumnName("EMAIL_ENABLE_SSL")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.EmailEndereco)
                    .HasColumnName("EMAIL_ENDERECO")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EmailHost)
                    .HasColumnName("EMAIL_HOST")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EmailModulo)
                    .HasColumnName("EMAIL_MODULO")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.EmailPorta)
                    .HasColumnName("EMAIL_PORTA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailRemetente)
                    .HasColumnName("EMAIL_REMETENTE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EmailSenha)
                    .HasColumnName("EMAIL_SENHA")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EmailUsuario)
                    .HasColumnName("EMAIL_USUARIO")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SisEmpresa>(entity =>
            {
                entity.HasKey(e => e.FilCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_empresa");

                entity.HasIndex(e => e.FilCodigoEmpresa)
                    .HasName("FK_FILIAL_EMPRESA");

                entity.Property(e => e.FilCodigo)
                    .HasColumnName("FIL_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FilCapitalSocial)
                    .HasColumnName("FIL_CAPITAL_SOCIAL")
                    .HasColumnType("decimal(18,0)");

                entity.Property(e => e.FilCategoria)
                    .HasColumnName("FIL_CATEGORIA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FilCodigoEmpresa)
                    .HasColumnName("FIL_CODIGO_EMPRESA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FilConservatoria)
                    .HasColumnName("FIL_CONSERVATORIA")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FilNaturezaJuridca)
                    .HasColumnName("FIL_NATUREZA_JURIDCA")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FilNomeComercial)
                    .HasColumnName("FIL_NOME_COMERCIAL")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FilRazaoSocial)
                    .HasColumnName("FIL_RAZAO_SOCIAL")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FilRegistoComercial)
                    .HasColumnName("FIL_REGISTO_COMERCIAL")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FilSigla)
                    .HasColumnName("FIL_SIGLA")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.FilSoftwareDesignation)
                    .HasColumnName("FIL_SOFTWARE_DESIGNATION")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FilSoftwareNif)
                    .HasColumnName("FIL_SOFTWARE_NIF")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.FilSoftwareProductVersion)
                    .HasColumnName("FIL_SOFTWARE_PRODUCT_VERSION")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FilSoftwareValidationId)
                    .HasColumnName("FIL_SOFTWARE_VALIDATION_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FilStatus)
                    .HasColumnName("FIL_STATUS")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.FilCodigoNavigation)
                    .WithOne(p => p.SisEmpresa)
                    .HasForeignKey<SisEmpresa>(d => d.FilCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sis_empresa_ibfk_1");
            });

            modelBuilder.Entity<SisFormulario>(entity =>
            {
                entity.HasKey(e => e.FormCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_formulario");

                entity.HasIndex(e => e.FormCodigo)
                    .HasName("sys_formulario_PK_SYS_FORMULARIO_ndx");

                entity.HasIndex(e => e.FormCodigoModulo)
                    .HasName("FK_FORMULARIO_MODULO");

                entity.Property(e => e.FormCodigo)
                    .HasColumnName("form_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormCodigoModulo)
                    .HasColumnName("form_codigo_modulo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormImagem)
                    .HasColumnName("form_imagem")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FormIndice)
                    .HasColumnName("form_indice")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormLink)
                    .HasColumnName("form_link")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.FormNome)
                    .IsRequired()
                    .HasColumnName("form_nome")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FormTag)
                    .HasColumnName("form_tag")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormTitulo)
                    .IsRequired()
                    .HasColumnName("form_titulo")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.FormCodigoModuloNavigation)
                    .WithMany(p => p.SisFormulario)
                    .HasForeignKey(d => d.FormCodigoModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sis_formulario_ibfk_1");
            });

            modelBuilder.Entity<SisFormularioPermissao>(entity =>
            {
                entity.HasKey(e => new { e.FormPermCodigoFormulario, e.FormPermCodigoPerfil })
                    .HasName("PRIMARY");

                entity.ToTable("sis_formulario_permissao");

                entity.HasIndex(e => e.FormPermCodigo)
                    .HasName("form_perm_codigo")
                    .IsUnique();

                entity.HasIndex(e => e.FormPermCodigoPerfil)
                    .HasName("FK_PERMISSAO_PERFIL");

                entity.HasIndex(e => new { e.FormPermCodigoFormulario, e.FormPermCodigoPerfil })
                    .HasName("sys_formulario_permissao_PK_SIS_FORMULARIO_PERMISSAO_ndx");

                entity.Property(e => e.FormPermCodigoFormulario)
                    .HasColumnName("form_perm_codigo_formulario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermCodigoPerfil)
                    .HasColumnName("form_perm_codigo_perfil")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermAcesso)
                    .HasColumnName("form_perm_acesso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermAlteracao)
                    .HasColumnName("form_perm_alteracao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermCodigo)
                    .HasColumnName("form_perm_codigo")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FormPermConsulta)
                    .HasColumnName("form_perm_consulta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermExclusao)
                    .HasColumnName("form_perm_exclusao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermImpressao)
                    .HasColumnName("form_perm_impressao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermInclusao)
                    .HasColumnName("form_perm_inclusao")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SisHistorico>(entity =>
            {
                entity.HasKey(e => e.HistCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_historico");

                entity.HasIndex(e => e.HistCodigo)
                    .HasName("sys_historico_PK_SYS_HISTORICO_ndx");

                entity.Property(e => e.HistCodigo)
                    .HasColumnName("hist_codigo")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HistAccao)
                    .IsRequired()
                    .HasColumnName("hist_accao")
                    .HasColumnType("char(20)");

                entity.Property(e => e.HistCodigoRegisto)
                    .HasColumnName("hist_codigo_registo")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.HistDataAlteracao)
                    .IsRequired()
                    .HasColumnName("hist_data_alteracao")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.HistDescricao)
                    .IsRequired()
                    .HasColumnName("hist_descricao")
                    .HasColumnType("text");

                entity.Property(e => e.HistFormulario)
                    .HasColumnName("hist_formulario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HistHora)
                    .IsRequired()
                    .HasColumnName("hist_hora")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.HistUtilizador)
                    .IsRequired()
                    .HasColumnName("hist_utilizador")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SisImportacao>(entity =>
            {
                entity.HasKey(e => new { e.ImpDescricao, e.ImpData })
                    .HasName("PRIMARY");

                entity.ToTable("sis_importacao");

                entity.Property(e => e.ImpDescricao)
                    .HasColumnName("IMP_DESCRICAO")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ImpData)
                    .HasColumnName("IMP_DATA")
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.ImpImportacao)
                    .HasColumnName("IMP_IMPORTACAO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SisLogs>(entity =>
            {
                entity.HasKey(e => e.LogCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_logs");

                entity.Property(e => e.LogCodigo)
                    .HasColumnName("LOG_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LogAccao)
                    .IsRequired()
                    .HasColumnName("LOG_ACCAO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.LogAlteracao)
                    .IsRequired()
                    .HasColumnName("LOG_ALTERACAO")
                    .HasColumnType("text");

                entity.Property(e => e.LogData)
                    .HasColumnName("LOG_DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogFormulario)
                    .IsRequired()
                    .HasColumnName("LOG_FORMULARIO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.LogIp)
                    .IsRequired()
                    .HasColumnName("LOG_IP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.LogUtilizador)
                    .IsRequired()
                    .HasColumnName("LOG_UTILIZADOR")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<SisMensagemErro>(entity =>
            {
                entity.HasKey(e => e.MsgCodigoErro)
                    .HasName("PRIMARY");

                entity.ToTable("sis_mensagem_erro");

                entity.HasIndex(e => e.MsgCodigo)
                    .HasName("msg_codigo")
                    .IsUnique();

                entity.HasIndex(e => e.MsgCodigoErro)
                    .HasName("sys_mensagem_erro_PK_SYS_MENSAGEM_ERRO_ndx");

                entity.Property(e => e.MsgCodigoErro)
                    .HasColumnName("msg_codigo_erro")
                    .HasColumnType("char(10)");

                entity.Property(e => e.MsgCodigo)
                    .HasColumnName("msg_codigo")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MsgMensagem)
                    .IsRequired()
                    .HasColumnName("msg_mensagem")
                    .HasColumnType("varchar(250)");
            });

            modelBuilder.Entity<SisModulo>(entity =>
            {
                entity.HasKey(e => e.ModCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_modulo");

                entity.HasIndex(e => e.ModCodigo)
                    .HasName("sys_modulo_PK_Table_1_ndx");

                entity.Property(e => e.ModCodigo)
                    .HasColumnName("mod_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModAbreviacao)
                    .HasColumnName("mod_abreviacao")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModDescricao)
                    .HasColumnName("mod_descricao")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModImagem)
                    .HasColumnName("mod_imagem")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ModIndice)
                    .HasColumnName("mod_indice")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModLink)
                    .HasColumnName("mod_link")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.ModStatus)
                    .HasColumnName("MOD_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ModTag)
                    .HasColumnName("mod_tag")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SisModuloPermissao>(entity =>
            {
                entity.HasKey(e => new { e.ModPermCodigoModulo, e.ModPermCodigoPerfil })
                    .HasName("PRIMARY");

                entity.ToTable("sis_modulo_permissao");

                entity.HasIndex(e => e.ModPermCodigoPerfil)
                    .HasName("FK_MODULO_PERMISSAO_PERFIL");

                entity.Property(e => e.ModPermCodigoModulo)
                    .HasColumnName("MOD_PERM_CODIGO_MODULO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModPermCodigoPerfil)
                    .HasColumnName("MOD_PERM_CODIGO_PERFIL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModPermAcesso)
                    .HasColumnName("MOD_PERM_ACESSO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModPermAutorizar)
                    .HasColumnName("MOD_PERM_AUTORIZAR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModPermCodigo)
                    .HasColumnName("MOD_PERM_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModPermVisibilidade)
                    .HasColumnName("MOD_PERM_VISIBILIDADE")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SisPerfil>(entity =>
            {
                entity.HasKey(e => e.PerCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_perfil");

                entity.HasIndex(e => e.PerCodigo)
                    .HasName("sis_perfil_PK_sis_PERFIL_ndx");

                entity.Property(e => e.PerCodigo)
                    .HasColumnName("per_codigo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PerCreatedBy)
                    .HasColumnName("per_created_by")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PerCreatedDate)
                    .HasColumnName("per_created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PerDescricao)
                    .HasColumnName("per_descricao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PerEmail)
                    .HasColumnName("per_email")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PerNome)
                    .IsRequired()
                    .HasColumnName("per_nome")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PerStatus)
                    .IsRequired()
                    .HasColumnName("per_status")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PerSupervisor)
                    .HasColumnName("per_supervisor")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PerUpdatedBy)
                    .HasColumnName("per_updated_by")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PerUpdatedDate)
                    .HasColumnName("per_updated_date")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<SisPerfilFilial>(entity =>
            {
                entity.HasKey(e => new { e.FilCodigoEmpresa, e.FilCodigoPerfil })
                    .HasName("PRIMARY");

                entity.ToTable("sis_perfil_filial");

                entity.HasIndex(e => e.FilCodigoPerfil)
                    .HasName("FK_PERFIL_FILIAL_PERFIL");

                entity.Property(e => e.FilCodigoEmpresa)
                    .HasColumnName("FIL_CODIGO_EMPRESA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FilCodigoPerfil)
                    .HasColumnName("FIL_CODIGO_PERFIL")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SisPosFormularioPermissao>(entity =>
            {
                entity.HasKey(e => new { e.FormPermCodigoFormulario, e.FormPermCodigoPerfil })
                    .HasName("PRIMARY");

                entity.ToTable("sis_pos_formulario_permissao");

                entity.HasIndex(e => e.FormPermCodigo)
                    .HasName("form_perm_codigo")
                    .IsUnique();

                entity.HasIndex(e => e.FormPermCodigoPerfil)
                    .HasName("FK_PERMISSAO_PERFIL");

                entity.HasIndex(e => new { e.FormPermCodigoFormulario, e.FormPermCodigoPerfil })
                    .HasName("sys_formulario_permissao_PK_SIS_FORMULARIO_PERMISSAO_ndx");

                entity.Property(e => e.FormPermCodigoFormulario)
                    .HasColumnName("form_perm_codigo_formulario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermCodigoPerfil)
                    .HasColumnName("form_perm_codigo_perfil")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermAcesso)
                    .HasColumnName("form_perm_acesso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermAlteracao)
                    .HasColumnName("form_perm_alteracao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermCodigo)
                    .HasColumnName("form_perm_codigo")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FormPermConsulta)
                    .HasColumnName("form_perm_consulta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermExclusao)
                    .HasColumnName("form_perm_exclusao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermImpressao)
                    .HasColumnName("form_perm_impressao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermInclusao)
                    .HasColumnName("form_perm_inclusao")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SisPosFormularios>(entity =>
            {
                entity.HasKey(e => e.PosFormCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_pos_formularios");

                entity.Property(e => e.PosFormCodigo)
                    .HasColumnName("POS_FORM_CODIGO")
                    .HasColumnType("int(255)");

                entity.Property(e => e.PosFormIndice)
                    .HasColumnName("POS_FORM_INDICE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosFormTag)
                    .HasColumnName("POS_FORM_TAG")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.PosFormCodigoNavigation)
                    .WithOne(p => p.SisPosFormularios)
                    .HasForeignKey<SisPosFormularios>(d => d.PosFormCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sis_pos_formularios_ibfk_1");
            });

            modelBuilder.Entity<SisPrinters>(entity =>
            {
                entity.HasKey(e => e.PrintCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_printers");

                entity.Property(e => e.PrintCodigo)
                    .HasColumnName("PRINT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrintCreatedBy)
                    .HasColumnName("PRINT_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PrintCreatedDate)
                    .HasColumnName("PRINT_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrintDescription)
                    .HasColumnName("PRINT_DESCRIPTION")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PrintIp)
                    .HasColumnName("PRINT_IP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PrintName)
                    .HasColumnName("PRINT_NAME")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PrintPath)
                    .HasColumnName("PRINT_PATH")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.PrintUpdatedBy)
                    .HasColumnName("PRINT_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PrintUpdatedDate)
                    .HasColumnName("PRINT_UPDATED_DATE")
                    .HasColumnType("datetime")
                    .();
            });

            modelBuilder.Entity<SisRestFormularioPermissao>(entity =>
            {
                entity.HasKey(e => new { e.FormPermCodigoFormulario, e.FormPermCodigoPerfil })
                    .HasName("PRIMARY");

                entity.ToTable("sis_rest_formulario_permissao");

                entity.HasIndex(e => e.FormPermCodigo)
                    .HasName("form_perm_codigo")
                    .IsUnique();

                entity.HasIndex(e => e.FormPermCodigoPerfil)
                    .HasName("FK_PERMISSAO_PERFIL");

                entity.HasIndex(e => new { e.FormPermCodigoFormulario, e.FormPermCodigoPerfil })
                    .HasName("sys_formulario_permissao_PK_SIS_FORMULARIO_PERMISSAO_ndx");

                entity.Property(e => e.FormPermCodigoFormulario)
                    .HasColumnName("form_perm_codigo_formulario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermCodigoPerfil)
                    .HasColumnName("form_perm_codigo_perfil")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermAcesso)
                    .HasColumnName("form_perm_acesso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermAlteracao)
                    .HasColumnName("form_perm_alteracao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermCodigo)
                    .HasColumnName("form_perm_codigo")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FormPermConsulta)
                    .HasColumnName("form_perm_consulta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermExclusao)
                    .HasColumnName("form_perm_exclusao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermImpressao)
                    .HasColumnName("form_perm_impressao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FormPermInclusao)
                    .HasColumnName("form_perm_inclusao")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SisRestFormularios>(entity =>
            {
                entity.HasKey(e => e.PosFormCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_rest_formularios");

                entity.Property(e => e.PosFormCodigo)
                    .HasColumnName("POS_FORM_CODIGO")
                    .HasColumnType("int(255)");

                entity.Property(e => e.PosFormIndice)
                    .HasColumnName("POS_FORM_INDICE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PosFormTag)
                    .HasColumnName("POS_FORM_TAG")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.PosFormCodigoNavigation)
                    .WithOne(p => p.SisRestFormularios)
                    .HasForeignKey<SisRestFormularios>(d => d.PosFormCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sis_rest_formularios_ibfk_1");
            });

            modelBuilder.Entity<SisSaftAoExport>(entity =>
            {
                entity.HasKey(e => e.SaftCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_saft_ao_export");

                entity.Property(e => e.SaftCodigo)
                    .HasColumnName("SAFT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SaftComapnyId)
                    .HasColumnName("SAFT_COMAPNY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SaftCreatedBy)
                    .HasColumnName("SAFT_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SaftCreatedDate)
                    .HasColumnName("SAFT_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SaftData)
                    .HasColumnName("SAFT_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.SaftDesignacao)
                    .HasColumnName("SAFT_DESIGNACAO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.SaftFinalidade)
                    .HasColumnName("SAFT_FINALIDADE")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.SaftFiscalYear)
                    .HasColumnName("SAFT_FISCAL_YEAR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SaftFrom)
                    .HasColumnName("SAFT_FROM")
                    .HasColumnType("date");

                entity.Property(e => e.SaftPeriodoId)
                    .HasColumnName("SAFT_PERIODO_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SaftStatus)
                    .HasColumnName("SAFT_STATUS")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.SaftUntil)
                    .HasColumnName("SAFT_UNTIL")
                    .HasColumnType("date");

                entity.Property(e => e.SaftUpdatedBy)
                    .HasColumnName("SAFT_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SaftUpdatedDate)
                    .HasColumnName("SAFT_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SaftVersao)
                    .HasColumnName("SAFT_VERSAO")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<SisSubscricoes>(entity =>
            {
                entity.HasKey(e => e.SubCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("sis_subscricoes");

                entity.Property(e => e.SubCodigo)
                    .HasColumnName("SUB_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubCreatedBy)
                    .HasColumnName("SUB_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SubCreatedDate)
                    .HasColumnName("SUB_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubDescricao)
                    .HasColumnName("SUB_DESCRICAO")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.SubUpdatedBy)
                    .HasColumnName("SUB_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.SubUpdatedDate)
                    .HasColumnName("SUB_UPDATED_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SisSystemInfo>(entity =>
            {
                entity.HasKey(e => e.ProductCompanyTaxId)
                    .HasName("PRIMARY");

                entity.ToTable("sis_system_info");

                entity.Property(e => e.ProductCompanyTaxId)
                    .HasColumnName("ProductCompanyTaxID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProductVersion).HasColumnType("varchar(30)");

                entity.Property(e => e.SoftwareValidationNumber).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SisUtilizador>(entity =>
            {
                entity.HasKey(e => e.UtiUtilizador)
                    .HasName("PRIMARY");

                entity.ToTable("sis_utilizador");

                entity.HasIndex(e => e.UtiCodigo)
                    .HasName("uti_codigo")
                    .IsUnique();

                entity.HasIndex(e => e.UtiCodigoPerfil)
                    .HasName("FK_UTILIZADOR_PERIFL");

                entity.HasIndex(e => e.UtiUtilizador)
                    .HasName("sis_utilizador_PK_sis_UTILIZADOR_ndx");

                entity.Property(e => e.UtiUtilizador)
                    .HasColumnName("uti_utilizador")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UtiCodigo)
                    .HasColumnName("uti_codigo")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UtiCodigoPerfil)
                    .HasColumnName("uti_codigo_perfil")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtiEmail)
                    .HasColumnName("uti_email")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.UtiEstado)
                    .HasColumnName("uti_estado")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.UtiFotoPath)
                    .HasColumnName("uti_foto_path")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.UtiIdioma)
                    .HasColumnName("uti_idioma")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtiNome)
                    .HasColumnName("uti_nome")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UtiSenha)
                    .HasColumnName("uti_senha")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.UtiSupervisor)
                    .HasColumnName("uti_supervisor")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<SisUtilizadorFilial>(entity =>
            {
                entity.HasKey(e => new { e.UtiFilialUtilizador, e.UtiFilialCodigoFilial })
                    .HasName("PRIMARY");

                entity.ToTable("sis_utilizador_filial");

                entity.Property(e => e.UtiFilialUtilizador)
                    .HasColumnName("UTI_FILIAL_UTILIZADOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UtiFilialCodigoFilial)
                    .HasColumnName("UTI_FILIAL_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtiFilialDefault)
                    .HasColumnName("UTI_FILIAL_DEFAULT")
                    .HasColumnType("bit(1)");
            });

            modelBuilder.Entity<SisUtilizadorPermissaoFormulario>(entity =>
            {
                entity.HasKey(e => new { e.UtiPermFormCodigoFormulario, e.UtiPermFormUtilizador })
                    .HasName("PRIMARY");

                entity.ToTable("sis_utilizador_permissao_formulario");

                entity.Property(e => e.UtiPermFormCodigoFormulario)
                    .HasColumnName("UTI_PERM_FORM_CODIGO_FORMULARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtiPermFormUtilizador)
                    .HasColumnName("UTI_PERM_FORM_UTILIZADOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UtiPermFormAcesso)
                    .HasColumnName("UTI_PERM_FORM_ACESSO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtiPermFormAlterar)
                    .HasColumnName("UTI_PERM_FORM_ALTERAR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtiPermFormConsultar)
                    .HasColumnName("UTI_PERM_FORM_CONSULTAR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtiPermFormExcluir)
                    .HasColumnName("UTI_PERM_FORM_EXCLUIR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtiPermFormImprimir)
                    .HasColumnName("UTI_PERM_FORM_IMPRIMIR")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtiPermFormInserir)
                    .HasColumnName("UTI_PERM_FORM_INSERIR")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<StockEntrada>(entity =>
            {
                entity.HasKey(e => e.DocEntCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("stock_entrada");

                entity.Property(e => e.DocEntCodigo)
                    .HasColumnName("DOC_ENT_CODIGO")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DocEntOrigem)
                    .HasColumnName("DOC_ENT_ORIGEM")
                    .HasColumnType("enum('EC','ED','ET')");
            });

            modelBuilder.Entity<StockExtratoArtigo>(entity =>
            {
                entity.HasKey(e => e.ExtCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("stock_extrato_artigo");

                entity.Property(e => e.ExtCodigo)
                    .HasColumnName("EXT_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExtCodigoDocumento)
                    .HasColumnName("EXT_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExtData)
                    .HasColumnName("EXT_DATA")
                    .HasColumnType("date");

                entity.Property(e => e.ExtExistencia)
                    .HasColumnName("EXT_EXISTENCIA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ExtNroDoc)
                    .HasColumnName("EXT_NRO_DOC")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.ExtPrecoMedio)
                    .HasColumnName("EXT_PRECO_MEDIO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ExtPrecoUnitario)
                    .HasColumnName("EXT_PRECO_UNITARIO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ExtQtdMovimentada)
                    .HasColumnName("EXT_QTD_MOVIMENTADA")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ExtQtdOriginal)
                    .HasColumnName("EXT_QTD_ORIGINAL")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ExtSerie)
                    .HasColumnName("EXT_SERIE")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<StockFaturaCompra>(entity =>
            {
                entity.HasKey(e => e.FatCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("stock_fatura_compra");

                entity.Property(e => e.FatCodigo)
                    .HasColumnName("FAT_CODIGO")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FatCambio)
                    .HasColumnName("FAT_CAMBIO")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatCodigoMoeda)
                    .HasColumnName("FAT_CODIGO_MOEDA")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FatDataEmissao)
                    .HasColumnName("FAT_DATA_EMISSAO")
                    .HasColumnType("date");

                entity.Property(e => e.FatFaturaFornecedor)
                    .HasColumnName("FAT_FATURA_FORNECEDOR")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.FatPercentDesconto)
                    .HasColumnName("FAT_PERCENT_DESCONTO")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatQuantidadeProdutos)
                    .HasColumnName("FAT_QUANTIDADE_PRODUTOS")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatSeguro)
                    .HasColumnName("FAT_SEGURO")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatTipo)
                    .HasColumnName("FAT_TIPO")
                    .HasColumnType("enum('CN','OC')");

                entity.Property(e => e.FatValorDespesasAdic)
                    .HasColumnName("FAT_VALOR_DESPESAS_ADIC")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatValorFatura)
                    .HasColumnName("FAT_VALOR_FATURA")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatValorFrete)
                    .HasColumnName("FAT_VALOR_FRETE")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatValorImpostos)
                    .HasColumnName("FAT_VALOR_IMPOSTOS")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatValorProdutos)
                    .HasColumnName("FAT_VALOR_PRODUTOS")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FatValorServico)
                    .HasColumnName("FAT_VALOR_SERVICO")
                    .HasColumnType("decimal(10,0)");

                entity.HasOne(d => d.FatCodigoNavigation)
                    .WithOne(p => p.StockFaturaCompra)
                    .HasForeignKey<StockFaturaCompra>(d => d.FatCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stock_fatura_compra_ibfk_1");
            });

            modelBuilder.Entity<StockMovimentoDirectos>(entity =>
            {
                entity.HasKey(e => e.MovCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("stock_movimento_directos");

                entity.HasIndex(e => e.MovCodigoArmazem)
                    .HasName("stock_movimento_directos_armazem");

                entity.HasIndex(e => e.MovCodigoArmazemFrom)
                    .HasName("FK_MOVIMENTO_STOCK_ARMAZEM_FROM");

                entity.HasIndex(e => e.MovCodigoArmazemTo)
                    .HasName("FK_MOVIMENTO_STOCK_ARMAZEM_TO");

                entity.HasIndex(e => e.MovCodigoDocumento)
                    .HasName("FK_MOVIMENTO_STOCK_DOCUMENTO");

                entity.HasIndex(e => e.MovDocumentFrom)
                    .HasName("stock_movimento_document_from");

                entity.HasIndex(e => e.MovReferencia)
                    .HasName("FK_MOVIMENTO_REFERENCIA_UK")
                    .IsUnique();

                entity.HasIndex(e => e.MovSerieId)
                    .HasName("stock_movimento_directo_serie");

                entity.HasIndex(e => e.MovTransferenciaId)
                    .HasName("stock_movimento_directos_transfencia");

                entity.Property(e => e.MovCodigo)
                    .HasColumnName("MOV_CODIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovCodigoArmazem)
                    .HasColumnName("MOV_CODIGO_ARMAZEM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovCodigoArmazemFrom)
                    .HasColumnName("MOV_CODIGO_ARMAZEM_FROM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovCodigoArmazemTo)
                    .HasColumnName("MOV_CODIGO_ARMAZEM_TO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovCodigoDocumento)
                    .HasColumnName("MOV_CODIGO_DOCUMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovDataLancamento)
                    .HasColumnName("MOV_DATA_LANCAMENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MovDataStock)
                    .HasColumnName("MOV_DATA_STOCK")
                    .HasColumnType("date");

                entity.Property(e => e.MovDeleteReason)
                    .HasColumnName("MOV_DELETE_REASON")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MovDeleted)
                    .HasColumnName("MOV_DELETED")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.MovDeletedBy)
                    .HasColumnName("MOV_DELETED_BY")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MovDeletedDate)
                    .HasColumnName("MOV_DELETED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MovDocumentFrom)
                    .HasColumnName("MOV_DOCUMENT_FROM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovDocumentId)
                    .HasColumnName("MOV_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovEntityId)
                    .HasColumnName("MOV_ENTITY_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovFuncionario)
                    .HasColumnName("MOV_FUNCIONARIO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovJustificativa)
                    .HasColumnName("MOV_JUSTIFICATIVA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovNumeracao)
                    .HasColumnName("MOV_NUMERACAO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovObservacoes)
                    .HasColumnName("MOV_OBSERVACOES")
                    .HasColumnType("varchar(120)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MovPurchageInvoiceId)
                    .HasColumnName("MOV_PURCHAGE_INVOICE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovReferencia)
                    .IsRequired()
                    .HasColumnName("MOV_REFERENCIA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MovSerieId)
                    .HasColumnName("MOV_SERIE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovTransferenciaId)
                    .HasColumnName("MOV_TRANSFERENCIA_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovUpdateDate)
                    .HasColumnName("MOV_UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MovUserCreate)
                    .HasColumnName("MOV_USER_CREATE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MovUserUpdate)
                    .HasColumnName("MOV_USER_UPDATE")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.MovCodigoArmazemNavigation)
                    .WithMany(p => p.StockMovimentoDirectosMovCodigoArmazemNavigation)
                    .HasForeignKey(d => d.MovCodigoArmazem)
                    .HasConstraintName("stock_movimento_directos_armazem");

                entity.HasOne(d => d.MovCodigoArmazemFromNavigation)
                    .WithMany(p => p.StockMovimentoDirectosMovCodigoArmazemFromNavigation)
                    .HasForeignKey(d => d.MovCodigoArmazemFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stock_movimento_directos_ibfk_1");

                entity.HasOne(d => d.MovCodigoArmazemToNavigation)
                    .WithMany(p => p.StockMovimentoDirectosMovCodigoArmazemToNavigation)
                    .HasForeignKey(d => d.MovCodigoArmazemTo)
                    .HasConstraintName("stock_movimento_directos_ibfk_2");

                entity.HasOne(d => d.MovCodigoDocumentoNavigation)
                    .WithMany(p => p.StockMovimentoDirectosMovCodigoDocumentoNavigation)
                    .HasForeignKey(d => d.MovCodigoDocumento)
                    .HasConstraintName("stock_movimento_directos_ibfk_3");

                entity.HasOne(d => d.MovDocumentFromNavigation)
                    .WithMany(p => p.StockMovimentoDirectosMovDocumentFromNavigation)
                    .HasForeignKey(d => d.MovDocumentFrom)
                    .HasConstraintName("stock_movimento_document_from");

                entity.HasOne(d => d.MovSerie)
                    .WithMany(p => p.StockMovimentoDirectos)
                    .HasForeignKey(d => d.MovSerieId)
                    .HasConstraintName("stock_movimento_directo_serie");

                entity.HasOne(d => d.MovTransferencia)
                    .WithMany(p => p.InverseMovTransferencia)
                    .HasForeignKey(d => d.MovTransferenciaId)
                    .HasConstraintName("stock_movimento_directos_transfencia");
            });

            modelBuilder.Entity<StockMovimentosDirectosArtigos>(entity =>
            {
                entity.HasKey(e => new { e.MovStkArtCodigoMovimento, e.MovStkArtCodigoArtigo })
                    .HasName("PRIMARY");

                entity.ToTable("stock_movimentos_directos_artigos");

                entity.HasIndex(e => e.MovStkArtCodigoArtigo)
                    .HasName("FK_MOVIMENTO_STOCK_ARTIGO_ARTIGO");

                entity.Property(e => e.MovStkArtCodigoMovimento)
                    .HasColumnName("MOV_STK_ART_CODIGO_MOVIMENTO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkArtCodigoArtigo)
                    .HasColumnName("MOV_STK_ART_CODIGO_ARTIGO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkArtCodigoArmazemFrom)
                    .HasColumnName("MOV_STK_ART_CODIGO_ARMAZEM_FROM")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkArtCodigoArmazemTo)
                    .HasColumnName("MOV_STK_ART_CODIGO_ARMAZEM_TO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkArtCreatedBy)
                    .HasColumnName("MOV_STK_ART_CREATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MovStkArtCreatedDate)
                    .HasColumnName("MOV_STK_ART_CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MovStkArtDataMovimento)
                    .HasColumnName("MOV_STK_ART_DATA_MOVIMENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MovStkArtExistencia)
                    .HasColumnName("MOV_STK_ART_EXISTENCIA")
                    .HasColumnType("decimal(18,1)");

                entity.Property(e => e.MovStkArtPrecoUnitario)
                    .HasColumnName("MOV_STK_ART_PRECO_UNITARIO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.MovStkArtQtdFinal)
                    .HasColumnName("MOV_STK_ART_QTD_FINAL")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.MovStkArtQuantidade)
                    .HasColumnName("MOV_STK_ART_QUANTIDADE")
                    .HasColumnType("decimal(18,5)");

                entity.Property(e => e.MovStkArtTipoMovimento)
                    .HasColumnName("MOV_STK_ART_TIPO_MOVIMENTO")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.MovStkArtUpdatedBy)
                    .HasColumnName("MOV_STK_ART_UPDATED_BY")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.MovStkArtUpdatedDate)
                    .HasColumnName("MOV_STK_ART_UPDATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.MovStkCodigoFilial)
                    .HasColumnName("MOV_STK_CODIGO_FILIAL")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkComposeId)
                    .HasColumnName("MOV_STK_COMPOSE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkContagemId)
                    .HasColumnName("MOV_STK_CONTAGEM_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkDataContagem)
                    .HasColumnName("MOV_STK_DATA_CONTAGEM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MovStkDocumentId)
                    .HasColumnName("MOV_STK_DOCUMENT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkDocumentType)
                    .HasColumnName("MOV_STK_DOCUMENT_TYPE")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkLoteId)
                    .HasColumnName("MOV_STK_LOTE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkSerialNumberId)
                    .HasColumnName("MOV_STK_SERIAL_NUMBER_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkSizeId)
                    .HasColumnName("MOV_STK_SIZE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MovStkStatus)
                    .HasColumnName("MOV_STK_STATUS")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.MovStkUltimoPrecoCusto)
                    .HasColumnName("MOV_STK_ULTIMO_PRECO_CUSTO")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.MovStkValorPc)
                    .HasColumnName("MOV_STK_VALOR_PC")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.MovStkValorPvp)
                    .HasColumnName("MOV_STK_VALOR_PVP")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(d => d.MovStkArtCodigoArtigoNavigation)
                    .WithMany(p => p.StockMovimentosDirectosArtigos)
                    .HasForeignKey(d => d.MovStkArtCodigoArtigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stock_movimentos_directos_artigos_ibfk_1");
            });
        }
    }
}
