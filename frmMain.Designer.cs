namespace Unidad_2_Paso_2
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBasicOperations = new System.Windows.Forms.Button();
            this.btnConditions = new System.Windows.Forms.Button();
            this.btnCycles = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPrimary = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnCycles);
            this.pnlMenu.Controls.Add(this.btnConditions);
            this.pnlMenu.Controls.Add(this.btnBasicOperations);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(241, 562);
            this.pnlMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnBasicOperations
            // 
            this.btnBasicOperations.BackColor = System.Drawing.Color.Transparent;
            this.btnBasicOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBasicOperations.FlatAppearance.BorderSize = 0;
            this.btnBasicOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasicOperations.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasicOperations.ForeColor = System.Drawing.Color.Black;
            this.btnBasicOperations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasicOperations.Location = new System.Drawing.Point(0, 100);
            this.btnBasicOperations.Name = "btnBasicOperations";
            this.btnBasicOperations.Size = new System.Drawing.Size(241, 56);
            this.btnBasicOperations.TabIndex = 1;
            this.btnBasicOperations.Text = "Operaciones básicas de programación";
            this.btnBasicOperations.UseVisualStyleBackColor = false;
            this.btnBasicOperations.Click += new System.EventHandler(this.btnBasicOperations_Click);
            // 
            // btnConditions
            // 
            this.btnConditions.BackColor = System.Drawing.Color.Transparent;
            this.btnConditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConditions.FlatAppearance.BorderSize = 0;
            this.btnConditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConditions.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConditions.ForeColor = System.Drawing.Color.Black;
            this.btnConditions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConditions.Location = new System.Drawing.Point(0, 156);
            this.btnConditions.Name = "btnConditions";
            this.btnConditions.Size = new System.Drawing.Size(241, 54);
            this.btnConditions.TabIndex = 2;
            this.btnConditions.Text = "Condicionales";
            this.btnConditions.UseVisualStyleBackColor = false;
            this.btnConditions.Click += new System.EventHandler(this.btnConditions_Click);
            // 
            // btnCycles
            // 
            this.btnCycles.BackColor = System.Drawing.Color.Transparent;
            this.btnCycles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCycles.FlatAppearance.BorderSize = 0;
            this.btnCycles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCycles.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCycles.ForeColor = System.Drawing.Color.Black;
            this.btnCycles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCycles.Location = new System.Drawing.Point(0, 210);
            this.btnCycles.Name = "btnCycles";
            this.btnCycles.Size = new System.Drawing.Size(241, 55);
            this.btnCycles.TabIndex = 3;
            this.btnCycles.Text = "Ciclos de programación";
            this.btnCycles.UseVisualStyleBackColor = false;
            this.btnCycles.Click += new System.EventHandler(this.btnCycles_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(241, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Unidad_2_Paso_2.Properties.Resources.unad_log;
            this.pictureBox1.Location = new System.Drawing.Point(7, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPrimary
            // 
            this.pnlPrimary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrimary.Location = new System.Drawing.Point(241, 0);
            this.pnlPrimary.Name = "pnlPrimary";
            this.pnlPrimary.Size = new System.Drawing.Size(750, 562);
            this.pnlPrimary.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(991, 562);
            this.Controls.Add(this.pnlPrimary);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCycles;
        private System.Windows.Forms.Button btnConditions;
        private System.Windows.Forms.Button btnBasicOperations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlPrimary;
    }
}

