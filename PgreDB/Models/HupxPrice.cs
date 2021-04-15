using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class HupxPrice
    {
        public int HupxPriceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Price { get; set; }
        public string Resolution { get; set; }
        public string PriceUnit { get; set; }
    }
}
