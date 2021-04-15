using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerControlEnergyReferencePowerPlant
    {
        public int PowerControlEnergyReferencePowerPlantId { get; set; }
        public int PowerPlantId { get; set; }
        public int ReferencePowerPlantId { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
        public virtual PowerPlant ReferencePowerPlant { get; set; }
    }
}
