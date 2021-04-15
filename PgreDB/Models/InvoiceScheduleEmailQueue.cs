using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InvoiceScheduleEmailQueue
    {
        public int ScheduleEmailQueueId { get; set; }
        public int EwiserUserId { get; set; }
        public int? InvoiceId { get; set; }
        public string InvoiceSoftware { get; set; }
        public DateTime MustBeSentOn { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Subtype { get; set; }
    }
}
