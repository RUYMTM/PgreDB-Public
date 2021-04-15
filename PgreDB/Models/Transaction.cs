using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public string Type { get; set; }
        public int CompanyId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? InvoiceId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? Confirmed { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CommentOnInv { get; set; }
        public DateTime? PaymentPeriodStart { get; set; }
        public DateTime? PaymentPeriodEnd { get; set; }
        public string PaymentType { get; set; }
    }
}
