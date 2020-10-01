using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;

namespace NetCoreApp.Controllers
{
	public class ContainerController : Microsoft.AspNetCore.Mvc.Controller
	{

		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Controller = "Container";
			ViewBag.AddMethod = "Add";
			ViewBag.EditMethod = "Edit";
			ViewBag.DeleteMethod = "Delete";

			ViewBag.Data = Container.Get();

			return View();
		}

		public IActionResult Add(string name)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			Container.Insert(name);
			return RedirectToAction("Index", "Container", null);
		}

		public IActionResult Edit(string id, string name)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			Container.Update(id, name);
			return RedirectToAction("Index", "Container", null);
		}

		public IActionResult Delete(string id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			Container.Delete(id);
			return RedirectToAction("Index", "Container", null);
		}

	}
}
