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
                return true;
            }
            catch
            {
                connectionStatus = "Connect fail!";
                labelStatus.Text = connectionStatus;
                ErrorMes("Lost connection!", "Error");
                return false;
            }
        }
        private void btnOffDenxanh_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Đèn xanh", 2079, " đã tắt", " đã bật", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void btnStar_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Start ngôi sao", 2080, "Off status", "On status", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void btnResetX2_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2082, "Off status", "On status", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void btnM165_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2213, "Off status", "On status", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void btnPassTro_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2289, "Off status", "On status", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void btnCuaTruot_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2093, "Off status", "On status", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void btnDoaMa_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2247, "Off status", "On status", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void rfidTui_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2263, "Off status", "On status", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void btnMoXquang_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2093, "Off status", "On status", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void btnDoneXQuang_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2150, "Off status", "On status", 0);
                lbInfor.Text = resetBtn.Write();
            }
        }
        private void btnDemo_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2548, "Off status", "On status", 2000);
                lbDemo.Text = resetBtn.Write();
            }
        }
        private void btnDemo2_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2548, "Off status", "On status", 0);
                lbDemo.Text = resetBtn.Write();
            }
        }
        private void btnDemo3_Click(object sender, EventArgs e)
        {
            if (CheckConnectionPLC(plcMaster, lbConnectStt))
            {
                Modules.ButtonsOfPLC resetBtn;
                resetBtn = new Modules.ButtonsOfPLC(plcMaster, "Reset", 2549, "Off status", "On status", 500);
                lbDemo.Text = resetBtn.Write();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            plcMaster.Disconnect();
        }
        public static void ErrorMes(string content, string title)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ucTest1_Load(object sender, EventArgs e)
        {

        }

        private void btnMoXquang_Click_1(object sender, EventArgs e)
        {

        }


    }
}
