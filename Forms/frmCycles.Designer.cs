namespace Unidad_2_Paso_2.Forms
{
    partial class frmCycles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumToAdd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMaxNumber = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResultMatrix = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.m1_00 = new System.Windows.Forms.NumericUpDown();
            this.m1_10 = new System.Windows.Forms.NumericUpDown();
            this.m1_01 = new System.Windows.Forms.NumericUpDown();
            this.m1_11 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m2_11 = new System.Windows.Forms.NumericUpDown();
            this.m2_01 = new System.Windows.Forms.NumericUpDown();
            this.m2_10 = new System.Windows.Forms.NumericUpDown();
            this.m2_00 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m3_11 = new System.Windows.Forms.NumericUpDown();
            this.m3_01 = new System.Windows.Forms.NumericUpDown();
            this.m3_10 = new System.Windows.Forms.NumericUpDown();
            this.m3_00 = new System.Windows.Forms.NumericUpDown();
            this.btnAddData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumToAdd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m1_00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_00)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(783, 102);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "\n\n\tEjercicio 13\n\n\tPrograma que realice el cargue de números en un arreglo me mues" +
    "tre el número mayor digitado. Se debe usar ciclo for.";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(783, 82);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Tema 3 Ciclos de programación";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.BackColor = System.Drawing.Color.White;
            this.btnAddNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNumber.Location = new System.Drawing.Point(205, 26);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(138, 27);
            this.btnAddNumber.TabIndex = 10;
            this.btnAddNumber.Text = "Agregar Numero";
            this.btnAddNumber.UseVisualStyleBackColor = false;
            this.btnAddNumber.Click += new System.EventHandler(this.btnExcercise13_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.lblMaxNumber);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.lblArray);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNumToAdd);
            this.panel1.Controls.Add(this.btnAddNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 121);
            this.panel1.TabIndex = 11;
            // 
            // txtNumToAdd
            // 
            this.txtNumToAdd.Location = new System.Drawing.Point(52, 31);
            this.txtNumToAdd.Name = "txtNumToAdd";
            this.txtNumToAdd.Size = new System.Drawing.Size(120, 20);
            this.txtNumToAdd.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Arreglo";
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblArray.ForeColor = System.Drawing.Color.White;
            this.lblArray.Location = new System.Drawing.Point(389, 50);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(0, 15);
            this.lblArray.TabIndex = 13;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(52, 71);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 27);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Obtener Numero Mayor";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblMaxNumber
            // 
            this.lblMaxNumber.AutoSize = true;
            this.lblMaxNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxNumber.ForeColor = System.Drawing.Color.White;
            this.lblMaxNumber.Location = new System.Drawing.Point(202, 77);
            this.lblMaxNumber.Name = "lblMaxNumber";
            this.lblMaxNumber.Size = new System.Drawing.Size(0, 19);
            this.lblMaxNumber.TabIndex = 15;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox2.Location = new System.Drawing.Point(0, 305);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(783, 102);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "\n\n\tEjercicio 14\n\t\n\tPrograma que realice la suma de matrices tomando datos desde e" +
    "l teclado. Se debe usar ciclo for.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.btnAddData);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.m3_11);
            this.panel2.Controls.Add(this.m3_01);
            this.panel2.Controls.Add(this.m3_10);
            this.panel2.Controls.Add(this.m3_00);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.m2_11);
            this.panel2.Controls.Add(this.m2_01);
            this.panel2.Controls.Add(this.m2_10);
            this.panel2.Controls.Add(this.m2_00);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.m1_11);
            this.panel2.Controls.Add(this.m1_01);
            this.panel2.Controls.Add(this.m1_10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnResultMatrix);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.m1_00);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 224);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(202, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 15;
            // 
            // btnResultMatrix
            // 
            this.btnResultMatrix.BackColor = System.Drawing.Color.White;
            this.btnResultMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultMatrix.Location = new System.Drawing.Point(227, 150);
            this.btnResultMatrix.Name = "btnResultMatrix";
            this.btnResultMatrix.Size = new System.Drawing.Size(136, 27);
            this.btnResultMatrix.TabIndex = 14;
            this.btnResultMatrix.Text = "Obtener Suma";
            this.btnResultMatrix.UseVisualStyleBackColor = false;
            this.btnResultMatrix.Click += new System.EventHandler(this.btnResultMatrix_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(389, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 13;
            // 
            // m1_00
            // 
            this.m1_00.Enabled = false;
            this.m1_00.Location = new System.Drawing.Point(45, 67);
            this.m1_00.Name = "m1_00";
            this.m1_00.Size = new System.Drawing.Size(52, 20);
            this.m1_00.TabIndex = 11;
            // 
            // m1_10
            // 
            this.m1_10.Enabled = false;
            this.m1_10.Location = new System.Drawing.Point(45, 93);
            this.m1_10.Name = "m1_10";
            this.m1_10.Size = new System.Drawing.Size(52, 20);
            this.m1_10.TabIndex = 16;
            // 
            // m1_01
            // 
            this.m1_01.Enabled = false;
            this.m1_01.Location = new System.Drawing.Point(114, 67);
            this.m1_01.Name = "m1_01";
            this.m1_01.Size = new System.Drawing.Size(46, 20);
            this.m1_01.TabIndex = 17;
            // 
            // m1_11
            // 
            this.m1_11.Enabled = false;
            this.m1_11.Location = new System.Drawing.Point(114, 93);
            this.m1_11.Name = "m1_11";
            this.m1_11.Size = new System.Drawing.Size(46, 20);
            this.m1_11.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Matriz 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(231, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Matriz 2";
            // 
            // m2_11
            // 
            this.m2_11.Enabled = false;
            this.m2_11.Location = new System.Drawing.Point(296, 93);
            this.m2_11.Name = "m2_11";
            this.m2_11.Size = new System.Drawing.Size(46, 20);
            this.m2_11.TabIndex = 23;
            // 
            // m2_01
            // 
            this.m2_01.Enabled = false;
            this.m2_01.Location = new System.Drawing.Point(296, 67);
            this.m2_01.Name = "m2_01";
            this.m2_01.Size = new System.Drawing.Size(46, 20);
            this.m2_01.TabIndex = 22;
            // 
            // m2_10
            // 
            this.m2_10.Enabled = false;
            this.m2_10.Location = new System.Drawing.Point(227, 93);
            this.m2_10.Name = "m2_10";
            this.m2_10.Size = new System.Drawing.Size(52, 20);
            this.m2_10.TabIndex = 21;
            // 
            // m2_00
            // 
            this.m2_00.Enabled = false;
            this.m2_00.Location = new System.Drawing.Point(227, 67);
            this.m2_00.Name = "m2_00";
            this.m2_00.Size = new System.Drawing.Size(52, 20);
            this.m2_00.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(182, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(375, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(418, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Resultado";
            // 
            // m3_11
            // 
            this.m3_11.Enabled = false;
            this.m3_11.Location = new System.Drawing.Point(483, 93);
            this.m3_11.Name = "m3_11";
            this.m3_11.Size = new System.Drawing.Size(46, 20);
            this.m3_11.TabIndex = 30;
            // 
            // m3_01
            // 
            this.m3_01.Enabled = false;
            this.m3_01.Location = new System.Drawing.Point(483, 67);
            this.m3_01.Name = "m3_01";
            this.m3_01.Size = new System.Drawing.Size(46, 20);
            this.m3_01.TabIndex = 29;
            // 
            // m3_10
            // 
            this.m3_10.Enabled = false;
            this.m3_10.Location = new System.Drawing.Point(414, 93);
            this.m3_10.Name = "m3_10";
            this.m3_10.Size = new System.Drawing.Size(52, 20);
            this.m3_10.TabIndex = 28;
            // 
            // m3_00
            // 
            this.m3_00.Enabled = false;
            this.m3_00.Location = new System.Drawing.Point(414, 67);
            this.m3_00.Name = "m3_00";
            this.m3_00.Size = new System.Drawing.Size(52, 20);
            this.m3_00.TabIndex = 27;
            // 
            // btnAddData
            // 
            this.btnAddData.BackColor = System.Drawing.Color.White;
            this.btnAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddData.Location = new System.Drawing.Point(45, 150);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(136, 27);
            this.btnAddData.TabIndex = 32;
            this.btnAddData.Text = "Agregar Datos";
            this.btnAddData.UseVisualStyleBackColor = false;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // frmCycles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCycles";
            this.Text = "frmCycles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumToAdd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m1_00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3_00)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtNumToAdd;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMaxNumber;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResultMatrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown m1_00;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown m3_11;
        private System.Windows.Forms.NumericUpDown m3_01;
        private System.Windows.Forms.NumericUpDown m3_10;
        private System.Windows.Forms.NumericUpDown m3_00;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown m2_11;
        private System.Windows.Forms.NumericUpDown m2_01;
        private System.Windows.Forms.NumericUpDown m2_10;
        private System.Windows.Forms.NumericUpDown m2_00;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown m1_11;
        private System.Windows.Forms.NumericUpDown m1_01;
        private System.Windows.Forms.NumericUpDown m1_10;
        private System.Windows.Forms.Button btnAddData;
    }
}