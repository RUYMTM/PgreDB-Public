using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PvPlantTempParameter
    {
        public int PvPlantTempParametersId { get; set; }
        public int PowerPlantId { get; set; }
        public double SnowCorrectionVariable { get; set; }
        public DateTime SnowCalculationTime { get; set; }
        public decimal GradientCorrectionVariable { get; set; }
        public string WeatherModifier { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
