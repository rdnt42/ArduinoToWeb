using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ArduinoToWeb.Models
{
    public class DeviceContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
    }
}