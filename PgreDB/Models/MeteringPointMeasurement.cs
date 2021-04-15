using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MeteringPointMeasurement
    {
        public int MeteringPointMeasurementId { get; set; }
        public int PowerPlantId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Quantity { get; set; }
        public string Resolution { get; set; }
        public decimal TFactor { get; set; }
        public string ValueName { get; set; }
        public string ValueUnit { get; set; }
        public decimal Status { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
