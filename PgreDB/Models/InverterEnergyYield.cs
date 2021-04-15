using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InverterEnergyYield
    {
        public int InverterEnergyYieldId { get; set; }
        public int InverterId { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal EnergyYield { get; set; }
        public string Type { get; set; }

        public virtual Inverter Inverter { get; set; }
    }
}
