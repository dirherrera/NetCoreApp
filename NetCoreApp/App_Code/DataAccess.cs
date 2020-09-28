using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
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
		
		public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\DataBase\App_Data\Database.mdf"";Integrated Security=True";

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
				conn.Close();
			}
			return table;
		}

		public static int Exec(string query)
		{
			int rows = 0;
			using (SqlConnection conn = new SqlConnection(connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					rows = cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			return rows;
		}

	}
}
