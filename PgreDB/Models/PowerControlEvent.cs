using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerControlEvent
    {
        public PowerControlEvent()
        {
            InverterPowerControlCommandHistories = new HashSet<InverterPowerControlCommandHistory>();
            InverterPowerControlCommands = new HashSet<InverterPowerControlCommand>();
            PowerControlGroups = new HashSet<PowerControlGroup>();
            PowerControlStatusLogs = new HashSet<PowerControlStatusLog>();
        }

        public int PowerControlEventId { get; set; }
        public int PowerControlGroupId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Difference { get; set; }
        public string Source { get; set; }
        public int? InitialPower { get; set; }
        public string DifferenceBasis { get; set; }
        public string Comment { get; set; }

        public virtual PowerControlGroup PowerControlGroup { get; set; }
        public virtual ICollection<InverterPowerControlCommandHistory> InverterPowerControlCommandHistories { get; set; }
        public virtual ICollection<InverterPowerControlCommand> InverterPowerControlCommands { get; set; }
        public virtual ICollection<PowerControlGroup> PowerControlGroups { get; set; }
        public virtual ICollection<PowerControlStatusLog> PowerControlStatusLogs { get; set; }
    }
}
