using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPM
{
	public partial class bill: Form
	{
		SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");

		public bill()
		{
			InitializeComponent();
		}

		private void bill_Load(object sender,EventArgs e)
		{
			try
			{
				bill_list.View = View.Details;
				bill_list.Items.Clear();

				SqlDataAdapter ada_2 = new SqlDataAdapter("select * from sales_tb ",connect);
				connect.Open();
				DataTable dt_1 = new DataTable();
				ada_2.Fill(dt_1);

				connect.Close();
				for (int i = 0;i < dt_1.Rows.Count;i++)
				{
					DataRow dr = dt_1.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["i_name"].ToString());
					listitem.SubItems.Add(dr["i_price"].ToString());
					listitem.SubItems.Add(dr["i_qty"].ToString());
					listitem.SubItems.Add(dr["f_price"].ToString());
					listitem.SubItems.Add(dr["dis_amt"].ToString());
					listitem.SubItems.Add(dr["entered_amt"].ToString());
					listitem.SubItems.Add(dr["balance"].ToString());
					listitem.SubItems.Add(dr["f_dis"].ToString());

					bill_list.Items.Add(listitem);
				}

				bill_list.Refresh();

			}
			catch (Exception)
			{
				MessageBox.Show("Error","****",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
			}
		}

		private void button1_Click(object sender,EventArgs e)
		{
			try
			{
				string query = "DELETE from sales_tb ";
				SqlCommand cmd = new SqlCommand(query,connect);
				connect.Open();
				cmd.ExecuteNonQuery();
				connect.Close();
			}
			catch (Exception)
			{ }
			this.Close();
		}
	
	}
}
