using System.Data;
using Microsoft.Data.SqlClient;

namespace TestApp
{
    public partial class Form5 : Form
    {
        public static int rtaid;
        BindingSource Sbind = new BindingSource();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DataTable dt = Autho();
            Sbind.DataSource = dt;
            dataGridView1.DataSource = Sbind;
            {
                dataGridView1.Columns["RTA_id"].HeaderText = "Номер извещения о ДТП";
                dataGridView1.Columns["date"].HeaderText = "Дата и время";
                dataGridView1.Columns["Address"].HeaderText = "Адрес";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtaid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var form = new ForReport();
            form.ShowDialog();
        }

        private DataTable Autho()
        {
            DataTable dt = new DataTable();
            string cmdstr = """
                            select R.RTA_id,
                                   concat(convert(varchar(10), R.Date_and_time, 104), ' ',
                                          substring(convert(varchar(19), R.Date_and_time), 12, 5)) as date,
                                   concat(R.City, ', ', R.Street, ', ', R.Building)                  as Address
                            from RTA R
                                     join RTA_Driver RD on R.RTA_id = RD.RTA_id
                            where RD.Driver_id = @id
                            """;
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", Form1.id);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            dt.Load(rdr);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex}");
                    }
                }
            }

            return dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var form = new Form2();
            form.ShowDialog();
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var form = new Form3();
            form.ShowDialog();
            Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var form = new Form6();
            form.ShowDialog();
            Close();
        }
    }
}
