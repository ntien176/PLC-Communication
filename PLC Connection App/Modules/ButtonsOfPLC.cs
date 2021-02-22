using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
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
        int Maintained;
        public ModbusClient plc;
        public ButtonsOfPLC(ModbusClient master, string nameOfBtn, ushort addressOfBtn, string desOfStatusOff, string desOfStatusOn, int maintained)
        {
            Name = nameOfBtn;
            Address = addressOfBtn;
            descriptionOfStatusOff = desOfStatusOff;
            descriptionOfStatusOn = desOfStatusOn;
            plc = master;
            Maintained = maintained;
        }
        public string Write()
        {
            try
            {
                if (Maintained < 500)
                {
                    if (Read())
                    {
                        plc.WriteSingleCoil(Address, false);
                        return descriptionOfStatusOff;
                    }
                    else
                    {
                        plc.WriteSingleCoil(Address, true);
                        return descriptionOfStatusOn;
                    }
                }
                else
                {
                    System.Timers.Timer aTimer;
                    aTimer = new System.Timers.Timer(Maintained);
                    plc.WriteSingleCoil(Address, true);
                    // Hook up the Elapsed event for the timer. 
                    aTimer.Elapsed += OnTimedEvent;
                    //aTimer.AutoReset = true;
                    aTimer.Enabled = true;
                    void OnTimedEvent(Object source, ElapsedEventArgs e)
                    {
                        plc.WriteSingleCoil(Address, false);
                        aTimer.Stop();
                    }
                    return descriptionOfStatusOn;
                }
            }
            catch
            {
                Form1.ErrorMes("Lost connection", "Error");
                return "";
            };
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            bool[] result = plc.ReadCoils(Address, 1);
            return result[0];
        }

    }
}
