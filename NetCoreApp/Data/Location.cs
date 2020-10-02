using System;
using System.Collections.Generic;
using System.Data;


namespace NetCoreApp.Models
{
	public partial class Location
	{

		public static List<Location> Get()
		{
			string query = $"Select * From [Location]";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Location>(table);
		}

	}
}
