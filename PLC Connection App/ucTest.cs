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
        private Modules.ButtonsOfPLC m82Btn;
        public ucTest()
        {
            InitializeComponent();
            m82Btn = new Modules.ButtonsOfPLC(Configuration.plcMaster, "Set up", 2081, "Turn off the light", "Turn on the light", 1);

        }

        private void btnM82_Click(object sender, EventArgs e)
        {
            lbM82.Text = m82Btn.Write();
        }
    }
}
