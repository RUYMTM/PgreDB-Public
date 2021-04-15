using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class BreakdownEvent
    {
        public BreakdownEvent()
        {
            HistBreakdownEvents = new HashSet<HistBreakdownEvent>();
        }

        public int BreakdownEventId { get; set; }
        public int PowerPlantId { get; set; }
        public int BreakdownPowerWatt { get; set; }
        public DateTime StartDatetime { get; set; }
        public DateTime EndDatetime { get; set; }
        public string CreationMode { get; set; }
        public string EditMode { get; set; }
        public string Note { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
        public virtual ICollection<HistBreakdownEvent> HistBreakdownEvents { get; set; }
    }
}
