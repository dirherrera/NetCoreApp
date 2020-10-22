using System;
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

		public static Customer Get(Guid id)
		{
			string query = $"Select * From [Customer] Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Customer>(table)[0];
		}

		public static List<Customer> Like(string like)
		{
			string squery = $"Select Top 10 * From [Customer] Where Name LIKE '%{like}%'";
			DataTable table = DataAccess.Fill(squery);
			List<Customer> customers = DataTableAdapter.Get<Customer>(table);
			return customers;
		}

		public static void Insert(string name)
		{
			string query = $"Insert Into [Customer] Values (default, '{name}')";
			DataAccess.Exec(query);
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

		public static bool Exist(Guid id)
		{
			string query = $"Select Count(*) From [Customer] Where ID = '{id}'";
			return (DataAccess.Find(query) > 0);
		}

	}
}
