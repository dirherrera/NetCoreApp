using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public class Logs
	{

		public Guid ID { get; set; }
		public Guid Action { get; set; }
		public Guid Data { get; set; }
		public System.DateTime Date { get; set; }

	}
}
