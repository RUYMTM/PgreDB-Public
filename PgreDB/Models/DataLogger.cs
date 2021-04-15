using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class DataLogger
    {
        public DataLogger()
        {
            DataLoggerPowerPlants = new HashSet<DataLoggerPowerPlant>();
            DataLoggerStatusCooldowns = new HashSet<DataLoggerStatusCooldown>();
            DataLoggerStatuses = new HashSet<DataLoggerStatus>();
            Inverters = new HashSet<Inverter>();
        }

        public int DataLoggerId { get; set; }
        public string RemotePath { get; set; }
        public string ConnectionType { get; set; }
        public double EnergyDivergenceLimit { get; set; }
        public double MaxTempDivergenceLimit { get; set; }
        public double PowerDivergenceLimit { get; set; }
        public string DataLoggerType { get; set; }
        public double InverterMonthlyEnergyDivergenceLimit { get; set; }
        public string Apikey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string KofUrl { get; set; }
        public string CameraUrl { get; set; }
        public string Comment { get; set; }
        public bool? PowerAdjustmentAvailable { get; set; }
        public string DateTimeZone { get; set; }
        public int? ModbusManagerDeviceId { get; set; }
        public int? HttpPullDeviceId { get; set; }

        public virtual Device HttpPullDevice { get; set; }
        public virtual Device ModbusManagerDevice { get; set; }
        public virtual ICollection<DataLoggerPowerPlant> DataLoggerPowerPlants { get; set; }
        public virtual ICollection<DataLoggerStatusCooldown> DataLoggerStatusCooldowns { get; set; }
        public virtual ICollection<DataLoggerStatus> DataLoggerStatuses { get; set; }
        public virtual ICollection<Inverter> Inverters { get; set; }
    }
}
