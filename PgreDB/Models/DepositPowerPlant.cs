using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class DepositPowerPlant
    {
        public int DepositPowerPlantId { get; set; }
        public int DepositId { get; set; }
        public int PowerPlantId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Value { get; set; }

        public virtual Deposit Deposit { get; set; }
        public virtual PowerPlant PowerPlant { get; set; }
    }
}
