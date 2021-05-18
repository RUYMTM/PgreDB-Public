using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;


#nullable disable

namespace PgreDB.Models
{
    public partial class ewiv2coreContext : DbContext
    {
        public ewiv2coreContext()
        {
        }

        public ewiv2coreContext(DbContextOptions<ewiv2coreContext> options)
            //: base(options)
        {
        }

        public virtual DbSet<AllInfoPvPlantV> AllInfoPvPlantVs { get; set; }
        public virtual DbSet<AllInfoWindParkV> AllInfoWindParkVs { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BaseStatusCooldown> BaseStatusCooldowns { get; set; }
        public virtual DbSet<BreakdownEvent> BreakdownEvents { get; set; }
        public virtual DbSet<Camera> Cameras { get; set; }
        public virtual DbSet<CameraForm> CameraForms { get; set; }
        public virtual DbSet<CameraImage> CameraImages { get; set; }
        public virtual DbSet<CameraPowerPlant> CameraPowerPlants { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyBankAccountNumber> CompanyBankAccountNumbers { get; set; }
        public virtual DbSet<ContactOldTodelete> ContactOldTodeletes { get; set; }
        public virtual DbSet<ContactPowerPlantOldTodelete> ContactPowerPlantOldTodeletes { get; set; }
        public virtual DbSet<CriticalWeatherEvent> CriticalWeatherEvents { get; set; }
        public virtual DbSet<DataExportForUsersV> DataExportForUsersVs { get; set; }
        public virtual DbSet<DataLogger> DataLoggers { get; set; }
        public virtual DbSet<DataLoggerPowerPlant> DataLoggerPowerPlants { get; set; }
        public virtual DbSet<DataLoggerRouter> DataLoggerRouters { get; set; }
        public virtual DbSet<DataLoggerStatus> DataLoggerStatuses { get; set; }
        public virtual DbSet<DataLoggerStatusCooldown> DataLoggerStatusCooldowns { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<DepositPowerPlant> DepositPowerPlants { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<EmailQueue> EmailQueues { get; set; }
        public virtual DbSet<EurHufExchangeRate> EurHufExchangeRates { get; set; }
        public virtual DbSet<EwiserUser> EwiserUsers { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FileCompany> FileCompanies { get; set; }
        public virtual DbSet<FilePowerPlant> FilePowerPlants { get; set; }
        public virtual DbSet<ForecastModel> ForecastModels { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<FormFile> FormFiles { get; set; }
        public virtual DbSet<HistBreakdownEvent> HistBreakdownEvents { get; set; }
        public virtual DbSet<HupxPrice> HupxPrices { get; set; }
        public virtual DbSet<ImageRecognition> ImageRecognitions { get; set; }
        public virtual DbSet<IntervalProduct> IntervalProducts { get; set; }
        public virtual DbSet<Inverter> Inverters { get; set; }
        public virtual DbSet<InverterEnergyYield> InverterEnergyYields { get; set; }
        public virtual DbSet<InverterManagementV> InverterManagementVs { get; set; }
        public virtual DbSet<InverterMeasurementEnoughDatum> InverterMeasurementEnoughData { get; set; }
        public virtual DbSet<InverterMonitoringMeasurementError> InverterMonitoringMeasurementErrors { get; set; }
        public virtual DbSet<InverterPowerControlCommand> InverterPowerControlCommands { get; set; }
        public virtual DbSet<InverterPowerControlCommandHistory> InverterPowerControlCommandHistories { get; set; }
        public virtual DbSet<InverterStatus> InverterStatuses { get; set; }
        public virtual DbSet<InverterStatusCooldown> InverterStatusCooldowns { get; set; }
        public virtual DbSet<InverterStatusDetailedV> InverterStatusDetailedVs { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceScheduleEmailQueue> InvoiceScheduleEmailQueues { get; set; }
        public virtual DbSet<ManualForecastOverwriteEvent> ManualForecastOverwriteEvents { get; set; }
        public virtual DbSet<MekIdentification> MekIdentifications { get; set; }
        public virtual DbSet<MekIdentificationGroup> MekIdentificationGroups { get; set; }
        public virtual DbSet<MekIdentificationGroupUnused> MekIdentificationGroupUnuseds { get; set; }
        public virtual DbSet<MekhId> MekhIds { get; set; }
        public virtual DbSet<MekhIdMekhSheet> MekhIdMekhSheets { get; set; }
        public virtual DbSet<MekhIdentification> MekhIdentifications { get; set; }
        public virtual DbSet<MekhIdentificationGroup> MekhIdentificationGroups { get; set; }
        public virtual DbSet<MekhIdentificationSheet> MekhIdentificationSheets { get; set; }
        public virtual DbSet<MekhReceivedSm> MekhReceivedSms { get; set; }
        public virtual DbSet<MekhScheduleEmailQueue> MekhScheduleEmailQueues { get; set; }
        public virtual DbSet<MekhSheet> MekhSheets { get; set; }
        public virtual DbSet<MeteringPointMeasurement> MeteringPointMeasurements { get; set; }
        public virtual DbSet<MobileTraffic> MobileTraffics { get; set; }
        public virtual DbSet<MolBidReport> MolBidReports { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<NotePowerPlant> NotePowerPlants { get; set; }
        public virtual DbSet<PostgresLog> PostgresLogs { get; set; }
        public virtual DbSet<PowerAdjustmentEvent> PowerAdjustmentEvents { get; set; }
        public virtual DbSet<PowerAdjustmentEventHist> PowerAdjustmentEventHists { get; set; }
        public virtual DbSet<PowerControlEnergy> PowerControlEnergies { get; set; }
        public virtual DbSet<PowerControlEnergyReferencePowerPlant> PowerControlEnergyReferencePowerPlants { get; set; }
        public virtual DbSet<PowerControlEvent> PowerControlEvents { get; set; }
        public virtual DbSet<PowerControlGroup> PowerControlGroups { get; set; }
        public virtual DbSet<PowerControlStateV> PowerControlStateVs { get; set; }
        public virtual DbSet<PowerControlStatusLog> PowerControlStatusLogs { get; set; }
        public virtual DbSet<PowerPlant> PowerPlants { get; set; }
        public virtual DbSet<PowerPlantMailAddress> PowerPlantMailAddresses { get; set; }
        public virtual DbSet<PowerPlantMonitoringSetting> PowerPlantMonitoringSettings { get; set; }
        public virtual DbSet<ProductionDataInvoice> ProductionDataInvoices { get; set; }
        public virtual DbSet<ProductionDatum> ProductionData { get; set; }
        public virtual DbSet<PvPlantGroupTempParamHistory> PvPlantGroupTempParamHistories { get; set; }
        public virtual DbSet<PvPlantPhysical> PvPlantPhysicals { get; set; }
        public virtual DbSet<PvPlantPhysicalLog> PvPlantPhysicalLogs { get; set; }
        public virtual DbSet<PvPlantTempParameter> PvPlantTempParameters { get; set; }
        public virtual DbSet<PvPlantTempParametersHistory> PvPlantTempParametersHistories { get; set; }
        public virtual DbSet<PvPlantTempParametersReadonly> PvPlantTempParametersReadonlies { get; set; }
        public virtual DbSet<RequestLog> RequestLogs { get; set; }
        public virtual DbSet<Router> Routers { get; set; }
        public virtual DbSet<RouterPowerPlant> RouterPowerPlants { get; set; }
        public virtual DbSet<RouterPowerPlantV> RouterPowerPlantVs { get; set; }
        public virtual DbSet<RouterV> RouterVs { get; set; }
        public virtual DbSet<ScheduleIdentification> ScheduleIdentifications { get; set; }
        public virtual DbSet<ScheduleIdentificationGroup> ScheduleIdentificationGroups { get; set; }
        public virtual DbSet<ScheduleIdentificationGroupUnused> ScheduleIdentificationGroupUnuseds { get; set; }
        public virtual DbSet<ScheduleItem> ScheduleItems { get; set; }
        public virtual DbSet<ScheduleVersion> ScheduleVersions { get; set; }
        public virtual DbSet<SchedulingIdentification> SchedulingIdentifications { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<SystemState> SystemStates { get; set; }
        public virtual DbSet<SystemStateForecast> SystemStateForecasts { get; set; }
        public virtual DbSet<TradingOfferVersion> TradingOfferVersions { get; set; }
        public virtual DbSet<TradingTactic> TradingTactics { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionItem> TransactionItems { get; set; }
        public virtual DbSet<UnassignedRoutersV> UnassignedRoutersVs { get; set; }
        public virtual DbSet<UserCompany> UserCompanies { get; set; }
        public virtual DbSet<UserPowerPlant> UserPowerPlants { get; set; }
        public virtual DbSet<UserScheduleIdentificationGroup> UserScheduleIdentificationGroups { get; set; }
        public virtual DbSet<Webcam> Webcams { get; set; }
        public virtual DbSet<WebcamPicture> WebcamPictures { get; set; }
        public virtual DbSet<WindParkPhysical> WindParkPhysicals { get; set; }
        public virtual DbSet<WindParkTempParameter> WindParkTempParameters { get; set; }
        public virtual DbSet<WindParkTempParametersReadonly> WindParkTempParametersReadonlies { get; set; }
        public virtual DbSet<Testtabla> Testtablas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=0.0.0.0;Database=Database;Username=user;Password=password;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasPostgresEnum(null, "vat_values_method", new[] { "AAM", "27", "5" })
                .HasPostgresExtension("pgcrypto")
                .HasAnnotation("Relational:Collation", "C.UTF-8");

            modelBuilder.Entity<AllInfoPvPlantV>(entity =>
            {
                entity.HasKey(e => e.PowerPlantId)
                    .HasName("power_plant_id_pv_unused_pkey");

                entity.ToTable("all_info_pv_plant_v");

                entity.Property(e => e.ActiveBilling).HasColumnName("active_billing");

                entity.Property(e => e.ActiveInverterMonitoring).HasColumnName("active_inverter_monitoring");

                entity.Property(e => e.ActiveMekh).HasColumnName("active_mekh");

                entity.Property(e => e.ActivePrediction).HasColumnName("active_prediction");

                entity.Property(e => e.CsoportFelhnev)
                    .HasMaxLength(64)
                    .HasColumnName("csoport_felhnev");

                entity.Property(e => e.DocumentCs)
                    .HasMaxLength(255)
                    .HasColumnName("document_cs");

                entity.Property(e => e.DocumentE)
                    .HasMaxLength(255)
                    .HasColumnName("document_e");

                entity.Property(e => e.DocumentSz)
                    .HasMaxLength(255)
                    .HasColumnName("document_sz");

                entity.Property(e => e.ElozoCsoportFelhnev)
                    .HasMaxLength(64)
                    .HasColumnName("elozo_csoport_felhnev");

                entity.Property(e => e.EromuNeve)
                    .HasMaxLength(255)
                    .HasColumnName("eromu_neve");

                entity.Property(e => e.EwiserAzonosito)
                    .HasMaxLength(255)
                    .HasColumnName("ewiser_azonosito");

                entity.Property(e => e.HivatalosTulajCegnev)
                    .HasMaxLength(255)
                    .HasColumnName("hivatalos_tulaj_cegnev");

                entity.Property(e => e.InverterMaxEfficiency).HasColumnName("inverter_max_efficiency");

                entity.Property(e => e.KatContractStartDate)
                    .HasColumnType("date")
                    .HasColumnName("kat_contract_start_date");

                entity.Property(e => e.KozvetitoCegnev)
                    .HasMaxLength(255)
                    .HasColumnName("kozvetito_cegnev");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.LocationCity)
                    .HasMaxLength(255)
                    .HasColumnName("location_city");

                entity.Property(e => e.LocationParcelNumber)
                    .HasMaxLength(40)
                    .HasColumnName("location_parcel_number");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.MekLastPasswordRenewingDate)
                    .HasColumnType("date")
                    .HasColumnName("mek_last_password_renewing_date");

                entity.Property(e => e.MekSendersTimeSeriesIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("mek_senders_time_series_identification");

                entity.Property(e => e.MekSendersTimeSeriesSequentialIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("mek_senders_time_series_sequential_identification");

                entity.Property(e => e.MekhId)
                    .HasMaxLength(255)
                    .HasColumnName("mekh_id");

                entity.Property(e => e.MeteringPointIdentification)
                    .HasMaxLength(128)
                    .HasColumnName("metering_point_identification");

                entity.Property(e => e.MkpSynced).HasColumnName("mkp_synced");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PvModuleNumber).HasColumnName("pv_module_number");

                entity.Property(e => e.PvModulePower).HasColumnName("pv_module_power");

                entity.Property(e => e.RealProductionStartDate)
                    .HasColumnType("date")
                    .HasColumnName("real_production_start_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_date");

                entity.Property(e => e.ScheduleDestination)
                    .HasMaxLength(32)
                    .HasColumnName("schedule_destination");

                entity.Property(e => e.ScheduleIdentificationGroupId).HasColumnName("schedule_identification_group_id");

                entity.Property(e => e.ScheduleIdentificationGroupPrevDate)
                    .HasColumnType("date")
                    .HasColumnName("schedule_identification_group_prev_date");

                entity.Property(e => e.ScheduleIdentificationGroupPrevId).HasColumnName("schedule_identification_group_prev_id");

                entity.Property(e => e.SzamalazasCegnev)
                    .HasMaxLength(255)
                    .HasColumnName("szamalazas_cegnev");

                entity.Property(e => e.TotalBaseFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("total_base_fee");

                entity.Property(e => e.TotalFeedInTariffFixFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("total_feed_in_tariff_fix_fee");

                entity.Property(e => e.TotalInverterPowerWatt).HasColumnName("total_inverter_power_watt");

                entity.Property(e => e.TotalSuccessFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("total_success_fee");

                entity.Property(e => e.Userek).HasColumnName("userek");

                entity.Property(e => e.UzemeltetoCegnev)
                    .HasMaxLength(255)
                    .HasColumnName("uzemelteto_cegnev");
            });

            modelBuilder.Entity<AllInfoWindParkV>(entity =>
            {
                entity.HasKey(e => e.PowerPlantId)
                    .HasName("power_plant_id_wind_unused_pkey");

                entity.ToTable("all_info_wind_park_v");

                entity.Property(e => e.ActiveBilling).HasColumnName("active_billing");

                entity.Property(e => e.ActiveInverterMonitoring).HasColumnName("active_inverter_monitoring");

                entity.Property(e => e.ActiveMekh).HasColumnName("active_mekh");

                entity.Property(e => e.ActivePrediction).HasColumnName("active_prediction");

                entity.Property(e => e.CsoportFelhnev)
                    .HasMaxLength(64)
                    .HasColumnName("csoport_felhnev");

                entity.Property(e => e.ElozoCsoportFelhnev)
                    .HasMaxLength(64)
                    .HasColumnName("elozo_csoport_felhnev");

                entity.Property(e => e.EromuNeve)
                    .HasMaxLength(255)
                    .HasColumnName("eromu_neve");

                entity.Property(e => e.EwiserAzonosito)
                    .HasMaxLength(255)
                    .HasColumnName("ewiser_azonosito");

                entity.Property(e => e.HivatalosTulajCegnev)
                    .HasMaxLength(255)
                    .HasColumnName("hivatalos_tulaj_cegnev");

                entity.Property(e => e.KatContractStartDate)
                    .HasColumnType("date")
                    .HasColumnName("kat_contract_start_date");

                entity.Property(e => e.KozvetitoCegnev)
                    .HasMaxLength(255)
                    .HasColumnName("kozvetito_cegnev");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.LocationCity)
                    .HasMaxLength(255)
                    .HasColumnName("location_city");

                entity.Property(e => e.LocationParcelNumber)
                    .HasMaxLength(40)
                    .HasColumnName("location_parcel_number");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.MekLastPasswordRenewingDate)
                    .HasColumnType("date")
                    .HasColumnName("mek_last_password_renewing_date");

                entity.Property(e => e.MekSendersTimeSeriesIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("mek_senders_time_series_identification");

                entity.Property(e => e.MekSendersTimeSeriesSequentialIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("mek_senders_time_series_sequential_identification");

                entity.Property(e => e.MekhId)
                    .HasMaxLength(255)
                    .HasColumnName("mekh_id");

                entity.Property(e => e.MeteringPointIdentification)
                    .HasMaxLength(128)
                    .HasColumnName("metering_point_identification");

                entity.Property(e => e.MkpSynced).HasColumnName("mkp_synced");

                entity.Property(e => e.PowerOutputWatt).HasColumnName("power_output_watt");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.RealProductionStartDate)
                    .HasColumnType("date")
                    .HasColumnName("real_production_start_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_date");

                entity.Property(e => e.ScheduleDestination)
                    .HasMaxLength(32)
                    .HasColumnName("schedule_destination");

                entity.Property(e => e.ScheduleIdentificationGroupId).HasColumnName("schedule_identification_group_id");

                entity.Property(e => e.ScheduleIdentificationGroupPrevDate)
                    .HasColumnType("date")
                    .HasColumnName("schedule_identification_group_prev_date");

                entity.Property(e => e.ScheduleIdentificationGroupPrevId).HasColumnName("schedule_identification_group_prev_id");

                entity.Property(e => e.SzamalazasCegnev)
                    .HasMaxLength(255)
                    .HasColumnName("szamalazas_cegnev");

                entity.Property(e => e.TotalBaseFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("total_base_fee");

                entity.Property(e => e.TotalFeedInTariffFixFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("total_feed_in_tariff_fix_fee");

                entity.Property(e => e.TotalSuccessFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("total_success_fee");

                entity.Property(e => e.Userek).HasColumnName("userek");

                entity.Property(e => e.UzemeltetoCegnev)
                    .HasMaxLength(255)
                    .HasColumnName("uzemelteto_cegnev");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("bank");

                entity.HasIndex(e => e.BankId, "banks_bank_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "banks_name_uindex")
                    .IsUnique();

                entity.Property(e => e.BankId)
                    .HasColumnName("bank_id")
                    .HasDefaultValueSql("nextval('banks_bank_id_seq'::regclass)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BaseStatusCooldown>(entity =>
            {
                entity.ToTable("base_status_cooldown");

                entity.Property(e => e.BaseStatusCooldownId)
                    .HasColumnName("base_status_cooldown_id")
                    .HasDefaultValueSql("nextval('base_status_cooldown_id_seq'::regclass)");

                entity.Property(e => e.CooldownSec).HasColumnName("cooldown_sec");

                entity.Property(e => e.MaxStack).HasColumnName("max_stack");

                entity.Property(e => e.Multiplier).HasColumnName("multiplier");

                entity.Property(e => e.StatusCode).HasColumnName("status_code");
            });

            modelBuilder.Entity<BreakdownEvent>(entity =>
            {
                entity.ToTable("breakdown_event");

                entity.Property(e => e.BreakdownEventId).HasColumnName("breakdown_event_id");

                entity.Property(e => e.BreakdownPowerWatt).HasColumnName("breakdown_power_watt");

                entity.Property(e => e.CreationMode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("creation_mode");

                entity.Property(e => e.EditMode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("edit_mode");

                entity.Property(e => e.EndDatetime).HasColumnName("end_datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("note")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.StartDatetime).HasColumnName("start_datetime");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.BreakdownEvents)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_breakdown_event_power_plant_id");
            });

            modelBuilder.Entity<Camera>(entity =>
            {
                entity.ToTable("camera");

                entity.HasIndex(e => e.CameraId, "camera_n_camera_id_uindex")
                    .IsUnique();

                entity.Property(e => e.CameraId).HasColumnName("camera_id");

                entity.Property(e => e.Attempt)
                    .HasColumnName("attempt")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BaseUrl)
                    .HasMaxLength(191)
                    .HasColumnName("base_url");

                entity.Property(e => e.Channel)
                    .HasMaxLength(191)
                    .HasColumnName("channel");

                entity.Property(e => e.City)
                    .HasMaxLength(191)
                    .HasColumnName("city")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Country)
                    .HasColumnType("character varying")
                    .HasColumnName("country");

                entity.Property(e => e.DailyAttempt)
                    .HasColumnName("daily_attempt")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeleteReason)
                    .HasMaxLength(255)
                    .HasColumnName("delete_reason")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.GpsLat)
                    .HasMaxLength(191)
                    .HasColumnName("gps_lat");

                entity.Property(e => e.GpsLon)
                    .HasMaxLength(191)
                    .HasColumnName("gps_lon");

                entity.Property(e => e.LastError).HasColumnName("last_error");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Nn).HasColumnName("nn");

                entity.Property(e => e.NnUrl)
                    .HasColumnType("character varying")
                    .HasColumnName("nn_url");

                entity.Property(e => e.Note)
                    .HasMaxLength(191)
                    .HasColumnName("note")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.OnlyObservation)
                    .HasColumnName("only_observation")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Onvif)
                    .HasColumnName("onvif")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Password)
                    .HasMaxLength(191)
                    .HasColumnName("password");

                entity.Property(e => e.Resolution)
                    .HasMaxLength(191)
                    .HasColumnName("resolution");

                entity.Property(e => e.Rtsp)
                    .HasColumnName("rtsp")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.Username)
                    .HasMaxLength(191)
                    .HasColumnName("username");

                entity.Property(e => e.Version)
                    .HasMaxLength(191)
                    .HasColumnName("version")
                    .HasDefaultValueSql("NULL::character varying");
            });

            modelBuilder.Entity<Testtabla>(entity =>
            {
                entity.ToTable("testtabla");

                entity.HasIndex(e => e.TesttablaId, "uq_testtabla_id")
                    .IsUnique();

                entity.Property(e => e.TesttablaId)
                    .HasColumnName("testtabla_id")
                    .HasDefaultValueSql("nextval('testtabla_seq'::regclass)");

                entity.Property(e => e.DataDirection)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("data_direction");

                entity.Property(e => e.Kibibytes)
                    .HasPrecision(16)
                    .HasColumnName("kibibytes");

                entity.Property(e => e.UsageDate)
                    .HasColumnType("date")
                    .HasColumnName("usage_date");
            });

            modelBuilder.Entity<CameraForm>(entity =>
            {
                entity.ToTable("camera_form");

                entity.HasIndex(e => e.CameraFormId, "camera_form_camera_form_id_uindex")
                    .IsUnique();

                entity.Property(e => e.CameraFormId).HasColumnName("camera_form_id");

                entity.Property(e => e.AssignedUserId).HasColumnName("assigned_user_id");

                entity.Property(e => e.CameraPassword)
                    .HasMaxLength(191)
                    .HasColumnName("camera_password");

                entity.Property(e => e.CameraType)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("camera_type");

                entity.Property(e => e.CameraUrl)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("camera_url");

                entity.Property(e => e.CameraUsername)
                    .HasMaxLength(191)
                    .HasColumnName("camera_username");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("company");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DevLog).HasColumnName("dev_log");

                entity.Property(e => e.Hash)
                    .HasMaxLength(191)
                    .HasColumnName("hash");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("location");

                entity.Property(e => e.OwnerEmail)
                    .HasMaxLength(191)
                    .HasColumnName("owner_email");

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("owner_name");

                entity.Property(e => e.OwnerPhone)
                    .HasMaxLength(191)
                    .HasColumnName("owner_phone");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<CameraImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("camera_image");

                entity.HasIndex(e => e.CameraImageId, "camera_picture_camera_picture_id_uindex")
                    .IsUnique();

                entity.Property(e => e.AssignedToUserId).HasColumnName("assigned_to_user_id");

                entity.Property(e => e.CameraId).HasColumnName("camera_id");

                entity.Property(e => e.CameraImageId)
                    .HasColumnName("camera_image_id")
                    .HasDefaultValueSql("nextval('camera_picture_camera_picture_id_seq'::regclass)");

                entity.Property(e => e.CameraWeatherType)
                    .HasMaxLength(191)
                    .HasColumnName("camera_weather_type");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.FileLocation)
                    .HasMaxLength(191)
                    .HasColumnName("file_location");

                entity.Property(e => e.SizeInKb).HasColumnName("size_in_kb");

                entity.Property(e => e.StoragePath)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("storage_path");

                entity.Property(e => e.StorageType)
                    .HasMaxLength(191)
                    .HasColumnName("storage_type");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<CameraPowerPlant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("camera_power_plant");

                entity.Property(e => e.CameraId).HasColumnName("camera_id");

                entity.Property(e => e.CameraPowerPlantId)
                    .HasColumnName("camera_power_plant_id")
                    .HasDefaultValueSql("nextval('camera_power_plant_id_seq'::regclass)");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.HasIndex(e => e.Name, "idx_company_name");

                entity.HasIndex(e => e.BusinessNumber, "uq_company_business_number")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "uq_company_name")
                    .IsUnique();

                entity.HasIndex(e => e.ShortName, "uq_company_short_name")
                    .IsUnique();

                entity.HasIndex(e => e.TaxNumber, "uq_company_taxnumber")
                    .IsUnique();

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.BillingAddress)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasColumnName("billing_address");

                entity.Property(e => e.BillingCity)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("billing_city");

                entity.Property(e => e.BillingName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("billing_name");

                entity.Property(e => e.BillingZip)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("billing_zip");

                entity.Property(e => e.BusinessNumber)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("business_number");

                entity.Property(e => e.CashmanNavInvoice)
                    .HasColumnName("cashman_nav_invoice")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CashmanUsergroup)
                    .HasMaxLength(255)
                    .HasColumnName("cashman_usergroup");

                entity.Property(e => e.CompanyReferenceId)
                    .HasMaxLength(10)
                    .HasColumnName("company_reference_id");

                entity.Property(e => e.Country)
                    .HasMaxLength(191)
                    .HasColumnName("country")
                    .HasDefaultValueSql("'hu'::character varying");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.GroupTaxNumber)
                    .HasMaxLength(191)
                    .HasColumnName("group_tax_number")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.InvoiceBankAccountNumber)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_bank_account_number")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.InvoiceBankName)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_bank_name")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.InvoiceCustomNote)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_custom_note");

                entity.Property(e => e.InvoiceDeadline)
                    .HasColumnName("invoice_deadline")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.InvoiceSoftware)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_software")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.LastSynced).HasColumnName("last_synced");

                entity.Property(e => e.MailAddress)
                    .HasMaxLength(1024)
                    .HasColumnName("mail_address");

                entity.Property(e => e.MailCity)
                    .HasMaxLength(255)
                    .HasColumnName("mail_city");

                entity.Property(e => e.MailName)
                    .HasMaxLength(255)
                    .HasColumnName("mail_name");

                entity.Property(e => e.MailZip)
                    .HasMaxLength(64)
                    .HasColumnName("mail_zip");

                entity.Property(e => e.MekhId)
                    .HasMaxLength(255)
                    .HasColumnName("mekh_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("short_name");

                entity.Property(e => e.SyncedBankAccountNumber)
                    .HasColumnName("synced_bank_account_number")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.TaxNumber)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tax_number");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_company_ewiser_user");
            });

            modelBuilder.Entity<CompanyBankAccountNumber>(entity =>
            {
                entity.ToTable("company_bank_account_number");

                entity.HasIndex(e => e.CompanyBankAccountNumberId, "company_bank_account_number_company_bank_account_number_id_uind")
                    .IsUnique();

                entity.Property(e => e.CompanyBankAccountNumberId).HasColumnName("company_bank_account_number_id");

                entity.Property(e => e.BankId).HasColumnName("bank_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<ContactOldTodelete>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("contact_pkey");

                entity.ToTable("contact_old_todelete");

                entity.HasIndex(e => new { e.Name, e.Email }, "uq_contact_nameemail")
                    .IsUnique();

                entity.HasIndex(e => new { e.Name, e.Tel }, "uq_contact_nametel")
                    .IsUnique();

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasDefaultValueSql("nextval('contact_contact_id_seq'::regclass)");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.DefaultLanguage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("default_language")
                    .HasDefaultValueSql("'Hungarian'::character varying");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("tel")
                    .HasDefaultValueSql("'-'::character varying");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.ContactOldTodeletes)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contact_ewiser_user");
            });

            modelBuilder.Entity<ContactPowerPlantOldTodelete>(entity =>
            {
                entity.HasKey(e => e.ContactPowerPlantId)
                    .HasName("contact_power_plant_pkey");

                entity.ToTable("contact_power_plant_old_todelete");

                entity.HasIndex(e => new { e.PowerPlantId, e.ContactId }, "uq_contact_power_plant")
                    .IsUnique();

                entity.HasIndex(e => new { e.PowerPlantId, e.ContactId }, "uq_contact_power_plant_power_plant_id_contact_id")
                    .IsUnique();

                entity.Property(e => e.ContactPowerPlantId)
                    .HasColumnName("contact_power_plant_id")
                    .HasDefaultValueSql("nextval('contact_power_plant_contact_power_plant_id_seq'::regclass)");

                entity.Property(e => e.ActiveBillingNotification)
                    .IsRequired()
                    .HasColumnName("active_billing_notification")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActiveBillingPostNotification)
                    .IsRequired()
                    .HasColumnName("active_billing_post_notification")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActiveBillingSampleNotification)
                    .IsRequired()
                    .HasColumnName("active_billing_sample_notification")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActiveDatasheetNotification)
                    .IsRequired()
                    .HasColumnName("active_datasheet_notification")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActiveDatasheetSampleNotification)
                    .IsRequired()
                    .HasColumnName("active_datasheet_sample_notification")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActiveEwiserPayoff)
                    .IsRequired()
                    .HasColumnName("active_ewiser_payoff")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActiveInverterMonitoringErrorNotification)
                    .IsRequired()
                    .HasColumnName("active_inverter_monitoring_error_notification")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActiveInverterMonitoringMonthlyPdf)
                    .IsRequired()
                    .HasColumnName("active_inverter_monitoring_monthly_pdf")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActiveScheduleNotification)
                    .IsRequired()
                    .HasColumnName("active_schedule_notification")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactPowerPlantOldTodeletes)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contact_power_plant_contact");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.ContactPowerPlantOldTodeletes)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contact_power_plant_power_plant");
            });

            modelBuilder.Entity<CriticalWeatherEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("critical_weather_event");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("country");

                entity.Property(e => e.CreationTimestamp).HasColumnName("creation_timestamp");

                entity.Property(e => e.CriticalWeatherEventId)
                    .HasColumnName("critical_weather_event_id")
                    .HasDefaultValueSql("nextval('image_recognition_id_seq'::regclass)");

                entity.Property(e => e.EndDatetime).HasColumnName("end_datetime");

                entity.Property(e => e.StartDatetime).HasColumnName("start_datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DataExportForUsersV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_export_for_users_v");

                entity.Property(e => e.BatteryOnSite).HasColumnName("battery_on_site");

                entity.Property(e => e.City)
                    .HasMaxLength(64)
                    .HasColumnName("city");

                entity.Property(e => e.DataLoggerIps).HasColumnName("data_logger_ips");

                entity.Property(e => e.DataLoggerType)
                    .HasMaxLength(24)
                    .HasColumnName("data_logger_type");

                entity.Property(e => e.EromuNeve)
                    .HasMaxLength(255)
                    .HasColumnName("eromu_neve");

                entity.Property(e => e.EwiserAzonosito)
                    .HasMaxLength(255)
                    .HasColumnName("ewiser_azonosito");

                entity.Property(e => e.ExactLocation)
                    .HasMaxLength(255)
                    .HasColumnName("exact_location");

                entity.Property(e => e.InstallationDate)
                    .HasColumnType("date")
                    .HasColumnName("installation_date");

                entity.Property(e => e.InverterCount).HasColumnName("inverter_count");

                entity.Property(e => e.InverterNames).HasColumnName("inverter_names");

                entity.Property(e => e.KatContractStartDate)
                    .HasColumnType("date")
                    .HasColumnName("kat_contract_start_date");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.LocationCity)
                    .HasMaxLength(255)
                    .HasColumnName("location_city");

                entity.Property(e => e.LocationParcelNumber)
                    .HasMaxLength(40)
                    .HasColumnName("location_parcel_number");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.MekhId)
                    .HasMaxLength(255)
                    .HasColumnName("mekh_id");

                entity.Property(e => e.MeteringPointIdentification)
                    .HasMaxLength(128)
                    .HasColumnName("metering_point_identification");

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .HasColumnName("model");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.ProsumerMaxValueW).HasColumnName("prosumer_max_value_w");

                entity.Property(e => e.PvModuleNumber).HasColumnName("pv_module_number");

                entity.Property(e => e.PvModulePower).HasColumnName("pv_module_power");

                entity.Property(e => e.RealProductionStartDate)
                    .HasColumnType("date")
                    .HasColumnName("real_production_start_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_date");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.Property(e => e.Subdomain)
                    .HasMaxLength(64)
                    .HasColumnName("subdomain");

                entity.Property(e => e.Userek).HasColumnName("userek");

                entity.Property(e => e.WifiPassword)
                    .HasMaxLength(255)
                    .HasColumnName("wifi_password");

                entity.Property(e => e.WifiSsid)
                    .HasMaxLength(255)
                    .HasColumnName("wifi_ssid");
            });

            modelBuilder.Entity<DataLogger>(entity =>
            {
                entity.ToTable("data_logger");

                entity.HasIndex(e => e.ModbusManagerDeviceId, "data_logger_modbus_manager_device_id_uindex")
                    .IsUnique();

                entity.Property(e => e.DataLoggerId)
                    .HasColumnName("data_logger_id")
                    .HasDefaultValueSql("nextval('vpp_vpp_id_seq'::regclass)");

                entity.Property(e => e.Apikey)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("apikey")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.CameraUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("camera_url")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment");

                entity.Property(e => e.ConnectionType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("connection_type")
                    .HasDefaultValueSql("'UNKNOWN'::character varying");

                entity.Property(e => e.DataLoggerType)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("data_logger_type")
                    .HasDefaultValueSql("'UNKNOWN'::character varying");

                entity.Property(e => e.DateTimeZone)
                    .HasMaxLength(32)
                    .HasColumnName("date_time_zone")
                    .HasDefaultValueSql("'Europe/Budapest'::character varying");

                entity.Property(e => e.EnergyDivergenceLimit)
                    .HasColumnName("energy_divergence_limit")
                    .HasDefaultValueSql("0.2");

                entity.Property(e => e.HttpPullDeviceId).HasColumnName("http_pull_device_id");

                entity.Property(e => e.InverterMonthlyEnergyDivergenceLimit)
                    .HasColumnName("inverter_monthly_energy_divergence_limit")
                    .HasDefaultValueSql("0.15");

                entity.Property(e => e.KofUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("kof_url")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.MaxTempDivergenceLimit)
                    .HasColumnName("max_temp_divergence_limit")
                    .HasDefaultValueSql("15");

                entity.Property(e => e.ModbusManagerDeviceId).HasColumnName("modbus_manager_device_id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.PowerAdjustmentAvailable)
                    .HasColumnName("power_adjustment_available")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PowerDivergenceLimit)
                    .HasColumnName("power_divergence_limit")
                    .HasDefaultValueSql("0.05");

                entity.Property(e => e.RemotePath)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("remote_path")
                    .HasDefaultValueSql("'/'::character varying");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''::character varying");

                entity.HasOne(d => d.HttpPullDevice)
                    .WithMany(p => p.DataLoggerHttpPullDevices)
                    .HasForeignKey(d => d.HttpPullDeviceId)
                    .HasConstraintName("fk_http_pull_device_id");

                entity.HasOne(d => d.ModbusManagerDevice)
                    .WithOne(p => p.DataLoggerModbusManagerDevice)
                    .HasForeignKey<DataLogger>(d => d.ModbusManagerDeviceId)
                    .HasConstraintName("fk_modbus_manager_device_id");
            });

            modelBuilder.Entity<DataLoggerPowerPlant>(entity =>
            {
                entity.ToTable("data_logger_power_plant");

                entity.Property(e => e.DataLoggerPowerPlantId)
                    .HasColumnName("data_logger_power_plant_id")
                    .HasDefaultValueSql("nextval('vpp_power_plant_id_seq'::regclass)");

                entity.Property(e => e.DataLoggerId).HasColumnName("data_logger_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.HasOne(d => d.DataLogger)
                    .WithMany(p => p.DataLoggerPowerPlants)
                    .HasForeignKey(d => d.DataLoggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_data_logger_power_plant_01");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.DataLoggerPowerPlants)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_data_logger_power_plant_02");
            });

            modelBuilder.Entity<DataLoggerRouter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_logger_router");

                entity.Property(e => e.DataLoggerId).HasColumnName("data_logger_id");

                entity.Property(e => e.DataLoggerRouterId).HasColumnName("data_logger_router_id");

                entity.Property(e => e.Routerid).HasColumnName("routerid");
            });

            modelBuilder.Entity<DataLoggerStatus>(entity =>
            {
                entity.ToTable("data_logger_status");

                entity.Property(e => e.DataLoggerStatusId)
                    .HasColumnName("data_logger_status_id")
                    .HasDefaultValueSql("nextval('vpp_status_id_seq'::regclass)");

                entity.Property(e => e.DataLoggerId).HasColumnName("data_logger_id");

                entity.Property(e => e.DateStamp)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("date_stamp");

                entity.Property(e => e.Reached).HasColumnName("reached");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("status");

                entity.HasOne(d => d.DataLogger)
                    .WithMany(p => p.DataLoggerStatuses)
                    .HasForeignKey(d => d.DataLoggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_data_logger_status_data_logger");
            });

            modelBuilder.Entity<DataLoggerStatusCooldown>(entity =>
            {
                entity.ToTable("data_logger_status_cooldown");

                entity.Property(e => e.DataLoggerStatusCooldownId)
                    .HasColumnName("data_logger_status_cooldown_id")
                    .HasDefaultValueSql("nextval('vpp_status_cooldown_id_seq'::regclass)");

                entity.Property(e => e.CurrentStack).HasColumnName("current_stack");

                entity.Property(e => e.DataLoggerId).HasColumnName("data_logger_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.StatusCode).HasColumnName("status_code");

                entity.HasOne(d => d.DataLogger)
                    .WithMany(p => p.DataLoggerStatusCooldowns)
                    .HasForeignKey(d => d.DataLoggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_data_logger_status_cooldown_data_logger");
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.ToTable("deposit");

                entity.HasIndex(e => e.DepositId, "deposit_deposit_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.DepositId, "deposit_deposit_id_uindex_2")
                    .IsUnique();

                entity.Property(e => e.DepositId).HasColumnName("deposit_id");

                entity.Property(e => e.BankTransactionId)
                    .HasMaxLength(191)
                    .HasColumnName("bank_transaction_id");

                entity.Property(e => e.GrossSummaryValue).HasColumnName("gross_summary_value");

                entity.Property(e => e.PayingCompanyId).HasColumnName("paying_company_id");

                entity.Property(e => e.Received).HasColumnName("received");

                entity.Property(e => e.TransferedToMavir).HasColumnName("transfered_to_mavir");
            });

            modelBuilder.Entity<DepositPowerPlant>(entity =>
            {
                entity.ToTable("deposit_power_plant");

                entity.HasIndex(e => e.DepositPowerPlantId, "deposit_power_plant_deposit_power_plant_id_uindex")
                    .IsUnique();

                entity.Property(e => e.DepositPowerPlantId).HasColumnName("deposit_power_plant_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DepositId).HasColumnName("deposit_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Deposit)
                    .WithMany(p => p.DepositPowerPlants)
                    .HasForeignKey(d => d.DepositId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deposit_power_plant_deposit_deposit_id_fk");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.DepositPowerPlants)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deposit_power_plant_power_plant_power_plant_id_fk");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("device");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("device_id")
                    .HasDefaultValueSql("nextval('device_id_seq'::regclass)");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DeviceType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("device_type");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("ip_address");

                entity.Property(e => e.IpPort).HasColumnName("ip_port");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .HasColumnName("password");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(64)
                    .HasColumnName("username");

                entity.HasOne(d => d.Router)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.RouterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_router_id");
            });

            modelBuilder.Entity<EmailQueue>(entity =>
            {
                entity.ToTable("email_queue");

                entity.HasIndex(e => e.EmailQueueId, "email_queue_email_queue_uindex")
                    .IsUnique();

                entity.Property(e => e.EmailQueueId)
                    .HasColumnName("email_queue_id")
                    .HasDefaultValueSql("nextval('email_queue_email_queue_seq'::regclass)");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.EwiserUserId).HasColumnName("ewiser_user_id");

                entity.Property(e => e.NotifiedAt).HasColumnName("notified_at");

                entity.Property(e => e.SendAt).HasColumnName("send_at");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UniqueId).HasColumnName("unique_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<EurHufExchangeRate>(entity =>
            {
                entity.ToTable("eur_huf_exchange_rate");

                entity.HasIndex(e => new { e.StartTime, e.EndTime }, "uq_eur_huf_exchange_rate")
                    .IsUnique();

                entity.Property(e => e.EurHufExchangeRateId)
                    .HasColumnName("eur_huf_exchange_rate_id")
                    .HasDefaultValueSql("nextval('eur_huf_exchange_rate_id_seq'::regclass)");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Rate)
                    .HasPrecision(11, 2)
                    .HasColumnName("rate");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("resolution");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<EwiserUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("ewiser_user_pkey");

                entity.ToTable("ewiser_user");

                entity.HasIndex(e => e.Email, "uq_ewiser_user_email")
                    .IsUnique();

                entity.HasIndex(e => e.EwiserauthUuid, "uq_ewiser_user_ewiserauth_uuid")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreatorUserId)
                    .HasColumnName("creator_user_id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DefaultLanguage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("default_language")
                    .HasDefaultValueSql("'Hungarian'::character varying");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.EwiserauthUuid)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ewiserauth_uuid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("tel")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.UserRole)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("user_role")
                    .HasDefaultValueSql("'Basic'::character varying");

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InverseCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ewiser_user_creator_user_id");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.ToTable("file");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("hash");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("path");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Subtype)
                    .HasMaxLength(100)
                    .HasColumnName("subtype");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<FileCompany>(entity =>
            {
                entity.ToTable("file_company");

                entity.Property(e => e.FileCompanyId).HasColumnName("file_company_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.PhysicallyExists)
                    .HasColumnName("physically_exists")
                    .HasDefaultValueSql("false");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.FileCompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_company_company_id_foreign");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.FileCompanies)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_company_file_id_foreign");
            });

            modelBuilder.Entity<FilePowerPlant>(entity =>
            {
                entity.ToTable("file_power_plant");

                entity.Property(e => e.FilePowerPlantId).HasColumnName("file_power_plant_id");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.FilePowerPlants)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_power_plant_file_id_foreign");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.FilePowerPlants)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("file_power_plant_power_plant_id_foreign");
            });

            modelBuilder.Entity<ForecastModel>(entity =>
            {
                entity.ToTable("forecast_model");

                entity.HasIndex(e => e.ForecastModelId, "forecast_model_forecast_model_id_uindex")
                    .IsUnique();

                entity.Property(e => e.ForecastModelId)
                    .HasColumnName("forecast_model_id")
                    .HasDefaultValueSql("nextval('forecast_model_id_seq'::regclass)");

                entity.Property(e => e.BalanceGroupType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("balance_group_type");

                entity.Property(e => e.Booster).HasColumnName("booster");

                entity.Property(e => e.CalculationType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("calculation_type");

                entity.Property(e => e.CountryType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("country_type");

                entity.Property(e => e.HistCreationDatetime)
                    .HasColumnName("hist_creation_datetime")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LeadTimeMin).HasColumnName("lead_time_min");

                entity.Property(e => e.PowerValueUnit)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("power_value_unit");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("resolution");

                entity.Property(e => e.ScheduleIdentificationGroupId).HasColumnName("schedule_identification_group_id");

                entity.HasOne(d => d.ScheduleIdentificationGroup)
                    .WithMany(p => p.ForecastModels)
                    .HasForeignKey(d => d.ScheduleIdentificationGroupId)
                    .HasConstraintName("fk_forecast_model_sig_id");
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.ToTable("form");

                entity.HasIndex(e => e.Hash, "form_hash_uindex")
                    .IsUnique();

                entity.Property(e => e.FormId).HasColumnName("form_id");

                entity.Property(e => e.AdminFields)
                    .HasColumnType("json")
                    .HasColumnName("admin_fields");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .HasColumnName("comment");

                entity.Property(e => e.Contacts)
                    .HasColumnType("json")
                    .HasColumnName("contacts");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Deadline)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("deadline");

                entity.Property(e => e.Fields)
                    .HasColumnType("json")
                    .HasColumnName("fields");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("hash");

                entity.Property(e => e.InvoiceFields)
                    .HasColumnType("json")
                    .HasColumnName("invoice_fields")
                    .HasDefaultValueSql("'{\"email\": \"\", \"password\": \"\", \"public_key\": \"\", \"private_key\": \"\", \"justpattern\": \"off\"}'::json");

                entity.Property(e => e.KatId)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("kat_id");

                entity.Property(e => e.Notified)
                    .HasColumnName("notified")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.Registered)
                    .HasColumnName("registered")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SentAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("sent_at");

                entity.Property(e => e.Synced)
                    .HasColumnName("synced")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.FormCreators)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("form_creator_id_foreign");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.FormOwners)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("form_owner_id_foreign");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.Forms)
                    .HasForeignKey(d => d.PowerPlantId)
                    .HasConstraintName("fk_form_power_plant");
            });

            modelBuilder.Entity<FormFile>(entity =>
            {
                entity.ToTable("form_files");

                entity.Property(e => e.FormFileId).HasColumnName("form_file_id");

                entity.Property(e => e.Confirmed)
                    .HasColumnName("confirmed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.FormId).HasColumnName("form_id");

                entity.Property(e => e.Hash)
                    .HasColumnType("character varying")
                    .HasColumnName("hash");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("path");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.FormFiles)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("form_files_form_id_foreign");
            });

            modelBuilder.Entity<HistBreakdownEvent>(entity =>
            {
                entity.ToTable("hist_breakdown_event");

                entity.Property(e => e.HistBreakdownEventId)
                    .HasColumnName("hist_breakdown_event_id")
                    .HasDefaultValueSql("nextval('hist_breakdown_event_id_seq'::regclass)");

                entity.Property(e => e.BreakdownEventId)
                    .HasColumnName("breakdown_event_id")
                    .HasDefaultValueSql("nextval('breakdown_event_breakdown_event_id_seq'::regclass)");

                entity.Property(e => e.BreakdownPowerWatt).HasColumnName("breakdown_power_watt");

                entity.Property(e => e.CreationMode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("creation_mode");

                entity.Property(e => e.EditMode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("edit_mode");

                entity.Property(e => e.EndDatetime).HasColumnName("end_datetime");

                entity.Property(e => e.HistCreationDatetime).HasColumnName("hist_creation_datetime");

                entity.Property(e => e.HistOperation)
                    .HasMaxLength(1)
                    .HasColumnName("hist_operation");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .HasColumnName("note")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.StartDatetime).HasColumnName("start_datetime");

                entity.HasOne(d => d.BreakdownEvent)
                    .WithMany(p => p.HistBreakdownEvents)
                    .HasForeignKey(d => d.BreakdownEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_hist_breakdown_event_breakdown_event_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.HistBreakdownEvents)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_hist_breakdown_event_power_plant_id");
            });

            modelBuilder.Entity<HupxPrice>(entity =>
            {
                entity.ToTable("hupx_price");

                entity.HasIndex(e => new { e.StartTime, e.EndTime }, "uq_hupx_price")
                    .IsUnique();

                entity.Property(e => e.HupxPriceId).HasColumnName("hupx_price_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Price)
                    .HasPrecision(11, 2)
                    .HasColumnName("price");

                entity.Property(e => e.PriceUnit)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("price_unit");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("resolution");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<ImageRecognition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("image_recognition");

                entity.Property(e => e.Activation).HasColumnName("activation");

                entity.Property(e => e.CameraId).HasColumnName("camera_id");

                entity.Property(e => e.CameraImageId).HasColumnName("camera_image_id");

                entity.Property(e => e.Country)
                    .HasColumnType("character varying")
                    .HasColumnName("country");

                entity.Property(e => e.HistCreationDatetime).HasColumnName("hist_creation_datetime");

                entity.Property(e => e.ImageRecognitionId)
                    .HasColumnName("image_recognition_id")
                    .HasDefaultValueSql("nextval('image_recognition_id_seq'::regclass)");

                entity.Property(e => e.LeadTimeMin).HasColumnName("lead_time_min");

                entity.Property(e => e.PowerFactorDifference).HasColumnName("power_factor_difference");

                entity.Property(e => e.RecogPowerFactor).HasColumnName("recog_power_factor");

                entity.Property(e => e.RecognisedWeatherType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("recognised_weather_type");

                entity.Property(e => e.WeatherForecastPowerFactor).HasColumnName("weather_forecast_power_factor");

                entity.Property(e => e.WeatherForecastWeatherType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("weather_forecast_weather_type");
            });

            modelBuilder.Entity<IntervalProduct>(entity =>
            {
                entity.ToTable("interval_product");

                entity.HasIndex(e => new { e.PowerControlGroupId, e.StartTime, e.EndTime, e.Resolution }, "uq_interval_product")
                    .IsUnique();

                entity.Property(e => e.IntervalProductId)
                    .HasColumnName("interval_product_id")
                    .HasDefaultValueSql("nextval('interval_product_id_seq'::regclass)");

                entity.Property(e => e.Edited)
                    .HasColumnName("edited")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.MarketPriceHuf)
                    .HasPrecision(8, 1)
                    .HasColumnName("market_price_huf");

                entity.Property(e => e.MarketPriceUnit)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("market_price_unit");

                entity.Property(e => e.PowerControlGroupId).HasColumnName("power_control_group_id");

                entity.Property(e => e.Quantity)
                    .HasPrecision(6, 2)
                    .HasColumnName("quantity");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("resolution");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.Status)
                    .HasPrecision(2)
                    .HasColumnName("status");

                entity.Property(e => e.TechnicalLimit)
                    .HasPrecision(6, 2)
                    .HasColumnName("technical_limit");

                entity.HasOne(d => d.PowerControlGroup)
                    .WithMany(p => p.IntervalProducts)
                    .HasForeignKey(d => d.PowerControlGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_interval_product_pcg");
            });

            modelBuilder.Entity<Inverter>(entity =>
            {
                entity.ToTable("inverter");

                entity.Property(e => e.InverterId)
                    .HasColumnName("inverter_id")
                    .HasDefaultValueSql("nextval('inverter_id_seq'::regclass)");

                entity.Property(e => e.AvailableTotalAcPower).HasColumnName("available_total_ac_power");

                entity.Property(e => e.Controllable)
                    .IsRequired()
                    .HasColumnName("controllable")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DataLoggerId).HasColumnName("data_logger_id");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.MaxAllowedAcPower).HasColumnName("max_allowed_ac_power");

                entity.Property(e => e.MeasurementPointNumber).HasColumnName("measurement_point_number");

                entity.Property(e => e.ModbusSlaveId).HasColumnName("modbus_slave_id");

                entity.Property(e => e.ModbusType)
                    .HasMaxLength(64)
                    .HasColumnName("modbus_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.NameByUser)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name_by_user");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.Producing)
                    .IsRequired()
                    .HasColumnName("producing")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PvModuleNumberJsonArray)
                    .IsRequired()
                    .HasMaxLength(192)
                    .HasColumnName("pv_module_number_json_array");

                entity.Property(e => e.RatedAcPower).HasColumnName("rated_ac_power");

                entity.Property(e => e.ReadyToWork).HasColumnName("ready_to_work");

                entity.HasOne(d => d.DataLogger)
                    .WithMany(p => p.Inverters)
                    .HasForeignKey(d => d.DataLoggerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inverter_data_logger");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.Inverters)
                    .HasForeignKey(d => d.PowerPlantId)
                    .HasConstraintName("fk_inverter_ppid");
            });

            modelBuilder.Entity<InverterEnergyYield>(entity =>
            {
                entity.ToTable("inverter_energy_yield");

                entity.HasIndex(e => new { e.InverterId, e.Timestamp, e.Type }, "uq_inverter_energy_yield_id_time_type")
                    .IsUnique();

                entity.Property(e => e.InverterEnergyYieldId)
                    .HasColumnName("inverter_energy_yield_id")
                    .HasDefaultValueSql("nextval('inverter_energy_yield_id_seq'::regclass)");

                entity.Property(e => e.EnergyYield)
                    .HasPrecision(16)
                    .HasColumnName("energy_yield");

                entity.Property(e => e.InverterId).HasColumnName("inverter_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("type");

                entity.HasOne(d => d.Inverter)
                    .WithMany(p => p.InverterEnergyYields)
                    .HasForeignKey(d => d.InverterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inverter_id");
            });

            modelBuilder.Entity<InverterManagementV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("inverter_management_v");

                entity.Property(e => e.AvailableTotalAcPower).HasColumnName("available_total_ac_power");

                entity.Property(e => e.City)
                    .HasMaxLength(64)
                    .HasColumnName("city");

                entity.Property(e => e.ConnectionType)
                    .HasMaxLength(10)
                    .HasColumnName("connection_type");

                entity.Property(e => e.DataLoggerId).HasColumnName("data_logger_id");

                entity.Property(e => e.DataLoggerType)
                    .HasMaxLength(24)
                    .HasColumnName("data_logger_type");

                entity.Property(e => e.Dataloggercomment)
                    .HasMaxLength(255)
                    .HasColumnName("dataloggercomment");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(255)
                    .HasColumnName("device_type");

                entity.Property(e => e.Devicecomment)
                    .HasMaxLength(255)
                    .HasColumnName("devicecomment");

                entity.Property(e => e.Deviceip)
                    .HasMaxLength(24)
                    .HasColumnName("deviceip");

                entity.Property(e => e.Devicename)
                    .HasMaxLength(255)
                    .HasColumnName("devicename");

                entity.Property(e => e.DevicesAdded).HasColumnName("devices_added");

                entity.Property(e => e.HttpPullDeviceId).HasColumnName("http_pull_device_id");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.InverterId).HasColumnName("inverter_id");

                entity.Property(e => e.Invertername)
                    .HasMaxLength(128)
                    .HasColumnName("invertername");

                entity.Property(e => e.IpPort).HasColumnName("ip_port");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LocationCity)
                    .HasMaxLength(255)
                    .HasColumnName("location_city");

                entity.Property(e => e.LocationParcelNumber)
                    .HasMaxLength(40)
                    .HasColumnName("location_parcel_number");

                entity.Property(e => e.MaxAllowedAcPower).HasColumnName("max_allowed_ac_power");

                entity.Property(e => e.MeasurementPointNumber).HasColumnName("measurement_point_number");

                entity.Property(e => e.ModbusManagerDeviceId).HasColumnName("modbus_manager_device_id");

                entity.Property(e => e.ModbusSlaveId).HasColumnName("modbus_slave_id");

                entity.Property(e => e.ModbusType)
                    .HasMaxLength(64)
                    .HasColumnName("modbus_type");

                entity.Property(e => e.NameByUser)
                    .HasMaxLength(128)
                    .HasColumnName("name_by_user");

                entity.Property(e => e.PowerAdjustmentAvailable).HasColumnName("power_adjustment_available");

                entity.Property(e => e.PowerControlGroupId).HasColumnName("power_control_group_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PowerPlantReferenceId)
                    .HasMaxLength(255)
                    .HasColumnName("power_plant_reference_id");

                entity.Property(e => e.Ppname)
                    .HasMaxLength(255)
                    .HasColumnName("ppname");

                entity.Property(e => e.PvModuleNumberJsonArray)
                    .HasMaxLength(192)
                    .HasColumnName("pv_module_number_json_array");

                entity.Property(e => e.RatedAcPower).HasColumnName("rated_ac_power");

                entity.Property(e => e.ReadyToWork).HasColumnName("ready_to_work");

                entity.Property(e => e.RemotePath)
                    .HasMaxLength(128)
                    .HasColumnName("remote_path");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.Property(e => e.Routercomment)
                    .HasMaxLength(1023)
                    .HasColumnName("routercomment");

                entity.Property(e => e.Routerip)
                    .HasMaxLength(24)
                    .HasColumnName("routerip");
            });

            modelBuilder.Entity<InverterMeasurementEnoughDatum>(entity =>
            {
                entity.HasKey(e => e.InverterMeasurementEnoughDataId)
                    .HasName("pk_inverter_measurement_enough_data");

                entity.ToTable("inverter_measurement_enough_data");

                entity.HasIndex(e => new { e.PowerPlantId, e.LastQhTime }, "uq_inverter_measurement_enough_data_pp_last_qh_time")
                    .IsUnique();

                entity.Property(e => e.InverterMeasurementEnoughDataId)
                    .HasColumnName("inverter_measurement_enough_data_id")
                    .HasDefaultValueSql("nextval('inverter_measurement_enough_data_id_seq'::regclass)");

                entity.Property(e => e.CheckTime).HasColumnName("check_time");

                entity.Property(e => e.LastQhEnough).HasColumnName("last_qh_enough");

                entity.Property(e => e.LastQhTime).HasColumnName("last_qh_time");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.QhBeforeLastEnough).HasColumnName("qh_before_last_enough");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.InverterMeasurementEnoughData)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inverter_measurement_enough_data_pp");
            });

            modelBuilder.Entity<InverterMonitoringMeasurementError>(entity =>
            {
                entity.ToTable("inverter_monitoring_measurement_error");

                entity.HasIndex(e => e.PowerPlantId, "uq_inverter_monitoring_measurement_error_pp")
                    .IsUnique();

                entity.Property(e => e.InverterMonitoringMeasurementErrorId)
                    .HasColumnName("inverter_monitoring_measurement_error_id")
                    .HasDefaultValueSql("nextval('inverter_monitoring_measurement_error_id_seq'::regclass)");

                entity.Property(e => e.DataLoggerType)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("data_logger_type")
                    .HasDefaultValueSql("'UNKNOWN'::character varying");

                entity.Property(e => e.HasFreshData).HasColumnName("has_fresh_data");

                entity.Property(e => e.MapeError)
                    .HasPrecision(6, 5)
                    .HasColumnName("mape_error");

                entity.Property(e => e.OnWhiteList).HasColumnName("on_white_list");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PowerPlantName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("power_plant_name")
                    .HasDefaultValueSql("'Name not found'::character varying");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.InverterMonitoringMeasurementError)
                    .HasForeignKey<InverterMonitoringMeasurementError>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inverter_monitoring_measurement_error_pp");
            });

            modelBuilder.Entity<InverterPowerControlCommand>(entity =>
            {
                entity.ToTable("inverter_power_control_command");

                entity.Property(e => e.InverterPowerControlCommandId)
                    .HasColumnName("inverter_power_control_command_id")
                    .HasDefaultValueSql("nextval('inverter_power_control_command_id_seq'::regclass)");

                entity.Property(e => e.CommandType)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("command_type");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.InverterId).HasColumnName("inverter_id");

                entity.Property(e => e.MaxPercentage).HasColumnName("max_percentage");

                entity.Property(e => e.PowerControlEventId).HasColumnName("power_control_event_id");

                entity.HasOne(d => d.Inverter)
                    .WithMany(p => p.InverterPowerControlCommands)
                    .HasForeignKey(d => d.InverterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inverter_id");

                entity.HasOne(d => d.PowerControlEvent)
                    .WithMany(p => p.InverterPowerControlCommands)
                    .HasForeignKey(d => d.PowerControlEventId)
                    .HasConstraintName("fk_power_control_event_id");
            });

            modelBuilder.Entity<InverterPowerControlCommandHistory>(entity =>
            {
                entity.ToTable("inverter_power_control_command_history");

                entity.Property(e => e.InverterPowerControlCommandHistoryId)
                    .HasColumnName("inverter_power_control_command_history_id")
                    .HasDefaultValueSql("nextval('inverter_power_control_command_history_id_seq'::regclass)");

                entity.Property(e => e.CommandType)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("command_type");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.HistoryCreationDatetime).HasColumnName("history_creation_datetime");

                entity.Property(e => e.InverterId).HasColumnName("inverter_id");

                entity.Property(e => e.InverterPowerControlCommandId).HasColumnName("inverter_power_control_command_id");

                entity.Property(e => e.MaxPercentage).HasColumnName("max_percentage");

                entity.Property(e => e.PowerControlEventId).HasColumnName("power_control_event_id");

                entity.HasOne(d => d.Inverter)
                    .WithMany(p => p.InverterPowerControlCommandHistories)
                    .HasForeignKey(d => d.InverterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inverter_id");

                entity.HasOne(d => d.InverterPowerControlCommand)
                    .WithMany(p => p.InverterPowerControlCommandHistories)
                    .HasForeignKey(d => d.InverterPowerControlCommandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inverter_power_control_command_id");

                entity.HasOne(d => d.PowerControlEvent)
                    .WithMany(p => p.InverterPowerControlCommandHistories)
                    .HasForeignKey(d => d.PowerControlEventId)
                    .HasConstraintName("fk_power_control_event_id");
            });

            modelBuilder.Entity<InverterStatus>(entity =>
            {
                entity.ToTable("inverter_status");

                entity.HasIndex(e => new { e.InverterId, e.StartTimeStamp, e.EndTimeStamp, e.StatusCode }, "uq_inverter_status")
                    .IsUnique();

                entity.Property(e => e.InverterStatusId)
                    .HasColumnName("inverter_status_id")
                    .HasDefaultValueSql("nextval('inverter_status_id_seq'::regclass)");

                entity.Property(e => e.EndTimeStamp).HasColumnName("end_time_stamp");

                entity.Property(e => e.InverterId).HasColumnName("inverter_id");

                entity.Property(e => e.Sent).HasColumnName("sent");

                entity.Property(e => e.StartTimeStamp).HasColumnName("start_time_stamp");

                entity.Property(e => e.StatusCode).HasColumnName("status_code");

                entity.HasOne(d => d.Inverter)
                    .WithMany(p => p.InverterStatuses)
                    .HasForeignKey(d => d.InverterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inverter_status_inverter");
            });

            modelBuilder.Entity<InverterStatusCooldown>(entity =>
            {
                entity.ToTable("inverter_status_cooldown");

                entity.Property(e => e.InverterStatusCooldownId)
                    .HasColumnName("inverter_status_cooldown_id")
                    .HasDefaultValueSql("nextval('inverter_status_cooldown_id_seq'::regclass)");

                entity.Property(e => e.CurrentStack).HasColumnName("current_stack");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.InverterId).HasColumnName("inverter_id");

                entity.Property(e => e.StatusCode).HasColumnName("status_code");

                entity.HasOne(d => d.Inverter)
                    .WithMany(p => p.InverterStatusCooldowns)
                    .HasForeignKey(d => d.InverterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inverter_status_cooldown_inverter");
            });

            modelBuilder.Entity<InverterStatusDetailedV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("inverter_status_detailed_v");

                entity.Property(e => e.AvailableTotalAcPower).HasColumnName("available_total_ac_power");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment");

                entity.Property(e => e.DataLoggerId).HasColumnName("data_logger_id");

                entity.Property(e => e.DataLoggerType)
                    .HasMaxLength(24)
                    .HasColumnName("data_logger_type");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(255)
                    .HasColumnName("device_name");

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(255)
                    .HasColumnName("device_type");

                entity.Property(e => e.HttpPullDeviceId).HasColumnName("http_pull_device_id");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.InverterId).HasColumnName("inverter_id");

                entity.Property(e => e.InverterName)
                    .HasMaxLength(128)
                    .HasColumnName("inverter_name");

                entity.Property(e => e.InverterNameByUser)
                    .HasMaxLength(128)
                    .HasColumnName("inverter_name_by_user");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(24)
                    .HasColumnName("ip_address");

                entity.Property(e => e.IpPort).HasColumnName("ip_port");

                entity.Property(e => e.LocationCity)
                    .HasMaxLength(255)
                    .HasColumnName("location_city");

                entity.Property(e => e.LocationParcelNumber)
                    .HasMaxLength(40)
                    .HasColumnName("location_parcel_number");

                entity.Property(e => e.MaxAllowedAcPower).HasColumnName("max_allowed_ac_power");

                entity.Property(e => e.ModbusManagerDeviceId).HasColumnName("modbus_manager_device_id");

                entity.Property(e => e.ModbusSlaveId).HasColumnName("modbus_slave_id");

                entity.Property(e => e.ModbusType)
                    .HasMaxLength(64)
                    .HasColumnName("modbus_type");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .HasColumnName("password");

                entity.Property(e => e.PowerAdjustmentAvailable).HasColumnName("power_adjustment_available");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.RatedAcPower).HasColumnName("rated_ac_power");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(64)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.BankTransactionId)
                    .HasMaxLength(191)
                    .HasColumnName("bank_transaction_id")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.BillingSoftware)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("billing_software")
                    .HasDefaultValueSql("'Other'::character varying");

                entity.Property(e => e.Cancelled)
                    .HasMaxLength(191)
                    .HasColumnName("cancelled")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CompletedAt).HasColumnName("completed_at");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DateBilled)
                    .HasColumnType("date")
                    .HasColumnName("date_billed");

                entity.Property(e => e.DateDue)
                    .HasColumnType("date")
                    .HasColumnName("date_due");

                entity.Property(e => e.DateFulfilled)
                    .HasColumnType("date")
                    .HasColumnName("date_fulfilled");

                entity.Property(e => e.FulfilledInInvoiceSoftware).HasColumnName("fulfilled_in_invoice_software");

                entity.Property(e => e.GrossPrice)
                    .HasPrecision(11, 2)
                    .HasColumnName("gross_price");

                entity.Property(e => e.InvoiceAcquirerCompanyId).HasColumnName("invoice_acquirer_company_id");

                entity.Property(e => e.InvoiceIssuerCompanyId).HasColumnName("invoice_issuer_company_id");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("invoice_number");

                entity.Property(e => e.Message)
                    .HasMaxLength(2048)
                    .HasColumnName("message");

                entity.Property(e => e.NetPrice)
                    .HasPrecision(11, 2)
                    .HasColumnName("net_price");

                entity.Property(e => e.NotifiedAt).HasColumnName("notified_at");

                entity.Property(e => e.PaymentDeadline)
                    .HasColumnType("date")
                    .HasColumnName("payment_deadline");

                entity.Property(e => e.PaymentPeriodEndMonth)
                    .HasColumnType("date")
                    .HasColumnName("payment_period_end_month");

                entity.Property(e => e.PaymentPeriodStartMonth)
                    .HasColumnType("date")
                    .HasColumnName("payment_period_start_month");

                entity.Property(e => e.PrintedAt).HasColumnName("printed_at");

                entity.Property(e => e.ReminderEmailVersion)
                    .HasColumnName("reminder_email_version")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ReminderSentAt).HasColumnName("reminder_sent_at");

                entity.Property(e => e.SoftwareUniqueId).HasColumnName("software_unique_id");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'Other'::character varying");

                entity.Property(e => e.UniqueIdentification)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("unique_identification");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.InvoiceAcquirerCompany)
                    .WithMany(p => p.InvoiceInvoiceAcquirerCompanies)
                    .HasForeignKey(d => d.InvoiceAcquirerCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_invoice_acquirer_company_company");

                entity.HasOne(d => d.InvoiceIssuerCompany)
                    .WithMany(p => p.InvoiceInvoiceIssuerCompanies)
                    .HasForeignKey(d => d.InvoiceIssuerCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_invoice_issuer_company_company");
            });

            modelBuilder.Entity<InvoiceScheduleEmailQueue>(entity =>
            {
                entity.HasKey(e => e.ScheduleEmailQueueId)
                    .HasName("invoice_schedule_email_queue_pkey");

                entity.ToTable("invoice_schedule_email_queue");

                entity.HasIndex(e => e.ScheduleEmailQueueId, "invoice_schedule_email_queue_schedule_email_queue_id_uindex")
                    .IsUnique();

                entity.Property(e => e.ScheduleEmailQueueId).HasColumnName("schedule_email_queue_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EwiserUserId).HasColumnName("ewiser_user_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.InvoiceSoftware)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("invoice_software");

                entity.Property(e => e.MustBeSentOn)
                    .HasColumnType("date")
                    .HasColumnName("must_be_sent_on");

                entity.Property(e => e.Subtype)
                    .HasMaxLength(191)
                    .HasColumnName("subtype")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'production_income'::character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ManualForecastOverwriteEvent>(entity =>
            {
                entity.HasKey(e => e.ManualForecastOverwriteId)
                    .HasName("manual_forecast_overwrite_event_pkey");

                entity.ToTable("manual_forecast_overwrite_event");

                entity.Property(e => e.ManualForecastOverwriteId)
                    .HasColumnName("manual_forecast_overwrite_id")
                    .HasDefaultValueSql("nextval('manual_forecast_overwrite_even_manual_forecast_overwrite_id_seq'::regclass)");

                entity.Property(e => e.CountryType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country_type")
                    .HasDefaultValueSql("'HUNGARY'::character varying");

                entity.Property(e => e.EndDatetime).HasColumnName("end_datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("note");

                entity.Property(e => e.ScaleFactor)
                    .HasColumnName("scale_factor")
                    .HasDefaultValueSql("1.0");

                entity.Property(e => e.StartDatetime).HasColumnName("start_datetime");

                entity.Property(e => e.WeatherType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("weather_type")
                    .HasDefaultValueSql("'DEFAULT'::character varying");
            });

            modelBuilder.Entity<MekIdentification>(entity =>
            {
                entity.ToTable("mek_identification");

                entity.HasIndex(e => e.SendersTimeSeriesSequentialIdentification, "mek_identification_s_t_s_sequential_identification_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.PowerPlantId, "uk_bfpm4ybm8mddxhtilpw4lb4rx")
                    .IsUnique();

                entity.HasIndex(e => e.SendersTimeSeriesIdentification, "uq_mek_identification_senders_time_series_identification")
                    .IsUnique();

                entity.Property(e => e.MekIdentificationId).HasColumnName("mek_identification_id");

                entity.Property(e => e.BusinessType)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("business_type");

                entity.Property(e => e.InArea)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("in_area");

                entity.Property(e => e.InAreaCodingScheme)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("in_area_coding_scheme");

                entity.Property(e => e.MeasurementUnit)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("measurement_unit");

                entity.Property(e => e.MekIdentificationGroupId).HasColumnName("mek_identification_group_id");

                entity.Property(e => e.MekIdentificationGroupPrevDate)
                    .HasColumnType("date")
                    .HasColumnName("mek_identification_group_prev_date");

                entity.Property(e => e.MekIdentificationGroupPrevId).HasColumnName("mek_identification_group_prev_id");

                entity.Property(e => e.MeteringPointIdentificationCodingScheme)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("metering_point_identification_coding_scheme");

                entity.Property(e => e.ObjectAggregation)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("object_aggregation");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("product");

                entity.Property(e => e.ProsumerMaxValueW)
                    .HasColumnName("prosumer_max_value_w")
                    .HasDefaultValueSql("77");

                entity.Property(e => e.SendersTimeSeriesIdentification)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("senders_time_series_identification");

                entity.Property(e => e.SendersTimeSeriesSequentialIdentification)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("senders_time_series_sequential_identification")
                    .HasDefaultValueSql("concat('STS-', nextval('mek_identification_s_t_s_sequential_identification_seq'::regclass))");

                entity.HasOne(d => d.MekIdentificationGroup)
                    .WithMany(p => p.MekIdentificationMekIdentificationGroups)
                    .HasForeignKey(d => d.MekIdentificationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkbnjl83o63hcvndf94mv9g9o0w");

                entity.HasOne(d => d.MekIdentificationGroupPrev)
                    .WithMany(p => p.MekIdentificationMekIdentificationGroupPrevs)
                    .HasForeignKey(d => d.MekIdentificationGroupPrevId)
                    .HasConstraintName("fl_mekidentification_mig_prev_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.MekIdentification)
                    .HasForeignKey<MekIdentification>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mekidentification_pvplant");
            });

            modelBuilder.Entity<MekIdentificationGroup>(entity =>
            {
                entity.ToTable("mek_identification_group");

                entity.HasIndex(e => e.MessageIdentification, "uq_mek_identification_group_message_identification")
                    .IsUnique();

                entity.Property(e => e.MekIdentificationGroupId).HasColumnName("mek_identification_group_id");

                entity.Property(e => e.ActiveMekEmailSchedule).HasColumnName("active_mek_email_schedule");

                entity.Property(e => e.ActiveScheduling).HasColumnName("active_scheduling");

                entity.Property(e => e.DtdRelease)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("dtd_release");

                entity.Property(e => e.DtdVersion)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("dtd_version");

                entity.Property(e => e.InParty)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("in_party");

                entity.Property(e => e.InPartyCodingScheme)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("in_party_coding_scheme");

                entity.Property(e => e.LastPasswordRenewingDate)
                    .HasColumnType("date")
                    .HasColumnName("last_password_renewing_date")
                    .HasDefaultValueSql("'2010-01-01'::date");

                entity.Property(e => e.MessageIdentification)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("message_identification");

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("message_type");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ProcessType)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("process_type");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("pwd");

                entity.Property(e => e.ReceiverIdentification)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("receiver_identification");

                entity.Property(e => e.ReceiverIdentificationCodingScheme)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("receiver_identification_coding_scheme");

                entity.Property(e => e.ReceiverRole)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("receiver_role");

                entity.Property(e => e.ScheduleClassificationType)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("schedule_classification_type");

                entity.Property(e => e.SenderIdentification)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("sender_identification");

                entity.Property(e => e.SenderIdentificationCodingScheme)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("sender_identification_coding_scheme");

                entity.Property(e => e.SenderRole)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("sender_role");

                entity.Property(e => e.TsoPassword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("tso_password");

                entity.Property(e => e.TsoUsername)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("tso_username");
            });

            modelBuilder.Entity<MekIdentificationGroupUnused>(entity =>
            {
                entity.HasKey(e => e.MekIdentificationGroupId)
                    .HasName("mek_identification_group_unused_pkey");

                entity.ToTable("mek_identification_group_unused");

                entity.Property(e => e.MekIdentificationGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("mek_identification_group_id");

                entity.Property(e => e.ActiveMekEmailSchedule)
                    .HasColumnName("active_mek_email_schedule")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ActiveScheduling).HasColumnName("active_scheduling");

                entity.Property(e => e.DtdRelease)
                    .HasMaxLength(8)
                    .HasColumnName("dtd_release");

                entity.Property(e => e.DtdVersion)
                    .HasMaxLength(8)
                    .HasColumnName("dtd_version");

                entity.Property(e => e.InParty)
                    .HasMaxLength(64)
                    .HasColumnName("in_party");

                entity.Property(e => e.InPartyCodingScheme)
                    .HasMaxLength(16)
                    .HasColumnName("in_party_coding_scheme");

                entity.Property(e => e.LastPasswordRenewingDate)
                    .HasColumnType("date")
                    .HasColumnName("last_password_renewing_date");

                entity.Property(e => e.MessageIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("message_identification");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(16)
                    .HasColumnName("message_type");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProcessType)
                    .HasMaxLength(16)
                    .HasColumnName("process_type");

                entity.Property(e => e.Pwd).HasColumnName("pwd");

                entity.Property(e => e.ReceiverIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("receiver_identification");

                entity.Property(e => e.ReceiverIdentificationCodingScheme)
                    .HasMaxLength(16)
                    .HasColumnName("receiver_identification_coding_scheme");

                entity.Property(e => e.ReceiverRole)
                    .HasMaxLength(16)
                    .HasColumnName("receiver_role");

                entity.Property(e => e.ScheduleClassificationType)
                    .HasMaxLength(16)
                    .HasColumnName("schedule_classification_type");

                entity.Property(e => e.SenderIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("sender_identification");

                entity.Property(e => e.SenderIdentificationCodingScheme)
                    .HasMaxLength(16)
                    .HasColumnName("sender_identification_coding_scheme");

                entity.Property(e => e.SenderRole)
                    .HasMaxLength(16)
                    .HasColumnName("sender_role");

                entity.Property(e => e.TsoPassword)
                    .HasMaxLength(255)
                    .HasColumnName("tso_password");

                entity.Property(e => e.TsoUsername)
                    .HasMaxLength(255)
                    .HasColumnName("tso_username");
            });

            modelBuilder.Entity<MekhId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mekh_ids");

                entity.Property(e => e.MekhId1)
                    .HasMaxLength(255)
                    .HasColumnName("mekh_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");
            });

            modelBuilder.Entity<MekhIdMekhSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mekh_id_mekh_sheets");

                entity.Property(e => e.CanBeParsed).HasColumnName("can_be_parsed");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.MekhId)
                    .HasMaxLength(255)
                    .HasColumnName("mekh_id");

                entity.Property(e => e.MekhIdentificationId).HasColumnName("mekh_identification_id");

                entity.Property(e => e.MekhIdentificationSheetId).HasColumnName("mekh_identification_sheet_id");

                entity.Property(e => e.NotifiedAt).HasColumnName("notified_at");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.SelfValidationError).HasColumnName("self_validation_error");

                entity.Property(e => e.SendEmail).HasColumnName("send_email");

                entity.Property(e => e.Sendable).HasColumnName("sendable");

                entity.Property(e => e.Sent).HasColumnName("sent");

                entity.Property(e => e.SheetOpen).HasColumnName("sheet_open");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<MekhIdentification>(entity =>
            {
                entity.ToTable("mekh_identification");

                entity.HasIndex(e => e.PowerPlantId, "mekh_identification_power_plant_id_uindex")
                    .IsUnique();

                entity.Property(e => e.MekhIdentificationId).HasColumnName("mekh_identification_id");

                entity.Property(e => e.BalanceGroupRegistrationNumber)
                    .HasMaxLength(255)
                    .HasColumnName("balance_group_registration_number");

                entity.Property(e => e.Bank)
                    .HasMaxLength(191)
                    .HasColumnName("bank");

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(191)
                    .HasColumnName("bank_account_number");

                entity.Property(e => e.BankAccountNumberId).HasColumnName("bank_account_number_id");

                entity.Property(e => e.Disabled)
                    .HasColumnName("disabled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.InvoiceBook)
                    .HasColumnType("character varying")
                    .HasColumnName("invoice_book");

                entity.Property(e => e.MekhId)
                    .HasMaxLength(255)
                    .HasColumnName("mekh_id");

                entity.Property(e => e.MekhIdentificationGroupId).HasColumnName("mekh_identification_group_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.SapId)
                    .HasMaxLength(255)
                    .HasColumnName("sap_id");

                entity.Property(e => e.T1)
                    .HasMaxLength(255)
                    .HasColumnName("t1")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.T2)
                    .HasMaxLength(255)
                    .HasColumnName("t2")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.T3)
                    .HasMaxLength(255)
                    .HasColumnName("t3")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.V300AutoFilled)
                    .HasColumnName("v300_auto_filled")
                    .HasDefaultValueSql("false");

                entity.HasOne(d => d.MekhIdentificationGroup)
                    .WithMany(p => p.MekhIdentifications)
                    .HasForeignKey(d => d.MekhIdentificationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mekh_identification_mekh_identification_group");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.MekhIdentification)
                    .HasForeignKey<MekhIdentification>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mekh_identification_power_plant");
            });

            modelBuilder.Entity<MekhIdentificationGroup>(entity =>
            {
                entity.ToTable("mekh_identification_group");

                entity.Property(e => e.MekhIdentificationGroupId).HasColumnName("mekh_identification_group_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(64)
                    .HasColumnName("phone");

                entity.Property(e => e.Username)
                    .HasMaxLength(64)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<MekhIdentificationSheet>(entity =>
            {
                entity.ToTable("mekh_identification_sheet");

                entity.HasIndex(e => e.MekhIdentificationSheetId, "mekh_identification_sheet_mekh_identification_sheet_di_uindex")
                    .IsUnique();

                entity.Property(e => e.MekhIdentificationSheetId)
                    .HasColumnName("mekh_identification_sheet_id")
                    .HasDefaultValueSql("nextval('mekh_identification_sheet_id_seq'::regclass)");

                entity.Property(e => e.CanBeParsed)
                    .HasColumnName("can_be_parsed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.MekhIdentificationId).HasColumnName("mekh_identification_id");

                entity.Property(e => e.NotifiedAt).HasColumnName("notified_at");

                entity.Property(e => e.SelfValidationError)
                    .HasColumnName("self_validation_error")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SendEmail)
                    .HasColumnName("send_email")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Sendable)
                    .HasColumnName("sendable")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Sent)
                    .HasColumnName("sent")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SheetId)
                    .HasMaxLength(100)
                    .HasColumnName("sheet_id")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.SheetOpen)
                    .HasColumnName("sheet_open")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MekhReceivedSm>(entity =>
            {
                entity.HasKey(e => e.MekhReceivedSmsId)
                    .HasName("mekh_received_sms_pkey");

                entity.ToTable("mekh_received_sms");

                entity.Property(e => e.MekhReceivedSmsId).HasColumnName("mekh_received_sms_id");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("body");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.FromNumber)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("from_number");

                entity.Property(e => e.MessageSid)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("message_sid");

                entity.Property(e => e.SmsMessageSid)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("sms_message_sid");

                entity.Property(e => e.SmsSid)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("sms_sid");

                entity.Property(e => e.Successful).HasColumnName("successful");

                entity.Property(e => e.ToNumber)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("to_number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MekhScheduleEmailQueue>(entity =>
            {
                entity.HasKey(e => e.ScheduleEmailQueueId)
                    .HasName("mekh_schedule_email_queue_pkey");

                entity.ToTable("mekh_schedule_email_queue");

                entity.HasIndex(e => e.ScheduleEmailQueueId, "mekh_schedule_email_queue_schedule email queue_id_uindex")
                    .IsUnique();

                entity.Property(e => e.ScheduleEmailQueueId)
                    .HasColumnName("schedule_email_queue_id")
                    .HasDefaultValueSql("nextval('\"mekh_schedule_email_queue_schedule email queue_id_seq\"'::regclass)");

                entity.Property(e => e.EwiserUserId).HasColumnName("ewiser_user_id");

                entity.Property(e => e.MekhSheetId).HasColumnName("mekh_sheet_id");

                entity.Property(e => e.MustBeSentOn)
                    .HasColumnType("date")
                    .HasColumnName("must_be_sent_on");
            });

            modelBuilder.Entity<MekhSheet>(entity =>
            {
                entity.ToTable("mekh_sheets");

                entity.Property(e => e.MekhSheetId).HasColumnName("mekh_sheet_id");

                entity.Property(e => e.ConfirmedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("confirmed_at");

                entity.Property(e => e.ConfirmedNote).HasColumnName("confirmed_note");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.Deadline)
                    .HasColumnType("date")
                    .HasColumnName("deadline");

                entity.Property(e => e.File)
                    .HasMaxLength(191)
                    .HasColumnName("file");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("hash");

                entity.Property(e => e.IsError).HasColumnName("is_error");

                entity.Property(e => e.ManuallyHandled).HasColumnName("manually_handled");

                entity.Property(e => e.MustBeNull).HasColumnName("must_be_null");

                entity.Property(e => e.MustBeSendAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("must_be_send_at");

                entity.Property(e => e.ProductionDataId).HasColumnName("production_data_id");

                entity.Property(e => e.ReportingPeriod)
                    .HasColumnType("date")
                    .HasColumnName("reporting_period");

                entity.Property(e => e.SentAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("sent_at");

                entity.Property(e => e.State)
                    .HasMaxLength(191)
                    .HasColumnName("state");

                entity.Property(e => e.StateVersion)
                    .HasMaxLength(191)
                    .HasColumnName("state_version");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'created'::character varying");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserFilled).HasColumnName("user_filled");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.ProductionData)
                    .WithMany(p => p.MekhSheets)
                    .HasForeignKey(d => d.ProductionDataId)
                    .HasConstraintName("mekh_sheets_production_data_id_foreign");
            });

            modelBuilder.Entity<MeteringPointMeasurement>(entity =>
            {
                entity.ToTable("metering_point_measurement");

                entity.HasIndex(e => new { e.StartTime, e.EndTime }, "idx_metering_point_measurement_01")
                    .HasFilter("(((value_name)::text = 'REAL_POWER_GENERATION'::text) AND ((resolution)::text = 'PT15M'::text))")
                    .HasMethod("brin");

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_01")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-01-01'::date) AND (end_time <= '2019-01-31'::date)) AND ((start_time >= '2019-01-01'::date) AND (start_time <= '2019-01-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_02")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-02-01'::date) AND (end_time <= '2019-02-28'::date)) AND ((start_time >= '2019-02-01'::date) AND (start_time <= '2019-02-28'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_03")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-03-01'::date) AND (end_time <= '2019-03-31'::date)) AND ((start_time >= '2019-03-01'::date) AND (start_time <= '2019-03-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_04")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-04-01'::date) AND (end_time <= '2019-04-30'::date)) AND ((start_time >= '2019-04-01'::date) AND (start_time <= '2019-04-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_05")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-05-01'::date) AND (end_time <= '2019-05-31'::date)) AND ((start_time >= '2019-05-01'::date) AND (start_time <= '2019-05-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_06")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-06-01'::date) AND (end_time <= '2019-06-30'::date)) AND ((start_time >= '2019-06-01'::date) AND (start_time <= '2019-06-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_07")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-07-01'::date) AND (end_time <= '2019-07-31'::date)) AND ((start_time >= '2019-07-01'::date) AND (start_time <= '2019-07-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_08")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-08-01'::date) AND (end_time <= '2019-08-31'::date)) AND ((start_time >= '2019-08-01'::date) AND (start_time <= '2019-08-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_09")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-09-01'::date) AND (end_time <= '2019-09-30'::date)) AND ((start_time >= '2019-09-01'::date) AND (start_time <= '2019-09-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_10")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-10-01'::date) AND (end_time <= '2019-10-31'::date)) AND ((start_time >= '2019-10-01'::date) AND (start_time <= '2019-10-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_11")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-11-01'::date) AND (end_time <= '2019-11-30'::date)) AND ((start_time >= '2019-11-01'::date) AND (start_time <= '2019-11-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2019_12")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2019-12-01'::date) AND (end_time <= '2019-12-31'::date)) AND ((start_time >= '2019-12-01'::date) AND (start_time <= '2019-12-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_01")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-01-01'::date) AND (end_time <= '2020-01-31'::date)) AND ((start_time >= '2020-01-01'::date) AND (start_time <= '2020-01-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_02")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-02-01'::date) AND (end_time <= '2020-02-28'::date)) AND ((start_time >= '2020-02-01'::date) AND (start_time <= '2020-02-28'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_03")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-03-01'::date) AND (end_time <= '2020-03-31'::date)) AND ((start_time >= '2020-03-01'::date) AND (start_time <= '2020-03-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_04")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-04-01'::date) AND (end_time <= '2020-04-30'::date)) AND ((start_time >= '2020-04-01'::date) AND (start_time <= '2020-04-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_05")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-05-01'::date) AND (end_time <= '2020-05-31'::date)) AND ((start_time >= '2020-05-01'::date) AND (start_time <= '2020-05-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_06")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-06-01'::date) AND (end_time <= '2020-06-30'::date)) AND ((start_time >= '2020-06-01'::date) AND (start_time <= '2020-06-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_07")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-07-01'::date) AND (end_time <= '2020-07-31'::date)) AND ((start_time >= '2020-07-01'::date) AND (start_time <= '2020-07-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_08")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-08-01'::date) AND (end_time <= '2020-08-31'::date)) AND ((start_time >= '2020-08-01'::date) AND (start_time <= '2020-08-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_09")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-09-01'::date) AND (end_time <= '2020-09-30'::date)) AND ((start_time >= '2020-09-01'::date) AND (start_time <= '2020-09-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_10")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-10-01'::date) AND (end_time <= '2020-10-31'::date)) AND ((start_time >= '2020-10-01'::date) AND (start_time <= '2020-10-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_11")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-11-01'::date) AND (end_time <= '2020-11-30'::date)) AND ((start_time >= '2020-11-01'::date) AND (start_time <= '2020-11-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_2020_12")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND ((end_time >= '2020-12-01'::date) AND (end_time <= '2020-12-31'::date)) AND ((start_time >= '2020-12-01'::date) AND (start_time <= '2020-12-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_bt_2020")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND (end_time > '2020-12-31'::date) AND (start_time > '2020-12-31'::date))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Status, e.ValueName }, "idx_metering_point_measurement_st_2019")
                    .IsUnique()
                    .HasFilter("(((resolution)::text = 'PT15M'::text) AND (end_time < '2019-01-01'::date) AND (start_time < '2019-01-01'::date))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => e.MeteringPointMeasurementId, "metering_point_measurement_metering_point_measurement_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => new { e.PowerPlantId, e.StartTime, e.EndTime, e.Resolution, e.ValueName }, "uq_metering_point_measurement")
                    .IsUnique();

                entity.HasIndex(e => new { e.StartTime, e.EndTime, e.PowerPlantId, e.ValueName }, "uq_metering_point_measurement_startendpowerplant")
                    .IsUnique();

                entity.Property(e => e.MeteringPointMeasurementId).HasColumnName("metering_point_measurement_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.Quantity)
                    .HasPrecision(16, 6)
                    .HasColumnName("quantity");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("resolution");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.Status)
                    .HasPrecision(3)
                    .HasColumnName("status");

                entity.Property(e => e.TFactor)
                    .HasPrecision(6, 5)
                    .HasColumnName("t_factor");

                entity.Property(e => e.ValueName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("value_name");

                entity.Property(e => e.ValueUnit)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("value_unit");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.MeteringPointMeasurements)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_metering_point_measurement_power_plant");
            });

            modelBuilder.Entity<MobileTraffic>(entity =>
            {
                entity.ToTable("mobile_traffic");

                entity.HasIndex(e => e.MobileTrafficId, "uq_mobile_traffic_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.RouterId, e.UsageDate, e.DataDirection }, "uq_mobile_traffic_router_date_direction")
                    .IsUnique();

                entity.Property(e => e.MobileTrafficId)
                    .HasColumnName("mobile_traffic_id")
                    .HasDefaultValueSql("nextval('mobile_traffic_id_seq'::regclass)");

                entity.Property(e => e.DataDirection)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("data_direction");

                entity.Property(e => e.Kibibytes)
                    .HasPrecision(16)
                    .HasColumnName("kibibytes");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.Property(e => e.UsageDate)
                    .HasColumnType("date")
                    .HasColumnName("usage_date");

                entity.HasOne(d => d.Router)
                    .WithMany(p => p.MobileTraffics)
                    .HasForeignKey(d => d.RouterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_router_id");
            });

            modelBuilder.Entity<MolBidReport>(entity =>
            {
                entity.ToTable("mol_bid_report");

                entity.Property(e => e.MolBidReportId)
                    .HasColumnName("mol_bid_report_id")
                    .HasDefaultValueSql("nextval('mol_bid_report_id_seq'::regclass)");

                entity.Property(e => e.BidQty)
                    .HasPrecision(6, 2)
                    .HasColumnName("bid_qty");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("currency");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("direction");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EnergyPrice)
                    .HasPrecision(8, 1)
                    .HasColumnName("energy_price");

                entity.Property(e => e.Market)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("market");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("resolution");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UnitOfQty)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("unit_of_qty");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("note");

                entity.Property(e => e.NoteId).HasColumnName("note_id");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Note1)
                    .IsRequired()
                    .HasColumnName("note");

                entity.Property(e => e.Visibility)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("visibility")
                    .HasDefaultValueSql("'Admin'::character varying");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_comment_user");
            });

            modelBuilder.Entity<NotePowerPlant>(entity =>
            {
                entity.ToTable("note_power_plant");

                entity.Property(e => e.NotePowerPlantId).HasColumnName("note_power_plant_id");

                entity.Property(e => e.NoteId).HasColumnName("note_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.NotePowerPlants)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_comment_power_plant_power_plant");
            });

            modelBuilder.Entity<PostgresLog>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.SessionLineNum })
                    .HasName("postgres_log_pkey");

                entity.ToTable("postgres_log");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.SessionLineNum).HasColumnName("session_line_num");

                entity.Property(e => e.ApplicationName).HasColumnName("application_name");

                entity.Property(e => e.CommandTag).HasColumnName("command_tag");

                entity.Property(e => e.ConnectionFrom).HasColumnName("connection_from");

                entity.Property(e => e.Context).HasColumnName("context");

                entity.Property(e => e.DatabaseName).HasColumnName("database_name");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.ErrorSeverity).HasColumnName("error_severity");

                entity.Property(e => e.Hint).HasColumnName("hint");

                entity.Property(e => e.InternalQuery).HasColumnName("internal_query");

                entity.Property(e => e.InternalQueryPos).HasColumnName("internal_query_pos");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.LogTime)
                    .HasColumnType("timestamp(3) with time zone")
                    .HasColumnName("log_time");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.ProcessId).HasColumnName("process_id");

                entity.Property(e => e.Query).HasColumnName("query");

                entity.Property(e => e.QueryPos).HasColumnName("query_pos");

                entity.Property(e => e.SessionStartTime)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("session_start_time");

                entity.Property(e => e.SqlStateCode).HasColumnName("sql_state_code");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.UserName).HasColumnName("user_name");

                entity.Property(e => e.VirtualTransactionId).HasColumnName("virtual_transaction_id");
            });

            modelBuilder.Entity<PowerAdjustmentEvent>(entity =>
            {
                entity.ToTable("power_adjustment_event");

                entity.Property(e => e.PowerAdjustmentEventId)
                    .HasColumnName("power_adjustment_event_id")
                    .HasDefaultValueSql("nextval('power_adjustment_event_id_seq'::regclass)");

                entity.Property(e => e.AdjustmentDatetime).HasColumnName("adjustment_datetime");

                entity.Property(e => e.AdjustmentType)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("adjustment_type");

                entity.Property(e => e.MaxPercentage).HasColumnName("max_percentage");

                entity.Property(e => e.MaxPower).HasColumnName("max_power");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.PowerAdjustmentEvents)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_power_plant_id");
            });

            modelBuilder.Entity<PowerAdjustmentEventHist>(entity =>
            {
                entity.ToTable("power_adjustment_event_hist");

                entity.Property(e => e.PowerAdjustmentEventHistId)
                    .HasColumnName("power_adjustment_event_hist_id")
                    .HasDefaultValueSql("nextval('power_adjustment_event_hist_id_seq'::regclass)");

                entity.Property(e => e.AdjustmentDatetime).HasColumnName("adjustment_datetime");

                entity.Property(e => e.AdjustmentType)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("adjustment_type");

                entity.Property(e => e.HistCreationDatetime).HasColumnName("hist_creation_datetime");

                entity.Property(e => e.HistOperation)
                    .HasMaxLength(1)
                    .HasColumnName("hist_operation");

                entity.Property(e => e.MaxPercentage).HasColumnName("max_percentage");

                entity.Property(e => e.MaxPower).HasColumnName("max_power");

                entity.Property(e => e.PowerAdjustmentEventId).HasColumnName("power_adjustment_event_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.HasOne(d => d.PowerAdjustmentEvent)
                    .WithMany(p => p.PowerAdjustmentEventHists)
                    .HasForeignKey(d => d.PowerAdjustmentEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_power_adjustment_event_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.PowerAdjustmentEventHists)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_power_plant_id");
            });

            modelBuilder.Entity<PowerControlEnergy>(entity =>
            {
                entity.ToTable("power_control_energy");

                entity.Property(e => e.PowerControlEnergyId).HasColumnName("power_control_energy_id");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ClaimedPower).HasColumnName("claimed_power");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Energy).HasColumnName("energy");

                entity.Property(e => e.EstimatedPower).HasColumnName("estimated_power");

                entity.Property(e => e.IntervalEnd).HasColumnName("interval_end");

                entity.Property(e => e.IntervalStart).HasColumnName("interval_start");

                entity.Property(e => e.MeasuredPower).HasColumnName("measured_power");

                entity.Property(e => e.Note)
                    .HasMaxLength(191)
                    .HasColumnName("note")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PowerControlEventId).HasColumnName("power_control_event_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PowerSource)
                    .HasMaxLength(191)
                    .HasColumnName("power_source");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<PowerControlEnergyReferencePowerPlant>(entity =>
            {
                entity.ToTable("power_control_energy_reference_power_plant");

                entity.Property(e => e.PowerControlEnergyReferencePowerPlantId)
                    .HasColumnName("power_control_energy_reference_power_plant_id")
                    .HasDefaultValueSql("nextval('power_control_energy_reference_power_plant_id_seq'::regclass)");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.ReferencePowerPlantId).HasColumnName("reference_power_plant_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.PowerControlEnergyReferencePowerPlantPowerPlants)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_power_plant_id");

                entity.HasOne(d => d.ReferencePowerPlant)
                    .WithMany(p => p.PowerControlEnergyReferencePowerPlantReferencePowerPlants)
                    .HasForeignKey(d => d.ReferencePowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reference_power_plant_id");
            });

            modelBuilder.Entity<PowerControlEvent>(entity =>
            {
                entity.ToTable("power_control_event");

                entity.Property(e => e.PowerControlEventId)
                    .HasColumnName("power_control_event_id")
                    .HasDefaultValueSql("nextval('power_control_event_id_seq'::regclass)");

                entity.Property(e => e.Comment)
                    .HasMaxLength(512)
                    .HasColumnName("comment");

                entity.Property(e => e.CreationTime).HasColumnName("creation_time");

                entity.Property(e => e.Difference).HasColumnName("difference");

                entity.Property(e => e.DifferenceBasis)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("difference_basis");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.InitialPower).HasColumnName("initial_power");

                entity.Property(e => e.PowerControlGroupId).HasColumnName("power_control_group_id");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("source");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.HasOne(d => d.PowerControlGroup)
                    .WithMany(p => p.PowerControlEvents)
                    .HasForeignKey(d => d.PowerControlGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_power_control_group_id");
            });

            modelBuilder.Entity<PowerControlGroup>(entity =>
            {
                entity.ToTable("power_control_group");

                entity.Property(e => e.PowerControlGroupId)
                    .HasColumnName("power_control_group_id")
                    .HasDefaultValueSql("nextval('power_control_group_id_seq'::regclass)");

                entity.Property(e => e.ActivePowerControlEventId).HasColumnName("active_power_control_event_id");

                entity.Property(e => e.Bsp)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("bsp")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("password")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("4");

                entity.Property(e => e.ReadEnergy).HasColumnName("read_energy");

                entity.Property(e => e.ScheduleDestination)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("schedule_destination")
                    .HasDefaultValueSql("'NONE'::character varying");

                entity.Property(e => e.SenderIdentification)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("sender_identification")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''::character varying");

                entity.HasOne(d => d.ActivePowerControlEvent)
                    .WithMany(p => p.PowerControlGroups)
                    .HasForeignKey(d => d.ActivePowerControlEventId)
                    .HasConstraintName("fk_active_power_control_event_id");
            });

            modelBuilder.Entity<PowerControlStateV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("power_control_state_v");

                entity.Property(e => e.DataLoggerIps).HasColumnName("data_logger_ips");

                entity.Property(e => e.DataLoggerType)
                    .HasMaxLength(24)
                    .HasColumnName("data_logger_type");

                entity.Property(e => e.DataloggerWithPowerAdjCount).HasColumnName("datalogger_with_power_adj_count");

                entity.Property(e => e.HasInverterWithoutModbusSlaveId).HasColumnName("has_inverter_without_modbus_slave_id");

                entity.Property(e => e.InverterCount).HasColumnName("inverter_count");

                entity.Property(e => e.InverterIds).HasColumnName("inverter_ids");

                entity.Property(e => e.MeteringPointIdentification)
                    .HasMaxLength(128)
                    .HasColumnName("metering_point_identification");

                entity.Property(e => e.OwnerCompany)
                    .HasMaxLength(255)
                    .HasColumnName("owner_company");

                entity.Property(e => e.PowerAdjustmentAvailableOnAllDataloggers).HasColumnName("power_adjustment_available_on_all_dataloggers");

                entity.Property(e => e.PowerAdjustmentEnabled).HasColumnName("power_adjustment_enabled");

                entity.Property(e => e.PowerControlGroupId).HasColumnName("power_control_group_id");

                entity.Property(e => e.PowerControlGroupName)
                    .HasMaxLength(255)
                    .HasColumnName("power_control_group_name");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PowerplantLoc)
                    .HasMaxLength(255)
                    .HasColumnName("powerplant_loc");

                entity.Property(e => e.PowerplantParcelnumber)
                    .HasMaxLength(40)
                    .HasColumnName("powerplant_parcelnumber");

                entity.Property(e => e.PowerplantPowerControlComment)
                    .HasMaxLength(511)
                    .HasColumnName("powerplant_power_control_comment");

                entity.Property(e => e.PpName)
                    .HasMaxLength(255)
                    .HasColumnName("pp_name");

                entity.Property(e => e.RouterComment)
                    .HasMaxLength(1023)
                    .HasColumnName("router_comment");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.Property(e => e.RouterLoc)
                    .HasMaxLength(64)
                    .HasColumnName("router_loc");

                entity.Property(e => e.SigId).HasColumnName("sig_id");

                entity.Property(e => e.Userek).HasColumnName("userek");
            });

            modelBuilder.Entity<PowerControlStatusLog>(entity =>
            {
                entity.ToTable("power_control_status_log");

                entity.Property(e => e.PowerControlStatusLogId)
                    .HasColumnName("power_control_status_log_id")
                    .HasDefaultValueSql("nextval('power_control_status_log_id_seq'::regclass)");

                entity.Property(e => e.CreationTime).HasColumnName("creation_time");

                entity.Property(e => e.IntervalEndTime).HasColumnName("interval_end_time");

                entity.Property(e => e.IntervalPower).HasColumnName("interval_power");

                entity.Property(e => e.IntervalStartTime).HasColumnName("interval_start_time");

                entity.Property(e => e.IntervalTargetPower).HasColumnName("interval_target_power");

                entity.Property(e => e.MaxPowerSet).HasColumnName("max_power_set");

                entity.Property(e => e.PowerControlEventId).HasColumnName("power_control_event_id");

                entity.Property(e => e.PowerControlGroupId).HasColumnName("power_control_group_id");

                entity.HasOne(d => d.PowerControlEvent)
                    .WithMany(p => p.PowerControlStatusLogs)
                    .HasForeignKey(d => d.PowerControlEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_power_control_event_id");

                entity.HasOne(d => d.PowerControlGroup)
                    .WithMany(p => p.PowerControlStatusLogs)
                    .HasForeignKey(d => d.PowerControlGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_power_control_group_id");
            });

            modelBuilder.Entity<PowerPlant>(entity =>
            {
                entity.ToTable("power_plant");

                entity.HasIndex(e => e.MeteringPointIdentification, "power_plant_metering_point_identification_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.PowerPlantReferenceId, "uq_power_plant_power_plant_reference_id")
                    .IsUnique();

                entity.HasIndex(e => e.UnguessableName, "uq_power_plant_unguessable_name")
                    .IsUnique();

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.BillingId).HasColumnName("billing_id");

                entity.Property(e => e.CoordinatorId).HasColumnName("coordinator_id");

                entity.Property(e => e.DocumentCs)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("document_cs")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DocumentE)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("document_e")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DocumentSz)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("document_sz")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.KatSubsidyConfirmation)
                    .HasMaxLength(255)
                    .HasColumnName("kat_subsidy_confirmation")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.KatSubsidyValidTo)
                    .HasMaxLength(40)
                    .HasColumnName("kat_subsidy_valid_to")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.LocationCity)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("location_city")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.LocationParcelNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("location_parcel_number")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.MeteringPointIdentification)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("metering_point_identification")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.MkpLoadProfileHistorySynced).HasColumnName("mkp_load_profile_history_synced");

                entity.Property(e => e.MkpRegisterDataHistorySynced).HasColumnName("mkp_register_data_history_synced");

                entity.Property(e => e.MkpSynced).HasColumnName("mkp_synced");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.PowerControlComment)
                    .HasMaxLength(511)
                    .HasColumnName("power_control_comment")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.PowerControlGroupId).HasColumnName("power_control_group_id");

                entity.Property(e => e.PowerPlantReferenceId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("power_plant_reference_id");

                entity.Property(e => e.PowerPlantType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("power_plant_type");

                entity.Property(e => e.PrimaryWeatherProvider)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("primary_weather_provider")
                    .HasDefaultValueSql("'WEATHER_COMPANY'::character varying");

                entity.Property(e => e.SpId).HasColumnName("sp_id");

                entity.Property(e => e.UnguessableName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("unguessable_name")
                    .HasDefaultValueSql("''::character varying");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.PowerPlantBillings)
                    .HasForeignKey(d => d.BillingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkir4eqlv5p5nfdtkn1t56ex9yc");

                entity.HasOne(d => d.Coordinator)
                    .WithMany(p => p.PowerPlantCoordinators)
                    .HasForeignKey(d => d.CoordinatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pvplant_coordinator_company");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.PowerPlantOwners)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pvplant_owner_company");

                entity.HasOne(d => d.PowerControlGroup)
                    .WithMany(p => p.PowerPlants)
                    .HasForeignKey(d => d.PowerControlGroupId)
                    .HasConstraintName("fk_power_control_group_id");

                entity.HasOne(d => d.Sp)
                    .WithMany(p => p.PowerPlantSps)
                    .HasForeignKey(d => d.SpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pvplant_sp_company");
            });

            modelBuilder.Entity<PowerPlantMailAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("power_plant_mail_address");

                entity.Property(e => e.DocumentCs)
                    .HasMaxLength(255)
                    .HasColumnName("document_cs");

                entity.Property(e => e.DocumentSz)
                    .HasMaxLength(255)
                    .HasColumnName("document_sz");

                entity.Property(e => e.MailAddress)
                    .HasMaxLength(1024)
                    .HasColumnName("mail_address");

                entity.Property(e => e.MailCity)
                    .HasMaxLength(255)
                    .HasColumnName("mail_city");

                entity.Property(e => e.MailName)
                    .HasMaxLength(255)
                    .HasColumnName("mail_name");

                entity.Property(e => e.MailZip)
                    .HasMaxLength(64)
                    .HasColumnName("mail_zip");

                entity.Property(e => e.PowerPlantReferenceId)
                    .HasMaxLength(255)
                    .HasColumnName("power_plant_reference_id");

                entity.Property(e => e.PpName)
                    .HasMaxLength(255)
                    .HasColumnName("pp_name");
            });

            modelBuilder.Entity<PowerPlantMonitoringSetting>(entity =>
            {
                entity.HasKey(e => e.PowerPlantMonitoringSettingsId)
                    .HasName("pk_power_plant_monitoring_settings");

                entity.ToTable("power_plant_monitoring_settings");

                entity.Property(e => e.PowerPlantMonitoringSettingsId)
                    .HasColumnName("power_plant_monitoring_settings_id")
                    .HasDefaultValueSql("nextval('power_plant_monitoring_settings_id_seq'::regclass)");

                entity.Property(e => e.CameraUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("camera_url")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.EnergyDivergenceLimit)
                    .HasPrecision(3, 2)
                    .HasColumnName("energy_divergence_limit");

                entity.Property(e => e.InverterMonthlyEnergyDivergenceLimit)
                    .HasPrecision(3, 2)
                    .HasColumnName("inverter_monthly_energy_divergence_limit");

                entity.Property(e => e.KofUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("kof_url")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.MaxTempDivergenceLimit)
                    .HasPrecision(4, 2)
                    .HasColumnName("max_temp_divergence_limit");

                entity.Property(e => e.MonitoringEnabled)
                    .IsRequired()
                    .HasColumnName("monitoring_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.PowerAdjustmentEnabled).HasColumnName("power_adjustment_enabled");

                entity.Property(e => e.PowerDivergenceLimit)
                    .HasPrecision(3, 2)
                    .HasColumnName("power_divergence_limit");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.PowerPlantMonitoringSettings)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_power_plant_monitoring_settings_01");
            });

            modelBuilder.Entity<ProductionDataInvoice>(entity =>
            {
                entity.ToTable("production_data_invoice");

                entity.Property(e => e.ProductionDataInvoiceId).HasColumnName("production_data_invoice_id");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.BillingoId).HasColumnName("billingo_id");

                entity.Property(e => e.ConfirmedNote).HasColumnName("confirmed_note");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.DownloadUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("download_url");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.Hash)
                    .HasMaxLength(191)
                    .HasColumnName("hash");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.InvoiceSoftwareId)
                    .HasMaxLength(500)
                    .HasColumnName("invoice_software_id");

                entity.Property(e => e.MustBeSendAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("must_be_send_at");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note");

                entity.Property(e => e.ProductionDataId).HasColumnName("production_data_id");

                entity.Property(e => e.SentAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("sent_at");

                entity.Property(e => e.ShouldRetry)
                    .HasColumnName("should_retry")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.ProductionData)
                    .WithMany(p => p.ProductionDataInvoices)
                    .HasForeignKey(d => d.ProductionDataId)
                    .HasConstraintName("production_data_invoice_production_data_id_foreign");
            });

            modelBuilder.Entity<ProductionDatum>(entity =>
            {
                entity.HasKey(e => e.ProductionDataId)
                    .HasName("production_data_pkey");

                entity.ToTable("production_data");

                entity.Property(e => e.ProductionDataId).HasColumnName("production_data_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("created_at");

                entity.Property(e => e.EmailSentAboutError)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("email_sent_about_error");

                entity.Property(e => e.ExtraData).HasColumnName("extra_data");

                entity.Property(e => e.Fields)
                    .IsRequired()
                    .HasColumnName("fields");

                entity.Property(e => e.IsError).HasColumnName("is_error");

                entity.Property(e => e.IsLocked).HasColumnName("is_locked");

                entity.Property(e => e.IsProduceEnergy)
                    .HasColumnName("is_produce_energy")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.KatProduction).HasColumnName("kat_production");

                entity.Property(e => e.LastError).HasColumnName("last_error");

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("month");

                entity.Property(e => e.MustBeNull).HasColumnName("must_be_null");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp(0) without time zone")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("year");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.ProductionData)
                    .HasForeignKey(d => d.PowerPlantId)
                    .HasConstraintName("production_data_power_plant_id_foreign");
            });

            modelBuilder.Entity<PvPlantGroupTempParamHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pv_plant_group_temp_param_history");

                entity.Property(e => e.CorrectionType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("correction_type");

                entity.Property(e => e.CorrectionVariable).HasColumnName("correction_variable");

                entity.Property(e => e.EndDatetime).HasColumnName("end_datetime");

                entity.Property(e => e.HistCreationDatetime)
                    .HasColumnName("hist_creation_datetime")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.PredictionParameters)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("prediction_parameters");

                entity.Property(e => e.PvPlantGroupTempParamHistoryId)
                    .HasColumnName("pv_plant_group_temp_param_history_id")
                    .HasDefaultValueSql("nextval('pv_plant_group_temp_param_history_id_seq'::regclass)");

                entity.Property(e => e.ScheduleIdentificationGroupId).HasColumnName("schedule_identification_group_id");

                entity.Property(e => e.StartDatetime).HasColumnName("start_datetime");
            });

            modelBuilder.Entity<PvPlantPhysical>(entity =>
            {
                entity.ToTable("pv_plant_physical");

                entity.HasIndex(e => e.PowerPlantId, "uk_ig5ndkmmpyk4rswkx94wedqqb")
                    .IsUnique();

                entity.HasIndex(e => new { e.Latitude, e.Longitude }, "uq_pv_plant_physical_latitude_longitude")
                    .IsUnique();

                entity.HasIndex(e => e.PowerPlantId, "uq_pv_plant_physical_power_plant_id")
                    .IsUnique();

                entity.Property(e => e.PvPlantPhysicalId).HasColumnName("pv_plant_physical_id");

                entity.Property(e => e.AcCableLoss).HasColumnName("ac_cable_loss");

                entity.Property(e => e.Albedo).HasColumnName("albedo");

                entity.Property(e => e.DcCableLoss).HasColumnName("dc_cable_loss");

                entity.Property(e => e.DustLoss).HasColumnName("dust_loss");

                entity.Property(e => e.InverterCosphi).HasColumnName("inverter_cosphi");

                entity.Property(e => e.InverterMaxEfficiency).HasColumnName("inverter_max_efficiency");

                entity.Property(e => e.KatContractStartDate)
                    .HasColumnType("date")
                    .HasColumnName("kat_contract_start_date");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PowerTransformerMaxLoadLossWatt).HasColumnName("power_transformer_max_load_loss_watt");

                entity.Property(e => e.PowerTransformerNoLoadLossWatt).HasColumnName("power_transformer_no_load_loss_watt");

                entity.Property(e => e.PowerTransformerRatedPowerVa).HasColumnName("power_transformer_rated_power_va");

                entity.Property(e => e.PvCellTechnology)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("pv_cell_technology");

                entity.Property(e => e.PvModuleAboveEachOther).HasColumnName("pv_module_above_each_other");

                entity.Property(e => e.PvModuleAzimuth).HasColumnName("pv_module_azimuth");

                entity.Property(e => e.PvModuleHeight).HasColumnName("pv_module_height");

                entity.Property(e => e.PvModuleLineDistanceMeter).HasColumnName("pv_module_line_distance_meter");

                entity.Property(e => e.PvModuleLineHeightFromGroundMeter).HasColumnName("pv_module_line_height_from_ground_meter");

                entity.Property(e => e.PvModuleLineHeightMeter).HasColumnName("pv_module_line_height_meter");

                entity.Property(e => e.PvModuleNumber).HasColumnName("pv_module_number");

                entity.Property(e => e.PvModulePower).HasColumnName("pv_module_power");

                entity.Property(e => e.RealProductionStartDate)
                    .HasColumnType("date")
                    .HasColumnName("real_production_start_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_date");

                entity.Property(e => e.SunTrackingAxis)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("sun_tracking_axis");

                entity.Property(e => e.TiltAnglePvModule).HasColumnName("tilt_angle_pv_module");

                entity.Property(e => e.Timezone)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("timezone");

                entity.Property(e => e.TotalInverterPowerWatt).HasColumnName("total_inverter_power_watt");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.PvPlantPhysical)
                    .HasForeignKey<PvPlantPhysical>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pvplantphysical_pvplant");
            });

            modelBuilder.Entity<PvPlantPhysicalLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pv_plant_physical_log");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.NewLatitude).HasColumnName("new_latitude");

                entity.Property(e => e.NewLongitude).HasColumnName("new_longitude");

                entity.Property(e => e.OrigLatitude).HasColumnName("orig_latitude");

                entity.Property(e => e.OrigLongitude).HasColumnName("orig_longitude");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");
            });

            modelBuilder.Entity<PvPlantTempParameter>(entity =>
            {
                entity.HasKey(e => e.PvPlantTempParametersId)
                    .HasName("pv_plant_temp_parameters_pkey");

                entity.ToTable("pv_plant_temp_parameters");

                entity.HasIndex(e => e.PowerPlantId, "uk_8w7gj3at1u5osbrstbmuyfck4")
                    .IsUnique();

                entity.HasIndex(e => e.PowerPlantId, "uq_pv_plant_temp_parameters_power_plant_id")
                    .IsUnique();

                entity.Property(e => e.PvPlantTempParametersId).HasColumnName("pv_plant_temp_parameters_id");

                entity.Property(e => e.GradientCorrectionVariable)
                    .HasColumnName("gradient_correction_variable")
                    .HasDefaultValueSql("1.0");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.SnowCalculationTime)
                    .HasColumnName("snow_calculation_time")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.SnowCorrectionVariable)
                    .HasColumnName("snow_correction_variable")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WeatherModifier)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("weather_modifier")
                    .HasDefaultValueSql("'NONE'::character varying");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.PvPlantTempParameter)
                    .HasForeignKey<PvPlantTempParameter>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pvplanttempparameters_pvplant");
            });

            modelBuilder.Entity<PvPlantTempParametersHistory>(entity =>
            {
                entity.ToTable("pv_plant_temp_parameters_history");

                entity.HasIndex(e => new { e.PowerPlantId, e.ModifiedAt }, "uq_pv_plant_temp_parameters_history_ppid_mod")
                    .IsUnique();

                entity.Property(e => e.PvPlantTempParametersHistoryId)
                    .HasColumnName("pv_plant_temp_parameters_history_id")
                    .HasDefaultValueSql("nextval('pv_plant_temp_parameters_history_id_seq'::regclass)");

                entity.Property(e => e.GradientCorrectionVariable)
                    .HasPrecision(5, 4)
                    .HasColumnName("gradient_correction_variable");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.SnowCalculationTime).HasColumnName("snow_calculation_time");

                entity.Property(e => e.SnowCorrectionVariable)
                    .HasPrecision(5, 4)
                    .HasColumnName("snow_correction_variable");

                entity.Property(e => e.WeatherModifier)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("weather_modifier");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.PvPlantTempParametersHistories)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pv_plant_temp_parameters_history_power_plant_id");
            });

            modelBuilder.Entity<PvPlantTempParametersReadonly>(entity =>
            {
                entity.ToTable("pv_plant_temp_parameters_readonly");

                entity.HasIndex(e => e.PowerPlantId, "uk_qt9hjcvhflfrdg6385j0dxbmp")
                    .IsUnique();

                entity.HasIndex(e => e.PowerPlantId, "uq_pv_plant_temp_parameters_readonly_power_plant_id")
                    .IsUnique();

                entity.Property(e => e.PvPlantTempParametersReadonlyId)
                    .HasColumnName("pv_plant_temp_parameters_readonly_id")
                    .HasDefaultValueSql("nextval('pv_plant_temp_parameters_read_pv_plant_temp_parameters_read_seq'::regclass)");

                entity.Property(e => e.FeedInPrice).HasColumnName("feed_in_price");

                entity.Property(e => e.NeuralNetworkZip).HasColumnName("neural_network_zip");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PredictionParameters)
                    .IsRequired()
                    .HasMaxLength(65536)
                    .HasColumnName("prediction_parameters");

                entity.Property(e => e.PvModuleWashingDate)
                    .HasColumnType("date")
                    .HasColumnName("pv_module_washing_date");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.PvPlantTempParametersReadonly)
                    .HasForeignKey<PvPlantTempParametersReadonly>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pvplanttempparametersro_pvplant");
            });

            modelBuilder.Entity<RequestLog>(entity =>
            {
                entity.ToTable("request_log");

                entity.Property(e => e.RequestLogId).HasColumnName("request_log_id");

                entity.Property(e => e.EwiserauthUuid)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("ewiserauth_uuid");

                entity.Property(e => e.FromIp)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("from_ip");

                entity.Property(e => e.IdToken)
                    .IsRequired()
                    .HasMaxLength(1536)
                    .HasColumnName("id_token");

                entity.Property(e => e.RequestCompletedTimestamp).HasColumnName("request_completed_timestamp");

                entity.Property(e => e.RequestTimestamp).HasColumnName("request_timestamp");

                entity.Property(e => e.RequestedPath)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnName("requested_path");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Router>(entity =>
            {
                entity.ToTable("router");

                entity.HasIndex(e => e.PhoneNumber, "router_phone_number_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.SimIccid, "router_sim_iccid_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Subdomain, "router_subdomain_uindex")
                    .IsUnique();

                entity.Property(e => e.RouterId)
                    .HasColumnName("router_id")
                    .HasDefaultValueSql("nextval('router_id_seq'::regclass)");

                entity.Property(e => e.AntennaType)
                    .HasMaxLength(64)
                    .HasColumnName("antenna_type");

                entity.Property(e => e.BatteryOnSite).HasColumnName("battery_on_site");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("city")
                    .HasDefaultValueSql("'-'::character varying");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(1023)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.DevicesAdded)
                    .HasColumnName("devices_added")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ExactLocation)
                    .HasMaxLength(255)
                    .HasColumnName("exact_location")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.FirmwareVersion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("firmware_version")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Imei)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("imei")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.InstallationDate)
                    .HasColumnType("date")
                    .HasColumnName("installation_date");

                entity.Property(e => e.InternetSubscriptionOwner)
                    .HasMaxLength(64)
                    .HasColumnName("internet_subscription_owner");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("ip_address")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsManageable).HasColumnName("is_manageable");

                entity.Property(e => e.IspType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("isp_type")
                    .HasDefaultValueSql("'UNKNOWN'::character varying");

                entity.Property(e => e.LanMacAddress)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("lan_mac_address")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("model")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NetworkManagementFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("network_management_fee");

                entity.Property(e => e.Owner)
                    .HasMaxLength(64)
                    .HasColumnName("owner");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(32)
                    .HasColumnName("phone_number");

                entity.Property(e => e.RouterPassword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("router_password")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("serial_number")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SimIccid)
                    .HasMaxLength(32)
                    .HasColumnName("sim_iccid");

                entity.Property(e => e.SimPin).HasColumnName("sim_pin");

                entity.Property(e => e.SimPuk).HasColumnName("sim_puk");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NEWLY_ADDED'::character varying");

                entity.Property(e => e.Subdomain)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("subdomain")
                    .HasDefaultValueSql("'-'::character varying");

                entity.Property(e => e.TunnelIp)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("tunnel_ip")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WifiPassword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("wifi_password")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WifiSsid)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("wifi_ssid")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<RouterPowerPlant>(entity =>
            {
                entity.ToTable("router_power_plant");

                entity.HasIndex(e => e.RouterPowerPlantId, "router_power_plant_router_power_plant_id_uindex")
                    .IsUnique();

                entity.Property(e => e.RouterPowerPlantId).HasColumnName("router_power_plant_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.RouterPowerPlants)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("router_power_plant_power_plant_power_plant_id_fk");

                entity.HasOne(d => d.Router)
                    .WithMany(p => p.RouterPowerPlants)
                    .HasForeignKey(d => d.RouterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("router_power_plant_router_router_id_fk");
            });

            modelBuilder.Entity<RouterPowerPlantV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("router__power_plant_v");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(24)
                    .HasColumnName("ip_address");

                entity.Property(e => e.IsManageable).HasColumnName("is_manageable");

                entity.Property(e => e.Owner)
                    .HasMaxLength(64)
                    .HasColumnName("owner");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PpLocationCity)
                    .HasMaxLength(255)
                    .HasColumnName("pp_location_city");

                entity.Property(e => e.PpName)
                    .HasMaxLength(255)
                    .HasColumnName("pp_name");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.Property(e => e.RouterLocationCity)
                    .HasMaxLength(64)
                    .HasColumnName("router_location_city");
            });

            modelBuilder.Entity<RouterV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("router_v");

                entity.Property(e => e.AntennaType)
                    .HasMaxLength(64)
                    .HasColumnName("antenna_type");

                entity.Property(e => e.BatteryOnSite).HasColumnName("battery_on_site");

                entity.Property(e => e.City)
                    .HasMaxLength(64)
                    .HasColumnName("city");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1023)
                    .HasColumnName("comment");

                entity.Property(e => e.DevicesAdded).HasColumnName("devices_added");

                entity.Property(e => e.ExactLocation)
                    .HasMaxLength(255)
                    .HasColumnName("exact_location");

                entity.Property(e => e.FirmwareVersion)
                    .HasMaxLength(255)
                    .HasColumnName("firmware_version");

                entity.Property(e => e.Imei)
                    .HasMaxLength(24)
                    .HasColumnName("imei");

                entity.Property(e => e.InstallationDate)
                    .HasColumnType("date")
                    .HasColumnName("installation_date");

                entity.Property(e => e.InternetSubscriptionOwner)
                    .HasMaxLength(64)
                    .HasColumnName("internet_subscription_owner");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(24)
                    .HasColumnName("ip_address");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsManageable).HasColumnName("is_manageable");

                entity.Property(e => e.IspType)
                    .HasMaxLength(255)
                    .HasColumnName("isp_type");

                entity.Property(e => e.LanMacAddress)
                    .HasMaxLength(24)
                    .HasColumnName("lan_mac_address");

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .HasColumnName("model");

                entity.Property(e => e.NetworkManagementFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("network_management_fee");

                entity.Property(e => e.Owner)
                    .HasMaxLength(64)
                    .HasColumnName("owner");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(32)
                    .HasColumnName("phone_number");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.Property(e => e.RouterPassword)
                    .HasMaxLength(255)
                    .HasColumnName("router_password");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(255)
                    .HasColumnName("serial_number");

                entity.Property(e => e.SimIccid)
                    .HasMaxLength(32)
                    .HasColumnName("sim_iccid");

                entity.Property(e => e.SimPin).HasColumnName("sim_pin");

                entity.Property(e => e.SimPuk).HasColumnName("sim_puk");

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .HasColumnName("status");

                entity.Property(e => e.Subdomain)
                    .HasMaxLength(64)
                    .HasColumnName("subdomain");

                entity.Property(e => e.TunnelIp)
                    .HasMaxLength(24)
                    .HasColumnName("tunnel_ip");

                entity.Property(e => e.WifiPassword)
                    .HasMaxLength(255)
                    .HasColumnName("wifi_password");

                entity.Property(e => e.WifiSsid)
                    .HasMaxLength(255)
                    .HasColumnName("wifi_ssid");
            });

            modelBuilder.Entity<ScheduleIdentification>(entity =>
            {
                entity.ToTable("schedule_identification");

                entity.HasIndex(e => e.ScheduleIdentificationGroupPrevDate, "idx_schedule_identification_01");

                entity.HasIndex(e => e.ScheduleIdentificationGroupId, "idx_schedule_identification_02");

                entity.HasIndex(e => e.ScheduleIdentificationGroupPrevId, "idx_schedule_identification_03");

                entity.HasIndex(e => e.MekSendersTimeSeriesIdentification, "schedule_identification_mek_senders_time_series_identificat_key")
                    .IsUnique();

                entity.HasIndex(e => e.MekSendersTimeSeriesSequentialIdentification, "schedule_identification_mek_senders_time_series_sequential__key")
                    .IsUnique();

                entity.HasIndex(e => e.PowerPlantId, "schedule_identification_power_plant_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.MekSendersTimeSeriesSequentialIdentification, "schedule_identification_s_t_s_sequential_identification_uindex")
                    .IsUnique();

                entity.Property(e => e.ScheduleIdentificationId).HasColumnName("schedule_identification_id");

                entity.Property(e => e.MekSendersTimeSeriesIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("mek_senders_time_series_identification");

                entity.Property(e => e.MekSendersTimeSeriesSequentialIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("mek_senders_time_series_sequential_identification")
                    .HasDefaultValueSql("concat('STS-', nextval('schedule_identification_s_t_s_sequential_identification_seq'::regclass))");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PredictionSource)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("prediction_source");

                entity.Property(e => e.ProsumerMaxValueW)
                    .HasColumnName("prosumer_max_value_w")
                    .HasDefaultValueSql("77777");

                entity.Property(e => e.ScheduleIdentificationGroupId).HasColumnName("schedule_identification_group_id");

                entity.Property(e => e.ScheduleIdentificationGroupPrevDate)
                    .HasColumnType("date")
                    .HasColumnName("schedule_identification_group_prev_date");

                entity.Property(e => e.ScheduleIdentificationGroupPrevId).HasColumnName("schedule_identification_group_prev_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.ScheduleIdentification)
                    .HasForeignKey<ScheduleIdentification>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ppid");

                entity.HasOne(d => d.ScheduleIdentificationGroup)
                    .WithMany(p => p.ScheduleIdentificationScheduleIdentificationGroups)
                    .HasForeignKey(d => d.ScheduleIdentificationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group_id");

                entity.HasOne(d => d.ScheduleIdentificationGroupPrev)
                    .WithMany(p => p.ScheduleIdentificationScheduleIdentificationGroupPrevs)
                    .HasForeignKey(d => d.ScheduleIdentificationGroupPrevId)
                    .HasConstraintName("fk_group_prev_id");
            });

            modelBuilder.Entity<ScheduleIdentificationGroup>(entity =>
            {
                entity.ToTable("schedule_identification_group");

                entity.HasIndex(e => e.MekSenderIdentification, "uq_sig_mek_sender_identification")
                    .IsUnique();

                entity.Property(e => e.ScheduleIdentificationGroupId)
                    .HasColumnName("schedule_identification_group_id")
                    .HasDefaultValueSql("nextval('schedule_identification_group_schedule_identification_group_seq'::regclass)");

                entity.Property(e => e.Comment)
                    .HasMaxLength(64)
                    .HasColumnName("comment");

                entity.Property(e => e.MekLastPasswordRenewingDate)
                    .HasColumnType("date")
                    .HasColumnName("mek_last_password_renewing_date");

                entity.Property(e => e.MekPassword)
                    .HasMaxLength(64)
                    .HasColumnName("mek_password");

                entity.Property(e => e.MekSenderIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("mek_sender_identification");

                entity.Property(e => e.MekUsername)
                    .HasMaxLength(64)
                    .HasColumnName("mek_username");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ScheduleDestination)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("schedule_destination");

                entity.Property(e => e.TradeModifications).HasColumnName("trade_modifications");
            });

            modelBuilder.Entity<ScheduleIdentificationGroupUnused>(entity =>
            {
                entity.HasKey(e => e.ScheduleIdentificationGroupId)
                    .HasName("schedule_identification_group_unused_pkey");

                entity.ToTable("schedule_identification_group_unused");

                entity.Property(e => e.ScheduleIdentificationGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("schedule_identification_group_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(64)
                    .HasColumnName("comment");

                entity.Property(e => e.MekLastPasswordRenewingDate)
                    .HasColumnType("date")
                    .HasColumnName("mek_last_password_renewing_date");

                entity.Property(e => e.MekPassword)
                    .HasMaxLength(64)
                    .HasColumnName("mek_password");

                entity.Property(e => e.MekSenderIdentification)
                    .HasMaxLength(64)
                    .HasColumnName("mek_sender_identification");

                entity.Property(e => e.MekUsername)
                    .HasMaxLength(64)
                    .HasColumnName("mek_username");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ScheduleDestination)
                    .HasMaxLength(32)
                    .HasColumnName("schedule_destination");

                entity.Property(e => e.TradeModifications).HasColumnName("trade_modifications");
            });

            modelBuilder.Entity<ScheduleItem>(entity =>
            {
                entity.ToTable("schedule_item");

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_01")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-01-01'::date) AND (end_time <= '2019-01-31'::date) AND ((start_time >= '2019-01-01'::date) AND (start_time <= '2019-01-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_02")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-02-01'::date) AND (end_time <= '2019-02-28'::date) AND ((start_time >= '2019-02-01'::date) AND (start_time <= '2019-02-28'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_03")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-03-01'::date) AND (end_time <= '2019-03-31'::date) AND ((start_time >= '2019-03-01'::date) AND (start_time <= '2019-03-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_04")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-04-01'::date) AND (end_time <= '2019-04-30'::date) AND ((start_time >= '2019-04-01'::date) AND (start_time <= '2019-04-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_05")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-05-01'::date) AND (end_time <= '2019-05-31'::date) AND ((start_time >= '2019-05-01'::date) AND (start_time <= '2019-05-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_06")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-06-01'::date) AND (end_time <= '2019-06-30'::date) AND ((start_time >= '2019-06-01'::date) AND (start_time <= '2019-06-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_07")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-07-01'::date) AND (end_time <= '2019-07-31'::date) AND ((start_time >= '2019-07-01'::date) AND (start_time <= '2019-07-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_08")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-08-01'::date) AND (end_time <= '2019-08-31'::date) AND ((start_time >= '2019-08-01'::date) AND (start_time <= '2019-08-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_09")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-09-01'::date) AND (end_time <= '2019-09-30'::date) AND ((start_time >= '2019-09-01'::date) AND (start_time <= '2019-09-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_10")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-10-01'::date) AND (end_time <= '2019-10-31'::date) AND ((start_time >= '2019-10-01'::date) AND (start_time <= '2019-10-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_11")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-11-01'::date) AND (end_time <= '2019-11-30'::date) AND ((start_time >= '2019-11-01'::date) AND (start_time <= '2019-11-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2019_12")
                    .IsUnique()
                    .HasFilter("((end_time >= '2019-12-01'::date) AND (end_time <= '2019-12-31'::date) AND ((start_time >= '2019-12-01'::date) AND (start_time <= '2019-12-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_01")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-01-01'::date) AND (end_time <= '2020-01-31'::date) AND ((start_time >= '2020-01-01'::date) AND (start_time <= '2020-01-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_02")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-02-01'::date) AND (end_time <= '2020-02-28'::date) AND ((start_time >= '2020-02-01'::date) AND (start_time <= '2020-02-28'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_03")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-03-01'::date) AND (end_time <= '2020-03-31'::date) AND ((start_time >= '2020-03-01'::date) AND (start_time <= '2020-03-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_04")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-04-01'::date) AND (end_time <= '2020-04-30'::date) AND ((start_time >= '2020-04-01'::date) AND (start_time <= '2020-04-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_05")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-05-01'::date) AND (end_time <= '2020-05-31'::date) AND ((start_time >= '2020-05-01'::date) AND (start_time <= '2020-05-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_06")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-06-01'::date) AND (end_time <= '2020-06-30'::date) AND ((start_time >= '2020-06-01'::date) AND (start_time <= '2020-06-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_07")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-07-01'::date) AND (end_time <= '2020-07-31'::date) AND ((start_time >= '2020-07-01'::date) AND (start_time <= '2020-07-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_08")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-08-01'::date) AND (end_time <= '2020-08-31'::date) AND ((start_time >= '2020-08-01'::date) AND (start_time <= '2020-08-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_09")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-09-01'::date) AND (end_time <= '2020-09-30'::date) AND ((start_time >= '2020-09-01'::date) AND (start_time <= '2020-09-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_10")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-10-01'::date) AND (end_time <= '2020-10-31'::date) AND ((start_time >= '2020-10-01'::date) AND (start_time <= '2020-10-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_11")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-11-01'::date) AND (end_time <= '2020-11-30'::date) AND ((start_time >= '2020-11-01'::date) AND (start_time <= '2020-11-30'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_2020_12")
                    .IsUnique()
                    .HasFilter("((end_time >= '2020-12-01'::date) AND (end_time <= '2020-12-31'::date) AND ((start_time >= '2020-12-01'::date) AND (start_time <= '2020-12-31'::date)))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_bt_2020")
                    .IsUnique()
                    .HasFilter("((end_time > '2020-12-31'::date) AND (start_time > '2020-12-31'::date))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.ScheduleType, e.EndTime, e.StartTime, e.ValueUnit, e.Quantity }, "idx_schedule_item_st_2019")
                    .IsUnique()
                    .HasFilter("((end_time < '2019-01-01'::date) AND (start_time < '2019-01-01'::date))")
                    .HasSortOrder(new[] { SortOrder.Ascending, SortOrder.Ascending, SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending, SortOrder.Ascending });

                entity.HasIndex(e => new { e.ScheduleIdentificationId, e.StartTime, e.EndTime, e.Resolution, e.ScheduleType }, "uq_schedule")
                    .IsUnique();

                entity.Property(e => e.ScheduleItemId).HasColumnName("schedule_item_id");

                entity.Property(e => e.Edited)
                    .HasColumnName("edited")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Quantity)
                    .HasPrecision(16, 6)
                    .HasColumnName("quantity");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("resolution");

                entity.Property(e => e.ScheduleIdentificationId).HasColumnName("schedule_identification_id");

                entity.Property(e => e.ScheduleStatus).HasColumnName("schedule_status");

                entity.Property(e => e.ScheduleType)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("schedule_type");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.ValueUnit)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("value_unit")
                    .HasDefaultValueSql("'kW'::character varying");

                entity.HasOne(d => d.ScheduleIdentification)
                    .WithMany(p => p.ScheduleItems)
                    .HasForeignKey(d => d.ScheduleIdentificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_si_id");
            });

            modelBuilder.Entity<ScheduleVersion>(entity =>
            {
                entity.ToTable("schedule_version");

                entity.Property(e => e.ScheduleVersionId).HasColumnName("schedule_version_id");

                entity.Property(e => e.LastSubmittedVersion).HasColumnName("last_submitted_version");

                entity.Property(e => e.ScheduleDate)
                    .HasColumnType("date")
                    .HasColumnName("schedule_date");

                entity.Property(e => e.ScheduleIdentificationGroupId).HasColumnName("schedule_identification_group_id");

                entity.HasOne(d => d.ScheduleIdentificationGroup)
                    .WithMany(p => p.ScheduleVersions)
                    .HasForeignKey(d => d.ScheduleIdentificationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("schedule_identification_group_id_fk");
            });

            modelBuilder.Entity<SchedulingIdentification>(entity =>
            {
                entity.ToTable("scheduling_identification");

                entity.Property(e => e.SchedulingIdentificationId)
                    .HasColumnName("scheduling_identification_id")
                    .HasDefaultValueSql("nextval('scheduling_identification_id_seq'::regclass)");

                entity.Property(e => e.ActiveScheduling)
                    .IsRequired()
                    .HasColumnName("active_scheduling")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MeteringPointIdentification)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("metering_point_identification");

                entity.Property(e => e.PowerPlantExternalIdentification)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("power_plant_external_identification");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.SchedulingIdentifications)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_scheduling_identification_power_plant");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.ServiceFeeId)
                    .HasName("services_pkey");

                entity.ToTable("services");

                entity.HasIndex(e => e.PowerPlantId, "uk_trhv5hpqetp6kqcqtomc7oslo")
                    .IsUnique();

                entity.HasIndex(e => e.PowerPlantId, "uq_services_power_plant_id")
                    .IsUnique();

                entity.Property(e => e.ServiceFeeId).HasColumnName("service_fee_id");

                entity.Property(e => e.ActiveBilling)
                    .IsRequired()
                    .HasColumnName("active_billing")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActiveInverterControl).HasColumnName("active_inverter_control");

                entity.Property(e => e.ActiveInverterMonitoring).HasColumnName("active_inverter_monitoring");

                entity.Property(e => e.ActiveMekh)
                    .IsRequired()
                    .HasColumnName("active_mekh")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ActivePrediction).HasColumnName("active_prediction");

                entity.Property(e => e.Currency)
                    .HasMaxLength(191)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'HUF'::character varying");

                entity.Property(e => e.PaymentCycle)
                    .HasColumnName("payment_cycle")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PaymentIgnoreFrom).HasColumnName("payment_ignore_from");

                entity.Property(e => e.PaymentIgnoreUntil).HasColumnName("payment_ignore_until");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(191)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'KAT'::character varying");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.TotalBaseFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("total_base_fee");

                entity.Property(e => e.TotalFeedInTariffFixFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("total_feed_in_tariff_fix_fee");

                entity.Property(e => e.TotalSuccessFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("total_success_fee");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.Service)
                    .HasForeignKey<Service>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_services_pvplant");
            });

            modelBuilder.Entity<SystemState>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("system_state");

                entity.Property(e => e.AfrrDown).HasColumnName("afrr_down");

                entity.Property(e => e.AfrrDownCountry).HasColumnName("afrr_down_country");

                entity.Property(e => e.AfrrUp).HasColumnName("afrr_up");

                entity.Property(e => e.AfrrUpCountry).HasColumnName("afrr_up_country");

                entity.Property(e => e.CountryType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("country_type");

                entity.Property(e => e.EndDatetime).HasColumnName("end_datetime");

                entity.Property(e => e.HistCreationDatetime)
                    .HasColumnName("hist_creation_datetime")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IgccDown).HasColumnName("igcc_down");

                entity.Property(e => e.IgccUp).HasColumnName("igcc_up");

                entity.Property(e => e.MfrrDown).HasColumnName("mfrr_down");

                entity.Property(e => e.MfrrUp).HasColumnName("mfrr_up");

                entity.Property(e => e.NotBalancingEnergyDown).HasColumnName("not_balancing_energy_down");

                entity.Property(e => e.NotBalancingEnergyUp).HasColumnName("not_balancing_energy_up");

                entity.Property(e => e.PowerValueUnit)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("power_value_unit");

                entity.Property(e => e.PvErrorToMeasurement).HasColumnName("pv_error_to_measurement");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("resolution");

                entity.Property(e => e.StartDatetime).HasColumnName("start_datetime");

                entity.Property(e => e.SystemStateId)
                    .HasColumnName("system_state_id")
                    .HasDefaultValueSql("nextval('system_state_id_seq'::regclass)");

                entity.Property(e => e.WindErrorToMeasurement).HasColumnName("wind_error_to_measurement");
            });

            modelBuilder.Entity<SystemStateForecast>(entity =>
            {
                entity.ToTable("system_state_forecast");

                entity.HasIndex(e => e.SystemStateForecastId, "system_state_forecast_system_state_forecast_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => new { e.BalanceGroupType, e.CountryType, e.StartDatetime, e.EndDatetime, e.ScheduleIdentificationGroupId }, "uq_system_state_forecast_bg_country_start_end_group_id")
                    .IsUnique();

                entity.Property(e => e.SystemStateForecastId)
                    .HasColumnName("system_state_forecast_id")
                    .HasDefaultValueSql("nextval('system_state_forecast_id_seq'::regclass)");

                entity.Property(e => e.AverageMeasurementTimeAfterSunriseMin).HasColumnName("average_measurement_time_after_sunrise_min");

                entity.Property(e => e.BalanceGroupType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("balance_group_type");

                entity.Property(e => e.CountryType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("country_type");

                entity.Property(e => e.DaForecastToMeasurement).HasColumnName("da_forecast_to_measurement");

                entity.Property(e => e.EndDatetime).HasColumnName("end_datetime");

                entity.Property(e => e.EstimatedIdWeatherType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("estimated_id_weather_type");

                entity.Property(e => e.IdForecastToMeasurement).HasColumnName("id_forecast_to_measurement");

                entity.Property(e => e.LeadTimeMin).HasColumnName("lead_time_min");

                entity.Property(e => e.MeasurementDatetime)
                    .HasColumnName("measurement_datetime")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.PowerValueUnit)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("power_value_unit");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("resolution");

                entity.Property(e => e.ScheduleIdentificationGroupId).HasColumnName("schedule_identification_group_id");

                entity.Property(e => e.StartDatetime).HasColumnName("start_datetime");

                entity.Property(e => e.SystemStatePrediction).HasColumnName("system_state_prediction");
            });

            modelBuilder.Entity<TradingOfferVersion>(entity =>
            {
                entity.ToTable("trading_offer_version");

                entity.HasIndex(e => new { e.PowerControlGroupId, e.OfferDate }, "uq_trading_offer_version")
                    .IsUnique();

                entity.Property(e => e.TradingOfferVersionId)
                    .HasColumnName("trading_offer_version_id")
                    .HasDefaultValueSql("nextval('trading_offer_version_id_seq'::regclass)");

                entity.Property(e => e.LastSubmittedVersion).HasColumnName("last_submitted_version");

                entity.Property(e => e.OfferDate)
                    .HasColumnType("date")
                    .HasColumnName("offer_date");

                entity.Property(e => e.PowerControlGroupId).HasColumnName("power_control_group_id");

                entity.HasOne(d => d.PowerControlGroup)
                    .WithMany(p => p.TradingOfferVersions)
                    .HasForeignKey(d => d.PowerControlGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_trading_offer_version_pcg");
            });

            modelBuilder.Entity<TradingTactic>(entity =>
            {
                entity.ToTable("trading_tactic");

                entity.HasIndex(e => e.TradingTacticId, "trading_tactic_trading_tactic_id_uindex")
                    .IsUnique();

                entity.Property(e => e.TradingTacticId).HasColumnName("trading_tactic_id");

                entity.Property(e => e.ActualPowerToIdScheduleCloudyLimit).HasColumnName("actual_power_to_id_schedule_cloudy_limit");

                entity.Property(e => e.ActualPowerToIdScheduleCloudyUsage).HasColumnName("actual_power_to_id_schedule_cloudy_usage");

                entity.Property(e => e.ActualPowerToIdScheduleFogLimit).HasColumnName("actual_power_to_id_schedule_fog_limit");

                entity.Property(e => e.ActualPowerToIdScheduleFogUsage).HasColumnName("actual_power_to_id_schedule_fog_usage");

                entity.Property(e => e.ActualPowerToIdScheduleModerateLimit).HasColumnName("actual_power_to_id_schedule_moderate_limit");

                entity.Property(e => e.ActualPowerToIdScheduleModerateMaxUsage).HasColumnName("actual_power_to_id_schedule_moderate_max_usage");

                entity.Property(e => e.ActualPowerToIdScheduleModerateStandardUsage).HasColumnName("actual_power_to_id_schedule_moderate_standard_usage");

                entity.Property(e => e.ActualPowerToIdScheduleModerateUpperLimit).HasColumnName("actual_power_to_id_schedule_moderate_upper_limit");

                entity.Property(e => e.ActualPowerToIdScheduleSunLimit).HasColumnName("actual_power_to_id_schedule_sun_limit");

                entity.Property(e => e.ActualPowerToIdScheduleSunLimitStage).HasColumnName("actual_power_to_id_schedule_sun_limit_stage");

                entity.Property(e => e.ActualPowerToIdScheduleSunUsageFirstStage).HasColumnName("actual_power_to_id_schedule_sun_usage_first_stage");

                entity.Property(e => e.ActualPowerToIdScheduleSunUsageSecondStage).HasColumnName("actual_power_to_id_schedule_sun_usage_second_stage");

                entity.Property(e => e.AffrRampDownActivationPriceLimit)
                    .HasPrecision(7, 1)
                    .HasColumnName("affr_ramp_down_activation_price_limit")
                    .HasDefaultValueSql("70000.0");

                entity.Property(e => e.AutoSystemStateCorrection).HasColumnName("auto_system_state_correction");

                entity.Property(e => e.BadWeatherModVariable).HasColumnName("bad_weather_mod_variable");

                entity.Property(e => e.BalanceGroupType)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("balance_group_type");

                entity.Property(e => e.Country)
                    .HasColumnType("character varying")
                    .HasColumnName("country");

                entity.Property(e => e.CreationTimestamp).HasColumnName("creation_timestamp");

                entity.Property(e => e.CriticalEventPowerBuying)
                    .HasPrecision(5, 2)
                    .HasColumnName("critical_event_power_buying");

                entity.Property(e => e.CriticalEventPowerSelling)
                    .HasPrecision(5, 2)
                    .HasColumnName("critical_event_power_selling");

                entity.Property(e => e.DaCloudyWeatherModValue).HasColumnName("da_cloudy_weather_mod_value");

                entity.Property(e => e.DaModerateWeatherModValue).HasColumnName("da_moderate_weather_mod_value");

                entity.Property(e => e.DaSunnyWeatherModValue).HasColumnName("da_sunny_weather_mod_value");

                entity.Property(e => e.DaUsageSunnyRateLimit)
                    .HasPrecision(4, 3)
                    .HasColumnName("da_usage_sunny_rate_limit")
                    .HasDefaultValueSql("0.88");

                entity.Property(e => e.DaUsageSunnyTimeLimit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("da_usage_sunny_time_limit")
                    .HasDefaultValueSql("'11:00'::character varying");

                entity.Property(e => e.DownSystemStateCloudyCorrection).HasColumnName("down_system_state_cloudy_correction");

                entity.Property(e => e.DownSystemStateCloudyLowerLimitMw).HasColumnName("down_system_state_cloudy_lower_limit_mw");

                entity.Property(e => e.DownSystemStateCloudyUpperLimitMw).HasColumnName("down_system_state_cloudy_upper_limit_mw");

                entity.Property(e => e.DownSystemStateModerateCorrection).HasColumnName("down_system_state_moderate_correction");

                entity.Property(e => e.DownSystemStateModerateLowerLimitMw).HasColumnName("down_system_state_moderate_lower_limit_mw");

                entity.Property(e => e.DownSystemStateModerateUpperLimitMw).HasColumnName("down_system_state_moderate_upper_limit_mw");

                entity.Property(e => e.DownSystemStateSunnyCorrection).HasColumnName("down_system_state_sunny_correction");

                entity.Property(e => e.DownSystemStateSunnyLowerLimitMw).HasColumnName("down_system_state_sunny_lower_limit_mw");

                entity.Property(e => e.DownSystemStateSunnyUpperLimitMw).HasColumnName("down_system_state_sunny_upper_limit_mw");

                entity.Property(e => e.EndTimeAfterSunriseMin).HasColumnName("end_time_after_sunrise_min");

                entity.Property(e => e.EndTimeCalculationAfterSunriseMin).HasColumnName("end_time_calculation_after_sunrise_min");

                entity.Property(e => e.FogTimeHorizontMin).HasColumnName("fog_time_horizont_min");

                entity.Property(e => e.FogyGradientCorrection).HasColumnName("fogy_gradient_correction");

                entity.Property(e => e.GoodWeatherModVariable).HasColumnName("good_weather_mod_variable");

                entity.Property(e => e.IdCloudyWeatherModValue).HasColumnName("id_cloudy_weather_mod_value");

                entity.Property(e => e.IdModerateWeatherModValue).HasColumnName("id_moderate_weather_mod_value");

                entity.Property(e => e.IdSunnyWeatherModValue).HasColumnName("id_sunny_weather_mod_value");

                entity.Property(e => e.PowerLimitForXgKw).HasColumnName("power_limit_for_xg_kw");

                entity.Property(e => e.ScheduleIdentificationGroupId).HasColumnName("schedule_identification_group_id");

                entity.Property(e => e.SmoothingPercentageLimit).HasColumnName("smoothing_percentage_limit");

                entity.Property(e => e.SmoothingVariable).HasColumnName("smoothing_variable");

                entity.Property(e => e.StartTimeAfterSunriseNoSunriseMin).HasColumnName("start_time_after_sunrise_no_sunrise_min");

                entity.Property(e => e.SunPositionLimitForSmoothing).HasColumnName("sun_position_limit_for_smoothing");

                entity.Property(e => e.SunPositionLimitForXg).HasColumnName("sun_position_limit_for_xg");

                entity.Property(e => e.SystemStateAdjustmentsJson)
                    .IsRequired()
                    .HasMaxLength(999999)
                    .HasColumnName("system_state_adjustments_json");

                entity.Property(e => e.UpSystemStateCloudyCorrection).HasColumnName("up_system_state_cloudy_correction");

                entity.Property(e => e.UpSystemStateCloudyLowerLimitMw).HasColumnName("up_system_state_cloudy_lower_limit_mw");

                entity.Property(e => e.UpSystemStateCloudyUpperLimitMw).HasColumnName("up_system_state_cloudy_upper_limit_mw");

                entity.Property(e => e.UpSystemStateModerateCorrection).HasColumnName("up_system_state_moderate_correction");

                entity.Property(e => e.UpSystemStateModerateLowerLimitMw).HasColumnName("up_system_state_moderate_lower_limit_mw");

                entity.Property(e => e.UpSystemStateModerateUpperLimitMw).HasColumnName("up_system_state_moderate_upper_limit_mw");

                entity.Property(e => e.UpSystemStateSunnyCorrection).HasColumnName("up_system_state_sunny_correction");

                entity.Property(e => e.UpSystemStateSunnyLowerLimitMw).HasColumnName("up_system_state_sunny_lower_limit_mw");

                entity.Property(e => e.UpSystemStateSunnyUpperLimitMw).HasColumnName("up_system_state_sunny_upper_limit_mw");

                entity.Property(e => e.UsingXg).HasColumnName("using_xg");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transaction");

                entity.HasIndex(e => e.TransactionId, "transaction_transaction_id_uindex")
                    .IsUnique();

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasDefaultValueSql("nextval('transactions_transaction_id_seq'::regclass)");

                entity.Property(e => e.CommentOnInv)
                    .HasMaxLength(191)
                    .HasColumnName("comment_on_inv")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Confirmed)
                    .HasColumnName("confirmed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.PaymentPeriodEnd).HasColumnName("payment_period_end");

                entity.Property(e => e.PaymentPeriodStart).HasColumnName("payment_period_start");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(199)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'KAT'::character varying");

                entity.Property(e => e.Type)
                    .HasMaxLength(191)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<TransactionItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("transaction_item");

                entity.Property(e => e.Comment)
                    .HasMaxLength(191)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.GrossValue).HasColumnName("gross_value");

                entity.Property(e => e.IsGroupMember)
                    .HasColumnName("is_group_member")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.NetValue).HasColumnName("net_value");

                entity.Property(e => e.OnProduction).HasColumnName("on_production");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.TransactionItemId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("transaction_item_id");

                entity.Property(e => e.UniqueIdentifier).HasColumnName("unique_identifier");

                entity.Property(e => e.UniqueIdentifierType)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("unique_identifier_type");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<UnassignedRoutersV>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("unassigned_routers_v");

                entity.Property(e => e.AntennaType)
                    .HasMaxLength(64)
                    .HasColumnName("antenna_type");

                entity.Property(e => e.BatteryOnSite).HasColumnName("battery_on_site");

                entity.Property(e => e.City)
                    .HasMaxLength(64)
                    .HasColumnName("city");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1023)
                    .HasColumnName("comment");

                entity.Property(e => e.DevicesAdded).HasColumnName("devices_added");

                entity.Property(e => e.ExactLocation)
                    .HasMaxLength(255)
                    .HasColumnName("exact_location");

                entity.Property(e => e.FirmwareVersion)
                    .HasMaxLength(255)
                    .HasColumnName("firmware_version");

                entity.Property(e => e.Imei)
                    .HasMaxLength(24)
                    .HasColumnName("imei");

                entity.Property(e => e.InstallationDate)
                    .HasColumnType("date")
                    .HasColumnName("installation_date");

                entity.Property(e => e.InternetSubscriptionOwner)
                    .HasMaxLength(64)
                    .HasColumnName("internet_subscription_owner");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(24)
                    .HasColumnName("ip_address");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsManageable).HasColumnName("is_manageable");

                entity.Property(e => e.IspType)
                    .HasMaxLength(255)
                    .HasColumnName("isp_type");

                entity.Property(e => e.LanMacAddress)
                    .HasMaxLength(24)
                    .HasColumnName("lan_mac_address");

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .HasColumnName("model");

                entity.Property(e => e.NetworkManagementFee)
                    .HasPrecision(11, 2)
                    .HasColumnName("network_management_fee");

                entity.Property(e => e.Owner)
                    .HasMaxLength(64)
                    .HasColumnName("owner");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(32)
                    .HasColumnName("phone_number");

                entity.Property(e => e.RouterId).HasColumnName("router_id");

                entity.Property(e => e.RouterPassword)
                    .HasMaxLength(255)
                    .HasColumnName("router_password");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(255)
                    .HasColumnName("serial_number");

                entity.Property(e => e.SimIccid)
                    .HasMaxLength(32)
                    .HasColumnName("sim_iccid");

                entity.Property(e => e.SimPin).HasColumnName("sim_pin");

                entity.Property(e => e.SimPuk).HasColumnName("sim_puk");

                entity.Property(e => e.Subdomain)
                    .HasMaxLength(64)
                    .HasColumnName("subdomain");

                entity.Property(e => e.TunnelIp)
                    .HasMaxLength(24)
                    .HasColumnName("tunnel_ip");

                entity.Property(e => e.WifiPassword)
                    .HasMaxLength(255)
                    .HasColumnName("wifi_password");

                entity.Property(e => e.WifiSsid)
                    .HasMaxLength(255)
                    .HasColumnName("wifi_ssid");
            });

            modelBuilder.Entity<UserCompany>(entity =>
            {
                entity.ToTable("user_company");

                entity.HasIndex(e => new { e.UserId, e.CompanyId }, "uq_user_company_1")
                    .IsUnique();

                entity.HasIndex(e => e.UserCompanyId, "user_company_user_company_id_uindex")
                    .IsUnique();

                entity.Property(e => e.UserCompanyId).HasColumnName("user_company_id");

                entity.Property(e => e.ActiveEwiserBillingNotification).HasColumnName("active_ewiser_billing_notification");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserCompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_company_company_company_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCompanies)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_company_ewiser_user_user_id_fk");
            });

            modelBuilder.Entity<UserPowerPlant>(entity =>
            {
                entity.ToTable("user_power_plant");

                entity.HasIndex(e => new { e.PowerPlantId, e.UserId }, "uq_user_power_plant")
                    .IsUnique();

                entity.Property(e => e.UserPowerPlantId)
                    .HasColumnName("user_power_plant_id")
                    .HasDefaultValueSql("nextval('user_pv_plant_user_plant_id_seq'::regclass)");

                entity.Property(e => e.ActiveBillingNotification).HasColumnName("active_billing_notification");

                entity.Property(e => e.ActiveBillingPostNotification).HasColumnName("active_billing_post_notification");

                entity.Property(e => e.ActiveBillingSampleNotification).HasColumnName("active_billing_sample_notification");

                entity.Property(e => e.ActiveDatasheetIncomeValidationNotification)
                    .HasColumnName("active_datasheet_income_validation_notification")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ActiveDatasheetNotification).HasColumnName("active_datasheet_notification");

                entity.Property(e => e.ActiveDatasheetSampleNotification).HasColumnName("active_datasheet_sample_notification");

                entity.Property(e => e.ActiveDatasheetSelfConsumptionNotification)
                    .HasColumnName("active_datasheet_self_consumption_notification")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ActiveEwiserPayoff).HasColumnName("active_ewiser_payoff");

                entity.Property(e => e.ActiveInverterMonitoringErrorNotification).HasColumnName("active_inverter_monitoring_error_notification");

                entity.Property(e => e.ActiveInverterMonitoringMonthlyPdf).HasColumnName("active_inverter_monitoring_monthly_pdf");

                entity.Property(e => e.ActiveScheduleNotification).HasColumnName("active_schedule_notification");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.PowerPlant)
                    .WithMany(p => p.UserPowerPlants)
                    .HasForeignKey(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk2203m0oe0hq0ltfil0oh75r40");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPowerPlants)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkanopm9gqynb4m2cdfk041rth");
            });

            modelBuilder.Entity<UserScheduleIdentificationGroup>(entity =>
            {
                entity.ToTable("user_schedule_identification_group");

                entity.Property(e => e.UserScheduleIdentificationGroupId)
                    .HasColumnName("user_schedule_identification_group_id")
                    .HasDefaultValueSql("nextval('user_schedule_identification__user_schedule_identification__seq'::regclass)");

                entity.Property(e => e.ScheduleIdentificationGroupId).HasColumnName("schedule_identification_group_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ScheduleIdentificationGroup)
                    .WithMany(p => p.UserScheduleIdentificationGroups)
                    .HasForeignKey(d => d.ScheduleIdentificationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserScheduleIdentificationGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_id");
            });

            modelBuilder.Entity<Webcam>(entity =>
            {
                entity.ToTable("webcam");

                entity.HasIndex(e => e.WebcamId, "webcam_webcam_id_uindex")
                    .IsUnique();

                entity.Property(e => e.WebcamId).HasColumnName("webcam_id");

                entity.Property(e => e.CrawlerType)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("crawler_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Desc).HasColumnName("desc");

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("device_id")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ForecastModelId).HasColumnName("forecast_model_id");

                entity.Property(e => e.GpsLat)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("gps_lat");

                entity.Property(e => e.GpsLng)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("gps_lng");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("link");

                entity.Property(e => e.Resolution)
                    .HasMaxLength(191)
                    .HasColumnName("resolution");

                entity.Property(e => e.TimeCorrection)
                    .HasMaxLength(191)
                    .HasColumnName("time_correction")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<WebcamPicture>(entity =>
            {
                entity.ToTable("webcam_picture");

                entity.HasIndex(e => e.WebcamPictureId, "webcam_picture_webcam_picture_id_uindex")
                    .IsUnique();

                entity.Property(e => e.WebcamPictureId).HasColumnName("webcam_picture_id");

                entity.Property(e => e.AssignedToUserId).HasColumnName("assigned_to_user_id");

                entity.Property(e => e.ConfirmedByUserId).HasColumnName("confirmed_by_user_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FileLocation)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("file_location")
                    .HasDefaultValueSql("191");

                entity.Property(e => e.StoragePath)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("storage_path")
                    .HasDefaultValueSql("191");

                entity.Property(e => e.StorageType)
                    .HasColumnType("character varying")
                    .HasColumnName("storage_type")
                    .HasDefaultValueSql("191");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("timestamp");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.WeatherType)
                    .HasMaxLength(191)
                    .HasColumnName("weather_type")
                    .HasDefaultValueSql("NULL::character varying");

                entity.Property(e => e.WebcamId).HasColumnName("webcam_id");
            });

            modelBuilder.Entity<WindParkPhysical>(entity =>
            {
                entity.ToTable("wind_park_physical");

                entity.HasIndex(e => new { e.Latitude, e.Longitude }, "uq_wind_park_physical_latitude_longitude")
                    .IsUnique();

                entity.HasIndex(e => e.PowerPlantId, "uq_wind_park_physical_power_plant_id")
                    .IsUnique();

                entity.HasIndex(e => e.WindParkPhysicalId, "wind_park_physical_wind_park_physical_id_uindex")
                    .IsUnique();

                entity.Property(e => e.WindParkPhysicalId).HasColumnName("wind_park_physical_id");

                entity.Property(e => e.KatContractStartDate)
                    .HasColumnType("date")
                    .HasColumnName("kat_contract_start_date");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.PowerOutputWatt).HasColumnName("power_output_watt");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.RealProductionStartDate)
                    .HasColumnType("date")
                    .HasColumnName("real_production_start_date");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_date");

                entity.Property(e => e.Timezone)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("timezone");

                entity.Property(e => e.TransformerCopperLoss).HasColumnName("transformer_copper_loss");

                entity.Property(e => e.TransformerIronLoss).HasColumnName("transformer_iron_loss");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.WindParkPhysical)
                    .HasForeignKey<WindParkPhysical>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wind_park_physical_power_plant");
            });

            modelBuilder.Entity<WindParkTempParameter>(entity =>
            {
                entity.HasKey(e => e.WindParkTempParametersId)
                    .HasName("wind_park_temp_parameters_pk");

                entity.ToTable("wind_park_temp_parameters");

                entity.HasIndex(e => e.PowerPlantId, "uq_wind_park_temp_parameters_power_plant_id")
                    .IsUnique();

                entity.HasIndex(e => e.WindParkTempParametersId, "wind_park_temp_parameters_wind_park_temp_parameters_id_uindex")
                    .IsUnique();

                entity.Property(e => e.WindParkTempParametersId).HasColumnName("wind_park_temp_parameters_id");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PredictionParameters)
                    .IsRequired()
                    .HasMaxLength(65536)
                    .HasColumnName("prediction_parameters");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.WindParkTempParameter)
                    .HasForeignKey<WindParkTempParameter>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wind_park_temp_parameters_power_plant");
            });

            modelBuilder.Entity<WindParkTempParametersReadonly>(entity =>
            {
                entity.ToTable("wind_park_temp_parameters_readonly");

                entity.HasIndex(e => e.PowerPlantId, "uq_wind_park_temp_parameters_readonly_power_plant_id")
                    .IsUnique();

                entity.HasIndex(e => e.WindParkTempParametersReadonlyId, "wind_park_temp_parameters_readonly_wind_park_temp_parameters_re")
                    .IsUnique();

                entity.Property(e => e.WindParkTempParametersReadonlyId)
                    .HasColumnName("wind_park_temp_parameters_readonly_id")
                    .HasDefaultValueSql("nextval('wind_park_temp_parameters_readonly_id_seq'::regclass)");

                entity.Property(e => e.FeedInPrice).HasColumnName("feed_in_price");

                entity.Property(e => e.NeuralNetworkZip).HasColumnName("neural_network_zip");

                entity.Property(e => e.PowerPlantId).HasColumnName("power_plant_id");

                entity.Property(e => e.PredictionParameters)
                    .IsRequired()
                    .HasMaxLength(65536)
                    .HasColumnName("prediction_parameters");

                entity.Property(e => e.XgboostZip).HasColumnName("xgboost_zip");

                entity.HasOne(d => d.PowerPlant)
                    .WithOne(p => p.WindParkTempParametersReadonly)
                    .HasForeignKey<WindParkTempParametersReadonly>(d => d.PowerPlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wind_park_temp_parameters_readonly_power_plant");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
