using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InverterStatus
    {
        public int InverterStatusId { get; set; }
        public int InverterId { get; set; }
        public DateTime StartTimeStamp { get; set; }
        public DateTime EndTimeStamp { get; set; }
        public int StatusCode { get; set; }
        public bool Sent { get; set; }

        public virtual Inverter Inverter { get; set; }
    }
}
