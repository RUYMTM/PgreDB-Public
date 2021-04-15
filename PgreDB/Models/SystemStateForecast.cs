using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class SystemStateForecast
    {
        public int SystemStateForecastId { get; set; }
        public decimal SystemStatePrediction { get; set; }
        public int LeadTimeMin { get; set; }
        public decimal IdForecastToMeasurement { get; set; }
        public decimal DaForecastToMeasurement { get; set; }
        public decimal AverageMeasurementTimeAfterSunriseMin { get; set; }
        public string CountryType { get; set; }
        public string BalanceGroupType { get; set; }
        public string EstimatedIdWeatherType { get; set; }
        public string PowerValueUnit { get; set; }
        public string Resolution { get; set; }
        public DateTime? StartDatetime { get; set; }
        public DateTime? EndDatetime { get; set; }
        public DateTime MeasurementDatetime { get; set; }
        public int? ScheduleIdentificationGroupId { get; set; }
    }
}
