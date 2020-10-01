using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;

namespace NetCoreApp.Controllers
{
	public class TruckController : Microsoft.AspNetCore.Mvc.Controller
	{

		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Controller = "Truck";
			ViewBag.AddMethod = "Add";
			ViewBag.EditMethod = "Edit";
			ViewBag.DeleteMethod = "Delete";

			ViewBag.Data = Truck.Get();

			return View();
		}

		public IActionResult Add(string model, string plates, string reference)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Truck.Insert(model, plates, reference);

			return RedirectToAction("Index", "Truck", null);
		}

		public IActionResult Edit(string id, string model, string plates, string reference)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Truck.Update(id, model, plates, reference);

			return RedirectToAction("Index", "Truck", null);
		}

		public IActionResult Delete(string id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Truck.Delete(id);

			return RedirectToAction("Index", "Truck", null);
		}
	}
}
