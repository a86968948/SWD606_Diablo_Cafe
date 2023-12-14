namespace SWD606_Diablo_Cafe
{
    partial class Print
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
            this.Location2Bt = new System.Windows.Forms.Button();
            this.Pathtxt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BnWBt = new System.Windows.Forms.RadioButton();
            this.FullCBt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pagetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DoubleBt = new System.Windows.Forms.RadioButton();
            this.SingleBt = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PrintBt = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.MoneyShow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Location2Bt
            // 
            this.Location2Bt.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location2Bt.Location = new System.Drawing.Point(637, 125);
            this.Location2Bt.Name = "Location2Bt";
            this.Location2Bt.Size = new System.Drawing.Size(141, 45);
            this.Location2Bt.TabIndex = 24;
            this.Location2Bt.Text = "Location";
            this.Location2Bt.UseVisualStyleBackColor = true;
            this.Location2Bt.Click += new System.EventHandler(this.Location2Bt_Click);
            // 
            // Pathtxt2
            // 
            this.Pathtxt2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pathtxt2.Location = new System.Drawing.Point(30, 125);
            this.Pathtxt2.Name = "Pathtxt2";
            this.Pathtxt2.ReadOnly = true;
            this.Pathtxt2.Size = new System.Drawing.Size(580, 41);
            this.Pathtxt2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select the file you want to Print : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 43);
            this.label3.TabIndex = 25;
            this.label3.Text = "Printer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Color :";
            // 
            // BnWBt
            // 
            this.BnWBt.AutoSize = true;
            this.BnWBt.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BnWBt.Location = new System.Drawing.Point(16, 15);
            this.BnWBt.Name = "BnWBt";
            this.BnWBt.Size = new System.Drawing.Size(160, 25);
            this.BnWBt.TabIndex = 27;
            this.BnWBt.TabStop = true;
            this.BnWBt.Text = "Black White";
            this.BnWBt.UseVisualStyleBackColor = true;
            this.BnWBt.Click += new System.EventHandler(this.BnWBt_Click);
            // 
            // FullCBt
            // 
            this.FullCBt.AutoSize = true;
            this.FullCBt.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FullCBt.Location = new System.Drawing.Point(16, 46);
            this.FullCBt.Name = "FullCBt";
            this.FullCBt.Size = new System.Drawing.Size(148, 25);
            this.FullCBt.TabIndex = 28;
            this.FullCBt.TabStop = true;
            this.FullCBt.Text = "Full Color";
            this.FullCBt.UseVisualStyleBackColor = true;
            this.FullCBt.Click += new System.EventHandler(this.FullCBt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FullCBt);
            this.groupBox1.Controls.Add(this.BnWBt);
            this.groupBox1.Location = new System.Drawing.Point(46, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 88);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "Page :";
            // 
            // Pagetxt
            // 
            this.Pagetxt.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pagetxt.Location = new System.Drawing.Point(131, 325);
            this.Pagetxt.Name = "Pagetxt";
            this.Pagetxt.Size = new System.Drawing.Size(102, 29);
            this.Pagetxt.TabIndex = 31;
            this.Pagetxt.Text = "0";
            this.Pagetxt.TextChanged += new System.EventHandler(this.Pagetxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "Side :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DoubleBt);
            this.groupBox2.Controls.Add(this.SingleBt);
            this.groupBox2.Location = new System.Drawing.Point(423, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 88);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // DoubleBt
            // 
            this.DoubleBt.AutoSize = true;
            this.DoubleBt.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoubleBt.Location = new System.Drawing.Point(16, 46);
            this.DoubleBt.Name = "DoubleBt";
            this.DoubleBt.Size = new System.Drawing.Size(160, 25);
            this.DoubleBt.TabIndex = 28;
            this.DoubleBt.TabStop = true;
            this.DoubleBt.Text = "Double side";
            this.DoubleBt.UseVisualStyleBackColor = true;
            this.DoubleBt.Click += new System.EventHandler(this.DoubleBt_Click);
            // 
            // SingleBt
            // 
            this.SingleBt.AutoSize = true;
            this.SingleBt.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SingleBt.Location = new System.Drawing.Point(16, 15);
            this.SingleBt.Name = "SingleBt";
            this.SingleBt.Size = new System.Drawing.Size(160, 25);
            this.SingleBt.TabIndex = 27;
            this.SingleBt.TabStop = true;
            this.SingleBt.Text = "Single side";
            this.SingleBt.UseVisualStyleBackColor = true;
            this.SingleBt.Click += new System.EventHandler(this.SingleBt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 33);
            this.label6.TabIndex = 33;
            this.label6.Text = "$ 0.5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 33);
            this.label7.TabIndex = 34;
            this.label7.Text = "$  1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(616, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 33);
            this.label8.TabIndex = 35;
            this.label8.Text = "Free";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(616, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 33);
            this.label9.TabIndex = 36;
            this.label9.Text = "$ 0.5";
            // 
            // PrintBt
            // 
            this.PrintBt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBt.Location = new System.Drawing.Point(212, 382);
            this.PrintBt.Name = "PrintBt";
            this.PrintBt.Size = new System.Drawing.Size(120, 39);
            this.PrintBt.TabIndex = 37;
            this.PrintBt.Text = "Print";
            this.PrintBt.UseVisualStyleBackColor = true;
            this.PrintBt.Click += new System.EventHandler(this.PrintBt_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(423, 382);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 39);
            this.Back.TabIndex = 38;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(427, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 33);
            this.label10.TabIndex = 39;
            this.label10.Text = "Cost :";
            // 
            // MoneyShow
            // 
            this.MoneyShow.AutoSize = true;
            this.MoneyShow.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyShow.Location = new System.Drawing.Point(503, 325);
            this.MoneyShow.Name = "MoneyShow";
            this.MoneyShow.Size = new System.Drawing.Size(79, 33);
            this.MoneyShow.TabIndex = 40;
            this.MoneyShow.Text = "money";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoneyShow);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.PrintBt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pagetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Location2Bt);
            this.Controls.Add(this.Pathtxt2);
            this.Controls.Add(this.label1);
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Location2Bt;
        private System.Windows.Forms.TextBox Pathtxt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton BnWBt;
        private System.Windows.Forms.RadioButton FullCBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pagetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton DoubleBt;
        private System.Windows.Forms.RadioButton SingleBt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button PrintBt;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label MoneyShow;
    }
}