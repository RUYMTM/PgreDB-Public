using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class WindParkTempParametersReadonly
    {
        public int WindParkTempParametersReadonlyId { get; set; }
        public int PowerPlantId { get; set; }
        public string PredictionParameters { get; set; }
        public double FeedInPrice { get; set; }
        public byte[] NeuralNetworkZip { get; set; }
        public byte[] XgboostZip { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
