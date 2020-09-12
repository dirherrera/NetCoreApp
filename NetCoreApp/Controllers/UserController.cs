using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Security;

namespace NetCoreApp.Controllers
{
	public class UserController : Controller, IController
	{
		public void Credentials()
		{
			throw new NotImplementedException();
		}

		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			else
				return View();
		}
	}
}
