using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PostgresLog
    {
        public DateTime? LogTime { get; set; }
        public string UserName { get; set; }
        public string DatabaseName { get; set; }
        public int? ProcessId { get; set; }
        public string ConnectionFrom { get; set; }
        public string SessionId { get; set; }
        public long SessionLineNum { get; set; }
        public string CommandTag { get; set; }
        public DateTime? SessionStartTime { get; set; }
        public string VirtualTransactionId { get; set; }
        public long? TransactionId { get; set; }
        public string ErrorSeverity { get; set; }
        public string SqlStateCode { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
        public string Hint { get; set; }
        public string InternalQuery { get; set; }
        public int? InternalQueryPos { get; set; }
        public string Context { get; set; }
        public string Query { get; set; }
        public int? QueryPos { get; set; }
        public string Location { get; set; }
        public string ApplicationName { get; set; }
    }
}
