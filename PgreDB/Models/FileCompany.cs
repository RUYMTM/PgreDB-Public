using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class FileCompany
    {
        public int FileCompanyId { get; set; }
        public int FileId { get; set; }
        public int CompanyId { get; set; }
        public bool? PhysicallyExists { get; set; }

        public virtual Company Company { get; set; }
        public virtual File File { get; set; }
    }
}
