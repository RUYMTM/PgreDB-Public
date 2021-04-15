using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class TransactionItem
    {
        public int TransactionItemId { get; set; }
        public int TransactionId { get; set; }
        public string Name { get; set; }
        public int UniqueIdentifier { get; set; }
        public string UniqueIdentifierType { get; set; }
        public double NetValue { get; set; }
        public double GrossValue { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool OnProduction { get; set; }
        public bool? IsGroupMember { get; set; }
        public string Comment { get; set; }
    }
}
