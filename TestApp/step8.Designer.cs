﻿namespace TestApp
{
    partial class step8
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(262, 34);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 0;
            label1.Text = "Европротокол успешно оформлен";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 82);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 1;
            label2.Text = "Номер извещения о ДТП:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 82);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(273, 161);
            button1.Name = "button1";
            button1.Size = new Size(244, 47);
            button1.TabIndex = 3;
            button1.Text = "Посмотреть отчёт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(648, 392);
            button2.Name = "button2";
            button2.Size = new Size(124, 36);
            button2.TabIndex = 4;
            button2.Text = "На главную";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // step8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "step8";
            Text = "Европротокол оформлен";
            Load += step8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}