using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PvPlantTempParametersHistory
    {
        public int PvPlantTempParametersHistoryId { get; set; }
        public int PowerPlantId { get; set; }
        public decimal GradientCorrectionVariable { get; set; }
        public string WeatherModifier { get; set; }
        public decimal SnowCorrectionVariable { get; set; }
        public DateTime SnowCalculationTime { get; set; }
        public DateTime ModifiedAt { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
