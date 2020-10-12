namespace Unidad_2_Paso_2.Forms
{
    partial class frmBasicOperations
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlExercise2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtResultExcercise2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExercise2Result = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pnlExercise3 = new System.Windows.Forms.Panel();
            this.btnExercise3Result = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultExcercise3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxFrom = new System.Windows.Forms.ComboBox();
            this.cbxTo = new System.Windows.Forms.ComboBox();
            this.pnlExercise2.SuspendLayout();
            this.pnlExercise3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 82);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tema 1 Operaciones básicas de programación";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 122);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "\n\n\tEjercicio 2\n\n\tPrograma para calcular la masa corporal de una persona.\n\n\tIMC = " +
    "Peso (kg) / altura (m)2";
            // 
            // pnlExercise2
            // 
            this.pnlExercise2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.pnlExercise2.Controls.Add(this.btnExercise2Result);
            this.pnlExercise2.Controls.Add(this.label4);
            this.pnlExercise2.Controls.Add(this.txtResultExcercise2);
            this.pnlExercise2.Controls.Add(this.txtHeight);
            this.pnlExercise2.Controls.Add(this.txtWeight);
            this.pnlExercise2.Controls.Add(this.label3);
            this.pnlExercise2.Controls.Add(this.label2);
            this.pnlExercise2.Controls.Add(this.label1);
            this.pnlExercise2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExercise2.Location = new System.Drawing.Point(0, 204);
            this.pnlExercise2.Name = "pnlExercise2";
            this.pnlExercise2.Size = new System.Drawing.Size(800, 139);
            this.pnlExercise2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso (Kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(188, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura (m)2";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(60, 81);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(191, 81);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 4;
            // 
            // txtResultExcercise2
            // 
            this.txtResultExcercise2.Enabled = false;
            this.txtResultExcercise2.Location = new System.Drawing.Point(326, 81);
            this.txtResultExcercise2.Name = "txtResultExcercise2";
            this.txtResultExcercise2.Size = new System.Drawing.Size(100, 20);
            this.txtResultExcercise2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(323, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado";
            // 
            // btnExercise2Result
            // 
            this.btnExercise2Result.BackColor = System.Drawing.Color.White;
            this.btnExercise2Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercise2Result.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExercise2Result.Location = new System.Drawing.Point(456, 79);
            this.btnExercise2Result.Name = "btnExercise2Result";
            this.btnExercise2Result.Size = new System.Drawing.Size(75, 23);
            this.btnExercise2Result.TabIndex = 7;
            this.btnExercise2Result.Text = "Calular";
            this.btnExercise2Result.UseVisualStyleBackColor = false;
            this.btnExercise2Result.Click += new System.EventHandler(this.btnExercise2Result_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox2.Location = new System.Drawing.Point(0, 343);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(800, 99);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "\n\tEjercicio 3\n\n\tPrograma que haga la conversión de:\n\tMetro cubico, Decímetro cubi" +
    "co, Centímetro cubico\n\tConvertir a: Litro, Decilitro, Centilitro";
            // 
            // pnlExercise3
            // 
            this.pnlExercise3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.pnlExercise3.Controls.Add(this.cbxTo);
            this.pnlExercise3.Controls.Add(this.cbxFrom);
            this.pnlExercise3.Controls.Add(this.btnExercise3Result);
            this.pnlExercise3.Controls.Add(this.label5);
            this.pnlExercise3.Controls.Add(this.txtResultExcercise3);
            this.pnlExercise3.Controls.Add(this.label6);
            this.pnlExercise3.Controls.Add(this.label7);
            this.pnlExercise3.Controls.Add(this.label8);
            this.pnlExercise3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExercise3.Location = new System.Drawing.Point(0, 442);
            this.pnlExercise3.Name = "pnlExercise3";
            this.pnlExercise3.Size = new System.Drawing.Size(800, 139);
            this.pnlExercise3.TabIndex = 5;
            // 
            // btnExercise3Result
            // 
            this.btnExercise3Result.BackColor = System.Drawing.Color.White;
            this.btnExercise3Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercise3Result.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExercise3Result.Location = new System.Drawing.Point(456, 79);
            this.btnExercise3Result.Name = "btnExercise3Result";
            this.btnExercise3Result.Size = new System.Drawing.Size(75, 23);
            this.btnExercise3Result.TabIndex = 7;
            this.btnExercise3Result.Text = "Calular";
            this.btnExercise3Result.UseVisualStyleBackColor = false;
            this.btnExercise3Result.Click += new System.EventHandler(this.btnExercise3Result_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(323, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Resultado";
            // 
            // txtResultExcercise3
            // 
            this.txtResultExcercise3.Enabled = false;
            this.txtResultExcercise3.Location = new System.Drawing.Point(326, 81);
            this.txtResultExcercise3.Name = "txtResultExcercise3";
            this.txtResultExcercise3.Size = new System.Drawing.Size(100, 20);
            this.txtResultExcercise3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(188, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Convertir a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(57, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Convertir de";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(57, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ingresar Datos";
            // 
            // cbxFrom
            // 
            this.cbxFrom.FormattingEnabled = true;
            this.cbxFrom.Location = new System.Drawing.Point(60, 81);
            this.cbxFrom.Name = "cbxFrom";
            this.cbxFrom.Size = new System.Drawing.Size(121, 21);
            this.cbxFrom.TabIndex = 8;
            // 
            // cbxTo
            // 
            this.cbxTo.FormattingEnabled = true;
            this.cbxTo.Location = new System.Drawing.Point(191, 81);
            this.cbxTo.Name = "cbxTo";
            this.cbxTo.Size = new System.Drawing.Size(121, 21);
            this.cbxTo.TabIndex = 9;
            // 
            // frmBasicOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.pnlExercise3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.pnlExercise2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmBasicOperations";
            this.Text = "frmBasicOperations";
            this.pnlExercise2.ResumeLayout(false);
            this.pnlExercise2.PerformLayout();
            this.pnlExercise3.ResumeLayout(false);
            this.pnlExercise3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel pnlExercise2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultExcercise2;
        private System.Windows.Forms.Button btnExercise2Result;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel pnlExercise3;
        private System.Windows.Forms.Button btnExercise3Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultExcercise3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTo;
        private System.Windows.Forms.ComboBox cbxFrom;
    }
}