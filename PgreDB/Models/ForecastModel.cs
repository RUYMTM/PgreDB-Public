using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ForecastModel
    {
        public int ForecastModelId { get; set; }
        public byte[] Booster { get; set; }
        public int LeadTimeMin { get; set; }
        public string CalculationType { get; set; }
        public string BalanceGroupType { get; set; }
        public string CountryType { get; set; }
        public string PowerValueUnit { get; set; }
        public string Resolution { get; set; }
        public DateTime HistCreationDatetime { get; set; }
        public int? ScheduleIdentificationGroupId { get; set; }

        public virtual ScheduleIdentificationGroup ScheduleIdentificationGroup { get; set; }
    }
}
