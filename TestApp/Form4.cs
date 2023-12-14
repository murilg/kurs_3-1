using System.Data;
using Microsoft.Data.SqlClient;

namespace TestApp
{
    public partial class Form4 : Form
    {
        BindingSource Sbind = new BindingSource();
        public static string ins;
        public static RtaClass rta = new RtaClass();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable dt = Autho();
            Sbind.DataSource = dt;
            dataGridView1.DataSource = Sbind;
            {
                dataGridView1.Columns["Make"].HeaderText = "Марка";
                dataGridView1.Columns["Model"].HeaderText = "Модель";
                dataGridView1.Columns["Number_plate"].HeaderText = "Госномер";
                dataGridView1.Columns["Color"].HeaderText = "Цвет";
                dataGridView1.Columns["Insurance"].HeaderText = "ОСАГО";
                dataGridView1.Columns["Date_of_issue"].HeaderText = "Дата выдачи ОСАГО";
                dataGridView1.Columns["Registration"].HeaderText = "СТС";
                dataGridView1.Columns["Registration_date_of_issue"].HeaderText = "Дата выдачи СТС";
                dataGridView1.Columns["O_FIO"].HeaderText = "Владелец";
            }
        }

        private DataTable Autho()
        {
            DataTable dt = new DataTable();
            string cmdstr = """
                            select V.Make,
                                   V.Model,
                                   V.Number_plate,
                                   V.Color,
                                   I.Insurance,
                                   convert(varchar(10), I.Date_of_issue, 104) as Date_of_issue,
                                   V.Registration,
                                   convert(varchar(10), V.Registration_date_of_issue, 104) as Registration_date_of_issue,
                                   concat(O.Surname, ' ', O.Name, ' ', O.Patronymic) as O_FIO
                            from Vehicle V
                                     join Driver O on V.Owner_id = O.Driver_id
                                     join dbo.Insurance I on V.Vehicle_id = I.Vehicle_id
                            where O.Driver_id = @id
                            union
                            select V.Make,
                                   V.Model,
                                   V.Number_plate,
                                   V.Color,
                                   I.Insurance,
                                   convert(varchar(10), I.Date_of_issue, 104) as Date_of_issue,
                                   V.Registration,
                                   convert(varchar(10), V.Registration_date_of_issue, 104) as Registration_date_of_issue,
                                   concat(O.Surname, ' ', O.Name, ' ', O.Patronymic) as O_FIO
                            from Vehicle V
                                     join dbo.Insurance I on V.Vehicle_id = I.Vehicle_id
                                     join dbo.Driver_Insurance DI on I.Insurance_id = DI.Insurance_id
                                     join dbo.Driver O on O.Driver_id = V.Owner_id
                            where DI.Driver_id = @id
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (check() != 0)
            {
                Form4.rta.VehicleId1 = check();
                Hide();
                var form = new step3();
                form.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Полис ОСАГО недействителен");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form2();
            form.ShowDialog();
            Close();
        }

        private int check()
        {
            int choose = 0;
            string cmdstr = """
                            declare @i int
                            set @i = (select datediff(dd, I.Date_of_issue, getdate()) from Insurance I where I.Insurance = @ins)
                            if @i >= 0 and @i <= 365
                            begin
                                select Vehicle_id from Insurance where Insurance = @ins
                            end
                            else
                                select 0 as RetVal
                            """;
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ins", dataGridView1.CurrentRow.Cells[4].Value);
                        con.Open();
                        choose = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex}");
                    }
                }
            }
            return choose;
        }
    }
}
