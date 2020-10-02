using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class City
	{

		public Guid ID { get; set; }
		public Guid State { get; set; }
		public string Name { get; set; }
	}
}
