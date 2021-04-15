using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Camera
    {
        public int CameraId { get; set; }
        public string Name { get; set; }
        public string Resolution { get; set; }
        public string BaseUrl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Channel { get; set; }
        public string GpsLat { get; set; }
        public string GpsLon { get; set; }
        public string Type { get; set; }
        public bool? Enabled { get; set; }
        public int? Attempt { get; set; }
        public string Note { get; set; }
        public byte[] Nn { get; set; }
        public bool? Onvif { get; set; }
        public bool? Rtsp { get; set; }
        public string Version { get; set; }
        public string City { get; set; }
        public int? DailyAttempt { get; set; }
        public DateTime? LastError { get; set; }
        public string Country { get; set; }
        public bool? OnlyObservation { get; set; }
        public string NnUrl { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeleteReason { get; set; }
    }
}
