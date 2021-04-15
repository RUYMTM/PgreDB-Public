using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class DataLoggerStatus
    {
        public int DataLoggerStatusId { get; set; }
        public string DateStamp { get; set; }
        public int DataLoggerId { get; set; }
        public bool Reached { get; set; }
        public string Status { get; set; }

        public virtual DataLogger DataLogger { get; set; }
    }
}
