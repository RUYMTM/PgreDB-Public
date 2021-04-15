using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ProductionDataInvoice
    {
        public int ProductionDataInvoiceId { get; set; }
        public int ProductionDataId { get; set; }
        public int BillingoId { get; set; }
        public string InvoiceNo { get; set; }
        public string DownloadUrl { get; set; }
        public bool? Approved { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
        public DateTime? SentAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? MustBeSendAt { get; set; }
        public string ConfirmedNote { get; set; }
        public string Hash { get; set; }
        public bool? ShouldRetry { get; set; }
        public string InvoiceSoftwareId { get; set; }
        public int? FileId { get; set; }

        public virtual ProductionDatum ProductionData { get; set; }
    }
}
