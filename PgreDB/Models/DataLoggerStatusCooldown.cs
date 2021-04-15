using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class DataLoggerStatusCooldown
    {
        public int DataLoggerStatusCooldownId { get; set; }
        public int DataLoggerId { get; set; }
        public int StatusCode { get; set; }
        public int CurrentStack { get; set; }
        public DateTime EndTime { get; set; }

        public virtual DataLogger DataLogger { get; set; }
    }
}
