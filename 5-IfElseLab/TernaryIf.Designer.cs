namespace _5_IfElseLab
{
    partial class TernaryIf
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
            this.lblRastgeleKarakterler = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblKalanHakkimiz = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kontrol Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRastgeleKarakterler
            // 
            this.lblRastgeleKarakterler.AutoSize = true;
            this.lblRastgeleKarakterler.Location = new System.Drawing.Point(534, 128);
            this.lblRastgeleKarakterler.Name = "lblRastgeleKarakterler";
            this.lblRastgeleKarakterler.Size = new System.Drawing.Size(38, 32);
            this.lblRastgeleKarakterler.TabIndex = 2;
            this.lblRastgeleKarakterler.Text = "...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 38);
            this.textBox1.TabIndex = 3;
            // 
            // lblKalanHakkimiz
            // 
            this.lblKalanHakkimiz.AutoSize = true;
            this.lblKalanHakkimiz.Location = new System.Drawing.Point(466, 289);
            this.lblKalanHakkimiz.Name = "lblKalanHakkimiz";
            this.lblKalanHakkimiz.Size = new System.Drawing.Size(310, 32);
            this.lblKalanHakkimiz.TabIndex = 4;
            this.lblKalanHakkimiz.Text = "5 Deneme Hakkiniz Var";
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(213, 44);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(918, 32);
            this.lblBilgi.TabIndex = 5;
            this.lblBilgi.Text = "Lutfen asagida gormus oldugunuz karakterleri TextBox icerisine yaziniz.";
            // 
            // TernaryIf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 698);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.lblKalanHakkimiz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRastgeleKarakterler);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TernaryIf";
            this.Text = "TernaryIf";
            this.Load += new System.EventHandler(this.TernaryIf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRastgeleKarakterler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblKalanHakkimiz;
        private System.Windows.Forms.Label lblBilgi;
    }
}