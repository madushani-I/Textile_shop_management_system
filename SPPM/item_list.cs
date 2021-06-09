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
	public partial class item_list: Form
	{
		SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
		float ITEM_PRICE;
		
		public item_list()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender,EventArgs e)
		{
			try
			{
				string query = "select * from item_tb  WHERE i_code like '" + item_code.Text + "%'";

				SqlCommand select_item = new SqlCommand(query,connect);
				connect.Open();
				SqlDataReader reader = select_item.ExecuteReader();
				reader.Read();

				string dis = Convert.ToString(reader["max_dis"]);
				string price = Convert.ToString(reader["sell_price"]);
				string dis_amt = Convert.ToString(reader["max_dis_amt"]);
				float PRICE = float.Parse(price);
				ITEM_PRICE = PRICE;
				i_price.Text = price;
				txt_dis_amt.Text = dis_amt;
				txt_dis.Text = dis;
			}
			catch (Exception)
			{
				MessageBox.Show("Error","Error with loading item data",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
			}
		}

		private void qty_txt_TextChanged(object sender,EventArgs e)
		{
			try
			{	
				int item_qty = Convert.ToInt16(qty_txt.Text);
				float f_p = ITEM_PRICE * item_qty;
				full_price.Text = Convert.ToString(f_p);
			}
			catch (Exception)
			{

			}
		}
	}
}
