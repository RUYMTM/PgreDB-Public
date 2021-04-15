using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MekIdentificationGroup
    {
        public MekIdentificationGroup()
        {
            MekIdentificationMekIdentificationGroupPrevs = new HashSet<MekIdentification>();
            MekIdentificationMekIdentificationGroups = new HashSet<MekIdentification>();
        }

        public int MekIdentificationGroupId { get; set; }
        public string DtdRelease { get; set; }
        public string DtdVersion { get; set; }
        public string MessageIdentification { get; set; }
        public string MessageType { get; set; }
        public string ProcessType { get; set; }
        public string ReceiverIdentification { get; set; }
        public string ReceiverIdentificationCodingScheme { get; set; }
        public string ReceiverRole { get; set; }
        public string ScheduleClassificationType { get; set; }
        public string SenderIdentification { get; set; }
        public string SenderIdentificationCodingScheme { get; set; }
        public string SenderRole { get; set; }
        public string TsoPassword { get; set; }
        public string TsoUsername { get; set; }
        public string InParty { get; set; }
        public string InPartyCodingScheme { get; set; }
        public int Priority { get; set; }
        public bool ActiveScheduling { get; set; }
        public DateTime LastPasswordRenewingDate { get; set; }
        public byte[] Pwd { get; set; }
        public bool ActiveMekEmailSchedule { get; set; }

        public virtual ICollection<MekIdentification> MekIdentificationMekIdentificationGroupPrevs { get; set; }
        public virtual ICollection<MekIdentification> MekIdentificationMekIdentificationGroups { get; set; }
    }
}
