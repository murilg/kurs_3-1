using System.Data;
using Microsoft.Data.SqlClient;

namespace TestApp
{
    public partial class Form4 : Form
    {
        BindingSource Sbind = new BindingSource();

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
                dataGridView1.Columns["Year_of_manufacture"].HeaderText = "Год производства";
                dataGridView1.Columns["VIN"].HeaderText = "VIN";
                dataGridView1.Columns["Registration"].HeaderText = "СТС";
                dataGridView1.Columns["Registration_date_of_issue"].HeaderText = "Дата выдачи СТС";
                dataGridView1.Columns["Owner"].HeaderText = "Владелец";
            }
        }

        private static DataTable Autho()
        {
            DataTable dt = new DataTable();
            string cmdstr = """
                            select distinct V.Make,
                                V.Model,
                                V.Number_plate,
                                V.Color,
                                right(convert(varchar(10), V.Year_of_manufacture, 104), 4) AS Year_of_manufacture,
                                V.VIN,
                                V.Registration,
                                convert(varchar(10), V.Registration_date_of_issue, 104)    AS Registration_date_of_issue,
                                concat(Surname, ' ', Name, ' ', Patronymic)                as Owner
                            from Vehicle V
                                join Driver D on D.Driver_id = V.Owner_id
                                join Insurance I on V.Vehicle_id = I.Vehicle_id
                                join Driver_Insurance DI on I.Insurance_id = DI.Insurance_id
                            where D.Driver_id = @id
                               or DI.Driver_id = @id
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
