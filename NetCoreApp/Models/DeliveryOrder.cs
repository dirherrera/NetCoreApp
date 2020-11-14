using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class DeliveryOrder
	{

		public Guid ID { get; set; }
		public string WO { get; set; }
		public string Reference { get; set; }
		public Guid Customer { get; set; }
		public Guid Vessel { get; set; }
		public Guid Container { get; set; }
		public string BL { get; set; }
		public string Weight { get; set; }
		public DateTime ArrivalDate { get; set; }
		public string Origin { get; set; }
		public string Destination { get; set; }
		public DateTime Created { get; set; }
		
	}
}
