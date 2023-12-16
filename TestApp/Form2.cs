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
                string cmdstr = "select * from dbo.GetDataForFisrtDriverInRta(@id, @vid)";
                try
                {
                    using (var cmd = new SqlCommand(cmdstr, con))
                    {
                        con.Open();
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Form1.id;
                        cmd.Parameters.Add("@vid", SqlDbType.Int).Value = 1;
                        using (var rdr = cmd.ExecuteReader())
                        {
                            try
                            {
                                if (rdr.HasRows)
                                {
                                    while (rdr.Read())
                                    {
                                        you1.Text = rdr.GetString(3) + ' ' + rdr.GetString(4) + ' ' + rdr.GetString(5);
                                        you3.Text = rdr.GetString(6);
                                        you5.Text = rdr.GetString(7);
                                        drl2.Text = rdr.GetString(8);
                                        drl4.Text = rdr.GetDateTime(9).ToString("d");
                                        drl6.Text = rdr.GetDateTime(10).ToString("d");
                                        drl8.Text = rdr.GetString(11);
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
