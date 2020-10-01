using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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

		public static void Insert(string username, string password, string firstName, string middleName, string lastName, string email)
		{
			if (!Exist(username))
			{
				string query = $"Insert Into [User] Values (default, '{username}', '{password}', '{firstName}', " +
					$"'{middleName}', '{lastName}', '{email}', GETDATE(), null, '201551a1-00e0-48fc-9b79-583d3c3e10db')";
				DataAccess.Exec(query);
			}
		}

		public static void Update(string id, string username, string password, string firstName, string middleName, string lastName, string email)
		{
			if (Exist(username))
			{
				string query = $"Update [User] Set Username = '{username}', Password = '{password}', FirstName = '{firstName}', " +
					$"MiddleName = '{middleName}', LastName = '{lastName}', Email = '{email}', Modified = GETDATE() " +
					$"Where ID = '{id}'";
				DataAccess.Exec(query);
			}
		}

		public static void Delete(string id)
		{
			string query = $"Delete From [User] Where ID = '{id}'";
			DataAccess.Exec(query);
		}

		public static bool Exist(string username)
		{
			string query = $"SELECT * FROM [User] WHERE Username = '{username}'";
			return (DataAccess.Find(query) > 0);
		}

	}
}
