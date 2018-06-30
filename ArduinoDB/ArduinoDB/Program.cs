using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace ArduinoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DeviceContext db = new DeviceContext();
                var devices = db.Devices;
                foreach (Device d in devices)
                {
                    Console.WriteLine(" Id: {0} Command: {1} Data: {2}", d.Id, d.Cmd, d.Data);
                }
            SerialPort port = new SerialPort("COM8", 115200);
            port.Open();
            while (true)
            {
                string data = port.ReadLine();
                String[] arrData = new String[2];
                arrData = data.Split(',');

                Device d = new Device( );
                d.Cmd = arrData[0];
                d.Data = Convert.ToInt32(arrData[1]);
                Console.WriteLine("Cmd: {0} Data: {1}", arrData[0], arrData[1]);

                db.Devices.Add(d);
                db.SaveChanges();
                //db.Dispose();
                
            }
            port.Close();

        }

        }
    }

