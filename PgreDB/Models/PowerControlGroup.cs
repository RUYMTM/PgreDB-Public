using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerControlGroup
    {
        public PowerControlGroup()
        {
            IntervalProducts = new HashSet<IntervalProduct>();
            PowerControlEvents = new HashSet<PowerControlEvent>();
            PowerControlStatusLogs = new HashSet<PowerControlStatusLog>();
            PowerPlants = new HashSet<PowerPlant>();
            TradingOfferVersions = new HashSet<TradingOfferVersion>();
        }

        public int PowerControlGroupId { get; set; }
        public string Name { get; set; }
        public int? ActivePowerControlEventId { get; set; }
        public bool ReadEnergy { get; set; }
        public string ScheduleDestination { get; set; }
        public int Priority { get; set; }
        public string Bsp { get; set; }
        public string SenderIdentification { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual PowerControlEvent ActivePowerControlEvent { get; set; }
        public virtual ICollection<IntervalProduct> IntervalProducts { get; set; }
        public virtual ICollection<PowerControlEvent> PowerControlEvents { get; set; }
        public virtual ICollection<PowerControlStatusLog> PowerControlStatusLogs { get; set; }
        public virtual ICollection<PowerPlant> PowerPlants { get; set; }
        public virtual ICollection<TradingOfferVersion> TradingOfferVersions { get; set; }
    }
}
