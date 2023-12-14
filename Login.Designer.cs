namespace SWD606_Diablo_Cafe
{
    partial class Login
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
            this.Registerbt = new System.Windows.Forms.Button();
            this.Loginbt = new System.Windows.Forms.Button();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Logintxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registerbt
            // 
            this.Registerbt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbt.Location = new System.Drawing.Point(442, 329);
            this.Registerbt.Name = "Registerbt";
            this.Registerbt.Size = new System.Drawing.Size(120, 39);
            this.Registerbt.TabIndex = 13;
            this.Registerbt.Text = "Register";
            this.Registerbt.UseVisualStyleBackColor = true;
            this.Registerbt.Click += new System.EventHandler(this.Registerbt_Click);
            // 
            // Loginbt
            // 
            this.Loginbt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbt.Location = new System.Drawing.Point(221, 329);
            this.Loginbt.Name = "Loginbt";
            this.Loginbt.Size = new System.Drawing.Size(120, 39);
            this.Loginbt.TabIndex = 12;
            this.Loginbt.Text = "Login";
            this.Loginbt.UseVisualStyleBackColor = true;
            this.Loginbt.Click += new System.EventHandler(this.Loginbt_Click_1);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("DengXian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(368, 240);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(176, 24);
            this.Passwordtxt.TabIndex = 11;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // Logintxt
            // 
            this.Logintxt.Font = new System.Drawing.Font("DengXian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Logintxt.Location = new System.Drawing.Point(368, 199);
            this.Logintxt.Name = "Logintxt";
            this.Logintxt.Size = new System.Drawing.Size(176, 24);
            this.Logintxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "PassWord : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "UserName : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wellcome to Bella Vista Internet Cafe";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registerbt);
            this.Controls.Add(this.Loginbt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Logintxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registerbt;
        private System.Windows.Forms.Button Loginbt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox Logintxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}