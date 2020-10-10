using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class State
	{

		public Guid ID { get; set; }
		public Guid Country { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }

	}
}
