using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class CriticalWeatherEvent
    {
        public int CriticalWeatherEventId { get; set; }
        public DateTime StartDatetime { get; set; }
        public DateTime EndDatetime { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public DateTime CreationTimestamp { get; set; }
    }
}
