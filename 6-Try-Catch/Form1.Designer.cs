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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 47);
            textBox1.TabIndex = 1;
            //
            // button1
            // 
            button1.Location = new Point(274, 167);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 0;
            button1.Text = "Onayla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;            
            // 
            // button2
            // 
            button2.Location = new Point(251, 256);
            button2.Name = "button2";
            button2.Size = new Size(406, 58);
            button2.TabIndex = 2;
            button2.Text = "Hata Yonetimiyle Onayla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(297, 349);
            button3.Name = "button3";
            button3.Size = new Size(188, 58);
            button3.TabIndex = 3;
            button3.Text = "Coklu Catch Kullanimi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(297, 441);
            button4.Name = "button4";
            button4.Size = new Size(188, 58);
            button4.TabIndex = 4;
            button4.Text = "Coklu Catch Kullanimi 2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(286, 536);
            button5.Name = "button5";
            button5.Size = new Size(188, 58);
            button5.TabIndex = 5;
            button5.Text = "Hata Firlatma";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(274, 640);
            button6.Name = "button6";
            button6.Size = new Size(188, 58);
            button6.TabIndex = 6;
            button6.Text = "Finnaly";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 982);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1); 
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;        
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
