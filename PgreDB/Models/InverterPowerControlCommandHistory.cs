using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InverterPowerControlCommandHistory
    {
        public int InverterPowerControlCommandHistoryId { get; set; }
        public DateTime HistoryCreationDatetime { get; set; }
        public int InverterPowerControlCommandId { get; set; }
        public int? PowerControlEventId { get; set; }
        public int InverterId { get; set; }
        public DateTime Datetime { get; set; }
        public string CommandType { get; set; }
        public double? MaxPercentage { get; set; }

        public virtual Inverter Inverter { get; set; }
        public virtual InverterPowerControlCommand InverterPowerControlCommand { get; set; }
        public virtual PowerControlEvent PowerControlEvent { get; set; }
    }
}
