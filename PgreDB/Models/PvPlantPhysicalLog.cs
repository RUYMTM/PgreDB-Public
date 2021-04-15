using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PvPlantPhysicalLog
    {
        public int? PowerPlantId { get; set; }
        public double? OrigLatitude { get; set; }
        public double? OrigLongitude { get; set; }
        public double? NewLatitude { get; set; }
        public double? NewLongitude { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
