using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp.Models
{
	public partial class User
	{

		public static List<User> GetUsers()
		{
			List<User> Users = new List<User>();
			string query = "Select [ID],[Username],[Password],[FirstName],[MiddleName],[LastName],[Email],[Created],[Modified],[Status] From [User]";
			DataTable table = DataAccess.Fill(query);
			Users = DataTableAdapter.Get<User>(table);
			return Users;
		}

		public static User Login(string Username, string Password)
		{
			User user = new User();
			string query = $"Select * From [User] Where [Username] = '{Username}' And [Password] = '{Password}'";
			DataTable table = DataAccess.Fill(query);
			user = DataTableAdapter.Get<User>(table).First<User>();
			return user;
		}

	}
}
