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
            Modules.ButtonsOfPLC m82Btn;
            if (Form1.CheckConnectionPLC(Form1.plcMaster))
            {
                m82Btn = new Modules.ButtonsOfPLC(Form1.plcMaster, "Set up", 2081, "Turn off the light", "Turn on the light", 1);
                lbM82.Text = m82Btn.Write();
            }
        }
    }
}
