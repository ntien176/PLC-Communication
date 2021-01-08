using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Windows.Forms;

namespace PLC_Connection_App
{
    public partial class Form1 : Form
    {
        public Configuration PLCClass;
        public static ModbusClient plcMaster;
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            plcMaster = ConnectPLC(PLCClass);
            if (CheckConnectionPLC(plcMaster))
            {
                lbConnectionStatus.Text = "Connect successfully!";
            }            
            else
            {
                lbConnectionStatus.Text = "Connect fail!";
            }
            //Declare variables:
            //setupBtn = new Modules.ButtonsOfPLC(plcMaster, "Set up", 2081, "Turn off the light", "Turn on the light", 1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Modules.ButtonsOfPLC resetBtn;
            resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2080, "Off status", "On status", 1);
            lbInfor.Text = resetBtn.Write();
            //Console.WriteLine("plc Connect: " + plcMaster.Master.IsConnected);
        }

        private void btnReConnect_Click(object sender, EventArgs e)
        {
            //Declare master plc
            plcMaster = ConnectPLC(PLCClass);
            if (plcMaster.Connected)
            {
                lbConnectionStatus.Text = "Connect successfully!";
            }
            else
            {
                lbConnectionStatus.Text = "Connect fail!";
            }
        }
        public ModbusClient ConnectPLC(Configuration plcClass)
        {
            plcClass = new Configuration(Constants.ipMasterSimulate, Constants.portMaster);
            return plcClass.Master;
        }
        public static bool CheckConnectionPLC(ModbusClient plc)
        {
            if (plc.Connected)
            {
                return true;
            }
            else
            {
                ErrorMes("Lost connection!", "Error");
                return false;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //plcMaster.Master.Close();
            plcMaster.Disconnect();
        }
        public static void ErrorMes(string content, string title)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
