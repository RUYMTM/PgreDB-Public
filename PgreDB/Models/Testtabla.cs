using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Testtabla
    {
        public int TesttablaId { get; set; }
        public DateTime UsageDate { get; set; }
        public decimal Kibibytes { get; set; }
        public string DataDirection { get; set; }
    }
}
