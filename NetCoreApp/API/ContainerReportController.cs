using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetCoreApp.API
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContainerReportController : ControllerBase
	{

		[HttpGet("Get")]
		public ActionResult<string> Get()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return "";

			List<ContainerReport> list = ContainerReport.Get();
			List<object> records = ContainerReport.ToArray(list);

			DataTablesJson json = new DataTablesJson();
			json.data = records;
			string result = System.Text.Json.JsonSerializer.Serialize(json);
			return result;
		}

		[HttpPost("Edit")]
		public ActionResult<string> Edit(string id, string wo, string portOfArrival, string vesselLineContainerOwner, string exportReturnPort, string vesselLineName,
			string customer1BillingParty, string destination, string containerNo, string size, string oblBooking, string pierPass, string customerReference,
			string weight, string te, string status, string orderReceivedDate, string vesselArrivalDate, string availableDate, string lastFreeDate,
			string customerApptDate, string terminalPickupDate, string cxtusYardArrivalDate, string crossingDate, string customerDeliveryDate,
			string customerNotificationDate, string customerPickupDate, string perdiemLastFreeDay, string terminationDate, string location,
			string invoice, string arrivalDate, string exportDate, int rowNo)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return "";

			//ContainerReport.Update(id, wo, portOfArrival, vesselLineContainerOwner, exportReturnPort, vesselLineName, customer1BillingParty, destination, containerNo, size, oblBooking,
			//	pierPass, customerReference, weight, te, status, orderReceivedDate, vesselArrivalDate, availableDate, lastFreeDate, customerApptDate, terminalPickupDate,
			//	cxtusYardArrivalDate, crossingDate, customerDeliveryDate, customerNotificationDate, customerPickupDate, perdiemLastFreeDay, terminationDate, location, invoice,
			//	arrivalDate, exportDate);

			ContainerReport containerReport = ContainerReport.Get(id);

			List<object> row = ContainerReport.ToArray(containerReport, rowNo);

			return System.Text.Json.JsonSerializer.Serialize(row);
		}

	}
}
