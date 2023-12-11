using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace TestApp
{
    public partial class ForReport : Form
    {
        public ForReport()
        {
            InitializeComponent();
        }

        private void ForReport_Load(object sender, EventArgs e)
        {
            var dt1 = GetData("gag @rtaid");
            var dt2 = GetData("Car1 @rtaid");
            var dt3 = GetData("Car2 @rtaid");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt1));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt2));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", dt3));
            reportViewer1.RefreshReport();
        }

        private DataTable GetData(string cmdstr)
        {
            DataTable dt = new DataTable();
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@rtaid", Form5.rtaid);
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
