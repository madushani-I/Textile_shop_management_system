using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPPM
{
	class connection
	{
		public static SqlConnection connect = null;
		public void db_connect()
		{
			connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");
			connect.Open();
		}

	}
}
