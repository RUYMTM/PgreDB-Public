using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class DataLoggerPowerPlant
    {
        public int DataLoggerPowerPlantId { get; set; }
        public int DataLoggerId { get; set; }
        public int PowerPlantId { get; set; }

        public virtual DataLogger DataLogger { get; set; }
        public virtual PowerPlant PowerPlant { get; set; }
    }
}
