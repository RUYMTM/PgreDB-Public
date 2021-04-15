using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class SystemState
    {
        public int SystemStateId { get; set; }
        public decimal AfrrUp { get; set; }
        public decimal AfrrDown { get; set; }
        public decimal AfrrUpCountry { get; set; }
        public decimal AfrrDownCountry { get; set; }
        public decimal IgccUp { get; set; }
        public decimal IgccDown { get; set; }
        public decimal MfrrUp { get; set; }
        public decimal MfrrDown { get; set; }
        public decimal NotBalancingEnergyUp { get; set; }
        public decimal NotBalancingEnergyDown { get; set; }
        public decimal PvErrorToMeasurement { get; set; }
        public decimal WindErrorToMeasurement { get; set; }
        public string CountryType { get; set; }
        public string PowerValueUnit { get; set; }
        public string Resolution { get; set; }
        public DateTime? StartDatetime { get; set; }
        public DateTime? EndDatetime { get; set; }
        public DateTime HistCreationDatetime { get; set; }
    }
}
