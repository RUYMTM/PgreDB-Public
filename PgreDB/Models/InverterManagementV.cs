using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InverterManagementV
    {
        public int? PowerPlantId { get; set; }
        public string Ppname { get; set; }
        public string PowerPlantReferenceId { get; set; }
        public string LocationCity { get; set; }
        public string LocationParcelNumber { get; set; }
        public int? PowerControlGroupId { get; set; }
        public int? InverterId { get; set; }
        public string Invertername { get; set; }
        public string NameByUser { get; set; }
        public string ModbusType { get; set; }
        public int? ModbusSlaveId { get; set; }
        public int? MaxAllowedAcPower { get; set; }
        public int? AvailableTotalAcPower { get; set; }
        public int? RatedAcPower { get; set; }
        public bool? Inactive { get; set; }
        public bool? ReadyToWork { get; set; }
        public int? MeasurementPointNumber { get; set; }
        public string PvModuleNumberJsonArray { get; set; }
        public int? DataLoggerId { get; set; }
        public string RemotePath { get; set; }
        public string ConnectionType { get; set; }
        public string DataLoggerType { get; set; }
        public string Dataloggercomment { get; set; }
        public int? ModbusManagerDeviceId { get; set; }
        public int? HttpPullDeviceId { get; set; }
        public bool? PowerAdjustmentAvailable { get; set; }
        public int? DeviceId { get; set; }
        public string Devicename { get; set; }
        public string DeviceType { get; set; }
        public string Devicecomment { get; set; }
        public string Deviceip { get; set; }
        public int? IpPort { get; set; }
        public int? RouterId { get; set; }
        public string Routerip { get; set; }
        public bool? IsActive { get; set; }
        public string City { get; set; }
        public string Routercomment { get; set; }
        public bool? DevicesAdded { get; set; }
    }
}
