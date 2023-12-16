namespace TestApp
{
    partial class step5
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
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox7 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(6, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 60);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Город";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(6, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 60);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Улица";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(6, 158);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 60);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Дом";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(685, 403);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Далее";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(6, 26);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(89, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(69, 90);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(20);
            groupBox4.Size = new Size(314, 196);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Дата и время ДТП";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dateTimePicker2);
            groupBox6.Location = new Point(23, 114);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(263, 60);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Укажите примерное время ДТП";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dateTimePicker1);
            groupBox5.Location = new Point(23, 31);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(263, 66);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Укажите дату ДТП";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(groupBox1);
            groupBox7.Controls.Add(groupBox2);
            groupBox7.Controls.Add(groupBox3);
            groupBox7.Location = new Point(432, 90);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(268, 230);
            groupBox7.TabIndex = 7;
            groupBox7.TabStop = false;
            groupBox7.Text = "Место ДТП";
            // 
            // button2
            // 
            button2.Location = new Point(585, 403);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 9;
            label1.Text = "Дата и место ДТП";
            // 
            // step5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(groupBox7);
            Controls.Add(groupBox4);
            Controls.Add(button1);
            Name = "step5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Дата и место ДТП";
            Load += step5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        private Button button2;
        private Label label1;
    }
}