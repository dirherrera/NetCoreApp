using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public class WorkOrder
	{

		private DeliveryOrder _deliveryOrder;

		public Guid ID { get; set; }
		public string Reference { get; set; }
		public DeliveryOrder DeliveryOrder { get; set; }
		public Customer Customer { get; set; }
		public Vessel Vessel { get; set; }
		public Container Container { get; set; }
		public string Weight { get; set; }
		public DateTime ArrivalDate { get; set; }
		public DateTime Created { get; set; }

	}
}
