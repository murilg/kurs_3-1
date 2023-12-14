namespace TestApp
{
    partial class step7
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
            groupBox7 = new GroupBox();
            groupBox6 = new GroupBox();
            textBox4 = new TextBox();
            groupBox5 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox4 = new GroupBox();
            textBox3 = new TextBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(maskedTextBox1);
            groupBox7.Location = new Point(386, 237);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(250, 57);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "Номер телефона";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox4);
            groupBox6.Location = new Point(395, 159);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(241, 63);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Адрес";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(235, 27);
            textBox4.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dateTimePicker1);
            groupBox5.Location = new Point(386, 79);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 61);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox3);
            groupBox4.Location = new Point(33, 277);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(241, 63);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Отчество";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(58, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(33, 185);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(241, 63);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Имя";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(58, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(33, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 63);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фамилия";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(689, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Далее";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(589, 400);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(9, 25);
            maskedTextBox1.Mask = "0000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(235, 27);
            maskedTextBox1.TabIndex = 0;
            // 
            // step7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox7);
            Controls.Add(button1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Name = "step7";
            Text = "step7";
            Load += step7_Load;
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox4;
        private TextBox textBox3;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private TextBox textBox4;
        private GroupBox groupBox5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
    }
}