using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class CameraForm
    {
        public int CameraFormId { get; set; }
        public string Hash { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
        public string CameraType { get; set; }
        public string CameraUsername { get; set; }
        public string CameraPassword { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public string CameraUrl { get; set; }
        public int? AssignedUserId { get; set; }
        public string DevLog { get; set; }
    }
}
