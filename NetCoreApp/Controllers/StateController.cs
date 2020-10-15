using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;
using System;

namespace NetCoreApp.Controllers
{
	public class StateController : Microsoft.AspNetCore.Mvc.Controller
	{

		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Controller = "State";
			ViewBag.AddMethod = "Add";
			ViewBag.EditMethod = "Edit";
			ViewBag.DeleteMethod = "Delete";

			ViewBag.Data = State.Get();

			ViewBag.Countries = Country.Get();

			return View();
		}

		public IActionResult Add(string name, Guid country, string code)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			State.Insert(name, country, code);

			return RedirectToAction("Index", "State", null);
		}

		public IActionResult Edit(Guid id, string name, Guid country, string code)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			State.Update(id, name, country, code);

			return RedirectToAction("Index", "State", null);
		}

		public IActionResult Delete(Guid id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			State.Delete(id);

			return RedirectToAction("Index", "State", null);
		}

	}
}
