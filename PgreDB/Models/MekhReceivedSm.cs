using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MekhReceivedSm
    {
        public int MekhReceivedSmsId { get; set; }
        public string Code { get; set; }
        public string Body { get; set; }
        public string MessageSid { get; set; }
        public string SmsSid { get; set; }
        public string SmsMessageSid { get; set; }
        public string FromNumber { get; set; }
        public string ToNumber { get; set; }
        public bool Successful { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
