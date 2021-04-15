using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ScheduleIdentificationGroupUnused
    {
        public int ScheduleIdentificationGroupId { get; set; }
        public int? Priority { get; set; }
        public string ScheduleDestination { get; set; }
        public string MekSenderIdentification { get; set; }
        public string MekUsername { get; set; }
        public string MekPassword { get; set; }
        public DateTime? MekLastPasswordRenewingDate { get; set; }
        public string Comment { get; set; }
        public bool? TradeModifications { get; set; }
    }
}
