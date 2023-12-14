using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class step5 : Form
    {
        public step5()
        {
            InitializeComponent();
        }

        private void step5_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today.AddDays(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, 0, 0);
            Form4.rta.Date_and_time = date;
            Form4.rta.City = textBox1.Text;
            Form4.rta.Street = textBox2.Text;
            Form4.rta.Building = textBox3.Text;
            Hide();
            var form = new step6();
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
    }
}
