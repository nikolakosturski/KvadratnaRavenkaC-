namespace WinFormsApp3
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox7 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(30, 73);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(71, 22);
            textBox1.TabIndex = 0;
            textBox1.Text = "Коефицент";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(141, 73);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(69, 22);
            textBox2.TabIndex = 1;
            textBox2.Text = "Коефицент";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(237, 74);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(71, 22);
            textBox3.TabIndex = 2;
            textBox3.Text = "Коефицент";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 160);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 22);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(81, 130);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 22);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(216, 130);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(83, 22);
            textBox6.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(402, 101);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 6;
            button1.Text = "Реши";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(402, 134);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 7;
            button2.Text = "Избриши";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(216, 163);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(83, 22);
            textBox7.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 77);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "X^2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 77);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 10;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 77);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 11;
            label3.Text = "= 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 134);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 12;
            label4.Text = "X1 =";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 163);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 13;
            label5.Text = "X2 =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 134);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 14;
            label6.Text = "* i";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 167);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 15;
            label7.Text = "* i";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 20);
            label8.Name = "label8";
            label8.Size = new Size(432, 30);
            label8.TabIndex = 16;
            label8.Text = "Внесете само целобројни коефиценти меѓу (-999 и 999) и притиснете\r\n на копчето подолу за да биде решена квадратната равенка";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 107);
            label9.Name = "label9";
            label9.Size = new Size(193, 15);
            label9.TabIndex = 17;
            label9.Text = "Корени / решенија на равенка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(497, 210);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe MDL2 Assets", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Квадратна Равенка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}