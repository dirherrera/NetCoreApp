using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public class User
	{
		public Guid ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
		public Guid Status { get; set; }
	}
}
