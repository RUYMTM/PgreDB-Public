using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Deposit
    {
        public Deposit()
        {
            DepositPowerPlants = new HashSet<DepositPowerPlant>();
        }

        public int DepositId { get; set; }
        public int PayingCompanyId { get; set; }
        public string BankTransactionId { get; set; }
        public int GrossSummaryValue { get; set; }
        public DateTime? TransferedToMavir { get; set; }
        public DateTime? Received { get; set; }

        public virtual ICollection<DepositPowerPlant> DepositPowerPlants { get; set; }
    }
}
