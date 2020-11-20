using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public class DataTablesJson
	{

		public int draw = 1;
		public int recordsTotal { get; set; }
		public int recordsFiltered { get; set; }
		public object data { get; set; }


	}
}
