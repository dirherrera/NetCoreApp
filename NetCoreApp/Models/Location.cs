using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class Location
	{
		public Guid ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }

	}
}
