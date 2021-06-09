using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace SPPM
{
    public partial class InventoryReport : Form
    {

        ReportDocument report = new ReportDocument();
        //String c = "Data Source=THISITHA_KAVIND/SQLEXPRESS;Initial Catalog=pos;Integrated Security=True";
        SqlConnection con = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS;Initial Catalog=pos;Integrated Security=True");

        public InventoryReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            String sqlCom = "SELECT * FROM item_tb";
            SqlDataAdapter da = new SqlDataAdapter(sqlCom, con);

            DataSet dataReport = new DataSet();
            da.Fill(dataReport, "item_tb");


            inventoryReport myData = new inventoryReport();
            myData.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myData;
        }
    }
}
