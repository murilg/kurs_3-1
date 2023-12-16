using Microsoft.Data.SqlClient;

namespace TestApp
{
    public partial class step3 : Form
    {
        public static string ins;
        public step3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check() == 1)
            {
                ins = maskedTextBox1.Text.Trim().Replace(" ", "");
                Hide();
                var form = new step4cs();
                form.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Полис ОСАГО недействителен");
            }
        }

        private int check()
        {
            int choose = 0;
            string cmdstr = """
                            declare @i int
                            set @i = (select datediff(dd, I.Date_of_issue, getdate()) from Insurance I where I.Insurance = @ins)
                            if @i >= 0 and @i <= 365
                                select 1 as RetVal
                            else
                                select 0 as RetVal
                            """;
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ins", maskedTextBox1.Text.Trim().Replace(" ", ""));
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

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form3();
            form.ShowDialog();
            Close();
        }
    }
}
