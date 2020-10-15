using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;
using System;

namespace NetCoreApp.Controllers
{

	public class CountryController : Microsoft.AspNetCore.Mvc.Controller
	{
		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Controller = "Country";
			ViewBag.AddMethod = "Add";
			ViewBag.EditMethod = "Edit";
			ViewBag.DeleteMethod = "Delete";

			ViewBag.Data = Country.Get();

			return View();
		}

		public IActionResult Add(string name)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Country.Insert(name);

			return RedirectToAction("Index","Country", null);
		}

		public IActionResult Edit(Guid id, string name)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Country.Update(id, name);

			return RedirectToAction("Index", "Country", null);
		}

		public IActionResult Delete(Guid id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Country.Delete(id);

			return RedirectToAction("Index", "Country", null);
		}

	}
}
