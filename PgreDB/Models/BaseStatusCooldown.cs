using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class BaseStatusCooldown
    {
        public int BaseStatusCooldownId { get; set; }
        public int StatusCode { get; set; }
        public int CooldownSec { get; set; }
        public int MaxStack { get; set; }
        public double Multiplier { get; set; }
    }
}
