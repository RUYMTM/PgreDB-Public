using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class EmailQueue
    {
        public int EmailQueueId { get; set; }
        public int EwiserUserId { get; set; }
        public string Type { get; set; }
        public DateTime SendAt { get; set; }
        public DateTime? NotifiedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UniqueId { get; set; }
    }
}
