using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class InverterPowerControlCommand
    {
        public InverterPowerControlCommand()
        {
            InverterPowerControlCommandHistories = new HashSet<InverterPowerControlCommandHistory>();
        }

        public int InverterPowerControlCommandId { get; set; }
        public int? PowerControlEventId { get; set; }
        public int InverterId { get; set; }
        public DateTime Datetime { get; set; }
        public string CommandType { get; set; }
        public double? MaxPercentage { get; set; }

        public virtual Inverter Inverter { get; set; }
        public virtual PowerControlEvent PowerControlEvent { get; set; }
        public virtual ICollection<InverterPowerControlCommandHistory> InverterPowerControlCommandHistories { get; set; }
    }
}
