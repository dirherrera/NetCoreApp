using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public class Notification
	{

		public Guid ID { get; set; }
		public string Description { get; set; }
		public Guid Group { get; set; }
		public System.DateTime Created { get; set; }
		public int Resends { get; set; }
		public System.DateTime Resended { get; set; }
		public Guid Origin { get; set; }

	}
}
