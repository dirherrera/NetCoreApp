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

		public static void Insert(string name, string address, Guid country, Guid state, Guid city, string street, string zipcode)
		{
			string query = $"Insert Into [State] Values (default, '{name}', '{address}', '{country}', '{state}', '{city}', '{street}', '{zipcode}')";
			DataAccess.Exec(query);
		}



	}
}
