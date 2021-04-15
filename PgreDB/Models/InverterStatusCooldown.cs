using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InverterStatusCooldown
    {
        public int InverterStatusCooldownId { get; set; }
        public int InverterId { get; set; }
        public int StatusCode { get; set; }
        public int CurrentStack { get; set; }
        public DateTime EndTime { get; set; }

        public virtual Inverter Inverter { get; set; }
    }
}
