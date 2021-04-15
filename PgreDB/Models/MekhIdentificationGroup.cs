using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MekhIdentificationGroup
    {
        public MekhIdentificationGroup()
        {
            MekhIdentifications = new HashSet<MekhIdentification>();
        }

        public int MekhIdentificationGroupId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<MekhIdentification> MekhIdentifications { get; set; }
    }
}
