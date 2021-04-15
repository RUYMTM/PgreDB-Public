using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerPlantMonitoringSetting
    {
        public int PowerPlantMonitoringSettingsId { get; set; }
        public int PowerPlantId { get; set; }
        public decimal EnergyDivergenceLimit { get; set; }
        public decimal MaxTempDivergenceLimit { get; set; }
        public decimal PowerDivergenceLimit { get; set; }
        public decimal InverterMonthlyEnergyDivergenceLimit { get; set; }
        public bool PowerAdjustmentEnabled { get; set; }
        public string KofUrl { get; set; }
        public string CameraUrl { get; set; }
        public bool? MonitoringEnabled { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
