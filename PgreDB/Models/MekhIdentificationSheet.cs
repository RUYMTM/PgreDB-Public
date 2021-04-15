using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MekhIdentificationSheet
    {
        public int MekhIdentificationSheetId { get; set; }
        public string Type { get; set; }
        public bool? Sendable { get; set; }
        public DateTime? NotifiedAt { get; set; }
        public int? MekhIdentificationId { get; set; }
        public bool? CanBeParsed { get; set; }
        public bool? Sent { get; set; }
        public bool? SelfValidationError { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? SendEmail { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? SheetOpen { get; set; }
        public string SheetId { get; set; }
    }
}
