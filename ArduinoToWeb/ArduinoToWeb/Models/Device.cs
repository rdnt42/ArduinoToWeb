
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ArduinoToWeb.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Cmd { get; set; }
        public int Data { get; set; }
    }
}