using System.Collections.Generic;
using System.Data;

namespace NetCoreApp.Models
{
	public partial class Vessel
	{

		public static List<Vessel> Get()
		{
			string query = $"Select * From [Vessel]";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Vessel>(table);
		}

		public static Vessel Get(string id)
		{
			string query = $"Select * From [Vessel] Where ID = '{id}'";
			DataTable table = DataAccess.Fill(query);
			return DataTableAdapter.Get<Vessel>(table)[0];
		}

		public static void Insert(string name, string code)
		{
			if (!Exist(name))
			{
				string query = $"Insert Into [Vessel] Values (default, '{name}', '{code}')";
				DataAccess.Exec(query);
			}
		}

		public static void Update(string id, string name, string code)
		{
			string query = $"Update [Vessel] Set Name = '{name}', Code = '{code}' Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static void Delete(string id)
		{
			string query = $"Delete From [Vessel] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static bool Exist(string name)
		{
			string query = $"Select * From [Vessel] Where Name = '{name}'";
			return (DataAccess.Exec(query) > 0);
		}

	}
}
