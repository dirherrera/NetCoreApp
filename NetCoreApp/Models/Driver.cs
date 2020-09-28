using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class Driver
	{

		public Guid ID { get; set; }
		public string DriverCode { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string Category { get; set; }
		public DateTime CheckIn { get; set; }
		public string Yard { get; set; }

	}
}
