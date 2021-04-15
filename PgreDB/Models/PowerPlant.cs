using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerPlant
    {
        public PowerPlant()
        {
            BreakdownEvents = new HashSet<BreakdownEvent>();
            ContactPowerPlantOldTodeletes = new HashSet<ContactPowerPlantOldTodelete>();
            DataLoggerPowerPlants = new HashSet<DataLoggerPowerPlant>();
            DepositPowerPlants = new HashSet<DepositPowerPlant>();
            FilePowerPlants = new HashSet<FilePowerPlant>();
            Forms = new HashSet<Form>();
            HistBreakdownEvents = new HashSet<HistBreakdownEvent>();
            InverterMeasurementEnoughData = new HashSet<InverterMeasurementEnoughDatum>();
            Inverters = new HashSet<Inverter>();
            MeteringPointMeasurements = new HashSet<MeteringPointMeasurement>();
            NotePowerPlants = new HashSet<NotePowerPlant>();
            PowerAdjustmentEventHists = new HashSet<PowerAdjustmentEventHist>();
            PowerAdjustmentEvents = new HashSet<PowerAdjustmentEvent>();
            PowerControlEnergyReferencePowerPlantPowerPlants = new HashSet<PowerControlEnergyReferencePowerPlant>();
            PowerControlEnergyReferencePowerPlantReferencePowerPlants = new HashSet<PowerControlEnergyReferencePowerPlant>();
            PowerPlantMonitoringSettings = new HashSet<PowerPlantMonitoringSetting>();
            ProductionData = new HashSet<ProductionDatum>();
            PvPlantTempParametersHistories = new HashSet<PvPlantTempParametersHistory>();
            RouterPowerPlants = new HashSet<RouterPowerPlant>();
            SchedulingIdentifications = new HashSet<SchedulingIdentification>();
            UserPowerPlants = new HashSet<UserPowerPlant>();
        }

        public int PowerPlantId { get; set; }
        public string Name { get; set; }
        public string PowerPlantReferenceId { get; set; }
        public int BillingId { get; set; }
        public int CoordinatorId { get; set; }
        public int OwnerId { get; set; }
        public int SpId { get; set; }
        public string PowerPlantType { get; set; }
        public string MeteringPointIdentification { get; set; }
        public string UnguessableName { get; set; }
        public string DocumentSz { get; set; }
        public string DocumentCs { get; set; }
        public string DocumentE { get; set; }
        public string LocationCity { get; set; }
        public string LocationParcelNumber { get; set; }
        public bool MkpSynced { get; set; }
        public string PrimaryWeatherProvider { get; set; }
        public bool MkpRegisterDataHistorySynced { get; set; }
        public bool MkpLoadProfileHistorySynced { get; set; }
        public string KatSubsidyConfirmation { get; set; }
        public int? PowerControlGroupId { get; set; }
        public string PowerControlComment { get; set; }
        public string KatSubsidyValidTo { get; set; }

        public virtual Company Billing { get; set; }
        public virtual Company Coordinator { get; set; }
        public virtual Company Owner { get; set; }
        public virtual PowerControlGroup PowerControlGroup { get; set; }
        public virtual Company Sp { get; set; }
        public virtual InverterMonitoringMeasurementError InverterMonitoringMeasurementError { get; set; }
        public virtual MekIdentification MekIdentification { get; set; }
        public virtual MekhIdentification MekhIdentification { get; set; }
        public virtual PvPlantPhysical PvPlantPhysical { get; set; }
        public virtual PvPlantTempParameter PvPlantTempParameter { get; set; }
        public virtual PvPlantTempParametersReadonly PvPlantTempParametersReadonly { get; set; }
        public virtual ScheduleIdentification ScheduleIdentification { get; set; }
        public virtual Service Service { get; set; }
        public virtual WindParkPhysical WindParkPhysical { get; set; }
        public virtual WindParkTempParameter WindParkTempParameter { get; set; }
        public virtual WindParkTempParametersReadonly WindParkTempParametersReadonly { get; set; }
        public virtual ICollection<BreakdownEvent> BreakdownEvents { get; set; }
        public virtual ICollection<ContactPowerPlantOldTodelete> ContactPowerPlantOldTodeletes { get; set; }
        public virtual ICollection<DataLoggerPowerPlant> DataLoggerPowerPlants { get; set; }
        public virtual ICollection<DepositPowerPlant> DepositPowerPlants { get; set; }
        public virtual ICollection<FilePowerPlant> FilePowerPlants { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
        public virtual ICollection<HistBreakdownEvent> HistBreakdownEvents { get; set; }
        public virtual ICollection<InverterMeasurementEnoughDatum> InverterMeasurementEnoughData { get; set; }
        public virtual ICollection<Inverter> Inverters { get; set; }
        public virtual ICollection<MeteringPointMeasurement> MeteringPointMeasurements { get; set; }
        public virtual ICollection<NotePowerPlant> NotePowerPlants { get; set; }
        public virtual ICollection<PowerAdjustmentEventHist> PowerAdjustmentEventHists { get; set; }
        public virtual ICollection<PowerAdjustmentEvent> PowerAdjustmentEvents { get; set; }
        public virtual ICollection<PowerControlEnergyReferencePowerPlant> PowerControlEnergyReferencePowerPlantPowerPlants { get; set; }
        public virtual ICollection<PowerControlEnergyReferencePowerPlant> PowerControlEnergyReferencePowerPlantReferencePowerPlants { get; set; }
        public virtual ICollection<PowerPlantMonitoringSetting> PowerPlantMonitoringSettings { get; set; }
        public virtual ICollection<ProductionDatum> ProductionData { get; set; }
        public virtual ICollection<PvPlantTempParametersHistory> PvPlantTempParametersHistories { get; set; }
        public virtual ICollection<RouterPowerPlant> RouterPowerPlants { get; set; }
        public virtual ICollection<SchedulingIdentification> SchedulingIdentifications { get; set; }
        public virtual ICollection<UserPowerPlant> UserPowerPlants { get; set; }
    }
}
