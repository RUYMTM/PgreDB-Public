using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MekhScheduleEmailQueue
    {
        public int ScheduleEmailQueueId { get; set; }
        public int? EwiserUserId { get; set; }
        public int? MekhSheetId { get; set; }
        public DateTime MustBeSentOn { get; set; }
    }
}
