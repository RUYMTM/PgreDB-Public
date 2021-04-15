using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PvPlantTempParametersReadonly
    {
        public int PvPlantTempParametersReadonlyId { get; set; }
        public double FeedInPrice { get; set; }
        public string PredictionParameters { get; set; }
        public DateTime PvModuleWashingDate { get; set; }
        public int PowerPlantId { get; set; }
        public byte[] NeuralNetworkZip { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
