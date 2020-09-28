using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Security;
using NetCoreApp.Models;
using NetCoreApp.App_Code;

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

		public IActionResult AddUser(string username, string password, string firstName, string middleName, string lastName, string email)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			password = MD5.Encrypt(password);

			NetCoreApp.Models.User.Insert(username, password, firstName, middleName, lastName, email);

			return RedirectToAction("Index", "User", null);
		}

		public IActionResult EditUser(string id, string username, string password, string firstName, string middleName, string lastName, string email)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			password = MD5.Encrypt(password);

			NetCoreApp.Models.User.Update(id, username, password, firstName, middleName, lastName, email);

			return RedirectToAction("Index", "User", null);
		}

		public IActionResult DeleteUser(string id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			NetCoreApp.Models.User.Delete(id);

			return RedirectToAction("Index", "User", null);
		}

	}
}
