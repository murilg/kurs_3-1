using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class ForReport2 : Form
    {
        public ForReport2()
        {
            InitializeComponent();
        }

        private void ForReport2_Load(object sender, EventArgs e)
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
                        cmd.Parameters.AddWithValue("@rtaid", Form4.rta.RtaId);
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
