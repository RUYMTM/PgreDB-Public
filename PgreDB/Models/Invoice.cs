using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Invoice
    {
        public int InvoiceId { get; set; }
        public int InvoiceIssuerCompanyId { get; set; }
        public int InvoiceAcquirerCompanyId { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public string InvoiceNumber { get; set; }
        public string UniqueIdentification { get; set; }
        public string BillingSoftware { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime PaymentPeriodStartMonth { get; set; }
        public DateTime PaymentPeriodEndMonth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? NotifiedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime? DateBilled { get; set; }
        public DateTime? DateDue { get; set; }
        public DateTime? DateFulfilled { get; set; }
        public DateTime? PrintedAt { get; set; }
        public string Cancelled { get; set; }
        public int? SourceId { get; set; }
        public int? SoftwareUniqueId { get; set; }
        public string BankTransactionId { get; set; }
        public bool? FulfilledInInvoiceSoftware { get; set; }
        public DateTime? ReminderSentAt { get; set; }
        public int? ReminderEmailVersion { get; set; }
        public DateTime? PaymentDeadline { get; set; }

        public virtual Company InvoiceAcquirerCompany { get; set; }
        public virtual Company InvoiceIssuerCompany { get; set; }
    }
}
