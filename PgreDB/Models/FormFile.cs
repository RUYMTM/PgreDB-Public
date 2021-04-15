using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class FormFile
    {
        public int FormFileId { get; set; }
        public int FormId { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public bool? Confirmed { get; set; }
        public int Size { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Name { get; set; }
        public string Hash { get; set; }

        public virtual Form Form { get; set; }
    }
}
