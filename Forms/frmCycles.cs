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
        private List<int> _matrix1 = new List<int>();
        private List<int> _matrix2 = new List<int>(); 

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

        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            int aux = 0;
            for (int i = 0; i < _numbers.Count; i++)
            {
                int currentVal = _numbers[i];
                if (aux < currentVal)
                    aux = currentVal;
            }

            lblMaxNumber.Text = $" El numero mayor es el {aux.ToString()}";
        }

        private void btnResultMatrix_Click(object sender, EventArgs e)
        {
            m3_00.Value = m1_00.Value + m2_00.Value;
            m3_01.Value = m1_01.Value + m2_01.Value;

            m3_10.Value = m1_10.Value + m2_10.Value;
            m3_11.Value = m1_11.Value + m2_11.Value;
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            // captura de datos matriz 1
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    // https://stackoverflow.com/questions/5427020/prompt-dialog-in-windows-forms

                    string title = string.Empty;
                    string sub = string.Empty;

                    if (i == 0)
                    {
                        title = "Datos Matriz 1";
                        if (j == 0)
                            sub = "Datos Fila 1";
                        else
                            sub = "Datos Fila 2";
                    }

                    string input = Microsoft.VisualBasic.Interaction.InputBox(sub,
                       title,
                      "0",
                       0,
                       0);
                    
                    if(j == 0 && i == 0)
                        m1_00.Value = int.Parse(input);
                    if (j == 1 && i == 0)
                        m1_01.Value = int.Parse(input);

                    if (j == 0 && i == 1)
                        m1_10.Value = int.Parse(input);
                    if (j == 1 && i == 1)
                        m1_11.Value = int.Parse(input);
                }
            }


            // captura de datos matriz 2
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    // https://stackoverflow.com/questions/5427020/prompt-dialog-in-windows-forms

                    string title = string.Empty;
                    string sub = string.Empty;

                    if (i == 0)
                    {
                        title = "Datos Matriz 2";
                        if (j == 0)
                            sub = "Datos Fila 1";
                        else
                            sub = "Datos Fila 2";
                    }

                    string input = Microsoft.VisualBasic.Interaction.InputBox(sub,
                       title,
                      "0",
                       0,
                       0);

                    if (j == 0 && i == 0)
                        m2_00.Value = int.Parse(input);
                    if (j == 1 && i == 0)
                        m2_01.Value = int.Parse(input);

                    if (j == 0 && i == 1)
                        m2_10.Value = int.Parse(input);
                    if (j == 1 && i == 1)
                        m2_11.Value = int.Parse(input);
                }
            }
        }
    }
}
