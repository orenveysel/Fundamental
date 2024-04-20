namespace _23_VeriGirisEkrani
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            maasUpDown = new NumericUpDown();
            label8 = new Label();
            cmbDepartman = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            dogumTarihiPicker = new DateTimePicker();
            label6 = new Label();
            cmbSehir = new ComboBox();
            label5 = new Label();
            rdbErkek = new RadioButton();
            rdbKadin = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            txtGsm = new TextBox();
            txtSoyad = new TextBox();
            label1 = new Label();
            txtAd = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maasUpDown).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(maasUpDown);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbDepartman);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dogumTarihiPicker);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbSehir);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rdbErkek);
            groupBox1.Controls.Add(rdbKadin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGsm);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayit";
            // 
            // button1
            // 
            button1.Location = new Point(117, 315);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maasUpDown
            // 
            maasUpDown.Location = new Point(117, 259);
            maasUpDown.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            maasUpDown.Name = "maasUpDown";
            maasUpDown.Size = new Size(120, 23);
            maasUpDown.TabIndex = 14;
            maasUpDown.Value = new decimal(new int[] { 17002, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 261);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 13;
            label8.Text = "Maas";
            // 
            // cmbDepartman
            // 
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Items.AddRange(new object[] { "Finans", "Pazarlama", "IT", "Insan Kaynaklari" });
            cmbDepartman.Location = new Point(117, 220);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(121, 23);
            cmbDepartman.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 223);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 11;
            label7.Text = "Departman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // dogumTarihiPicker
            // 
            dogumTarihiPicker.Location = new Point(117, 184);
            dogumTarihiPicker.Name = "dogumTarihiPicker";
            dogumTarihiPicker.Size = new Size(200, 23);
            dogumTarihiPicker.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 190);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 9;
            label6.Text = "Dogum Tarihi";
            // 
            // cmbSehir
            // 
            cmbSehir.FormattingEnabled = true;
            cmbSehir.Items.AddRange(new object[] { "Ankara", "Izmir", "Istanbul", "Bursa" });
            cmbSehir.Location = new Point(117, 150);
            cmbSehir.Name = "cmbSehir";
            cmbSehir.Size = new Size(121, 23);
            cmbSehir.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 153);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 7;
            label5.Text = "Sehir";
            // 
            // rdbErkek
            // 
            rdbErkek.AutoSize = true;
            rdbErkek.Location = new Point(190, 121);
            rdbErkek.Name = "rdbErkek";
            rdbErkek.Size = new Size(53, 19);
            rdbErkek.TabIndex = 6;
            rdbErkek.TabStop = true;
            rdbErkek.Text = "Erkek";
            rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadin
            // 
            rdbKadin.AutoSize = true;
            rdbKadin.Location = new Point(117, 121);
            rdbKadin.Name = "rdbKadin";
            rdbKadin.Size = new Size(55, 19);
            rdbKadin.TabIndex = 1;
            rdbKadin.TabStop = true;
            rdbKadin.Text = "Kadin";
            rdbKadin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 123);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 89);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Gsm:";
            // 
            // txtGsm
            // 
            txtGsm.Location = new Point(117, 86);
            txtGsm.Name = "txtGsm";
            txtGsm.Size = new Size(159, 23);
            txtGsm.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(117, 57);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(159, 23);
            txtSoyad.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(117, 28);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(159, 23);
            txtAd.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maasUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAd;
        private Label label1;
        private Label label4;
        private TextBox txtGsm;
        private TextBox txtSoyad;
        private ComboBox cmbSehir;
        private Label label5;
        private RadioButton rdbErkek;
        private RadioButton rdbKadin;
        private Label label3;
        private DateTimePicker dogumTarihiPicker;
        private Label label6;
        private ComboBox cmbDepartman;
        private Label label7;
        private Label label2;
        private NumericUpDown maasUpDown;
        private Label label8;
        private Button button1;
    }
}
