namespace TestApp
{
    public partial class step8 : Form
    {
        public step8()
        {
            InitializeComponent();
        }

        private void step8_Load(object sender, EventArgs e)
        {
            label3.Text = Form4.rta.RtaId.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form2();
            form.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new ForReport2();
            form.ShowDialog();
        }
    }
}
