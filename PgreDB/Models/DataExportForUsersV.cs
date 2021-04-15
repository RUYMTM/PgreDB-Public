using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class DataExportForUsersV
    {
        public int? PowerPlantId { get; set; }
        public string EromuNeve { get; set; }
        public string EwiserAzonosito { get; set; }
        public string MeteringPointIdentification { get; set; }
        public string LocationCity { get; set; }
        public string LocationParcelNumber { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Userek { get; set; }
        public string MekhId { get; set; }
        public DateTime? KatContractStartDate { get; set; }
        public DateTime? RealProductionStartDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? PvModuleNumber { get; set; }
        public double? PvModulePower { get; set; }
        public int? ProsumerMaxValueW { get; set; }
        public string DataLoggerType { get; set; }
        public string DataLoggerIps { get; set; }
        public long? InverterCount { get; set; }
        public string InverterNames { get; set; }
        public int? RouterId { get; set; }
        public string Model { get; set; }
        public string Subdomain { get; set; }
        public string City { get; set; }
        public string ExactLocation { get; set; }
        public string WifiSsid { get; set; }
        public string WifiPassword { get; set; }
        public bool? BatteryOnSite { get; set; }
        public DateTime? InstallationDate { get; set; }
    }
}
