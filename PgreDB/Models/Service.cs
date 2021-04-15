using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Service
    {
        public int ServiceFeeId { get; set; }
        public bool? ActiveMekh { get; set; }
        public bool ActiveInverterControl { get; set; }
        public bool ActiveInverterMonitoring { get; set; }
        public bool ActivePrediction { get; set; }
        public int PowerPlantId { get; set; }
        public bool? ActiveBilling { get; set; }
        public decimal TotalFeedInTariffFixFee { get; set; }
        public decimal TotalBaseFee { get; set; }
        public decimal TotalSuccessFee { get; set; }
        public string PaymentType { get; set; }
        public string Currency { get; set; }
        public int? PaymentCycle { get; set; }
        public DateTime? PaymentIgnoreFrom { get; set; }
        public DateTime? PaymentIgnoreUntil { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
    }
}
