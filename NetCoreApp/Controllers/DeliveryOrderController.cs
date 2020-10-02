using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;
using System;

namespace NetCoreApp.Controllers
{
	public class DeliveryOrderController : Microsoft.AspNetCore.Mvc.Controller
	{

		public IActionResult Index(DeliveryOrder deliverOrder)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Controller = "DeliveryOrder";
			ViewBag.AddMethod = "Add";
			ViewBag.EditMethod = "Edit";
			ViewBag.DeleteMethod = "Delete";
			ViewBag.DeliveryOrder = deliverOrder;
			ViewBag.Message = (deliverOrder != null) ? "Reference is in use" : "";

			ViewBag.Data = DeliveryOrder.Get();
			ViewBag.Customers = Customer.Get();
			ViewBag.Vessels = Vessel.Get();
			ViewBag.Containers = Container.Get();

			return View();
		}

		public IActionResult Add(string reference, Guid customer, Guid vessel, Guid container, string weight, string arrivalDate, string arrivalTime)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			DeliveryOrder deliverOrder = new DeliveryOrder();
			deliverOrder.Reference = reference;
			deliverOrder.Customer = customer;
			deliverOrder.Vessel = vessel;
			deliverOrder.Container = container;
			deliverOrder.Weight = weight;
			DateTime date;
			DateTime.TryParse(arrivalDate + " " + arrivalTime, out date);
			deliverOrder.ArrivalDate = date;

			if (DeliveryOrder.Duplicate(reference))
				return RedirectToAction("Index", "DeliveryOrder", deliverOrder);

			bool bCustomer = Customer.Exist(customer);
			bool bVessel = Vessel.Exist(vessel);
			bool bContainer = Container.Exist(container);

			if (bCustomer && bVessel && bContainer)
				DeliveryOrder.Insert(reference, customer, vessel, container, weight, arrivalDate + " " + arrivalTime);
			else
				return RedirectToAction("Index", "DeliveryOrder", 2);

			return RedirectToAction("Index", "DeliveryOrder", null);
		}

		public IActionResult Edit(string id, string reference, Guid customer, Guid vessel, Guid container, string weight, string arrivalDate, string arrivalTime)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			DeliveryOrder.Edit(id, reference, customer, vessel, container, weight, arrivalDate + " " + arrivalTime);

			return RedirectToAction("Index", "DeliveryOrder", null);
		}

		public IActionResult Delete(Guid id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			DeliveryOrder.Delete(id);

			return RedirectToAction("Index", "DeliveryOrder", null);
		}

	}
}
