using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class FilePowerPlant
    {
        public int FilePowerPlantId { get; set; }
        public int FileId { get; set; }
        public int PowerPlantId { get; set; }

        public virtual File File { get; set; }
        public virtual PowerPlant PowerPlant { get; set; }
    }
}
