using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerControlEnergy
    {
        public int PowerControlEnergyId { get; set; }
        public int PowerPlantId { get; set; }
        public int PowerControlEventId { get; set; }
        public DateTime IntervalStart { get; set; }
        public DateTime IntervalEnd { get; set; }
        public string Status { get; set; }
        public int? Energy { get; set; }
        public int? MeasuredPower { get; set; }
        public int? EstimatedPower { get; set; }
        public int? ClaimedPower { get; set; }
        public string PowerSource { get; set; }
        public string Note { get; set; }
        public bool? Approved { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
