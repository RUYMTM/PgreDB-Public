using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MekIdentification
    {
        public int MekIdentificationId { get; set; }
        public string BusinessType { get; set; }
        public string InArea { get; set; }
        public string InAreaCodingScheme { get; set; }
        public string MeasurementUnit { get; set; }
        public string MeteringPointIdentificationCodingScheme { get; set; }
        public string ObjectAggregation { get; set; }
        public string Product { get; set; }
        public string SendersTimeSeriesIdentification { get; set; }
        public int MekIdentificationGroupId { get; set; }
        public int PowerPlantId { get; set; }
        public int? MekIdentificationGroupPrevId { get; set; }
        public DateTime? MekIdentificationGroupPrevDate { get; set; }
        public int ProsumerMaxValueW { get; set; }
        public string SendersTimeSeriesSequentialIdentification { get; set; }

        public virtual MekIdentificationGroup MekIdentificationGroup { get; set; }
        public virtual MekIdentificationGroup MekIdentificationGroupPrev { get; set; }
        public virtual PowerPlant PowerPlant { get; set; }
    }
}
