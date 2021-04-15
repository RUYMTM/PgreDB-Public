using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ScheduleIdentification
    {
        public ScheduleIdentification()
        {
            ScheduleItems = new HashSet<ScheduleItem>();
        }

        public int ScheduleIdentificationId { get; set; }
        public int PowerPlantId { get; set; }
        public string PredictionSource { get; set; }
        public int ScheduleIdentificationGroupId { get; set; }
        public int? ScheduleIdentificationGroupPrevId { get; set; }
        public DateTime? ScheduleIdentificationGroupPrevDate { get; set; }
        public int ProsumerMaxValueW { get; set; }
        public string MekSendersTimeSeriesIdentification { get; set; }
        public string MekSendersTimeSeriesSequentialIdentification { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
        public virtual ScheduleIdentificationGroup ScheduleIdentificationGroup { get; set; }
        public virtual ScheduleIdentificationGroup ScheduleIdentificationGroupPrev { get; set; }
        public virtual ICollection<ScheduleItem> ScheduleItems { get; set; }
    }
}
