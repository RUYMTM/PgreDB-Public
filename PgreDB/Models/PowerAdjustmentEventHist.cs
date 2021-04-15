using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerAdjustmentEventHist
    {
        public int PowerAdjustmentEventHistId { get; set; }
        public DateTime HistCreationDatetime { get; set; }
        public char HistOperation { get; set; }
        public int PowerAdjustmentEventId { get; set; }
        public int PowerPlantId { get; set; }
        public DateTime AdjustmentDatetime { get; set; }
        public string AdjustmentType { get; set; }
        public double? MaxPercentage { get; set; }
        public int? MaxPower { get; set; }

        public virtual PowerAdjustmentEvent PowerAdjustmentEvent { get; set; }
        public virtual PowerPlant PowerPlant { get; set; }
    }
}
