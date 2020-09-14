using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using NetCoreApp.Models;

namespace NetCoreApp.Models
{
	public partial class User
	{

		public List<User> GetUsers()
		{
			List<User> Users = new List<User>();
			string query = "Select [ID],[Username],[Password],[FirstName],[MiddleName],[LastName],[Email],[Created],[Modified],[Status] From [User]";
			DataTable table = DataAccess.Fill(query);
			Users = DataTableAdapter.Get<User>(table);
			return Users;
		}

	}
}
