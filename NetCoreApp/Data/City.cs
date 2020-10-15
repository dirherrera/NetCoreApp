using System;
using System.Collections.Generic;
using System.Data;


namespace NetCoreApp.Models
{
	public partial class City
	{

		public static List<City> Get()
		{
			string query = $"Select * From [City]";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<City>(table);
		}

		public static City Get(Guid id)
		{
			string query = $"Select * From [City] Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<City>(table)[0];
		}

		public static void Insert(string name, Guid state)
		{
			string query = $"Insert Into [City] Values (default, '{state}', '{name}')";
			DataAccess.Exec(query);
		}

		public static void Update(Guid id, string name, Guid state)
		{
			string query = $"Update [City] Set Name = '{name}', State = '{state}' Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static void Delete(Guid id)
		{
			string query = $"Delete From [City] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

	}
}
