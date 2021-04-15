using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class EwiserUser
    {
        public EwiserUser()
        {
            Companies = new HashSet<Company>();
            ContactOldTodeletes = new HashSet<ContactOldTodelete>();
            FormCreators = new HashSet<Form>();
            FormOwners = new HashSet<Form>();
            InverseCreatorUser = new HashSet<EwiserUser>();
            Notes = new HashSet<Note>();
            UserCompanies = new HashSet<UserCompany>();
            UserPowerPlants = new HashSet<UserPowerPlant>();
            UserScheduleIdentificationGroups = new HashSet<UserScheduleIdentificationGroup>();
        }

        public int UserId { get; set; }
        public bool Active { get; set; }
        public string EwiserauthUuid { get; set; }
        public string Name { get; set; }
        public string UserRole { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public int CreatorUserId { get; set; }
        public string DefaultLanguage { get; set; }
        public int? ContactId { get; set; }

        public virtual EwiserUser CreatorUser { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<ContactOldTodelete> ContactOldTodeletes { get; set; }
        public virtual ICollection<Form> FormCreators { get; set; }
        public virtual ICollection<Form> FormOwners { get; set; }
        public virtual ICollection<EwiserUser> InverseCreatorUser { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<UserCompany> UserCompanies { get; set; }
        public virtual ICollection<UserPowerPlant> UserPowerPlants { get; set; }
        public virtual ICollection<UserScheduleIdentificationGroup> UserScheduleIdentificationGroups { get; set; }
    }
}
