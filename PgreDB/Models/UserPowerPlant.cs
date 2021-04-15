using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class UserPowerPlant
    {
        public int UserPowerPlantId { get; set; }
        public int PowerPlantId { get; set; }
        public int UserId { get; set; }
        public bool ActiveScheduleNotification { get; set; }
        public bool ActiveBillingNotification { get; set; }
        public bool ActiveDatasheetNotification { get; set; }
        public bool ActiveBillingSampleNotification { get; set; }
        public bool ActiveDatasheetSampleNotification { get; set; }
        public bool ActiveBillingPostNotification { get; set; }
        public bool ActiveInverterMonitoringErrorNotification { get; set; }
        public bool ActiveInverterMonitoringMonthlyPdf { get; set; }
        public bool ActiveEwiserPayoff { get; set; }
        public bool? ActiveDatasheetSelfConsumptionNotification { get; set; }
        public bool? ActiveDatasheetIncomeValidationNotification { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
        public virtual EwiserUser User { get; set; }
    }
}
