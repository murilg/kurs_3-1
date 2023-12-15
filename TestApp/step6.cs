

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

            {
                //int columnID = 0;
                //switch (comboBox1.SelectedIndex)
                //{
                //    case 0: columnID = 1; break;
                //    case 1: columnID = 2; break;
                //    case 2: columnID = 3; break;
                //    case 3: columnID = 4; break;
                //    case 4: columnID = 5; break;
                //    default: columnID = 0; break;
                //}
                //Form4.rta.type1 = columnID;
                //switch (comboBox2.SelectedIndex)
                //{
                //    case 0: columnID = 1; break;
                //    case 1: columnID = 2; break;
                //    case 2: columnID = 3; break;
                //    case 3: columnID = 4; break;
                //    case 4: columnID = 5; break;
                //    default: columnID = 0; break;
                //}
                //Form4.rta.type2 = columnID;
            }

            Hide();
            var form = new step7();
            form.ShowDialog();
            Close();
        }

        private void step6_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
            //comboBox2.SelectedIndex = 0;
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
            }
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = "";
                textBox2.Enabled = false;
            }
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox3.Text = "";
                textBox3.Enabled = false;
            }
            if (radioButton3.Checked)
            {
                textBox3.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox3.Text = "";
                textBox3.Enabled = false;
            }
            if (radioButton3.Checked)
            {
                textBox3.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
