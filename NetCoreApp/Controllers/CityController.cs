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

			ViewBag.Data = City.Get();
			ViewBag.States = State.Get();

			return View();
		}

		public IActionResult Add(string name, Guid state)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			City.Insert(name, state);

			return RedirectToAction("Index", "City", null);
		}

		public IActionResult Edit(Guid id, string name, Guid state)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			City.Update(id, name, state);

			return RedirectToAction("Index", "City", null);
		}

		public IActionResult Delete(Guid id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			City.Delete(id);

			return RedirectToAction("Index", "City", null);
		}

	}
}
