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
            Hide();
            var form = new ForReport();
            form.ShowDialog();
            Close();
        }

        private DataTable Autho()
        {
            DataTable dt = new DataTable();
            string cmdstr = """
                            select R.RTA_id, left(R.Date_and_time, 16) as date, concat(R.City, ', ', R.Street, ', ', R.Building) as Address
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
    }
}
