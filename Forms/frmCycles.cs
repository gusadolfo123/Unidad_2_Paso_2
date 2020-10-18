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
    public partial class frmCycles : Form
    {
        private List<int> _numbers = new List<int>();

        public frmCycles()
        {
            InitializeComponent();
        }

        private void btnExcercise13_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumToAdd.Value);
            _numbers.Add(number);
            lblArray.Text = string.Join(",", _numbers);
        }
    }
}
