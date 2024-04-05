namespace _6_Try_Catch
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
            Onaylama = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Onaylama
            // 
            Onaylama.Location = new Point(153, 214);
            Onaylama.Name = "Onaylama";
            Onaylama.Size = new Size(188, 58);
            Onaylama.TabIndex = 0;
            Onaylama.Text = "Buton";
            Onaylama.UseVisualStyleBackColor = true;
            Onaylama.Click += Onaylama_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 47);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Onaylama);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Onaylama;
        private TextBox textBox1;
    }
}
