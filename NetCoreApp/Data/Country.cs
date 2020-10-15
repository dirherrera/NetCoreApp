using System;
using System.Collections.Generic;
using System.Data;


namespace NetCoreApp.Models
{
	public partial class Country
	{

		public static List<Country> Get()
		{
			string query = $"Select * From [Country]";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Country>(table);
		}

		public static Country Get(Guid id)
		{
			string query = $"Select * From [Country] Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Country>(table)[0];
		}

		public static void Insert(string name)
		{
			string query = $"Insert Into [Country] Values (default, '{name}')";
			DataAccess.Exec(query);
		}

		public static void Update(Guid id, string name)
		{
			string query = $"Update [Country] Set Name = '{name}' Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static void Delete(Guid id)
		{
			string query = $"Delete From [Country] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

	}
}
