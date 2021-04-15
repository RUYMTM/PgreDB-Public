using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PvPlantGroupTempParamHistory
    {
        public int PvPlantGroupTempParamHistoryId { get; set; }
        public int ScheduleIdentificationGroupId { get; set; }
        public string PredictionParameters { get; set; }
        public decimal CorrectionVariable { get; set; }
        public string CorrectionType { get; set; }
        public DateTime? StartDatetime { get; set; }
        public DateTime? EndDatetime { get; set; }
        public DateTime HistCreationDatetime { get; set; }
    }
}
