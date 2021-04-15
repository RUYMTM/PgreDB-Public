using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PvPlantPhysical
    {
        public int PvPlantPhysicalId { get; set; }
        public double AcCableLoss { get; set; }
        public double Albedo { get; set; }
        public double DcCableLoss { get; set; }
        public double DustLoss { get; set; }
        public double InverterCosphi { get; set; }
        public double InverterMaxEfficiency { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int PowerTransformerMaxLoadLossWatt { get; set; }
        public int PowerTransformerNoLoadLossWatt { get; set; }
        public int PowerTransformerRatedPowerVa { get; set; }
        public string PvCellTechnology { get; set; }
        public int PvModuleAboveEachOther { get; set; }
        public double PvModuleAzimuth { get; set; }
        public double PvModuleHeight { get; set; }
        public double PvModuleLineDistanceMeter { get; set; }
        public double PvModuleLineHeightFromGroundMeter { get; set; }
        public double PvModuleLineHeightMeter { get; set; }
        public int PvModuleNumber { get; set; }
        public double PvModulePower { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime KatContractStartDate { get; set; }
        public string SunTrackingAxis { get; set; }
        public int TiltAnglePvModule { get; set; }
        public string Timezone { get; set; }
        public int TotalInverterPowerWatt { get; set; } //inn
        public int PowerPlantId { get; set; }
        public DateTime RealProductionStartDate { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
