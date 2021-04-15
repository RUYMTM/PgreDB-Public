using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Form
    {
        public Form()
        {
            FormFiles = new HashSet<FormFile>();
        }

        public int FormId { get; set; }
        public int OwnerId { get; set; }
        public int CreatorId { get; set; }
        public string Hash { get; set; }
        public string KatId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Fields { get; set; }
        public string AdminFields { get; set; }
        public DateTime? SentAt { get; set; }
        public bool? Registered { get; set; }
        public bool? Notified { get; set; }
        public string InvoiceFields { get; set; }
        public string Comment { get; set; }
        public string Contacts { get; set; }
        public DateTime? Deadline { get; set; }
        public int? PowerPlantId { get; set; }
        public bool? Synced { get; set; }

        public virtual EwiserUser Creator { get; set; }
        public virtual EwiserUser Owner { get; set; }
        public virtual PowerPlant PowerPlant { get; set; }
        public virtual ICollection<FormFile> FormFiles { get; set; }
    }
}
