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

	}
}
