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
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox3 = new TextBox();
            groupBox6 = new GroupBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(63, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Транспортное средство «А»";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(16, 139);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 116);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Может ли ТС передвигаться своим ходом?";
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
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(0, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 27);
            textBox2.TabIndex = 1;
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
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Location = new Point(419, 59);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(281, 268);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Транспортное средство «В»";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(radioButton3);
            groupBox5.Controls.Add(radioButton4);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Location = new Point(16, 139);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(251, 110);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Может ли ТС передвигаться своим ходом?";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(69, 45);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 24);
            radioButton3.TabIndex = 5;
            radioButton3.Text = "Нет";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(15, 45);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(48, 24);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Да";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(0, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 27);
            textBox3.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox4);
            groupBox6.Location = new Point(16, 26);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(251, 87);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Перечень видимых повреждений";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(0, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(251, 27);
            textBox4.TabIndex = 0;
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
            // step6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Name = "step6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о ТС";
            Load += step6_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBox3;
        private GroupBox groupBox6;
        private TextBox textBox4;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button2;
    }
}