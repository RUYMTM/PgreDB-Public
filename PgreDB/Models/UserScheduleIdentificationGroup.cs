using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class UserScheduleIdentificationGroup
    {
        public int UserScheduleIdentificationGroupId { get; set; }
        public int UserId { get; set; }
        public int ScheduleIdentificationGroupId { get; set; }

        public virtual ScheduleIdentificationGroup ScheduleIdentificationGroup { get; set; }
        public virtual EwiserUser User { get; set; }
    }
}
