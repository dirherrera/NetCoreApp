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

	}
}
