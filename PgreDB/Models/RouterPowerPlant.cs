using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class RouterPowerPlant
    {
        public int RouterPowerPlantId { get; set; }
        public int RouterId { get; set; }
        public int PowerPlantId { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
        public virtual Router Router { get; set; }
    }
}
