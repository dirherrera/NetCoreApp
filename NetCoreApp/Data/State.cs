using System;
using System.Collections.Generic;
using System.Data;

namespace NetCoreApp.Models
{
	public partial class State
	{

		public static List<State> Get()
		{
			string query = $"Select * From [State]";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<State>(table);
		}

		public static void Insert(string name, Guid country, string code)
		{
			string query = $"Insert Into [State] Values (default, '{name}',  '{country}',  '{code}')";
			DataAccess.Exec(query);
		}

		public static void Update(Guid id, string name, Guid country, string code)
		{
			string query = $"Update [State] Set Name = '{name}', Country = '{country}', Code = '{code}' Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static void Delete(Guid id)
		{
			string query = $"Delete From [State] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

	}
}
