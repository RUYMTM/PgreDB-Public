using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ContactOldTodelete
    {
        public ContactOldTodelete()
        {
            ContactPowerPlantOldTodeletes = new HashSet<ContactPowerPlantOldTodelete>();
        }

        public int ContactId { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public int CreatorId { get; set; }
        public string DefaultLanguage { get; set; }

        public virtual EwiserUser Creator { get; set; }
        public virtual ICollection<ContactPowerPlantOldTodelete> ContactPowerPlantOldTodeletes { get; set; }
    }
}
