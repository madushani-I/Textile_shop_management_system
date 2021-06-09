using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SPPM
{
	public partial class admin_main: Form
	{
		SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
		string im_loc = "";
		string item_code;
		string id;



		public void items_list_load()
		{
			//added_item_list_view item tab item list loader
			try
			{
				added_item_list_view.View = View.Details;
				added_item_list_view.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from item_tb",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["i_code"].ToString());
					listitem.SubItems.Add(dr["pos_description"].ToString());
					listitem.SubItems.Add(dr["sell_price"].ToString());
					listitem.SubItems.Add(dr["i_id"].ToString());
					added_item_list_view.Items.Add(listitem);
				}

				added_item_list_view.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error","Error with loading data into item list1",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}
			//add stock item list loader
			try
			{
				stock_item_load_list.View = View.Details;
				stock_item_load_list.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from item_tb",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["i_code"].ToString());
					listitem.SubItems.Add(dr["pos_description"].ToString());
					listitem.SubItems.Add(dr["sell_price"].ToString());
					listitem.SubItems.Add(dr["max_dis_amt"].ToString());
					listitem.SubItems.Add(dr["re_or_amt"].ToString());
					stock_item_load_list.Items.Add(listitem);
				}

				stock_item_load_list.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error","Error with loading data into item list2",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}
		}
		public void load_supliers()
		{
			//load supllier list in item add tab
			try
			{
				suplier_list_view.View = View.Details;
				suplier_list_view.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from suplier_tb",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["s_id"].ToString());
					listitem.SubItems.Add(dr["s_name"].ToString());
					listitem.SubItems.Add(dr["s_contact"].ToString());
					listitem.SubItems.Add(dr["s_email"].ToString());
					suplier_list_view.Items.Add(listitem);
				}

				suplier_list_view.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error","Error with loading data into item list3",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}
			//load suplier list in addnin new suplier
			try
			{
				suplier_add_list_view.View = View.Details;
				suplier_add_list_view.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from suplier_tb",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["s_id"].ToString());
					listitem.SubItems.Add(dr["s_name"].ToString());
					listitem.SubItems.Add(dr["s_contact"].ToString());
					listitem.SubItems.Add(dr["s_email"].ToString());
					suplier_add_list_view.Items.Add(listitem);
				}

				suplier_add_list_view.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error","Error with loading data into item list4",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}

			//loading supliers in stock tab
			try
			{
				stock_suplier_load_list.View = View.Details;
				stock_suplier_load_list.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from suplier_tb",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["s_id"].ToString());
					listitem.SubItems.Add(dr["s_name"].ToString());
					listitem.SubItems.Add(dr["s_email"].ToString());
					stock_suplier_load_list.Items.Add(listitem);
				}

				stock_suplier_load_list.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error","Error with loading data into item list5",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}
		}
		public void load_emp_list()
		{
			//	 load employee details into add_employee tab
			try
			{
				listView1.View = View.Details;
				listView1.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from emp_tb",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["E_id"].ToString());
					listitem.SubItems.Add(dr["name"].ToString());
					listitem.SubItems.Add(dr["contact"].ToString());
					listitem.SubItems.Add(dr["role"].ToString());
					listView1.Items.Add(listitem);
				}

				listView1.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error with load employee details6","**Error**",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}

			//	 load employee details into credentials tab
			try
			{
				edit_emp_credential_load_emp_list.View = View.Details;
				edit_emp_credential_load_emp_list.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from emp_tb",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["E_id"].ToString());
					listitem.SubItems.Add(dr["name"].ToString());
					listitem.SubItems.Add(dr["contact"].ToString());
					listitem.SubItems.Add(dr["email"].ToString());
					listitem.SubItems.Add(dr["role"].ToString());
					edit_emp_credential_load_emp_list.Items.Add(listitem);
				}

				edit_emp_credential_load_emp_list.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error with load employee details7","**Error**",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}
		}
		public void load_loylty_customers()
		{
			try
			{
				load_loyalty_cus_list.View = View.Details;
				load_loyalty_cus_list.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from loyalty_cus_tb",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["c_id"].ToString());
					listitem.SubItems.Add(dr["c_name"].ToString());
					listitem.SubItems.Add(dr["c_con"].ToString());
					listitem.SubItems.Add(dr["max_dis"].ToString());
					listitem.SubItems.Add(dr["c_id_no"].ToString());
					load_loyalty_cus_list.Items.Add(listitem);
				}

				load_loyalty_cus_list.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error with load employee details8","**Error**",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}
		}
		public admin_main()
		{
			InitializeComponent();
			//Load Items Into list
			items_list_load();
			load_supliers();
			load_emp_list();
			load_loylty_customers();

		}


		private void button7_Click(object sender,EventArgs e)
		{
			if (i_des.Text == "" || p_des.Text == "" || sup_sell.Text == "" || cost_price.Text == "" || mark_up.Text == "" || sell_price.Text == "" || max_dis.Text == "" || max_dis_amt.Text == "" || txt_isbn.Text == "" || suplier.Text == "" || re_or_lvl.Text == "" || re_or_amt.Text == "" ||ord_qty.Text=="")
			{
				MessageBox.Show("Error","Fill all the deatils ",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					string query = "INSERT INTO item_tb (i_code,i_desription,pos_description,sup_selling,c_price,mark,sell_price,max_dis,max_dis_amt,ISBN,suplier,re_or_lvl,re_or_amt,i_qty) VALUES('" + i_code.Text + "','" + i_des.Text + "','" + p_des.Text + "','" + sup_sell.Text + "','" + cost_price.Text + "','" + mark_up.Text + "','" + sell_price.Text + "','" + max_dis.Text + "','" + max_dis_amt.Text + "','" + txt_isbn.Text + "','" + suplier.Text + "','" + re_or_lvl.Text + "','" + re_or_amt.Text + "','"+ord_qty.Text+"')";
					SqlCommand cmd = new SqlCommand(query,connect);
					connect.Open();
					cmd.ExecuteNonQuery();
					//MessageBox.Show("Done","Items Are Added to the Database ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					items_list_load();
					i_code.Clear(); i_des.Clear(); p_des.Clear(); sup_sell.Clear(); cost_price.Clear(); mark_up.Clear(); sell_price.Clear(); max_dis.Clear(); max_dis_amt.Clear(); txt_isbn.Clear(); suplier.Clear(); re_or_lvl.Clear(); re_or_amt.Clear();
					connect.Close();



				}
				catch (Exception)
				{

					MessageBox.Show("Error","Items Didn't Add to the Database ",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}


		}
		private bool EmailIsValid(string email)
		{
			string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

			if (Regex.IsMatch(email,expression))
			{
				if (Regex.Replace(email,expression,string.Empty).Length == 0)
				{
					return false;
				}
			}
			return true;
		}
		private void button3_Click(object sender,EventArgs e)
		{//
			if (txt_s_name.Text == "" || txt_s_con.Text == "" || txt_s_email.Text == "" || s_group.Text == "" || s_cat.Text == "" || s_add_1.Text == "" || s_or_cy.Text == "" || s_c_li.Text == "" || s_c_p.Text == "" || deli_methode.Text == "" || s_dis.Text == "" || s_contribution.Text == "" || s_con_per.Text == "")
			{
				MessageBox.Show("Enter all details !!! ");
			}
			else
			{
				if ((EmailIsValid(txt_s_email.Text)))
				{
					MessageBox.Show("Enter valid email address !!! ");
					txt_s_email.Clear();
				}
				else
				{
					string digits = Convert.ToString(txt_s_con.Text);
					int con_digits = digits.ToString().Length;
					if (con_digits == 9)
					{
						MessageBox.Show("Enter valid contact number !!! ");
					}
					else
					{
						try
						{
							connect.Close();
							string query = "INSERT INTO suplier_tb (s_name,s_contact,s_email) VALUES('" + txt_s_name.Text + "','" + txt_s_con.Text + "','" + txt_s_email.Text + "' )";
							SqlCommand cmd = new SqlCommand(query,connect);
							connect.Open();
							cmd.ExecuteNonQuery();
							MessageBox.Show("Done","Data Are Added to the Database ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
							txt_s_name.Clear(); txt_s_con.Clear(); txt_s_email.Clear(); s_group.Clear(); s_cat.Clear(); s_add_1.Clear(); s_add_2.Clear(); s_or_cy.Clear(); s_c_li.Clear(); s_c_p.Clear(); deli_methode.Clear();  s_dis.Clear(); s_contribution.Clear(); s_con_per.Clear(); qc_chk.Checked = false; active_chk.Checked = false; pr_chk.Checked = false; pos_dis_chk.Checked = false;
							load_supliers();
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error","Error with adding data into item list",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
							MessageBox.Show(ex.Message);
						}
					}
				}
			}
		}

		private void suplier_TextChanged(object sender,EventArgs e)
		{
			try
			{
				suplier_list_view.View = View.Details;
				suplier_list_view.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from suplier_tb WHERE s_name like '" + suplier.Text + "%' ",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["s_id"].ToString());
					listitem.SubItems.Add(dr["s_name"].ToString());
					listitem.SubItems.Add(dr["s_contact"].ToString());
					listitem.SubItems.Add(dr["s_email"].ToString());
					suplier_list_view.Items.Add(listitem);
				}

				suplier_list_view.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error","Error with loading data into item list9",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}
		}

		private void suplier_list_view_SelectedIndexChanged(object sender,EventArgs e)
		{
			if (suplier_list_view.SelectedItems.Count == 0)
				return;

			ListViewItem s_name = suplier_list_view.SelectedItems[0];
			//fill the text boxes
			suplier.Text = s_name.SubItems[1].Text;
		}

		private void button2_Click(object sender,EventArgs e)
		{
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All files (*.*)|*.*";
				if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					im_loc = dialog.FileName;
					pictureBox1.ImageLocation = im_loc;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("No file has selected","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		string role_combo;
		int state;


		//creating and registering users
		private void button6_Click(object sender,EventArgs e)
		{

			if (checkBox1.Checked)
			{
				role_combo = "Chashier";
				state = 2;
			}
			else if (checkBox2.Checked)
			{
				role_combo = "Admin";
				state = 1;
			}

			if (checkBox1.Checked || checkBox2.Checked)
			{

				if ((name_txt_1.Text == "") || (contact_txt.Text == "") || (email.Text == "") || (user_name.Text == "") || (pass.Text == "") || (c_pass.Text == ""))
				{
					MessageBox.Show("Please fill all details");
				}

				else
				{
					if ((EmailIsValid(email.Text)))
					{
						MessageBox.Show("Enter valid email address !! ");
						email.Clear();
					}
					else
					{
						string digits = Convert.ToString(contact_txt.Text);
						int con_digits = digits.ToString().Length;
						if (con_digits == 10)
						{
							if (pass.Text == c_pass.Text)
							{
								try
								{
									//SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");

									string query = "INSERT INTO emp_tb (name,email,contact,username,password,role,state) VALUES('" + name_txt_1.Text + "','" + email.Text + "','" + contact_txt.Text + "','" + user_name.Text + "','" + pass.Text + "','" + role_combo + "','" + state + "')";
									SqlCommand cmd = new SqlCommand(query,connect);
									connect.Open();
									cmd.ExecuteNonQuery();
									connect.Close();
									MessageBox.Show("Added to the user details","Done",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

									name_txt_1.Clear();
									contact_txt.Clear();
									email.Clear();
									user_name.Clear();
									pass.Clear();
									c_pass.Clear();
									checkBox1.Checked = false;
									checkBox2.Checked = false;

									load_emp_list();

								}

								catch (Exception ex)
								{
									MessageBox.Show("Existing Username, try again !!");
									MessageBox.Show("Please enter valid details .......!");
									user_name.Clear();

								}

							}//password matching

							else
							{

								MessageBox.Show("Re-correct the password");
								pass.Clear();
								c_pass.Clear();

							}

						}
						else
						{
							MessageBox.Show("Please enter the correct contact ");
							contact_txt.Clear();
						}
					}

				}//2nd if else end
			}

		}


		private void checkBox1_CheckedChanged(object sender,EventArgs e)
		{

			if (checkBox1.Checked)
			{
				checkBox2.Enabled = false;
			}
			if (checkBox1.Checked == false)
			{
				checkBox2.Enabled = true;
			}
		}

		private void checkBox2_CheckedChanged(object sender,EventArgs e)
		{

			if (checkBox2.Checked)
			{
				checkBox1.Enabled = false;
			}
			if (checkBox2.Checked == false)
			{
				checkBox1.Enabled = true;
			}
		}


		//update user credentials
		private void button5_Click(object sender,EventArgs e)
		{
			if (id == null)
			{
				MessageBox.Show("Please Select an employee to Update");
			}
			else
			{
				if (e_password.Text != e_c_password.Text)
				{
					MessageBox.Show("Given password is not match");
				}
				else
				{
					try
					{
						string query = "UPDATE emp_tb SET name='" + e_name.Text + "',email='" + e_mail.Text + "',contact='" + e_con.Text + "',username='" + e_uname.Text + "',password='" + e_password.Text + "' WHERE E_id='" + id + "'";
						SqlCommand cmd = new SqlCommand(query,connect);

						connect.Open();
						cmd.ExecuteNonQuery();
						MessageBox.Show("Done","Added to the DB",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
						e_name.Clear();
						e_con.Clear();
						e_c_password.Clear();
						e_mail.Clear();
						e_sts.Clear();
						e_uname.Clear();
						e_password.Clear();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}

		}

		private void edit_emp_credential_load_emp_list_SelectedIndexChanged(object sender,EventArgs e)
		{
			if (edit_emp_credential_load_emp_list.SelectedItems.Count == 0)
				return;

			ListViewItem emp = edit_emp_credential_load_emp_list.SelectedItems[0];
			//fill the text boxes
			id = emp.Text;
			e_name.Text = emp.SubItems[1].Text;
			e_con.Text = emp.SubItems[2].Text;
			e_mail.Text = emp.SubItems[3].Text;
			e_sts.Text = emp.SubItems[4].Text;


		}

		//	 load employee details into credentials ta
		private void e_name_TextChanged(object sender,EventArgs e)
		{
			//	 load employee details into credentials tab
			try
			{
				edit_emp_credential_load_emp_list.View = View.Details;
				edit_emp_credential_load_emp_list.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from emp_tb WHERE name like '" + e_name.Text + "%' ",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["E_id"].ToString());
					listitem.SubItems.Add(dr["name"].ToString());
					listitem.SubItems.Add(dr["contact"].ToString());
					listitem.SubItems.Add(dr["email"].ToString());
					listitem.SubItems.Add(dr["role"].ToString());
					edit_emp_credential_load_emp_list.Items.Add(listitem);
				}

				edit_emp_credential_load_emp_list.Refresh();



			}
			catch (Exception)
			{
				MessageBox.Show("Error with load employee details","**Error**",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}
		}

		private void stock_item_load_list_SelectedIndexChanged(object sender,EventArgs e)
		{
			try
			{
				if (stock_item_load_list.SelectedItems.Count == 0)
					return;

				ListViewItem stock = stock_item_load_list.SelectedItems[0];
				//fill the text boxes
				stk_i_code.Text = stock.Text;
				stk_i_des.Text = stock.SubItems[1].Text;
				stk_c_price.Text = stock.SubItems[2].Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void stk_s_name_TextChanged(object sender,EventArgs e)
		{
			try
			{
				stock_suplier_load_list.View = View.Details;
				stock_suplier_load_list.Items.Clear();

				SqlDataAdapter ada = new SqlDataAdapter("select * from suplier_tb where s_name like '" + stk_s_name.Text + "%' ",connect);
				DataTable dt = new DataTable();
				ada.Fill(dt);

				for (int i = 0;i < dt.Rows.Count;i++)
				{
					DataRow dr = dt.Rows[i];
					ListViewItem listitem = new ListViewItem(dr["s_id"].ToString());
					listitem.SubItems.Add(dr["s_name"].ToString());
					listitem.SubItems.Add(dr["s_email"].ToString());
					stock_suplier_load_list.Items.Add(listitem);
				}

				stock_suplier_load_list.Refresh();



		}
			catch (Exception)
			{
				MessageBox.Show("Error","Error with loading data into item list10",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Asterisk);
			}
}

		private void stock_suplier_load_list_SelectedIndexChanged(object sender,EventArgs e)
		{
			try
			{
				if (stock_suplier_load_list.SelectedItems.Count == 0)
					return;

				ListViewItem stock = stock_suplier_load_list.SelectedItems[0];
				//fill the text boxes
				stk_s_name.Text = stock.SubItems[1].Text;
			}
			catch
			{

			}
		}

		private void button8_Click(object sender,EventArgs e)
		{
			try
			{
				int up_qty = Convert.ToInt32(stk_or_qty.Text);
				string query = "UPDATE item_tb SET max_dis_amt='" + stk_dis_amt.Text + "',re_or_amt=re_or_amt +'" + up_qty + "' WHERE i_code='" + stk_i_code.Text + "'";
				SqlCommand cmd = new SqlCommand(query,connect);

				connect.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Done","Added to the DB",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				connect.Close();
				stk_i_code.Clear();
				stk_i_des.Clear();
				stk_s_name.Clear();
				stk_dis_amt.Clear();
				stk_c_price.Clear();
				stk_or_qty.Clear();
				items_list_load();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button16_Click(object sender,EventArgs e)
		{
			string digits = Convert.ToString(c_con.Text);
			int con_digits = digits.ToString().Length;
			if (con_digits == 10)
			{
				try
				{
					//SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");

					string query = "INSERT INTO loyalty_cus_tb (c_name,max_dis,c_id_no,c_con,c_add,points) VALUES('" + c_name.Text + "','" + c_max_dis.Text + "','" + c_id.Text + "','" + c_con.Text + "','" + c_add.Text + "','0')";
					SqlCommand cmd = new SqlCommand(query,connect);
					connect.Open();
					cmd.ExecuteNonQuery();
					connect.Close();
					MessageBox.Show("Added to the user details","Done",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					load_loylty_customers();
					c_name.Clear();
					c_max_dis.Clear();
					c_id.Clear();
					c_con.Clear();
					c_add.Clear();


				}

				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					MessageBox.Show("Please enter valid details .......!");
					user_name.Clear();
					

				}



			}
			else
			{
				MessageBox.Show("Please enter the correct contact ");
				contact_txt.Clear();
			}

		}

		private void button19_Click(object sender,EventArgs e)
		{
			load_loylty_customers();
			c_name.Clear();
			c_max_dis.Clear();
			c_id.Clear();
			c_con.Clear();
			c_add.Clear();
		}

		private void button18_Click(object sender,EventArgs e)
		{
			stk_i_code.Clear();
			stk_i_des.Clear();
			stk_s_name.Clear();
			stk_dis_amt.Clear();
			stk_c_price.Clear();
			stk_or_qty.Clear();
			items_list_load();
		}

		private void button4_Click(object sender,EventArgs e)
		{
			e_name.Clear();
			e_con.Clear();
			e_c_password.Clear();
			e_mail.Clear();
			e_sts.Clear();
			e_uname.Clear();
			e_password.Clear();
		}

        private void button14_Click(object sender, EventArgs e)
        {
			InventoryReport inv = new InventoryReport();
			inv.Show();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void button25_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void button24_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void button23_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void button22_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void button21_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }
    }
	
}
