using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ImageRecognition
    {
        public int ImageRecognitionId { get; set; }
        public int CameraId { get; set; }
        public int CameraImageId { get; set; }
        public string RecognisedWeatherType { get; set; }
        public int LeadTimeMin { get; set; }
        public DateTime HistCreationDatetime { get; set; }
        public string WeatherForecastWeatherType { get; set; }
        public decimal WeatherForecastPowerFactor { get; set; }
        public bool Activation { get; set; }
        public decimal PowerFactorDifference { get; set; }
        public decimal RecogPowerFactor { get; set; }
        public string Country { get; set; }
    }
}
