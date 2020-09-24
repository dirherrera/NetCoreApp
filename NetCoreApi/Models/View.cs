using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public class View
	{

		public Guid ID { get; set; }
		public string Name { get; set; }
		public Guid Controller { get; set; }
		public Guid Satatus { get; set; }

	}
}
