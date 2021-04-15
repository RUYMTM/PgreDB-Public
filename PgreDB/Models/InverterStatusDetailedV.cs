using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InverterStatusDetailedV
    {
        public int? PowerPlantId { get; set; }
        public string Name { get; set; }
        public string LocationCity { get; set; }
        public string LocationParcelNumber { get; set; }
        public int? InverterId { get; set; }
        public string InverterName { get; set; }
        public string InverterNameByUser { get; set; }
        public string DeviceName { get; set; }
        public int? DataLoggerId { get; set; }
        public int? ModbusSlaveId { get; set; }
        public bool? Inactive { get; set; }
        public int? MaxAllowedAcPower { get; set; }
        public int? AvailableTotalAcPower { get; set; }
        public int? RatedAcPower { get; set; }
        public string ModbusType { get; set; }
        public string DataLoggerType { get; set; }
        public bool? PowerAdjustmentAvailable { get; set; }
        public int? ModbusManagerDeviceId { get; set; }
        public int? HttpPullDeviceId { get; set; }
        public int? DeviceId { get; set; }
        public int? RouterId { get; set; }
        public string IpAddress { get; set; }
        public int? IpPort { get; set; }
        public string DeviceType { get; set; }
        public string Comment { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
