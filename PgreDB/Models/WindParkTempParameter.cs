using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class WindParkTempParameter
    {
        public int WindParkTempParametersId { get; set; }
        public int PowerPlantId { get; set; }
        public string PredictionParameters { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
