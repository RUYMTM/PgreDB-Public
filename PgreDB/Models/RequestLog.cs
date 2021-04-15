using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class RequestLog
    {
        public int RequestLogId { get; set; }
        public string EwiserauthUuid { get; set; }
        public string FromIp { get; set; }
        public string IdToken { get; set; }
        public DateTime RequestTimestamp { get; set; }
        public string RequestedPath { get; set; }
        public string Status { get; set; }
        public DateTime? RequestCompletedTimestamp { get; set; }
    }
}
