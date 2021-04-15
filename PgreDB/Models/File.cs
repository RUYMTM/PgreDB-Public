using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class File
    {
        public File()
        {
            FileCompanies = new HashSet<FileCompany>();
            FilePowerPlants = new HashSet<FilePowerPlant>();
        }

        public int FileId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int Size { get; set; }
        public string Hash { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }

        public virtual ICollection<FileCompany> FileCompanies { get; set; }
        public virtual ICollection<FilePowerPlant> FilePowerPlants { get; set; }
    }
}
