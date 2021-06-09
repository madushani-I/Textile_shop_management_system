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
	public partial class Login: Form
	{
		public Login()
		{
			InitializeComponent();
		}
		SqlConnection connect = new SqlConnection(@"Data Source=THISITHA_KAVIND\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
		int state;
		public int validate_user(string username,string password)
		{
			state = 3;
			string valid = "SELECT * FROM emp_tb WHERE username = '" + username + "' AND password = '" + password + "'";

			connect.Open();
			SqlCommand validate = new SqlCommand(valid,connect);
			SqlDataReader get_state = validate.ExecuteReader();

			while (get_state.Read())
			{
				state = Convert.ToInt32(get_state["state"]);
			}
			connect.Close();
			if (state != 0) { return state; }
			int invalid = 3;
			return invalid;
		}

		private void button1_Click(object sender,EventArgs e)
		{
			if (validate_user(txt_uname.Text, txt_pws.Text) == 1)
			{
				admin_main add = new admin_main();
				add.Show();

				txt_pws.Clear();
				txt_uname.Clear();
			}
			else if (validate_user(txt_uname.Text, txt_pws.Text) == 2)
			{

				string query = "INSERT INTO temp (u_name) VALUES('" + txt_uname.Text + "')";
				SqlCommand cmd = new SqlCommand(query, connect);
				connect.Open();
				cmd.ExecuteNonQuery();
				connect.Close();

				cashier cash = new cashier();
				cash.Show();

				txt_pws.Clear();
				txt_uname.Clear();
			}
			else
			{
				MessageBox.Show("Enter valid usercridentials");
			}

		}

		private void button2_Click(object sender,EventArgs e)
		{
			admin_main cash = new admin_main();
			cash.Show();
		}

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
