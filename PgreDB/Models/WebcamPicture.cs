using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class WebcamPicture
    {
        public int WebcamPictureId { get; set; }
        public int WebcamId { get; set; }
        public string Timestamp { get; set; }
        public string FileLocation { get; set; }
        public string WeatherType { get; set; }
        public int? AssignedToUserId { get; set; }
        public int? ConfirmedByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string StoragePath { get; set; }
        public string StorageType { get; set; }
    }
}
