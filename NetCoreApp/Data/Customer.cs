using System.Collections.Generic;
using System.Data;

namespace NetCoreApp.Models
{
	public partial class Customer
	{

		public static List<Customer> Get()
		{
			string query = $"Select * From Customer";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Customer>(table);
		}

		public static Customer Get(string id)
		{
			string query = $"Select * From [Customer] Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Customer>(table)[0];
		}

		public static void Insert(string name)
		{
			if (!Exist(name))
			{
				string query = $"Insert Into [Customer] Values (default, '{name}')";
				DataAccess.Exec(query);
			}
		}

		public static void Update(string id, string name)
		{
			string query = $"Update [Customer] Set Name = '{name}' Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static void Delete(string id)
		{
			string query = $"Delete From [Customer] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static bool Exist(string name)
		{
			string query = $"Select * From [Customer] Where Name = '{name}'";
			return (DataAccess.Exec(query) > 0);
		}

	}
}
