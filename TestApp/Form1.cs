using Microsoft.Data.SqlClient;

namespace TestApp;

public partial class Form1 : Form
{
    public static int id;

    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string cmdstr = """
                        select Driver_Id
                        from Driver
                        where Phone_number=@number and Password=@pass
                        """;
        using (var con = new SqlConnection(Connection.Constr.ConnectionString))
        {
            using (var cmd = new SqlCommand(cmdstr, con))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@number", maskedTextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", maskedTextBox2.Text.Trim());
                    con.Open();
                    id = (int)cmd.ExecuteScalar();
                    {
                        var form = new Form4();
                        form.Show();
                        Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка входа: {ex}");
                }
            }
        }
    }
}
