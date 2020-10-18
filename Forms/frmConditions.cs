using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_2_Paso_2.Data;
using Unidad_2_Paso_2.Models;

namespace Unidad_2_Paso_2.Forms
{
    public partial class frmConditions : Form
    {
        private int _maxMinTest = 120;
        private List<Product> _products;

        public frmConditions()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            _products = SeedData.SeedProducts();
            dgvProducts.DataSource = _products;
            dgvProducts.Refresh();

            // se agrega el campo boton y su respectivo evento
            // https://stackoverflow.com/questions/21191950/how-to-add-a-button-to-a-column-in-the-datagridview
                      
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "AddToOrder";
                button.HeaderText = "Agregar a Venta";
                button.Text = "Agregar";
                button.UseColumnTextForButtonValue = true;
                this.dgvProducts.Columns.Add(button);
            }

            dgvProducts.CellContentClick += dgvProducts_CellContentClick;

        }
         
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check deleted rows
            if (dgvProducts.Columns[e.ColumnIndex].Name == "AddToOrder")
            {
                var value = dgvProducts.Rows[e.RowIndex].Cells[0].Value;

                Product prod = _products.Find(x => x.Id == int.Parse(value.ToString()));

                if(prod.Stock > 0)
                {
                    prod.Stock -= 1;

                    dgvProducts.DataSource = _products;
                    dgvProducts.Refresh();

                    decimal currentPrice = decimal.Parse(lblPrice.Text);
                    currentPrice += prod.UnitPrice;
                    lblPrice.Text = currentPrice.ToString();

                    decimal currentTax = decimal.Parse(lblTax.Text);
                    currentTax += prod.Tax;
                    lblTax.Text = currentTax.ToString();

                    lblFullPrice.Text = (currentPrice + currentTax).ToString();
                }
                else
                {
                    MessageBox.Show("Producto sin Stock");
                }
                
            }
        }

        private void btnInitTest_Click(object sender, EventArgs e)
        {
            pnlExercise2.Enabled = true;
            pnlExercise2.Visible = true;

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            pnlTest.Enabled = true;
            pnlTest.Visible = true;

            timer1.Enabled = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SetTime();
            if (_maxMinTest <= 0)
            {
                MessageBox.Show("Finalizo el tiempo");
                EvaluateTest();
            }
        }

        private void EvaluateTest()
        {
            int totalValue = 0;
                        
            // question 1
            if (Question1_op2.Checked) totalValue++;

            // question 2
            if (Question2_op3.Checked) totalValue++;

            // question 3
            if (Question3_op2.Checked) totalValue++;

            // question 4
            if (Question4_op1.Checked) totalValue++;

            // question 5
            if (Question5_op1.Checked) totalValue++;

            if (totalValue < 3)
            {
                MessageBox.Show("No aprobaste vuelve a intentarlo");
                return;
            }

            MessageBox.Show("Aprobaste");
            ResetFormTest();
        }

        private bool ValidateQuestions()
        {
            // question 1
            if( !Question1_op1.Checked && 
                !Question1_op2.Checked &&
                !Question1_op3.Checked)
                return false;

            // question 2
            if (!Question2_op1.Checked &&
                !Question2_op2.Checked &&
                !Question2_op3.Checked)
                return false;

            // question 3
            if (!Question3_op1.Checked &&
                !Question3_op2.Checked &&
                !Question3_op3.Checked)
                return false;

            // question 4
            if (!Question4_op1.Checked &&
                !Question4_op2.Checked &&
                !Question4_op3.Checked)
                return false;

            // question 5
            if (!Question5_op1.Checked &&
                !Question5_op2.Checked)
                return false;

            return true;
        }

        private void SetTime()
        {
            _maxMinTest -= 1;
            decimal minutes = _maxMinTest / 60;
            decimal seconds = _maxMinTest % 60;
            lblTimeTest.Text = string.Format("{0}:{1}", minutes, seconds.ToString().PadLeft(2, '0'));
        }

        private void btnFinishTest_Click(object sender, EventArgs e)
        {
            if (ValidateQuestions())
            {
                timer1.Enabled = false;
                timer1.Stop();
                _maxMinTest = 120;
                decimal minutes = _maxMinTest / 60;
                decimal seconds = _maxMinTest % 60;
                lblTimeTest.Text = string.Format("{0}:{1}", minutes, seconds.ToString().PadLeft(2, '0'));
                EvaluateTest();
                ResetFormTest();
            }
            else
            {
                MessageBox.Show("Debe contestar el total de preguntas");
            }
        }

        private void ResetFormTest() 
        {
            // question 1
            Question1_op1.Checked = false;
            Question1_op2.Checked = false;
            Question1_op3.Checked = false;
            
            // question 2
            Question2_op1.Checked = false;
            Question2_op2.Checked = false;
            Question2_op3.Checked = false;

            // question 3
            Question3_op1.Checked = false;
            Question3_op2.Checked = false;
            Question3_op3.Checked = false;
            
            // question 4
            Question4_op1.Checked = false;
            Question4_op2.Checked = false;
            Question4_op3.Checked = false;

            // question 5
            Question5_op1.Checked = false;
            Question5_op2.Checked = false;

            SetTime();
        }

      
    }
}
