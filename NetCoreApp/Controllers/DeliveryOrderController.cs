using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;
using System;
using System.Collections.Generic;
using System.Web.Helpers;

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

		public string DeliveryOrderGrid(int page, int size)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return "{}";
			List<DeliveryOrder> result = DeliveryOrder.Filter();
			return Newtonsoft.Json.JsonConvert.SerializeObject(result);
		}

		public IActionResult Add(string wo, string reference, Guid customer, Guid vessel, Guid container, string weight, string arrivalDate, string arrivalTime, string origin, string destination)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			DeliveryOrder deliveryOrder = new DeliveryOrder();
			deliveryOrder.WO = wo;
			deliveryOrder.Reference = reference;
			deliveryOrder.Customer = customer;
			deliveryOrder.Vessel = vessel;
			deliveryOrder.Container = container;
			deliveryOrder.Weight = weight;
			DateTime date;
			DateTime.TryParse(arrivalDate + " " + arrivalTime, out date);
			deliveryOrder.ArrivalDate = date;
			deliveryOrder.Origin = origin;
			deliveryOrder.Destination = destination;

			if (DeliveryOrder.Duplicate(reference))
				return RedirectToAction("Index", "DeliveryOrder", deliveryOrder);

			bool bCustomer = Customer.Exist(customer);
			bool bVessel = Vessel.Exist(vessel);
			bool bContainer = Container.Exist(container);

			if (bCustomer && bVessel && bContainer)
				DeliveryOrder.Insert(wo, reference, customer, vessel, container, weight, arrivalDate + " " + arrivalTime, origin, destination);
			else
				return RedirectToAction("Index", "DeliveryOrder", 2);

			return RedirectToAction("Index", "DeliveryOrder", null);
		}

		public IActionResult Edit(string id, string wo, string reference, Guid customer, Guid vessel, Guid container, string weight, string arrivalDate, string arrivalTime, string origin, string destination)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			DeliveryOrder.Edit(id, wo, reference, customer, vessel, container, weight, arrivalDate + " " + arrivalTime, origin, destination);

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
