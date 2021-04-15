using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MobileTraffic
    {
        public int MobileTrafficId { get; set; }
        public int RouterId { get; set; }
        public DateTime UsageDate { get; set; }
        public decimal Kibibytes { get; set; }
        public string DataDirection { get; set; }

        public virtual Router Router { get; set; }
    }
}
