using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class ProductionDatum
    {
        public ProductionDatum()
        {
            MekhSheets = new HashSet<MekhSheet>();
            ProductionDataInvoices = new HashSet<ProductionDataInvoice>();
        }

        public int ProductionDataId { get; set; }
        public int PowerPlantId { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Fields { get; set; }
        public bool IsError { get; set; }
        public bool IsLocked { get; set; }
        public bool MustBeNull { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsProduceEnergy { get; set; }
        public string LastError { get; set; }
        public bool? KatProduction { get; set; }
        public string ExtraData { get; set; }
        public DateTime? EmailSentAboutError { get; set; }

        public virtual PowerPlant PowerPlant { get; set; }
        public virtual ICollection<MekhSheet> MekhSheets { get; set; }
        public virtual ICollection<ProductionDataInvoice> ProductionDataInvoices { get; set; }
    }
}
