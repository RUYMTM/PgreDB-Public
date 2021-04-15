using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class Device
    {
        public Device()
        {
            DataLoggerHttpPullDevices = new HashSet<DataLogger>();
        }

        public int DeviceId { get; set; }
        public int RouterId { get; set; }
        public string IpAddress { get; set; }
        public int IpPort { get; set; }
        public string Name { get; set; }
        public string DeviceType { get; set; }
        public string Comment { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual Router Router { get; set; }
        public virtual DataLogger DataLoggerModbusManagerDevice { get; set; }
        public virtual ICollection<DataLogger> DataLoggerHttpPullDevices { get; set; }
    }
}
