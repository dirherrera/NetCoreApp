using System.Collections.Generic;
using System.Data;

namespace NetCoreApp.Models
{
	public partial class Truck
	{

		public static List<Truck> Get()
		{
			string query = $"Select * From [Truck]";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Truck>(table);
		}

		public static Truck Get(string id)
		{
			string query = $"Select * From [Truck] Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Truck>(table)[0];
		}

		public static void Insert(string model, string plates, string reference)
		{
			if (!Exist(model))
			{
				string query = $"Insert Into [Truck] Values (default, '{model}', '{plates}', '{reference}')";
				DataAccess.Exec(query);
			}
		}

		public static void Update(string id, string model, string plates, string reference)
		{
			string query = $"Update [Truck] Set Model = '{model}', Plates = '{plates}', Reference = '{reference}' Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static void Delete(string id)
		{
			string query = $"Delete From [Truck] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static bool Exist(string model)
		{
			string query = $"Select * From [Truck] Where Model = '{model}'";
			return (DataAccess.Find(query) > 0);
		}

	}
}
