using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class ContainerReport
	{

		public static List<ContainerReport> Get()
		{
			List<ContainerReport> list = new List<ContainerReport>();
			string query = $"Select * From ContainerReport";
			DataTable table = DataAccess.Fill(query);
			list = DataTableAdapter.Get<ContainerReport>(table);
			return list;
		}

	}
}
