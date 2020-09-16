using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class Data
	{
		public static List<Data> GetDatas()
		{
			List<Data> datas = new List<Data>();
			string query = "Select [ID],[Name],[Description] From [Data] Order By [Name] Asc";
			DataTable table = DataAccess.Fill(query);
			datas = DataTableAdapter.Get<Data>(table);
			return datas;
		}

		public static void InsertData(string Name, string Description)
		{
			string query = $"Insert Into [Data] Values (default, '{Name}','{Description}')";
			DataAccess.Exec(query);
		}

		public static void DeleteData(string ID)
		{
			string query = $"Delete From [Data] Where ID = '{ID}'";
			DataAccess.Exec(query);
		}

		internal static void UpdateData(string ID, string Name, string Description)
		{
			string query = $"Update [Data] Set [Name] = '{Name}', [Description] = '{Description}' WHERE [ID] = '{ID}'";
			DataAccess.Exec(query);
		}

	}
}
