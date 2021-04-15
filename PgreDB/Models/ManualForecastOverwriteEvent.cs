using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ManualForecastOverwriteEvent
    {
        public int ManualForecastOverwriteId { get; set; }
        public string CountryType { get; set; }
        public string WeatherType { get; set; }
        public decimal ScaleFactor { get; set; }
        public string Note { get; set; }
        public DateTime StartDatetime { get; set; }
        public DateTime EndDatetime { get; set; }
    }
}
