using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class PowerPlantMailAddress
    {
        public string PowerPlantReferenceId { get; set; }
        public string PpName { get; set; }
        public string DocumentSz { get; set; }
        public string DocumentCs { get; set; }
        public string MailZip { get; set; }
        public string MailCity { get; set; }
        public string MailAddress { get; set; }
        public string MailName { get; set; }
    }
}
