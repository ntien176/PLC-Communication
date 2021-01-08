using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using ModbusTCPIP;
namespace PLC_Connection_App.Modules
{
    public class ButtonsOfPLC
    {
        string name;
        public string Name { get => name; set => name = value; }

        ushort address;
        public ushort Address { get => address; set => address = value; }
        string descriptionOfStatusOff;
        string descriptionOfStatusOn;
        public ModbusClient plc;
        public ButtonsOfPLC(ModbusClient master, string nameOfBtn, ushort addressOfBtn, string desOfStatusOff, string desOfStatusOn, int maintained)
        {
            Name = nameOfBtn;
            Address = addressOfBtn;
            descriptionOfStatusOff = desOfStatusOff;
            descriptionOfStatusOn = desOfStatusOn;
            plc = master;
        }
        public string Write()
        {
            try
            {
                if (Form1.CheckConnectionPLC(plc))
                {
                    if (Read())
                    {
                        plc.WriteSingleCoil(Address, false);
                        Console.WriteLine(address + " is " + Read().ToString());
                        return descriptionOfStatusOff;
                    }
                    else
                    {
                        plc.WriteSingleCoil(Address, true);
                        Console.WriteLine(address + " is " + Read().ToString());
                        return descriptionOfStatusOn;
                    }
                }
                else
                {
                    return "Error";
                };
            }
            catch
            {
                if (Form1.CheckConnectionPLC(plc))
                {
                    Console.WriteLine("Lost connection!");
                    return "Lost connection!";
                }
                else
                {
                    return "Lost connection!";
                }
            };

        }
        public bool Read()
        {
            bool[] result = plc.ReadCoils(Address, 1);
            return result[0];
        }

    }
}
