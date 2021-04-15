using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InverterMonitoringMeasurementError
    {
        public int InverterMonitoringMeasurementErrorId { get; set; }
        public int PowerPlantId { get; set; }
        public string PowerPlantName { get; set; }
        public string DataLoggerType { get; set; }
        public decimal MapeError { get; set; }
        public bool OnWhiteList { get; set; }
        public bool HasFreshData { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
