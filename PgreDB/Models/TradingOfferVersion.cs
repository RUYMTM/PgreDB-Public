using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class TradingOfferVersion
    {
        public int TradingOfferVersionId { get; set; }
        public int LastSubmittedVersion { get; set; }
        public int PowerControlGroupId { get; set; }
        public DateTime OfferDate { get; set; }

        public virtual PowerControlGroup PowerControlGroup { get; set; }
    }
}
