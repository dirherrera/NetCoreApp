using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp
{
	public class DataAccess
	{
		
		public static string connString = @"Data source=LGAOFF2\SQLSERVER;Initial Catalog=ProjectManagerWeb;User ID=sa;Password=Nevermind10.1;";

		public static DataTable Fill(string query)
		{
			DataTable table;
			using (SqlConnection conn = new SqlConnection(connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataSet data = new DataSet();
					adapter.Fill(data);
					table = data.Tables[0];
				}
			}
			return table;
		}

	}
}
