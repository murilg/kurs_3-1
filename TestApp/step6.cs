namespace TestApp
{
    public partial class step6 : Form
    {
        public step6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = 0;
            Form4.rta.damage1 = textBox1.Text;
            Form4.rta.damage2 = textBox4.Text;
            if (radioButton1.Checked)
            {
                f = 1;
            }
            Form4.rta.park1 = textBox2.Text;
            Form4.rta.can1 = f;
            f = 0;
            if (radioButton4.Checked)
            {
                f = 1;
            }
            Form4.rta.can2 = f;
            Form4.rta.park2 = textBox3.Text;

            Hide();
            var form = new step7();
            form.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form3();
            form.ShowDialog();
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = "";
                textBox2.Enabled = false;
                groupBox7.ForeColor = Color.Gray;
            }
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
                groupBox7.ForeColor = Color.Black;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = "";
                textBox2.Enabled = false;
                groupBox7.ForeColor = Color.Gray;
            }
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
                groupBox7.ForeColor = Color.Black;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox3.Text = "";
                textBox3.Enabled = false;
                groupBox6.ForeColor = Color.Gray;
            }
            if (radioButton3.Checked)
            {
                textBox3.Enabled = true;
                groupBox6.ForeColor = Color.Black;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox3.Text = "";
                textBox3.Enabled = false;
                groupBox6.ForeColor = Color.Gray;
            }
            if (radioButton3.Checked)
            {
                textBox3.Enabled = true;
                groupBox6.ForeColor = Color.Black;
            }
        }
    }
}
