using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class MekhIdentification
    {
        public int MekhIdentificationId { get; set; }
        public int PowerPlantId { get; set; }
        public int MekhIdentificationGroupId { get; set; }
        public string SapId { get; set; }
        public string BalanceGroupRegistrationNumber { get; set; }
        public string MekhId { get; set; }
        public bool? V300AutoFilled { get; set; }
        public string T1 { get; set; }
        public string T2 { get; set; }
        public string T3 { get; set; }
        public bool? Disabled { get; set; }
        public string BankAccountNumber { get; set; }
        public string Bank { get; set; }
        public int? BankAccountNumberId { get; set; }
        public string InvoiceBook { get; set; }

        public virtual MekhIdentificationGroup MekhIdentificationGroup { get; set; }
        public virtual PowerPlant PowerPlant { get; set; }
    }
}
