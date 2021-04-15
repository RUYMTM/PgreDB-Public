using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Webcam
    {
        public int WebcamId { get; set; }
        public int? ForecastModelId { get; set; }
        public string GpsLat { get; set; }
        public string GpsLng { get; set; }
        public string Desc { get; set; }
        public string Resolution { get; set; }
        public string Link { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CrawlerType { get; set; }
        public string TimeCorrection { get; set; }
        public string DeviceId { get; set; }
        public bool? Enabled { get; set; }
    }
}
