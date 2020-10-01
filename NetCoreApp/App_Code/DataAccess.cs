using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp
{
	public class DataAccess
	{
		
		public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Programador 2\Documents\David Ramos\Poyectos\NetCoreApp\DataBase\App_Data\Database.mdf"";Integrated Security=True";

		public static DataTable Fill(string query)
		{
			var path = Directory.GetCurrentDirectory().Replace("NetCoreApp\\NetCoreApp\\", "NetCoreApp\\DataBase\\");
			//connString = connString.Replace("[PATH]", path).Replace(@"\\",@"\");
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

		public static void Exec(string query)
		{
			using (SqlConnection conn = new SqlConnection(connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static int Find(string query)
		{
			int rows = 0;
			using (SqlConnection conn = new SqlConnection(connString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					rows = (int)cmd.ExecuteScalar();
				}
				conn.Close();
			}
			return rows;
		}
		
	}
}
