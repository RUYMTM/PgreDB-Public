using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ScheduleItem
    {
        public int ScheduleItemId { get; set; }
        public int ScheduleIdentificationId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Quantity { get; set; }
        public string Resolution { get; set; }
        public string ScheduleType { get; set; }
        public int ScheduleStatus { get; set; }
        public DateTime Edited { get; set; }
        public string ValueUnit { get; set; }

        public virtual ScheduleIdentification ScheduleIdentification { get; set; }
    }
}
