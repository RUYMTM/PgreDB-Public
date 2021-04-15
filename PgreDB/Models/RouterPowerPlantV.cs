using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class RouterPowerPlantV
    {
        public int? RouterId { get; set; }
        public string IpAddress { get; set; }
        public string Owner { get; set; }
        public bool? IsManageable { get; set; }
        public string RouterLocationCity { get; set; }
        public int? PowerPlantId { get; set; }
        public string PpName { get; set; }
        public string PpLocationCity { get; set; }
    }
}
