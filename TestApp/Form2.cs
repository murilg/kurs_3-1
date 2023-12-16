using Microsoft.Data.SqlClient;
using System.Data;

namespace TestApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var form = new Form6();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            Autho();
        }

        private void Autho()
        {
            var constr = new SqlConnectionStringBuilder()
            {
                DataSource = """localhost,1433""",
                InitialCatalog = """RTA""",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
            };

            using (var con = new SqlConnection(constr.ConnectionString))
            {
                string cmdstr = """
                                select concat(D.Surname, ' ', D.Name, ' ', D.Patronymic) as FIO,
                                D.Address                                                as d_address,
                                D.Phone_number,
                                D.Driver_licence,
                                D.Date_of_issue,
                                dateadd(year, 10, D.Date_of_issue)                       as licence_expire_date,
                                D.Category
                                from Driver D
                                where D.Driver_id = @id
                                """;
                try
                {
                    using (var cmd = new SqlCommand(cmdstr, con))
                    {
                        con.Open();
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Form1.id;
                        using (var rdr = cmd.ExecuteReader())
                        {
                            try
                            {
                                if (rdr.HasRows)
                                {
                                    while (rdr.Read())
                                    {
                                        you1.Text = rdr.GetString(0);
                                        you3.Text = rdr.GetString(1);
                                        you5.Text = rdr.GetString(2);
                                        drl2.Text = rdr.GetString(3);
                                        drl4.Text = rdr.GetDateTime(4).ToString("d");
                                        drl6.Text = rdr.GetDateTime(5).ToString("d");
                                        drl8.Text = rdr.GetString(6);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Ошибка: {ex}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex}");
                }
            }
        }
    }
}
