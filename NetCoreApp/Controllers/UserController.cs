using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Security;
using NetCoreApp.Models;

namespace NetCoreApp.Controllers
{
	public class UserController : Microsoft.AspNetCore.Mvc.Controller, IController
	{
		public void Credentials()
		{
			throw new NotImplementedException();
		}

		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.AddMethod = "AddUser";
			ViewBag.EditMethod = "EditUser";
			ViewBag.DeleteMethod = "DeleteUser";

			ViewBag.Data = NetCoreApp.Models.User.GetUsers();

			return View();
		}

		public IActionResult AddUser(string firstName, string middleName, string lastName, string email)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

		}

	}
}
