using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;

namespace NetCoreApp.Controllers
{
	public class DeliveryOrderController : Microsoft.AspNetCore.Mvc.Controller
	{

		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Controller = "Vessel";
			ViewBag.AddMethod = "Add";
			ViewBag.EditMethod = "Edit";
			ViewBag.DeleteMethod = "Delete";

			ViewBag.Data = Container.Get();
			ViewBag.Customers = Customer.Get();
			ViewBag.Vessels = Vessel.Get();
			ViewBag.Containers = Container.Get();

			return View();
		}

		public IActionResult Add(string reference, string customer, string vessel, string container, string weight, string date, string time)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			
			

			return RedirectToAction("Index", "DeliveryOrder", null);
		}

		public IActionResult Edit(string id, string reference, string customer, string vessel, string container, string weight, string date, string time)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			
			return RedirectToAction("Index", "DeliveryOrder", null);
		}

		public IActionResult Delete(string id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);
			
			return RedirectToAction("Index", "DeliveryOrder", null);
		}

	}
}
