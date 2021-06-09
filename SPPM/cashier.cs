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

	public partial class cashier: Form
	{
		private TextBox focusedTextbox = null;
		SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
		string user_name;
		float ITEM_PRICE;
		public cashier()
		{
			InitializeComponent();
			touchControl1.OnUserControlButtonClicked += new touchControl.ButtonClickedEventHandler(touchScreen1_OnUserControlButtonClicked);



			load_cashier();
			delete_sales_TB();
			customer_id();
		}



		protected void touchScreen1_OnUserControlButtonClicked(object sender,EventArgs e)
		{
			Button b = (Button)sender;
			if (focusedTextbox != null)
			{
				if (b.Text == "Back")
				{
					if (focusedTextbox.Text.Length > 1)
					{
						focusedTextbox.Text = focusedTextbox.Text.Substring(0,focusedTextbox.Text.Length - 1);
					}
					else
					{
						focusedTextbox.Text = string.Empty;
					}
				}
				else
				{
					if (MyGlobal.bTouch)
						focusedTextbox.Text = b.Text;
					else
					{
						MyGlobal.bTouch = false;
						focusedTextbox.Text += b.Text;
					}
				}
			}
		}


		public void delete_sales_TB()
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
		}
		
		public void load_cashier()
		{
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
			string shw_user_query = "SELECT * FROM temp";
				SqlCommand shw_user_cmd = new SqlCommand(shw_user_query, connect);
				connect.Open();
				SqlDataReader read_pid = shw_user_cmd.ExecuteReader();

				while (read_pid.Read())
				{
					user_name = Convert.ToString(read_pid["u_name"]);
				}

				user.Text = user_name;

				connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error...Loading cashier name");

            }
        }

		public void customer_id()
		{
			int length = 7;

			// creating a StringBuilder object()
			StringBuilder str_build = new StringBuilder();
			Random random = new Random();

			char letter;

			for (int i = 0;i < length;i++)
			{
				double flt = random.NextDouble();
				int shift = Convert.ToInt32(Math.Floor(25 * flt));
				letter = Convert.ToChar(shift + 65);
				str_build.Append(letter);
			}
			txt_cus.Text = str_build.ToString();
		}

		private void cashier_Load(object sender,EventArgs e)
		{
			//pcontroller.Controls.Clear();
			//item_list list = new item_list() { Dock = DockStyle.Fill,TopLevel = false,TopMost = true };
			//this.pcontroller.Controls.Add(list);
			//list.Show();

		}

		private void kbrd_btn_Click(object sender,EventArgs e)
		{
			//redeem
			lbl_v.Visible = true;
			lbl_v_amt.Visible = true;
			btn_v.Visible = true;
			txt_v_amt.Visible = true;
			txt_v_id.Visible = true;
		}

		private void label1_Click(object sender,EventArgs e)
		{

		}

		private void textBox14_TextChanged(object sender,EventArgs e)
		{
			if (txt_net_dis.Text != "")
			{
				float total_discount = float.Parse(total_dis.Text);
				float line_discount = float.Parse(line_dis_amt.Text);
				float net_dis = float.Parse(txt_net_dis.Text);
				float totel = float.Parse(total.Text);
				float net_dis_amt = totel * net_dis / 100;
				float g_total = totel - net_dis_amt;
				if (net_dis < 10)
				{
					txt_net_dis_amt.Text = Convert.ToString(net_dis_amt);
					total_dis.Text = Convert.ToString(line_discount + net_dis_amt);
					total.Text = Convert.ToString(g_total);
				}
				else
				{
					MessageBox.Show("Maximum Discount is 9%");
					txt_net_dis.Clear();
				}
			}
		}

		private void button13_Click(object sender,EventArgs e)
		{
			//pcontroller.Controls.Clear();
			//cashier_buttns list = new cashier_buttns() { Dock = DockStyle.Fill,TopLevel = false,TopMost = true };
			//this.pcontroller.Controls.Add(list);
			//list.Show();
		}

		private void button30_Click(object sender,EventArgs e)
		{
			//pcontroller.Controls.Clear();
			//item_list list = new item_list() { Dock = DockStyle.Fill,TopLevel = false,TopMost = true };
			//this.pcontroller.Controls.Add(list);
			//list.Show();
		}

		private void button19_Click(object sender,EventArgs e)
		{

		}

		private void button24_Click(object sender,EventArgs e)
		{

		}

		private void panel1_Paint(object sender,PaintEventArgs e)
		{

		}

		private void remove_qty_TextChanged(object sender,EventArgs e)
		{

		}

		private void qty_txt_TextChanged(object sender,EventArgs e)
		{
			try
			{
				if (qty_txt.Text == "")
				{
					full_price.Text = "0";
				}
				else {
					int item_qty = Convert.ToInt16(qty_txt.Text);
					float f_p = ITEM_PRICE * item_qty;
					full_price.Text = Convert.ToString(f_p);
					
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Error with genarating price");
			}
		}

		private void button34_Click(object sender,EventArgs e)
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
				string i_discription = Convert.ToString(reader["i_desription"]);

				float PRICE = float.Parse(price);
				ITEM_PRICE = PRICE;
				i_dis.Text = i_discription;
				i_price.Text = price;
				txt_dis_amt.Text = dis_amt;
				txt_dis.Text = dis;
				connect.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Error with loading item data","Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
			}
		}

		private void user_dis_TextChanged(object sender,EventArgs e)
		{
			try
			{
				if (user_dis.Text != "")
				{
					if (full_price.Text == "")
					{
						MessageBox.Show("Cannot genarate discount without item total");
						user_dis.Clear();
						user_dis_amt.Clear();
					}
					else
					{
						float u_dis = float.Parse(user_dis.Text);
						float max_dis = float.Parse(txt_dis.Text);
						float item_price = float.Parse(full_price.Text);
						if (u_dis > max_dis)
						{
							MessageBox.Show("You cannot exceeds the maximum discount level");
							user_dis.Clear();
							user_dis_amt.Clear();
						}
						else
						{
							float total_discount = float.Parse(line_dis_amt.Text);
							float dis_amount = item_price * u_dis / 100;
							float full = item_price - dis_amount;
							user_dis_amt.Text = Convert.ToString(dis_amount);
							full_price.Text = Convert.ToString(full);
							line_dis_amt.Text = Convert.ToString(total_discount+ dis_amount);
						}
					}
				}
			}
			catch(Exception )
			{
				MessageBox.Show("Error with genarating the discount"); 
			}
		}

		private void button35_Click(object sender,EventArgs e)
		{
			if (total.Text == "")
			{
                try
                {
                    float t = float.Parse(full_price.Text);
					string query = "INSERT INTO sales_tb(i_id,i_name,i_price,i_qty,f_price,total,dis,dis_amt,entered_amt,balance,f_dis) VALUES('" + item_code.Text + "','" + i_dis.Text + "','" + ITEM_PRICE + "','" + qty_txt.Text + "','" + full_price.Text + "','','" + user_dis.Text + "','" + user_dis_amt.Text + "','','','')";
					SqlCommand cmd = new SqlCommand(query, connect);
					connect.Open();
					cmd.ExecuteNonQuery();
					total.Text = Convert.ToString(t);
					////MessageBox.Show("Done", "Added to the DB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					connect.Close();
					bill_list_load();
					item_code.Clear();
					i_dis.Clear();
					qty_txt.Clear();
					i_price.Clear();
					txt_dis.Clear();
					txt_dis_amt.Clear();
					user_dis.Clear();
					user_dis_amt.Clear();
					full_price.Clear();
				}
					catch (Exception)
				{
					MessageBox.Show("Error with inserting the data");
				}
            try
                {

					string update_query = "UPDATE item_tb  SET i_qty =i_qty-'" + qty_txt.Text + "' WHERE i_code='" + item_code.Text + "' ";
					SqlCommand update_cmd = new SqlCommand(update_query, connect);
					connect.Open();
					update_cmd.ExecuteNonQuery();
					//MessageBox.Show("Done", "Updated the DB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					connect.Close();




				}
				catch (Exception)
				{
					MessageBox.Show("Error with updating the stock");
				}
			}
			else
			{
				float subtotal = float.Parse(total.Text);
				float newtotal = float.Parse(full_price.Text);
				float fulltotal = subtotal + newtotal;
				total.Text = Convert.ToString(fulltotal);

				try
				{
					string query = "INSERT INTO sales_tb(i_id,i_name,i_price,i_qty,f_price,total,dis,dis_amt,entered_amt,balance,f_dis) VALUES('" + item_code.Text + "','" + i_dis.Text + "','" + ITEM_PRICE + "','" + qty_txt.Text + "','" + full_price.Text + "','','" + user_dis.Text + "','" + user_dis_amt.Text + "','','','')";
					SqlCommand cmd = new SqlCommand(query, connect);
					connect.Open();
					cmd.ExecuteNonQuery();
					//MessageBox.Show("Done", "Added to the DB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					connect.Close();
					bill_list_load();
					item_code.Clear();
					i_dis.Clear();
					qty_txt.Clear();
					i_price.Clear();
					txt_dis.Clear();
					txt_dis_amt.Clear();
					user_dis.Clear();
					user_dis_amt.Clear();
					full_price.Clear();
				}
				catch (Exception)
				{
					MessageBox.Show("Error with inserting the sale");
				}
				try
				{

					string update_query = "UPDATE item_tb  SET i_qty =i_qty-'" + qty_txt.Text + "' WHERE i_code='" + item_code.Text + "' ";
					SqlCommand update_cmd = new SqlCommand(update_query, connect);
					connect.Open();
					update_cmd.ExecuteNonQuery();
					//reMessageBox.Show("Done", "Updated the DB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					connect.Close();

				}
				catch (Exception)
				{
					MessageBox.Show("Error with updating the stock");
				}
			
			}
		}


		public void bill_recall_list_loaded()
		{
			delete_sales_TB();
			string sale_query = "INSERT INTO sales_tb SELECT [i_id],[i_name],[i_price],[i_qty] ,[f_price],[total],[dis],[dis_amt],[entered_amt],[balance],[f_dis] FROM  " + txt_recall.Text+" ";
			SqlCommand cmd_sale = new SqlCommand(sale_query,connect);
			connect.Open();
			cmd_sale.ExecuteNonQuery();
			connect.Close();



			string query = "SELECT SUM(f_price) AS Total from sales_tb";

			SqlCommand get_sum = new SqlCommand(query,connect);
			connect.Open();
			SqlDataReader reader = get_sum.ExecuteReader();
			while(reader.Read())
			{
				total.Text = reader["Total"].ToString();
			}
			connect.Close();


			bill_list_load();
			string drop_query = "DROP TABLE [dbo].[" + txt_recall.Text + "] ";
			SqlCommand cmd_drop = new SqlCommand(drop_query,connect);
			connect.Open();
			cmd_drop.ExecuteNonQuery();
			connect.Close();



		}
  public void bill_list_load(){
			//user bill
			try
			{
				bill_list.View = View.Details;
				bill_list.Items.Clear();

				SqlDataAdapter ada_2 = new SqlDataAdapter("select * from sales_tb ", connect);
				connect.Open();
				DataTable dt_1 = new DataTable();
				ada_2.Fill(dt_1);

				connect.Close();
				for (int i = 0; i < dt_1.Rows.Count; i++)
				{
					DataRow dr = dt_1.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["t_id"].ToString());
					listitem.SubItems.Add(dr["i_id"].ToString());
					listitem.SubItems.Add(dr["i_name"].ToString());
					listitem.SubItems.Add(dr["i_price"].ToString());
					listitem.SubItems.Add(dr["i_qty"].ToString());
					listitem.SubItems.Add(dr["dis"].ToString());
					listitem.SubItems.Add(dr["dis_amt"].ToString());
					listitem.SubItems.Add(dr["f_price"].ToString());


					bill_list.Items.Add(listitem);
				}

				bill_list.Refresh();


			}
			catch (Exception)
			{
				MessageBox.Show("Error with loading data to list", "****", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}




		}

		private void bill_list_SelectedIndexChanged(object sender,EventArgs e)
		{
			if (bill_list.SelectedItems.Count == 0)
				return;

			ListViewItem item = bill_list.SelectedItems[0];

			remove_itm_txt.Text = item.Text;
		}

		private void Remove_Click(object sender,EventArgs e)
		{


			if (remove_qty.Text == "")
			{
				string query = "select * from sales_tb  WHERE t_id = '" + remove_itm_txt.Text + "'";

				SqlCommand select_id = new SqlCommand(query, connect);
				connect.Open();
				SqlDataReader reader = select_id.ExecuteReader();
				reader.Read();
				string qty = Convert.ToString(reader["i_qty"]);
				string ID = Convert.ToString(reader["i_id"]);
				string p = Convert.ToString(reader["f_price"]);
				float PRICE = float.Parse(p);
				float tot = float.Parse(total.Text);
				float g_t = tot - PRICE;
				total.Text = Convert.ToString(g_t);

				//MessageBox.Show("Succesfully Removed", "****", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				connect.Close();

				try    //update query should here
				{
					SqlConnection connect_up = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
					string query_1 = "UPDATE  item_tb SET i_qty=i_qty+'" + qty + "' WHERE i_code='" + ID + "' ";
					SqlCommand cmd_1 = new SqlCommand(query_1, connect_up);
					connect_up.Open();
					cmd_1.ExecuteNonQuery();
					//MessageBox.Show("Done", "Values chaned", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					connect_up.Close();

					SqlConnection connect_5 = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
					string query_rmv = "DELETE from sales_tb  WHERE t_id ='" + remove_itm_txt.Text + "'";
					SqlCommand cmd_rm = new SqlCommand(query_rmv, connect_5);
					connect_5.Open();
					cmd_rm.ExecuteNonQuery();
					//MessageBox.Show("Done", "Remove From List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					remove_itm_txt.Clear();

					bill_list_load();
					connect_5.Close();
				}
				catch (Exception)
				{ }





			}
			else   // Reducing Full amount price
			{
				SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");

				try
				{
					string query = "select * from sales_tb  WHERE t_id = '" + remove_itm_txt.Text + "'";

					SqlCommand select_id = new SqlCommand(query, connect);
					connect.Open();
					SqlDataReader reader = select_id.ExecuteReader();
					reader.Read();

					//string qty = Convert.ToString(reader["i_qty"]);
					string p = Convert.ToString(reader["i_price"]);
					string ID = Convert.ToString(reader["i_id"]);

					float PRICE = float.Parse(p);

					int qty = int.Parse(remove_qty.Text);

					float f_p = qty * PRICE;

					float tot = float.Parse(total.Text);
					float g_t = tot - f_p;
					total.Text = Convert.ToString(g_t);

					MessageBox.Show("Succesfully Removed", "****", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					////////////////////////////////////////////////////////////////////////////////////////////////////

					//UPDATING THE ITEM TABLE AND SALES TABLE

					SqlConnection connect_up = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
					string query_1 = "UPDATE  item_tb SET i_qty=i_qty+'" + remove_qty.Text + "' WHERE i_code='" + ID + "' ";
					SqlCommand cmd_1 = new SqlCommand(query_1, connect_up);
					connect_up.Open();
					cmd_1.ExecuteNonQuery();
					MessageBox.Show("Done", "Values chaned", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					connect_up.Close();



					SqlConnection connect_3 = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
					string update_query = "UPDATE sales_tb  SET i_qty =i_qty-'" + remove_qty.Text + "',f_price=f_price-'" + f_p + "' WHERE t_id='" + remove_itm_txt.Text + "' ";
					SqlCommand update_cmd = new SqlCommand(update_query, connect_3);
					connect_3.Open();
					update_cmd.ExecuteNonQuery();
					MessageBox.Show("Done", "Updated the DB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					bill_list_load();
					remove_itm_txt.Clear();
					remove_qty.Clear();
					connect_3.Close();
				}
				catch (Exception)
				{

				}


			}
		}

		private void button1_Click(object sender,EventArgs e)
		{
			this.Close();
			delete_sales_TB();
		}

		private void button2_Click(object sender,EventArgs e)
		{
			delete_sales_TB();
			bill_list.Items.Clear();
			item_code.Clear();
			i_dis.Clear();
			qty_txt.Clear();
			i_price.Clear();
			txt_dis.Clear();
			txt_dis_amt.Clear();
			user_dis.Clear();
			user_dis_amt.Clear();
			full_price.Clear();
			total.Clear();
			balence.Clear();
			total_dis.Clear();
			txt_net_dis.Clear();
			txt_net_dis_amt.Clear();
			line_dis_amt.Clear();


		}

		private void textBox15_TextChanged(object sender,EventArgs e)
		{

		}

		private void textBox11_TextChanged(object sender,EventArgs e)
		{

		}

		private void enterd_amt_TextChanged(object sender,EventArgs e)
		{
			if (enterd_amt.Text == "")
			{
				balence.Text = "0";

			}
			try
			{
				float p = float.Parse(total.Text);
				float g = float.Parse(enterd_amt.Text);
				balence.Text = Convert.ToString(g - p);
			}
			catch (Exception)
			{ }
		}

		private void total_TextChanged(object sender,EventArgs e)
		{
			if(total.Text!="")
			{
				try
				{
					float p = float.Parse(total.Text);
					float g = float.Parse(enterd_amt.Text);
					balence.Text = Convert.ToString(g - p);
				}
				catch (Exception)
				{ }
			}
		}

		private void button7_Click(object sender,EventArgs e)
		{
			if (enterd_amt.Text != "")
			{
				MessageBoxButtons btn = MessageBoxButtons.YesNo;
				DialogResult res = MessageBox.Show("Do you want do more transactions? ","Successfully Done the transcation",btn);
				if (res == DialogResult.Yes)
				{
					
				}
				if (res == DialogResult.No)
				{
					string query = "INSERT INTO sales_tb (i_id,i_name,i_price,i_qty,f_price,total,dis,dis_amt,entered_amt,balance,f_dis) VALUES('','','','','','" + total.Text + "','0','"+line_dis_amt.Text+"','" + enterd_amt.Text + "','" + balence.Text + "','"+total_dis.Text+"')";
					SqlCommand cmd = new SqlCommand(query,connect);
					connect.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Done","Added to the DB",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					connect.Close();
					total.Clear();
					enterd_amt.Clear();
					bill_list.Items.Clear();
					balence.Clear();
					total_dis.Clear();
					txt_net_dis.Clear();
					txt_net_dis_amt.Clear();
					line_dis_amt.Clear();

					bill bil = new bill();
					bil.Show();
				}
			}
		}

		private void txt_dis_TextChanged(object sender,EventArgs e)
		{

		}

		private void button10_Click(object sender,EventArgs e)
		{
			customer_id();
		}

		private void button4_Click(object sender,EventArgs e)
		{
			MessageBoxButtons btn = MessageBoxButtons.YesNo;
			DialogResult res = MessageBox.Show("Do you want hold the Bill? ","Successfully hold the Bill",btn);
			if (res == DialogResult.Yes)
			{
				try
				{
					string query = "CREATE TABLE [dbo].[" +txt_cus.Text + "]([i_id] [int] NULL,[i_name][varchar](50) NULL,[i_price][float] NULL,[i_qty][int] NULL,[f_price][float] NULL,[total][float] NULL,[dis][float] NULL,[dis_amt][float] NULL,[entered_amt][float] NULL,[balance][float] NULL,[f_dis][float] NULL,[t_id] [int] IDENTITY(1,1) NOT NULL)";
					SqlCommand cmd = new SqlCommand(query,connect);
					connect.Open();
					cmd.ExecuteNonQuery();
					connect.Close();

					string sale_query = "INSERT INTO " + txt_cus.Text + " SELECT [i_id],[i_name],[i_price],[i_qty] ,[f_price],[total],[dis],[dis_amt],[entered_amt],[balance],[f_dis] FROM sales_tb";
					SqlCommand cmd_sale = new SqlCommand(sale_query,connect);
					connect.Open();
					cmd_sale.ExecuteNonQuery();
					connect.Close();
					delete_sales_TB();
					//MessageBox.Show("Bill hold successfully");
					MessageBox.Show("Held bill invoice :"+txt_cus.Text);

					customer_id();
					bill_list.Items.Clear();
					item_code.Clear();
					i_dis.Clear();
					qty_txt.Clear();
					i_price.Clear();
					txt_dis.Clear();
					txt_dis_amt.Clear();
					user_dis.Clear();
					user_dis_amt.Clear();
					full_price.Clear();
					total.Clear();
					balence.Clear();
					total_dis.Clear();
					txt_net_dis.Clear();
					txt_net_dis_amt.Clear();
					line_dis_amt.Clear();

				}
				catch (Exception)
				{
					MessageBox.Show("Already hold this bill");
					customer_id();
				}


			}
			if (res == DialogResult.No)
			{

			}
		}

		private void button11_Click(object sender,EventArgs e)
		{
			txt_recall.Enabled=true;
			txt_recall.Visible = true;
			btnrecall.Enabled = true;
			btnrecall.Visible = true;

		}

		private void btnrecall_Click(object sender,EventArgs e)
		{
			bill_recall_list_loaded();
			txt_recall.Clear();
			txt_recall.Visible = false;
			btnrecall.Visible = false;
		}

        private void item_code_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void i_price_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void i_dis_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void qty_txt_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void txt_dis_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void txt_dis_amt_Layout(object sender, LayoutEventArgs e)
        {
			////
        }

        private void txt_dis_amt_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void user_dis_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void user_dis_amt_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void full_price_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void remove_itm_txt_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void remove_qty_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void enterd_amt_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void total_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void textBox3_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void textBox6_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void textBox5_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void textBox7_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void balence_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void txt_net_dis_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;

		}

        private void txt_net_dis_amt_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void line_dis_amt_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

        private void total_dis_Enter(object sender, EventArgs e)
        {
			focusedTextbox = (TextBox)sender;
		}

		private void button14_Click(object sender,EventArgs e)
		{
			lbl_loyal.Visible = true;
			txt_loyal.Visible = true;
			txt_loyal_amt.Visible = true;
			lbl_loyal_amt.Visible = true;
			btn_loyal.Visible = true;
		}

		private void btn_loyal_Click(object sender,EventArgs e)
		{
			if (txt_loyal.Text == "")
			{
				MessageBox.Show("Please enter loyalty card number");
			}
			else
			{
				try
				{
					float tot = float.Parse(total.Text);
					float points = tot / 1000;
					txt_loyal_amt.Text = Convert.ToString(points);
					string loyal_query = "UPDATE loyalty_cus_tb SET points=points+'" +points+ "' WHERE c_id='" + txt_loyal.Text + "' ";
					SqlCommand cmd_loyal = new SqlCommand(loyal_query,connect);
					connect.Open();
					cmd_loyal.ExecuteNonQuery();
					connect.Close();

					MessageBox.Show("Points :"+points);

					txt_loyal.Clear();
					txt_loyal_amt.Clear();

					lbl_loyal.Visible = false;
					txt_loyal.Visible = false;
					txt_loyal_amt.Visible = false;
					lbl_loyal_amt.Visible = false;
					btn_loyal.Visible = false;

				}
				catch (Exception)
				{
					MessageBox.Show("Card number is wrong");
					txt_loyal.Clear();
					txt_loyal_amt.Clear();

					lbl_loyal.Visible = false;
					txt_loyal.Visible = false;
					txt_loyal_amt.Visible = false;
					lbl_loyal_amt.Visible = false;
					btn_loyal.Visible = false;
				}
			}
		}

		private void button29_Click(object sender,EventArgs e)
		{

				voucher v = new voucher();
				v.Show();

		}

		private void button17_Click(object sender,EventArgs e)
		{
			if (txt_v_id.Text == "")
			{
				MessageBox.Show("Please Enter voucher id");
			}
			else
			{
				try
				{
					string query = "select * from voucher  WHERE v_id = '" + txt_v_id.Text + "'";
					SqlCommand select_id = new SqlCommand(query, connect);
					connect.Open();
					SqlDataReader reader = select_id.ExecuteReader();
					reader.Read();
					string amt = Convert.ToString(reader["v_amt"]);
					txt_v_amt.Text = amt;
					enterd_amt.Text = amt;
				}
				catch (Exception)
				{
					MessageBox.Show("Please select correct Voucher ID");
				}

			}

		}

		private void txt_v_amt_TextChanged(object sender,EventArgs e)
		{
			if(total.Text!="")
			{
				try
				{
					float vou = float.Parse(txt_v_amt.Text);
					float tot = float.Parse(total.Text);
					if (vou > tot)
					{
						MessageBox.Show("Voucher is grater that total");
						float max_g_tot = vou - tot;
						balence.Text = Convert.ToString(max_g_tot);
					}
					else
					{
						float g_tot = tot - vou;
						balence.Text = Convert.ToString(g_tot);
					}

					MessageBox.Show("Done");
					txt_v_amt.Clear();
					txt_v_id.Clear();
					lbl_v.Visible = false;
					lbl_v_amt.Visible = false;
					btn_v.Visible = false;
					txt_v_amt.Visible = false;
					txt_v_id.Visible = false;

				}
				catch(Exception)
				{
					txt_v_amt.Clear();
					txt_v_id.Clear();
				}

			}
		}

        private void bill_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
			try
			{
				if (bill_list.SelectedItems.Count == 0)
					return;

				ListViewItem item = bill_list.SelectedItems[0];

				remove_itm_txt.Text = item.Text;
			}
			catch(Exception ex1)
			{ }
		}

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void touchControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
