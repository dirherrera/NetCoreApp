using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class Truck
	{

		public Guid ID { get; set; }
		public string Model { get; set; }
		public string Plates { get; set; }
		public string Reference { get; set; }

	}
}
