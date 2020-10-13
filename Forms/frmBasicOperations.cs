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
    public partial class frmBasicOperations : Form
    {
        public frmBasicOperations()
        {
            InitializeComponent();
        }

        private void btnExercise2Result_Click(object sender, EventArgs e)
        {
            decimal height = decimal.Parse(txtHeight.Text);
            decimal weight = decimal.Parse(txtWeight.Text);

            if (height == 0)
            {
                MessageBox.Show("La altuna no puede ser 0");
                return;
            }

            if (weight == 0)
            {
                MessageBox.Show("El peso no puede ser 0");
                return;
            }

            decimal result = weight / (height * height);
            txtResultExcercise2.Text = result.ToString();
        }

        private void btnExercise3Result_Click(object sender, EventArgs e)
        {
            decimal num = txtConvertNum.Value;
            if(num == 0)
            {
                MessageBox.Show("El valor a convertir debe ser diferente de 0");
                return;
            }

            if (cbxFrom.SelectedIndex == -1 || cbxTo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione los tipos a convertir");
                return;
            }


            decimal result = 0;

            if (cbxFrom.Text == "Metro cubico")
            {
                if (cbxTo.Text == "Litro")
                {
                    result = Convert.ToDecimal(num) * Convert.ToDecimal(1000);
                    txtResultExcercise3.Text = result.ToString();
                }
                else if (cbxTo.Text == "Decilitro")
                {
                    result = Convert.ToDecimal(num) * Convert.ToDecimal(10000);
                    txtResultExcercise3.Text = result.ToString();
                }
                else if (cbxTo.Text == "Centilitro")
                {
                    result = Convert.ToDecimal(num) * Convert.ToDecimal(100000);
                    txtResultExcercise3.Text = result.ToString();
                }
            }
            else if (cbxFrom.Text == "Decímetro cubico")
            {
                if (cbxTo.Text == "Litro")
                {
                    result = Convert.ToDecimal(num) * Convert.ToDecimal(1);
                    txtResultExcercise3.Text = result.ToString();
                }
                else if (cbxTo.Text == "Decilitro")
                {
                    result = Convert.ToDecimal(num) * Convert.ToDecimal(10);
                    txtResultExcercise3.Text = result.ToString();
                }
                else if (cbxTo.Text == "Centilitro")
                {
                    result = Convert.ToDecimal(num) * Convert.ToDecimal(100);
                    txtResultExcercise3.Text = result.ToString();
                }
            }
            else if(cbxFrom.Text == "Centímetro cubico")
            {
                if (cbxTo.Text == "Litro")
                {
                    result = Convert.ToDecimal(num) / Convert.ToDecimal(1000);
                    txtResultExcercise3.Text = result.ToString();
                }
                else if (cbxTo.Text == "Decilitro")
                {
                    result = Convert.ToDecimal(num) * Convert.ToDecimal(100);
                    txtResultExcercise3.Text = result.ToString();
                }
                else if (cbxTo.Text == "Centilitro")
                {
                    result = Convert.ToDecimal(num) * Convert.ToDecimal(10);
                    txtResultExcercise3.Text = result.ToString();
                }
            }

        }

        #region Se crea evento para que convierta el punto en coma 

        /// Recurso donde se encontro solucion
        /// https://stackoverflow.com/questions/24310445/numericupdown-accept-both-comma-and-dot-as-decimal-separator
        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void txtConvertNum_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }
        #endregion
    }
}
