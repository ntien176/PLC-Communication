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
            CheckConnectionPLC(plcMaster, lbConnectStt);
        }
        public ModbusClient ConnectPLC(Configuration plcClass)
        {
            plcClass = new Configuration(Constants.ipMasterSimulate, Constants.portMaster);
            return plcClass.Master;
        }
        private void btnReConnect_Click(object sender, EventArgs e)
        {
            //Declare master plc
            plcMaster = ConnectPLC(PLCClass);
            CheckConnectionPLC(plcMaster, lbConnectStt);
        }
        public bool CheckConnectionPLC(ModbusClient plc, Label labelStatus)
        {
            string connectionStatus;
            try
            {
                plc.Connect();
                connectionStatus = "Connect successfully!";

                labelStatus.Text = connectionStatus;
                //Console.WriteLine(f.lbIsConnected);
                return true;
            }
            catch
            {
                connectionStatus = "Connect fail!";
                labelStatus.Text = connectionStatus;
                ErrorMes("Lost connection!", "Error");
                //Console.WriteLine(f.lbIsConnected);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2201, "Off status", "On status", 1);
                lbInfor.Text = resetBtn.Write();
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
