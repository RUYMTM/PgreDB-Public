using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MekhSheet
    {
        public int MekhSheetId { get; set; }
        public int ProductionDataId { get; set; }
        public DateTime? ReportingPeriod { get; set; }
        public DateTime Deadline { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int Version { get; set; }
        public string State { get; set; }
        public string StateVersion { get; set; }
        public string File { get; set; }
        public bool IsError { get; set; }
        public bool ManuallyHandled { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool MustBeNull { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public string ConfirmedNote { get; set; }
        public DateTime? MustBeSendAt { get; set; }
        public string Hash { get; set; }
        public DateTime? SentAt { get; set; }
        public bool? UserFilled { get; set; }

        public virtual ProductionDatum ProductionData { get; set; }
    }
}
