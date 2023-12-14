using Microsoft.Data.SqlClient;
using System.Data;


namespace TestApp
{
    public partial class step4cs : Form
    {
        BindingSource Sbind = new BindingSource();

        public step4cs()
        {
            InitializeComponent();
        }

        private void step4cs_Load(object sender, EventArgs e)
        {
            DataTable dt = Autho();
            Sbind.DataSource = dt;
            dataGridView1.DataSource = Sbind;
            {
                dataGridView1.Columns["Surname"].HeaderText = "Фамилия";
                dataGridView1.Columns["Name"].HeaderText = "Имя";
                dataGridView1.Columns["Patronymic"].HeaderText = "Отчество";
                dataGridView1.Columns["Driver_licence"].HeaderText = "Водительское удостоверение";
            }
        }

        private DataTable Autho()
        {
            DataTable dt = new DataTable();
            string cmdstr = """
                            select D.Surname, D.Name, D.Patronymic, D.Driver_licence
                            from Driver D
                            join Driver_Insurance DI on D.Driver_id = DI.Driver_id
                            join Insurance I on DI.Insurance_id = I.Insurance_id
                            where I.Insurance = @insurance
                            """;
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@insurance", step3.ins);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string dl = (string)dataGridView1.CurrentRow.Cells[3].Value;
            Autho2(dl);
            Hide();
            var form = new step5();
            form.ShowDialog();
            Close();
        }

        private void Autho2(string dl)
        {
            string cmdstr = """
                            select D.Driver_id, I.Vehicle_id
                            from Driver D, Insurance I
                            where D.Driver_licence = @dl and I.Insurance = @ins
                            """;
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@dl", dl);
                        cmd.Parameters.AddWithValue("@ins", step3.ins);
                        con.Open();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    Form4.rta.DriverId2 = rdr.GetInt32(0);
                                    Form4.rta.VehicleId2 = rdr.GetInt32(1);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form3();
            form.ShowDialog();
            Close();
        }
    }
}
