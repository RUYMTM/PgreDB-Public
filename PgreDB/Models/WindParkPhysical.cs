using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class WindParkPhysical
    {
        public int WindParkPhysicalId { get; set; }
        public int PowerPlantId { get; set; }
        public string Timezone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime KatContractStartDate { get; set; }
        public int PowerOutputWatt { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime RealProductionStartDate { get; set; }
        public double TransformerIronLoss { get; set; }
        public double TransformerCopperLoss { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
