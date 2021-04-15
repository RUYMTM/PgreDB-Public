using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class NotePowerPlant
    {
        public int NotePowerPlantId { get; set; }
        public int NoteId { get; set; }
        public int PowerPlantId { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
