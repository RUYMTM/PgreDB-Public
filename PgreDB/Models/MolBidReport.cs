using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MolBidReport
    {
        public int MolBidReportId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Resolution { get; set; }
        public string Market { get; set; }
        public string Direction { get; set; }
        public decimal BidQty { get; set; }
        public string UnitOfQty { get; set; }
        public decimal EnergyPrice { get; set; }
        public string Currency { get; set; }
    }
}
