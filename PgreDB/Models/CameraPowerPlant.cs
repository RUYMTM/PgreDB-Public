using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class CameraPowerPlant
    {
        public int CameraPowerPlantId { get; set; }
        public int CameraId { get; set; }
        public int PowerPlantId { get; set; }
    }
}
