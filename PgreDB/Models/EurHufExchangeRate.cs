using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class EurHufExchangeRate
    {
        public int EurHufExchangeRateId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Rate { get; set; }
        public string Resolution { get; set; }
    }
}
