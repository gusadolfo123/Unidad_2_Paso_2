using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_2_Paso_2.Forms;

namespace Unidad_2_Paso_2
{
    public partial class frmMain : Form
    {
        private Form _currentChildForm;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBasicOperations_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmBasicOperations());
        }

        private void btnConditions_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmConditions());
        }

        private void btnCycles_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmCycles());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFormChild(Form childForm)
        {
            if (_currentChildForm != null)            
                _currentChildForm.Close();
            
            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPrimary.Controls.Add(childForm);
            pnlPrimary.Tag = childForm;
            childForm.BringToFront();
            childForm.Width = pnlPrimary.Width;
            childForm.Show();
        }

    }
}
