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
        public string lbIsConnected
        {
            get { return lbConnectionStatus.Text; }
            set { lbConnectionStatus.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            plcMaster = ConnectPLC(PLCClass);
            CheckConnectionPLC(plcMaster);
            Console.WriteLine(lbConnectionStatus);
            //Declare variables:
            //setupBtn = new Modules.ButtonsOfPLC(plcMaster, "Set up", 2081, "Turn off the light", "Turn on the light", 1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2080, "Off status", "On status", 1);
                lbInfor.Text = resetBtn.Write();
            }
            //else
            //{
            //    lbConnectionStatus.Text = connectionStatus;
            //}
            //Console.WriteLine("plc Connect: " + plcMaster.Master.IsConnected);
        }

        private void btnReConnect_Click(object sender, EventArgs e)
        {
            //Declare master plc
            plcMaster = ConnectPLC(PLCClass);
            CheckConnectionPLC(plcMaster);
            //lbConnectionStatus.Text = connectionStatus;
        }
        public ModbusClient ConnectPLC(Configuration plcClass)
        {
            plcClass = new Configuration(Constants.ipMasterSimulate, Constants.portMaster);
            return plcClass.Master;
        }

        public static bool CheckConnectionPLC(ModbusClient plc)
        {
            string connectionStatus;
            try
            {
                Form1 f = new Form1();                
                plc.Connect();
                connectionStatus = "Connect successfully!";
                Console.WriteLine(f.lbIsConnected);

                f.lbIsConnected = connectionStatus;
                return true;
            }
            catch
            {
                Form1 f = new Form1();
                connectionStatus = "Connect fail!";
                f.lbIsConnected = connectionStatus;
                Console.WriteLine(f.lbIsConnected);
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

        private void ucTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
