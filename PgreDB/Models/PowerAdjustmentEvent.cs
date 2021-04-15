using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerAdjustmentEvent
    {
        public PowerAdjustmentEvent()
        {
            PowerAdjustmentEventHists = new HashSet<PowerAdjustmentEventHist>();
        }

        public int PowerAdjustmentEventId { get; set; }
        public int PowerPlantId { get; set; }
        public DateTime AdjustmentDatetime { get; set; }
        public string AdjustmentType { get; set; }
        public double? MaxPercentage { get; set; }
        public int? MaxPower { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
        public virtual ICollection<PowerAdjustmentEventHist> PowerAdjustmentEventHists { get; set; }
    }
}
