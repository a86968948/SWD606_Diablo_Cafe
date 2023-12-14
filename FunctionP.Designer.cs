namespace SWD606_Diablo_Cafe
{
    partial class FunctionP
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
            this.Print = new System.Windows.Forms.Button();
            this.DownLoad = new System.Windows.Forms.Button();
            this.UpLoad = new System.Windows.Forms.Button();
            this.InterSur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(424, 203);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(156, 50);
            this.Print.TabIndex = 21;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // DownLoad
            // 
            this.DownLoad.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownLoad.Location = new System.Drawing.Point(186, 313);
            this.DownLoad.Name = "DownLoad";
            this.DownLoad.Size = new System.Drawing.Size(156, 50);
            this.DownLoad.TabIndex = 20;
            this.DownLoad.Text = "DownLoad";
            this.DownLoad.UseVisualStyleBackColor = true;
            this.DownLoad.Click += new System.EventHandler(this.DownLoad_Click);
            // 
            // UpLoad
            // 
            this.UpLoad.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpLoad.Location = new System.Drawing.Point(424, 313);
            this.UpLoad.Name = "UpLoad";
            this.UpLoad.Size = new System.Drawing.Size(156, 50);
            this.UpLoad.TabIndex = 19;
            this.UpLoad.Text = "Upload";
            this.UpLoad.UseVisualStyleBackColor = true;
            this.UpLoad.Click += new System.EventHandler(this.UpLoad_Click);
            // 
            // InterSur
            // 
            this.InterSur.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterSur.Location = new System.Drawing.Point(186, 203);
            this.InterSur.Name = "InterSur";
            this.InterSur.Size = new System.Drawing.Size(156, 50);
            this.InterSur.TabIndex = 18;
            this.InterSur.Text = "Internet Surfing";
            this.InterSur.UseVisualStyleBackColor = true;
            this.InterSur.Click += new System.EventHandler(this.InterSur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 47);
            this.label1.TabIndex = 17;
            this.label1.Text = "Wellcome to Bella Vista Internet Cafe";
            // 
            // FunctionP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.DownLoad);
            this.Controls.Add(this.UpLoad);
            this.Controls.Add(this.InterSur);
            this.Controls.Add(this.label1);
            this.Name = "FunctionP";
            this.Text = "FunctionP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button DownLoad;
        private System.Windows.Forms.Button UpLoad;
        private System.Windows.Forms.Button InterSur;
        private System.Windows.Forms.Label label1;
    }
}