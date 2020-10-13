using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;
using System;

namespace NetCoreApp.Controllers
{
	public class CityController : Microsoft.AspNetCore.Mvc.Controller
	{
		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Controller = "City";
			ViewBag.AddMethod = "Add";
			ViewBag.EditMethod = "Edit";
			ViewBag.DeleteMethod = "Delete";

			return View();

		}
	}
}
