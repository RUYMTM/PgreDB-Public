using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class CameraImage
    {
        public int CameraImageId { get; set; }
        public int CameraId { get; set; }
        public string FileLocation { get; set; }
        public string CameraWeatherType { get; set; }
        public string StoragePath { get; set; }
        public string StorageType { get; set; }
        public int? AssignedToUserId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? SizeInKb { get; set; }
    }
}
