using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Company
    {
        public Company()
        {
            FileCompanies = new HashSet<FileCompany>();
            InvoiceInvoiceAcquirerCompanies = new HashSet<Invoice>();
            InvoiceInvoiceIssuerCompanies = new HashSet<Invoice>();
            PowerPlantBillings = new HashSet<PowerPlant>();
            PowerPlantCoordinators = new HashSet<PowerPlant>();
            PowerPlantOwners = new HashSet<PowerPlant>();
            PowerPlantSps = new HashSet<PowerPlant>();
            UserCompanies = new HashSet<UserCompany>();
        }

        public int CompanyId { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingName { get; set; }
        public string BillingZip { get; set; }
        public string BusinessNumber { get; set; }
        public string MailAddress { get; set; }
        public string MailCity { get; set; }
        public string MailName { get; set; }
        public string MailZip { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string TaxNumber { get; set; }
        public string InvoiceCustomNote { get; set; }
        public int CreatorId { get; set; }
        public string MekhId { get; set; }
        public string InvoiceSoftware { get; set; }
        public string InvoiceBankAccountNumber { get; set; }
        public string InvoiceBankName { get; set; }
        public string CashmanUsergroup { get; set; }
        public string CompanyReferenceId { get; set; }
        public bool? CashmanNavInvoice { get; set; }
        public bool? SyncedBankAccountNumber { get; set; }
        public string Country { get; set; }
        public int? InvoiceDeadline { get; set; }
        public string GroupTaxNumber { get; set; }
        public DateTime? LastSynced { get; set; }

        public virtual EwiserUser Creator { get; set; }
        public virtual ICollection<FileCompany> FileCompanies { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceAcquirerCompanies { get; set; }
        public virtual ICollection<Invoice> InvoiceInvoiceIssuerCompanies { get; set; }
        public virtual ICollection<PowerPlant> PowerPlantBillings { get; set; }
        public virtual ICollection<PowerPlant> PowerPlantCoordinators { get; set; }
        public virtual ICollection<PowerPlant> PowerPlantOwners { get; set; }
        public virtual ICollection<PowerPlant> PowerPlantSps { get; set; }
        public virtual ICollection<UserCompany> UserCompanies { get; set; }
    }
}
