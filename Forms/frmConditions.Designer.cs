namespace Unidad_2_Paso_2.Forms
{
    partial class frmConditions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConditions));
            this.pnlExercise2 = new System.Windows.Forms.Panel();
            this.btnFinishTest = new System.Windows.Forms.Button();
            this.lblTimeTest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInitTest = new System.Windows.Forms.Button();
            this.pnlTest = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Question3_op3 = new System.Windows.Forms.RadioButton();
            this.Question3_op2 = new System.Windows.Forms.RadioButton();
            this.Question3_op1 = new System.Windows.Forms.RadioButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Question2_op2 = new System.Windows.Forms.RadioButton();
            this.Question2_op3 = new System.Windows.Forms.RadioButton();
            this.Question2_op1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlQuestion1 = new System.Windows.Forms.Panel();
            this.Question1_op2 = new System.Windows.Forms.RadioButton();
            this.Question1_op3 = new System.Windows.Forms.RadioButton();
            this.Question1_op1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Question4_op1 = new System.Windows.Forms.RadioButton();
            this.Question4_op2 = new System.Windows.Forms.RadioButton();
            this.Question4_op3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Question5_op1 = new System.Windows.Forms.RadioButton();
            this.Question5_op2 = new System.Windows.Forms.RadioButton();
            this.pnlExercise2.SuspendLayout();
            this.pnlTest.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlQuestion1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlExercise2
            // 
            this.pnlExercise2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.pnlExercise2.Controls.Add(this.btnFinishTest);
            this.pnlExercise2.Controls.Add(this.lblTimeTest);
            this.pnlExercise2.Controls.Add(this.label2);
            this.pnlExercise2.Controls.Add(this.btnInitTest);
            this.pnlExercise2.Controls.Add(this.pnlTest);
            this.pnlExercise2.Controls.Add(this.label1);
            this.pnlExercise2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExercise2.Location = new System.Drawing.Point(0, 219);
            this.pnlExercise2.Name = "pnlExercise2";
            this.pnlExercise2.Size = new System.Drawing.Size(761, 872);
            this.pnlExercise2.TabIndex = 8;
            // 
            // btnFinishTest
            // 
            this.btnFinishTest.BackColor = System.Drawing.Color.White;
            this.btnFinishTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishTest.Location = new System.Drawing.Point(563, 62);
            this.btnFinishTest.Name = "btnFinishTest";
            this.btnFinishTest.Size = new System.Drawing.Size(138, 33);
            this.btnFinishTest.TabIndex = 5;
            this.btnFinishTest.Text = "Terminar Prueba";
            this.btnFinishTest.UseVisualStyleBackColor = false;
            this.btnFinishTest.Click += new System.EventHandler(this.btnFinishTest_Click);
            // 
            // lblTimeTest
            // 
            this.lblTimeTest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTimeTest.ForeColor = System.Drawing.Color.White;
            this.lblTimeTest.Location = new System.Drawing.Point(653, 31);
            this.lblTimeTest.Name = "lblTimeTest";
            this.lblTimeTest.Size = new System.Drawing.Size(48, 15);
            this.lblTimeTest.TabIndex = 4;
            this.lblTimeTest.Text = "2:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(560, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo Limite:";
            // 
            // btnInitTest
            // 
            this.btnInitTest.BackColor = System.Drawing.Color.White;
            this.btnInitTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitTest.Location = new System.Drawing.Point(56, 62);
            this.btnInitTest.Name = "btnInitTest";
            this.btnInitTest.Size = new System.Drawing.Size(138, 33);
            this.btnInitTest.TabIndex = 2;
            this.btnInitTest.Text = "Iniciar Prueba";
            this.btnInitTest.UseVisualStyleBackColor = false;
            this.btnInitTest.Click += new System.EventHandler(this.btnInitTest_Click);
            // 
            // pnlTest
            // 
            this.pnlTest.Controls.Add(this.panel4);
            this.pnlTest.Controls.Add(this.label7);
            this.pnlTest.Controls.Add(this.panel3);
            this.pnlTest.Controls.Add(this.label6);
            this.pnlTest.Controls.Add(this.panel2);
            this.pnlTest.Controls.Add(this.label5);
            this.pnlTest.Controls.Add(this.panel1);
            this.pnlTest.Controls.Add(this.label4);
            this.pnlTest.Controls.Add(this.pnlQuestion1);
            this.pnlTest.Controls.Add(this.label3);
            this.pnlTest.Location = new System.Drawing.Point(56, 109);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(645, 730);
            this.pnlTest.TabIndex = 1;
            this.pnlTest.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Question4_op3);
            this.panel3.Controls.Add(this.Question4_op2);
            this.panel3.Controls.Add(this.Question4_op1);
            this.panel3.Controls.Add(this.richTextBox3);
            this.panel3.Location = new System.Drawing.Point(24, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 190);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "4. El resultado del siguiente codigo que figura muestra como resultado:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Question3_op3);
            this.panel2.Controls.Add(this.Question3_op2);
            this.panel2.Controls.Add(this.Question3_op1);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Location = new System.Drawing.Point(24, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 100);
            this.panel2.TabIndex = 6;
            // 
            // Question3_op3
            // 
            this.Question3_op3.AutoSize = true;
            this.Question3_op3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question3_op3.ForeColor = System.Drawing.Color.White;
            this.Question3_op3.Location = new System.Drawing.Point(286, 63);
            this.Question3_op3.Name = "Question3_op3";
            this.Question3_op3.Size = new System.Drawing.Size(43, 19);
            this.Question3_op3.TabIndex = 8;
            this.Question3_op3.TabStop = true;
            this.Question3_op3.Text = "157";
            this.Question3_op3.UseVisualStyleBackColor = true;
            // 
            // Question3_op2
            // 
            this.Question3_op2.AutoSize = true;
            this.Question3_op2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question3_op2.ForeColor = System.Drawing.Color.White;
            this.Question3_op2.Location = new System.Drawing.Point(286, 38);
            this.Question3_op2.Name = "Question3_op2";
            this.Question3_op2.Size = new System.Drawing.Size(166, 19);
            this.Question3_op2.TabIndex = 7;
            this.Question3_op2.TabStop = true;
            this.Question3_op2.Text = "Error de tipo de operacion";
            this.Question3_op2.UseVisualStyleBackColor = true;
            // 
            // Question3_op1
            // 
            this.Question3_op1.AutoSize = true;
            this.Question3_op1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question3_op1.ForeColor = System.Drawing.Color.White;
            this.Question3_op1.Location = new System.Drawing.Point(286, 13);
            this.Question3_op1.Name = "Question3_op1";
            this.Question3_op1.Size = new System.Drawing.Size(58, 19);
            this.Question3_op1.TabIndex = 6;
            this.Question3_op1.TabStop = true;
            this.Question3_op1.Text = "157.55";
            this.Question3_op1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(17, 13);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(237, 69);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "\t\n\tdecimal num1 = 7.55M;\n\tdouble num2 = 150;\n\tvar result = num1 + num2;";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "3. El resultado de la siguiente operacion es:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Question2_op2);
            this.panel1.Controls.Add(this.Question2_op3);
            this.panel1.Controls.Add(this.Question2_op1);
            this.panel1.Location = new System.Drawing.Point(261, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 116);
            this.panel1.TabIndex = 3;
            // 
            // Question2_op2
            // 
            this.Question2_op2.AutoSize = true;
            this.Question2_op2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question2_op2.ForeColor = System.Drawing.Color.White;
            this.Question2_op2.Location = new System.Drawing.Point(23, 45);
            this.Question2_op2.Name = "Question2_op2";
            this.Question2_op2.Size = new System.Drawing.Size(97, 19);
            this.Question2_op2.TabIndex = 2;
            this.Question2_op2.TabStop = true;
            this.Question2_op2.Text = "De -128 a 127";
            this.Question2_op2.UseVisualStyleBackColor = true;
            // 
            // Question2_op3
            // 
            this.Question2_op3.AutoSize = true;
            this.Question2_op3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question2_op3.ForeColor = System.Drawing.Color.White;
            this.Question2_op3.Location = new System.Drawing.Point(23, 70);
            this.Question2_op3.Name = "Question2_op3";
            this.Question2_op3.Size = new System.Drawing.Size(80, 19);
            this.Question2_op3.TabIndex = 1;
            this.Question2_op3.TabStop = true;
            this.Question2_op3.Text = "De 0 a 255";
            this.Question2_op3.UseVisualStyleBackColor = true;
            // 
            // Question2_op1
            // 
            this.Question2_op1.AutoSize = true;
            this.Question2_op1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question2_op1.ForeColor = System.Drawing.Color.White;
            this.Question2_op1.Location = new System.Drawing.Point(23, 20);
            this.Question2_op1.Name = "Question2_op1";
            this.Question2_op1.Size = new System.Drawing.Size(199, 19);
            this.Question2_op1.TabIndex = 0;
            this.Question2_op1.TabStop = true;
            this.Question2_op1.Text = "De -2.147.483.648 a 2.147.483.647";
            this.Question2_op1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(258, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "2. El rango de valor de un tipo de dato byte es:";
            // 
            // pnlQuestion1
            // 
            this.pnlQuestion1.Controls.Add(this.Question1_op2);
            this.pnlQuestion1.Controls.Add(this.Question1_op3);
            this.pnlQuestion1.Controls.Add(this.Question1_op1);
            this.pnlQuestion1.Location = new System.Drawing.Point(24, 49);
            this.pnlQuestion1.Name = "pnlQuestion1";
            this.pnlQuestion1.Size = new System.Drawing.Size(148, 116);
            this.pnlQuestion1.TabIndex = 1;
            // 
            // Question1_op2
            // 
            this.Question1_op2.AutoSize = true;
            this.Question1_op2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question1_op2.ForeColor = System.Drawing.Color.White;
            this.Question1_op2.Location = new System.Drawing.Point(23, 45);
            this.Question1_op2.Name = "Question1_op2";
            this.Question1_op2.Size = new System.Drawing.Size(76, 19);
            this.Question1_op2.TabIndex = 2;
            this.Question1_op2.TabStop = true;
            this.Question1_op2.Text = "Complejo";
            this.Question1_op2.UseVisualStyleBackColor = true;
            // 
            // Question1_op3
            // 
            this.Question1_op3.AutoSize = true;
            this.Question1_op3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question1_op3.ForeColor = System.Drawing.Color.White;
            this.Question1_op3.Location = new System.Drawing.Point(23, 70);
            this.Question1_op3.Name = "Question1_op3";
            this.Question1_op3.Size = new System.Drawing.Size(76, 19);
            this.Question1_op3.TabIndex = 1;
            this.Question1_op3.TabStop = true;
            this.Question1_op3.Text = "Dinamico";
            this.Question1_op3.UseVisualStyleBackColor = true;
            // 
            // Question1_op1
            // 
            this.Question1_op1.AutoSize = true;
            this.Question1_op1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question1_op1.ForeColor = System.Drawing.Color.White;
            this.Question1_op1.Location = new System.Drawing.Point(23, 20);
            this.Question1_op1.Name = "Question1_op1";
            this.Question1_op1.Size = new System.Drawing.Size(60, 19);
            this.Question1_op1.TabIndex = 0;
            this.Question1_op1.TabStop = true;
            this.Question1_op1.Text = "Simple";
            this.Question1_op1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "1. String es un tipo de dato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prueba de Conocimiento";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(761, 137);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(761, 82);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Tema 2 Condicionales";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Location = new System.Drawing.Point(14, 10);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(240, 163);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // Question4_op1
            // 
            this.Question4_op1.AutoSize = true;
            this.Question4_op1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question4_op1.ForeColor = System.Drawing.Color.White;
            this.Question4_op1.Location = new System.Drawing.Point(286, 24);
            this.Question4_op1.Name = "Question4_op1";
            this.Question4_op1.Size = new System.Drawing.Size(65, 19);
            this.Question4_op1.TabIndex = 7;
            this.Question4_op1.TabStop = true;
            this.Question4_op1.Text = "Cuadro";
            this.Question4_op1.UseVisualStyleBackColor = true;
            // 
            // Question4_op2
            // 
            this.Question4_op2.AutoSize = true;
            this.Question4_op2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question4_op2.ForeColor = System.Drawing.Color.White;
            this.Question4_op2.Location = new System.Drawing.Point(286, 62);
            this.Question4_op2.Name = "Question4_op2";
            this.Question4_op2.Size = new System.Drawing.Size(75, 19);
            this.Question4_op2.TabIndex = 8;
            this.Question4_op2.TabStop = true;
            this.Question4_op2.Text = "Triangulo";
            this.Question4_op2.UseVisualStyleBackColor = true;
            // 
            // Question4_op3
            // 
            this.Question4_op3.AutoSize = true;
            this.Question4_op3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question4_op3.ForeColor = System.Drawing.Color.White;
            this.Question4_op3.Location = new System.Drawing.Point(286, 102);
            this.Question4_op3.Name = "Question4_op3";
            this.Question4_op3.Size = new System.Drawing.Size(54, 19);
            this.Question4_op3.TabIndex = 9;
            this.Question4_op3.TabStop = true;
            this.Question4_op3.Text = "Linea";
            this.Question4_op3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(398, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "5. la condicion Do While ejecuta su condigo  y luego valida la condicion";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Question5_op2);
            this.panel4.Controls.Add(this.Question5_op1);
            this.panel4.Location = new System.Drawing.Point(24, 609);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 10;
            // 
            // Question5_op1
            // 
            this.Question5_op1.AutoSize = true;
            this.Question5_op1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question5_op1.ForeColor = System.Drawing.Color.White;
            this.Question5_op1.Location = new System.Drawing.Point(17, 17);
            this.Question5_op1.Name = "Question5_op1";
            this.Question5_op1.Size = new System.Drawing.Size(83, 19);
            this.Question5_op1.TabIndex = 10;
            this.Question5_op1.TabStop = true;
            this.Question5_op1.Text = "Verdadero";
            this.Question5_op1.UseVisualStyleBackColor = true;
            // 
            // Question5_op2
            // 
            this.Question5_op2.AutoSize = true;
            this.Question5_op2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Question5_op2.ForeColor = System.Drawing.Color.White;
            this.Question5_op2.Location = new System.Drawing.Point(17, 55);
            this.Question5_op2.Name = "Question5_op2";
            this.Question5_op2.Size = new System.Drawing.Size(53, 19);
            this.Question5_op2.TabIndex = 11;
            this.Question5_op2.TabStop = true;
            this.Question5_op2.Text = "Falso";
            this.Question5_op2.UseVisualStyleBackColor = true;
            // 
            // frmConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(778, 824);
            this.Controls.Add(this.pnlExercise2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmConditions";
            this.Text = "frmConditions";
            this.pnlExercise2.ResumeLayout(false);
            this.pnlExercise2.PerformLayout();
            this.pnlTest.ResumeLayout(false);
            this.pnlTest.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlQuestion1.ResumeLayout(false);
            this.pnlQuestion1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlExercise2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInitTest;
        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.Label lblTimeTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlQuestion1;
        private System.Windows.Forms.RadioButton Question1_op2;
        private System.Windows.Forms.RadioButton Question1_op3;
        private System.Windows.Forms.RadioButton Question1_op1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFinishTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Question2_op2;
        private System.Windows.Forms.RadioButton Question2_op3;
        private System.Windows.Forms.RadioButton Question2_op1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Question3_op3;
        private System.Windows.Forms.RadioButton Question3_op2;
        private System.Windows.Forms.RadioButton Question3_op1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Question4_op3;
        private System.Windows.Forms.RadioButton Question4_op2;
        private System.Windows.Forms.RadioButton Question4_op1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton Question5_op2;
        private System.Windows.Forms.RadioButton Question5_op1;
    }
}