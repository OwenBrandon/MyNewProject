namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.badi = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.bcan = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(30, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(403, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n1.Location = new System.Drawing.Point(40, 112);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(75, 53);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n2.Location = new System.Drawing.Point(143, 112);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(75, 53);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n3.Location = new System.Drawing.Point(247, 112);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(75, 53);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n4.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n4.Location = new System.Drawing.Point(40, 196);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(75, 53);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n5.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n5.Location = new System.Drawing.Point(148, 203);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(75, 46);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n6.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n6.Location = new System.Drawing.Point(247, 202);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(75, 47);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n7.Location = new System.Drawing.Point(40, 270);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(75, 53);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n8.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n8.Location = new System.Drawing.Point(148, 270);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(75, 53);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n9.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n9.Location = new System.Drawing.Point(247, 270);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(75, 53);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n0.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n0.Location = new System.Drawing.Point(148, 352);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(75, 50);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // badi
            // 
            this.badi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.badi.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.badi.Location = new System.Drawing.Point(356, 112);
            this.badi.Name = "badi";
            this.badi.Size = new System.Drawing.Size(75, 53);
            this.badi.TabIndex = 11;
            this.badi.Text = "+";
            this.badi.UseVisualStyleBackColor = false;
            this.badi.Click += new System.EventHandler(this.badi_Click);
            // 
            // bsub
            // 
            this.bsub.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bsub.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bsub.Location = new System.Drawing.Point(358, 203);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(75, 46);
            this.bsub.TabIndex = 12;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = false;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bmul
            // 
            this.bmul.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bmul.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bmul.Location = new System.Drawing.Point(356, 268);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(75, 55);
            this.bmul.TabIndex = 13;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = false;
            this.bmul.Click += new System.EventHandler(this.bmul_Click);
            // 
            // bdot
            // 
            this.bdot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bdot.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bdot.Location = new System.Drawing.Point(40, 352);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(75, 50);
            this.bdot.TabIndex = 14;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = false;
            this.bdot.Click += new System.EventHandler(this.bdot_Click);
            // 
            // bcan
            // 
            this.bcan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bcan.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bcan.Location = new System.Drawing.Point(247, 352);
            this.bcan.Name = "bcan";
            this.bcan.Size = new System.Drawing.Size(75, 50);
            this.bcan.TabIndex = 15;
            this.bcan.Text = "C";
            this.bcan.UseVisualStyleBackColor = false;
            this.bcan.Click += new System.EventHandler(this.bcan_Click);
            // 
            // bdiv
            // 
            this.bdiv.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bdiv.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bdiv.Location = new System.Drawing.Point(358, 352);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(75, 50);
            this.bdiv.TabIndex = 16;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bequal
            // 
            this.bequal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bequal.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bequal.Location = new System.Drawing.Point(201, 417);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(75, 38);
            this.bequal.TabIndex = 17;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = false;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Font = new System.Drawing.Font("News706 BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(467, 37);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "Created By Brandon Bruk";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(357, 32);
            this.toolStripStatusLabel1.Text = "Created By Brandon Bruk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 515);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bcan);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.badi);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button badi;
        private Button bsub;
        private Button bmul;
        private Button bdot;
        private Button bcan;
        private Button bdiv;
        private Button bequal;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}