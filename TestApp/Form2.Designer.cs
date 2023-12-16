namespace TestApp
{
    partial class Form2
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
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            you1 = new Label();
            label2 = new Label();
            you2 = new Label();
            you3 = new Label();
            label3 = new Label();
            you4 = new Label();
            you5 = new Label();
            groupBox2 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            drl1 = new Label();
            drl2 = new Label();
            label6 = new Label();
            drl3 = new Label();
            drl4 = new Label();
            label7 = new Label();
            drl5 = new Label();
            drl6 = new Label();
            label8 = new Label();
            drl7 = new Label();
            drl8 = new Label();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(47, 37);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(65, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Главная";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(145, 37);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(38, 20);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "ДТП";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(223, 37);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(26, 20);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "ТС";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(60, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 206);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Контактные данные";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(you1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(you2);
            flowLayoutPanel1.Controls.Add(you3);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(you4);
            flowLayoutPanel1.Controls.Add(you5);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 26);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(356, 174);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // you1
            // 
            you1.AutoSize = true;
            you1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            you1.Location = new Point(3, 0);
            you1.Name = "you1";
            you1.Size = new Size(51, 20);
            you1.TabIndex = 0;
            you1.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // you2
            // 
            you2.AutoSize = true;
            you2.Location = new Point(3, 40);
            you2.Name = "you2";
            you2.Size = new Size(51, 20);
            you2.TabIndex = 1;
            you2.Text = "Адрес";
            // 
            // you3
            // 
            you3.AutoSize = true;
            you3.Location = new Point(3, 60);
            you3.Name = "you3";
            you3.Size = new Size(50, 20);
            you3.TabIndex = 2;
            you3.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // you4
            // 
            you4.AutoSize = true;
            you4.Location = new Point(3, 100);
            you4.Name = "you4";
            you4.Size = new Size(69, 20);
            you4.TabIndex = 3;
            you4.Text = "Телефон";
            // 
            // you5
            // 
            you5.AutoSize = true;
            you5.Location = new Point(3, 120);
            you5.Name = "you5";
            you5.Size = new Size(50, 20);
            you5.TabIndex = 4;
            you5.Text = "label6";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Location = new Point(470, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(243, 271);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Водительские права";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(drl1);
            flowLayoutPanel2.Controls.Add(drl2);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(drl3);
            flowLayoutPanel2.Controls.Add(drl4);
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(drl5);
            flowLayoutPanel2.Controls.Add(drl6);
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Controls.Add(drl7);
            flowLayoutPanel2.Controls.Add(drl8);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(6, 26);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(231, 239);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // drl1
            // 
            drl1.AutoSize = true;
            drl1.Location = new Point(3, 0);
            drl1.Name = "drl1";
            drl1.Size = new Size(115, 20);
            drl1.TabIndex = 0;
            drl1.Text = "Серия и номер";
            // 
            // drl2
            // 
            drl2.AutoSize = true;
            drl2.Location = new Point(3, 20);
            drl2.Name = "drl2";
            drl2.Size = new Size(50, 20);
            drl2.TabIndex = 1;
            drl2.Text = "label3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 40);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 8;
            // 
            // drl3
            // 
            drl3.AutoSize = true;
            drl3.Location = new Point(3, 60);
            drl3.Name = "drl3";
            drl3.Size = new Size(97, 20);
            drl3.TabIndex = 2;
            drl3.Text = "Дата выдачи";
            // 
            // drl4
            // 
            drl4.AutoSize = true;
            drl4.Location = new Point(3, 80);
            drl4.Name = "drl4";
            drl4.Size = new Size(50, 20);
            drl4.TabIndex = 3;
            drl4.Text = "label5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 100);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 9;
            // 
            // drl5
            // 
            drl5.AutoSize = true;
            drl5.Location = new Point(3, 120);
            drl5.Name = "drl5";
            drl5.Size = new Size(137, 20);
            drl5.TabIndex = 4;
            drl5.Text = "Действительны до";
            // 
            // drl6
            // 
            drl6.AutoSize = true;
            drl6.Location = new Point(3, 140);
            drl6.Name = "drl6";
            drl6.Size = new Size(50, 20);
            drl6.TabIndex = 5;
            drl6.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 160);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 10;
            // 
            // drl7
            // 
            drl7.AutoSize = true;
            drl7.Location = new Point(3, 180);
            drl7.Name = "drl7";
            drl7.Size = new Size(82, 20);
            drl7.TabIndex = 6;
            drl7.Text = "Категории";
            // 
            // drl8
            // 
            drl8.AutoSize = true;
            drl8.Location = new Point(3, 200);
            drl8.Name = "drl8";
            drl8.Size = new Size(50, 20);
            drl8.TabIndex = 7;
            drl8.Text = "label9";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label you1;
        private Label label2;
        private Label you2;
        private Label you3;
        private Label label3;
        private Label you4;
        private Label you5;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label drl1;
        private Label drl2;
        private Label label6;
        private Label drl3;
        private Label drl4;
        private Label label7;
        private Label drl5;
        private Label drl6;
        private Label label8;
        private Label drl7;
        private Label drl8;
    }
}