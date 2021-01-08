using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using ModbusTCPIP;
using EasyModbus;
using System.Threading.Tasks;

namespace PLC_Connection_App
{
    //Config PLC Master
    public class Configuration
    {
        private string ipmaster;
        public string Ipmaster { get => ipmaster; set => ipmaster = value; }

        private int port;
        public int Port { get => port; set => port = value; }
        //public ModbusMaster Master;
        public ModbusClient Master;
        public Configuration(string ip, int port)
        {
            Ipmaster = ip;
            Port = port;
            //Master = new ModbusMaster(Ipmaster, Port);
            //Master.Open();
            try
            {
                Master = new ModbusClient(Ipmaster, Port);
                Master.Connect();
            }
            catch
            {
                //Form1.ErrorMes("Lost connection!", "Error");
            }
        }
    }

}
