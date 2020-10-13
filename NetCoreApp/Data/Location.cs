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

		public static void Insert(string name, string address, Guid country, Guid state, Guid city, string street, string zipcode)
		{
			string query = $"Insert Into [Location] Values (default, '{name}', '{address}', '{country}', '{state}', '{city}', '{street}', '{zipcode}')";
			DataAccess.Exec(query);
		}

		public static void Update(Guid id, string name, string address, Guid country, Guid state, Guid city, string street, string zipcode)
		{
			string query = $"Update [Location] Set Name = '{name}', Address = '{address}', Country = '{country}', " +
				$"State = '{state}', City = '{city}', Street = '{street}', ZipCode = '{zipcode}' Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static void Delete(Guid id)
		{
			string query = $"Delete From [Location] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

	}
}
