using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class IntervalProduct
    {
        public int IntervalProductId { get; set; }
        public int PowerControlGroupId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Quantity { get; set; }
        public decimal TechnicalLimit { get; set; }
        public decimal MarketPriceHuf { get; set; }
        public string MarketPriceUnit { get; set; }
        public string Resolution { get; set; }
        public decimal Status { get; set; }
        public DateTime Edited { get; set; }

        public virtual PowerControlGroup PowerControlGroup { get; set; }
    }
}
