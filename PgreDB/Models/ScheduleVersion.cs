using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ScheduleVersion
    {
        public int ScheduleVersionId { get; set; }
        public int LastSubmittedVersion { get; set; }
        public int ScheduleIdentificationGroupId { get; set; }
        public DateTime ScheduleDate { get; set; }

        public virtual ScheduleIdentificationGroup ScheduleIdentificationGroup { get; set; }
    }
}
