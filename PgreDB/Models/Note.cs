using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Note
    {
        public int NoteId { get; set; }
        public int CreatorId { get; set; }
        public string Note1 { get; set; }
        public string Visibility { get; set; }
        public bool Archived { get; set; }
        public DateTime Created { get; set; }

        public virtual EwiserUser Creator { get; set; }
    }
}
