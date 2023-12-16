namespace TestApp
{
    partial class step6
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox7 = new GroupBox();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            textBox3 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox8 = new GroupBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(63, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 294);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Транспортное средство «А»";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox7);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(16, 127);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(265, 149);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Может ли ТС передвигаться своим ходом?";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBox2);
            groupBox7.ForeColor = Color.Gray;
            groupBox7.Location = new Point(6, 78);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(245, 58);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "Местонахождение ТС";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(0, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(72, 48);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 24);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Нет";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(18, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Да";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(16, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(251, 95);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Перечень видимых повреждений";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(691, 390);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Далее";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(591, 390);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Location = new Point(403, 59);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(298, 294);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Транспортное средство «В»";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Controls.Add(radioButton3);
            groupBox5.Controls.Add(radioButton4);
            groupBox5.Location = new Point(16, 127);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(265, 149);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Может ли ТС передвигаться своим ходом?";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox3);
            groupBox6.ForeColor = Color.Gray;
            groupBox6.Location = new Point(6, 78);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(245, 58);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Местонахождение ТС";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(0, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 1;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(72, 48);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 24);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "Нет";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(18, 48);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(48, 24);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "Да";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBox4);
            groupBox8.Location = new Point(16, 26);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(251, 95);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Перечень видимых повреждений";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(0, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(251, 27);
            textBox4.TabIndex = 0;
            // 
            // step6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "step6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о ТС";
            Load += step6_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private GroupBox groupBox7;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TextBox textBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox8;
        private TextBox textBox4;
    }
}