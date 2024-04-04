namespace _5_IfElseLab
{
    partial class SayiTahmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.deneme = new System.Windows.Forms.TextBox();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kontrol Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deneme
            // 
            this.deneme.Location = new System.Drawing.Point(290, 106);
            this.deneme.Name = "deneme";
            this.deneme.Size = new System.Drawing.Size(203, 38);
            this.deneme.TabIndex = 1;
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Location = new System.Drawing.Point(235, 170);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(297, 32);
            this.lblTahmin.TabIndex = 2;
            this.lblTahmin.Text = "5 deneme hakkiniz var";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(235, 58);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(38, 32);
            this.lblMesaj.TabIndex = 3;
            this.lblMesaj.Text = "...";
            // 
            // SayiTahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 489);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.deneme);
            this.Controls.Add(this.button1);
            this.Name = "SayiTahmin";
            this.Text = "SayiTahmin";
            this.Load += new System.EventHandler(this.SayiTahmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox deneme;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.Label lblMesaj;
    }
}