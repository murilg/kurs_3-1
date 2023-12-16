namespace TestApp;

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
        button1 = new Button();
        maskedTextBox1 = new MaskedTextBox();
        maskedTextBox2 = new MaskedTextBox();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        button1.Location = new Point(352, 320);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 1;
        button1.Text = "Войти";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // maskedTextBox1
        // 
        maskedTextBox1.Location = new Point(0, 26);
        maskedTextBox1.Mask = "0000000000";
        maskedTextBox1.Name = "maskedTextBox1";
        maskedTextBox1.Size = new Size(250, 27);
        maskedTextBox1.TabIndex = 0;
        // 
        // maskedTextBox2
        // 
        maskedTextBox2.Location = new Point(0, 26);
        maskedTextBox2.Name = "maskedTextBox2";
        maskedTextBox2.Size = new Size(203, 27);
        maskedTextBox2.TabIndex = 0;
        maskedTextBox2.UseSystemPasswordChar = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(maskedTextBox1);
        groupBox1.Location = new Point(301, 122);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(203, 63);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "Номер телефона";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(maskedTextBox2);
        groupBox2.Location = new Point(301, 216);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(203, 63);
        groupBox2.TabIndex = 4;
        groupBox2.TabStop = false;
        groupBox2.Text = "Пароль";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(button1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Вход";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    private MaskedTextBox maskedTextBox1;
    private MaskedTextBox maskedTextBox2;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
}
