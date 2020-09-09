using System;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrystalReport
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //rprt.Load(Server.MapPath("~/CrystalReport1.rpt"));
            CrystalReport4 cr = new CrystalReport4();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQL;Initial Catalog=Test_DB;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("sp_select_Employee", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cr.SetDataSource(dt);
            // rprt.SetParameterValue("MyParameter", TextBox1.Text);
            CrystalReportViewer1.ReportSource = cr;
            CrystalReportViewer1.DataBind();
        }
    }
}