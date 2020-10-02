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
		public Guid Country { get; set; }
		public Guid State { get; set; }
		public Guid City { get; set; }
		public string Street { get; set; }
		public string ZipCode { get; set; }

	}
}
