using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLC_Connection_App
{
    public partial class ucTest : UserControl
    {
        public ucTest()
        {
            InitializeComponent();
        }
        private void btnM82_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            Modules.ButtonsOfPLC m82Btn;
            if (F1.CheckConnectionPLC(Form1.plcMaster, F1.lbConnectStt))
            {
                m82Btn = new Modules.ButtonsOfPLC(Form1.plcMaster, "Set up", 2081, "Turn off the light", "Turn on the light", 1);
                lbM82.Text = m82Btn.Write();
            }
        }
    }
}
