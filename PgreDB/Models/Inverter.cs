using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Inverter
    {
        public Inverter()
        {
            InverterEnergyYields = new HashSet<InverterEnergyYield>();
            InverterPowerControlCommandHistories = new HashSet<InverterPowerControlCommandHistory>();
            InverterPowerControlCommands = new HashSet<InverterPowerControlCommand>();
            InverterStatusCooldowns = new HashSet<InverterStatusCooldown>();
            InverterStatuses = new HashSet<InverterStatus>();
        }

        public int InverterId { get; set; }
        public string Name { get; set; }
        public string NameByUser { get; set; }
        public int DataLoggerId { get; set; }
        public int MeasurementPointNumber { get; set; }
        public string PvModuleNumberJsonArray { get; set; }
        public bool ReadyToWork { get; set; }
        public bool Inactive { get; set; }
        public int? ModbusSlaveId { get; set; }
        public int? PowerPlantId { get; set; }
        public int MaxAllowedAcPower { get; set; }
        public int AvailableTotalAcPower { get; set; }
        public int RatedAcPower { get; set; }
        public string ModbusType { get; set; }
        public bool? Producing { get; set; }
        public bool? Controllable { get; set; }

        public virtual DataLogger DataLogger { get; set; }
        public virtual PowerPlant PowerPlant { get; set; }
        public virtual ICollection<InverterEnergyYield> InverterEnergyYields { get; set; }
        public virtual ICollection<InverterPowerControlCommandHistory> InverterPowerControlCommandHistories { get; set; }
        public virtual ICollection<InverterPowerControlCommand> InverterPowerControlCommands { get; set; }
        public virtual ICollection<InverterStatusCooldown> InverterStatusCooldowns { get; set; }
        public virtual ICollection<InverterStatus> InverterStatuses { get; set; }
    }
}
