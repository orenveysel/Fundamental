namespace _4_ifAtYarisi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.at1 = new System.Windows.Forms.PictureBox();
            this.at2 = new System.Windows.Forms.PictureBox();
            this.at3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.at1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.at2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.at3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.AutoEllipsis = true;
            this.lblDurum.BackColor = System.Drawing.Color.Olive;
            this.lblDurum.Location = new System.Drawing.Point(5, 9);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(1095, 57);
            this.lblDurum.TabIndex = 0;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.OliveDrab;
            this.lblFinish.Location = new System.Drawing.Point(1086, 86);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(10, 729);
            this.lblFinish.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(5, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1075, 20);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(5, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1075, 19);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(5, 654);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1075, 31);
            this.label4.TabIndex = 4;
            // 
            // at1
            // 
            this.at1.Image = ((System.Drawing.Image)(resources.GetObject("at1.Image")));
            this.at1.Location = new System.Drawing.Point(9, 86);
            this.at1.Name = "at1";
            this.at1.Size = new System.Drawing.Size(170, 137);
            this.at1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at1.TabIndex = 5;
            this.at1.TabStop = false;
            // 
            // at2
            // 
            this.at2.Image = ((System.Drawing.Image)(resources.GetObject("at2.Image")));
            this.at2.Location = new System.Drawing.Point(9, 283);
            this.at2.Name = "at2";
            this.at2.Size = new System.Drawing.Size(170, 137);
            this.at2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at2.TabIndex = 6;
            this.at2.TabStop = false;
            // 
            // at3
            // 
            this.at3.Image = ((System.Drawing.Image)(resources.GetObject("at3.Image")));
            this.at3.Location = new System.Drawing.Point(9, 494);
            this.at3.Name = "at3";
            this.at3.Size = new System.Drawing.Size(170, 137);
            this.at3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at3.TabIndex = 7;
            this.at3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Yarışı Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 690);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Yarışı Sıfırla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1103, 788);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.at3);
            this.Controls.Add(this.at2);
            this.Controls.Add(this.at1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblDurum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.at1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.at2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.at3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox at1;
        private System.Windows.Forms.PictureBox at2;
        private System.Windows.Forms.PictureBox at3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

