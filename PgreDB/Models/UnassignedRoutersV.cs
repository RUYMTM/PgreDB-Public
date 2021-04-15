using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class UnassignedRoutersV
    {
        public int? RouterId { get; set; }
        public string Model { get; set; }
        public string IpAddress { get; set; }
        public string Subdomain { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsManageable { get; set; }
        public string WifiSsid { get; set; }
        public bool? BatteryOnSite { get; set; }
        public string City { get; set; }
        public string Comment { get; set; }
        public string ExactLocation { get; set; }
        public bool? DevicesAdded { get; set; }
        public decimal? NetworkManagementFee { get; set; }
        public DateTime? InstallationDate { get; set; }
        public string IspType { get; set; }
        public string Owner { get; set; }
        public string InternetSubscriptionOwner { get; set; }
        public string TunnelIp { get; set; }
        public string RouterPassword { get; set; }
        public string WifiPassword { get; set; }
        public string AntennaType { get; set; }
        public string SerialNumber { get; set; }
        public string LanMacAddress { get; set; }
        public string Imei { get; set; }
        public string FirmwareVersion { get; set; }
        public string SimIccid { get; set; }
        public int? SimPin { get; set; }
        public int? SimPuk { get; set; }
        public string PhoneNumber { get; set; }
    }
}
