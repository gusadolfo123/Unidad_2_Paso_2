using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_2_Paso_2.Forms
{
    public partial class frmConditions : Form
    {
        private int _maxMinTest = 120;

        public frmConditions()
        {
            InitializeComponent();
        }

        private void btnInitTest_Click(object sender, EventArgs e)
        {                        
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            pnlTest.Enabled = true;
            pnlTest.Visible = true;

            timer1.Enabled = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _maxMinTest -= 1;
            decimal minutes = _maxMinTest / 60;
            decimal seconds = _maxMinTest % 60;
            lblTimeTest.Text = string.Format("{0}:{1}", minutes, seconds.ToString().PadLeft(2, '0'));
        }

        private void btnFinishTest_Click(object sender, EventArgs e)
        {
            _maxMinTest = 120;
            timer1.Enabled = false;
            timer1.Stop();
        }
    }
}
