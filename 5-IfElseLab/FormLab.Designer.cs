namespace _5_IfElseLab
{
    partial class FormLab
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
            this.girdi = new System.Windows.Forms.TextBox();
            this.kontrol = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girdi
            // 
            this.girdi.Location = new System.Drawing.Point(387, 66);
            this.girdi.Name = "girdi";
            this.girdi.Size = new System.Drawing.Size(192, 38);
            this.girdi.TabIndex = 0;
            // 
            // kontrol
            // 
            this.kontrol.Location = new System.Drawing.Point(658, 59);
            this.kontrol.Name = "kontrol";
            this.kontrol.Size = new System.Drawing.Size(195, 52);
            this.kontrol.TabIndex = 1;
            this.kontrol.Text = "Kontrol Et";
            this.kontrol.UseVisualStyleBackColor = true;
            this.kontrol.Click += new System.EventHandler(this.kontrol_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(40, 148);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(38, 32);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "0-24 arasi bir sayi giriniz:";
            // 
            // FormLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.kontrol);
            this.Controls.Add(this.girdi);
            this.Name = "FormLab";
            this.Text = "FormLab";
            this.Load += new System.EventHandler(this.FormLab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox girdi;
        private System.Windows.Forms.Button kontrol;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label label1;
    }
}