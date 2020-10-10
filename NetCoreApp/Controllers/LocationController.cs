using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;
using System;

namespace NetCoreApp.Controllers
{
	public class LocationController : Microsoft.AspNetCore.Mvc.Controller
	{

		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Controller = "Location";
			ViewBag.AddMethod = "Add";
			ViewBag.EditMethod = "Edit";
			ViewBag.DeleteMethod = "Delete";

			ViewBag.Data = Location.Get();
			ViewBag.Countries = Country.Get();
			ViewBag.States = State.Get();
			ViewBag.Cities = City.Get();

			return View();
		}

		public IActionResult Add(string name, string address, Guid country, Guid state, Guid city, string street, string zipcode)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);



			return RedirectToAction("Index", "Location", null);
		}

	}
}
