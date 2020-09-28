using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;

namespace NetCoreApp.Controllers
{
	public class CustomerController : Microsoft.AspNetCore.Mvc.Controller
	{

		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Controller = "Customer";
			ViewBag.AddMethod = "Add";
			ViewBag.EditMethod = "Edit";
			ViewBag.DeleteMethod = "Delete";

			ViewBag.Data = Customer.Get();

			return View();
		}

		public IActionResult Add(string name, string code)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			Customer.Insert(name);
			return RedirectToAction("Index", "Customer", null);
		}

		public IActionResult Edit(string id, string name)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			Customer.Update(id, name);
			return RedirectToAction("Index", "Customer", null);
		}

		public IActionResult Delete(string id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			Customer.Delete(id);
			return RedirectToAction("Index", "Customer", null);
		}

	}
}
