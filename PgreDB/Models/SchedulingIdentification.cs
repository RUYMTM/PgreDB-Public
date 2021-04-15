using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class SchedulingIdentification
    {
        public int SchedulingIdentificationId { get; set; }
        public int PowerPlantId { get; set; }
        public string PowerPlantExternalIdentification { get; set; }
        public string MeteringPointIdentification { get; set; }
        public int Priority { get; set; }
        public bool? ActiveScheduling { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
