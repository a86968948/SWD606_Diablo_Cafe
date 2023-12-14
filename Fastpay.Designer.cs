namespace SWD606_Diablo_Cafe
{
    partial class Fastpay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Timelab = new System.Windows.Forms.Label();
            this.Costlab = new System.Windows.Forms.Label();
            this.PayBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 94);
            this.label1.TabIndex = 9;
            this.label1.Text = "     Thank you so much\r\nHappy to see you next time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "$ 2 / Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Time Count :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 33);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total Cost :";
            // 
            // Timelab
            // 
            this.Timelab.AutoSize = true;
            this.Timelab.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelab.Location = new System.Drawing.Point(319, 278);
            this.Timelab.Name = "Timelab";
            this.Timelab.Size = new System.Drawing.Size(62, 33);
            this.Timelab.TabIndex = 23;
            this.Timelab.Text = "Time";
            // 
            // Costlab
            // 
            this.Costlab.AutoSize = true;
            this.Costlab.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costlab.Location = new System.Drawing.Point(319, 327);
            this.Costlab.Name = "Costlab";
            this.Costlab.Size = new System.Drawing.Size(56, 33);
            this.Costlab.TabIndex = 24;
            this.Costlab.Text = "Cost";
            // 
            // PayBt
            // 
            this.PayBt.Location = new System.Drawing.Point(209, 402);
            this.PayBt.Name = "PayBt";
            this.PayBt.Size = new System.Drawing.Size(138, 48);
            this.PayBt.TabIndex = 25;
            this.PayBt.Text = "Pay Now";
            this.PayBt.UseVisualStyleBackColor = true;
            this.PayBt.Click += new System.EventHandler(this.PayBt_Click);
            // 
            // Fastpay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 492);
            this.Controls.Add(this.PayBt);
            this.Controls.Add(this.Costlab);
            this.Controls.Add(this.Timelab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Fastpay";
            this.Text = "Fastpay";
            this.Load += new System.EventHandler(this.Fastpay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Timelab;
        private System.Windows.Forms.Label Costlab;
        private System.Windows.Forms.Button PayBt;
    }
}