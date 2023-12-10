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
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(323, 310);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "Войти";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // maskedTextBox1
        // 
        maskedTextBox1.Location = new Point(363, 201);
        maskedTextBox1.Name = "maskedTextBox1";
        maskedTextBox1.Size = new Size(125, 27);
        maskedTextBox1.TabIndex = 1;
        // 
        // maskedTextBox2
        // 
        maskedTextBox2.Location = new Point(383, 257);
        maskedTextBox2.Name = "maskedTextBox2";
        maskedTextBox2.Size = new Size(125, 27);
        maskedTextBox2.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(maskedTextBox2);
        Controls.Add(maskedTextBox1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private MaskedTextBox maskedTextBox1;
    private MaskedTextBox maskedTextBox2;
}
