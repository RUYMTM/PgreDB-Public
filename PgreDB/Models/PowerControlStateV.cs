using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerControlStateV
    {
        public int? PowerPlantId { get; set; }
        public int? RouterId { get; set; }
        public string PpName { get; set; }
        public string PowerplantLoc { get; set; }
        public string PowerplantParcelnumber { get; set; }
        public string RouterLoc { get; set; }
        public int? PowerControlGroupId { get; set; }
        public string PowerControlGroupName { get; set; }
        public bool? PowerAdjustmentEnabled { get; set; }
        public bool? PowerAdjustmentAvailableOnAllDataloggers { get; set; }
        public string DataLoggerType { get; set; }
        public bool? HasInverterWithoutModbusSlaveId { get; set; }
        public long? DataloggerWithPowerAdjCount { get; set; }
        public long? InverterCount { get; set; }
        public string PowerplantPowerControlComment { get; set; }
        public string RouterComment { get; set; }
        public string InverterIds { get; set; }
        public string DataLoggerIps { get; set; }
        public string Userek { get; set; }
        public string MeteringPointIdentification { get; set; }
        public int? SigId { get; set; }
        public string OwnerCompany { get; set; }
    }
}
