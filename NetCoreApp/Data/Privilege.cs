using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class Privilege
	{

		public static List<Privilege> GetPrivileges()
		{
			string query = "Select * From [Privilege]";
			DataTable table = DataAccess.Fill(query);
			List<Privilege> privileges = DataTableAdapter.Get<Privilege>(table);
			return privileges;
		}

		public static void InsertPrivilege(string name)
		{
			string query = $"Insert Into [Privilege] values (default,'{name}')";
			DataAccess.Exec(query);
		}

		public static void UpdatePrivilege(string id, string name)
		{
			string query = $"Update [Privilege] Set [Name] = '{name}' Where [ID] = '{id}'";
			DataAccess.Exec(query);
		}

		public static void DeletePrivilege(string id)
		{
			string query = $"Delete From [Privilege] Where [ID] = '{id}'";
			//DataAccess.Exec(query);
		}

	}
}
