using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class CompanyBankAccountNumber
    {
        public int CompanyBankAccountNumberId { get; set; }
        public int CompanyId { get; set; }
        public string Value { get; set; }
        public int? BankId { get; set; }
    }
}
