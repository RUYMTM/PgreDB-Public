using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InverterMeasurementEnoughDatum
    {
        public int InverterMeasurementEnoughDataId { get; set; }
        public int PowerPlantId { get; set; }
        public bool LastQhEnough { get; set; }
        public DateTime LastQhTime { get; set; }
        public DateTime CheckTime { get; set; }
        public bool QhBeforeLastEnough { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
