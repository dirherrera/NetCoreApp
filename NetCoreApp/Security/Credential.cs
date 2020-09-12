using Microsoft.AspNetCore.Http;
using NetCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.WebPages;

namespace NetCoreApp.Security
{

	public interface ISecure
	{
		
	}

	public class Credential : ISecure
	{
		/***
		 * public properties
		 */

		/***
		 * private properties
		 */

		/***
		 * Contructors
		 */
		public Credential()
		{
			
		}

		/***
		 * public methods
		 */

		/***
		 * private methods
		 */

		/***
		 * Static methods
		 */
		public static bool ValidateUser(HttpContext httpContext)
		{
			bool valid = false;
			return valid;
		}

		public static bool IsLoggedIn(HttpContext httpContext)
		{
			bool valid = false;
			var ID = httpContext.Request.Cookies["_u"];
			if (!ID.IsEmpty())
			{
				string query = $"Select [ID] From [User] Where [ID] = '{ID}'";
				DataTable table = DataAccess.Fill(query);
				List<User> users = DataTableAdapter.Get<User>(table);
				valid = (users.Count > 0);
			}
			return valid;
		}

		public static bool HasPrivileges(HttpContext httpContext)
		{
			bool valid = false;
			return valid;
		}

		public static void CreateSession(HttpContext httpContext, User user)
		{
			httpContext.Response.Cookies.Append("_u", user.ID.ToString(), new CookieOptions()
			{
				Expires = DateTime.Now.AddDays(1),
				Path = "/"
			});
		}
	}
}
