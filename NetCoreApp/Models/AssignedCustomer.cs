using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public class AssignedCustomer
	{

		public List<Customer> assign { get; set; }
		public List<Customer> unassign { get; set; }

	}
}
