using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerControlStatusLog
    {
        public int PowerControlStatusLogId { get; set; }
        public int PowerControlGroupId { get; set; }
        public int PowerControlEventId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime IntervalStartTime { get; set; }
        public DateTime IntervalEndTime { get; set; }
        public int MaxPowerSet { get; set; }
        public int IntervalTargetPower { get; set; }
        public int IntervalPower { get; set; }

        public virtual PowerControlEvent PowerControlEvent { get; set; }
        public virtual PowerControlGroup PowerControlGroup { get; set; }
    }
}
