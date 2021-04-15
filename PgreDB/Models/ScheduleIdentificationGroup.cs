using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ScheduleIdentificationGroup
    {
        public ScheduleIdentificationGroup()
        {
            ForecastModels = new HashSet<ForecastModel>();
            ScheduleIdentificationScheduleIdentificationGroupPrevs = new HashSet<ScheduleIdentification>();
            ScheduleIdentificationScheduleIdentificationGroups = new HashSet<ScheduleIdentification>();
            ScheduleVersions = new HashSet<ScheduleVersion>();
            UserScheduleIdentificationGroups = new HashSet<UserScheduleIdentificationGroup>();
        }

        public int ScheduleIdentificationGroupId { get; set; }
        public int Priority { get; set; }
        public string ScheduleDestination { get; set; }
        public string MekSenderIdentification { get; set; }
        public string MekUsername { get; set; }
        public string MekPassword { get; set; }
        public DateTime? MekLastPasswordRenewingDate { get; set; }
        public string Comment { get; set; }
        public bool TradeModifications { get; set; }

        public virtual ICollection<ForecastModel> ForecastModels { get; set; }
        public virtual ICollection<ScheduleIdentification> ScheduleIdentificationScheduleIdentificationGroupPrevs { get; set; }
        public virtual ICollection<ScheduleIdentification> ScheduleIdentificationScheduleIdentificationGroups { get; set; }
        public virtual ICollection<ScheduleVersion> ScheduleVersions { get; set; }
        public virtual ICollection<UserScheduleIdentificationGroup> UserScheduleIdentificationGroups { get; set; }
    }
}
