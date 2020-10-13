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

			Location.Insert(name, address, country, state, city, street, zipcode);

			return RedirectToAction("Index", "Location", null);
		}

		public IActionResult Edit(Guid id, string name, string address, Guid country, Guid state, Guid city, string street, string zipcode)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Location.Update(id, name, address, country, state, city, street, zipcode);

			return RedirectToAction("Index", "Location", null);

		}

		public IActionResult Delete(Guid id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Location.Delete(id);

			return RedirectToAction("Index", "Location", null);

		}

	}
}
