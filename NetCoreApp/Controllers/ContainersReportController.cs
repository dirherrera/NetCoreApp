using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Security;
using System;
using System.Collections.Generic;

namespace NetCoreApp.Controllers
{
	public class ContainersReportController : Microsoft.AspNetCore.Mvc.Controller
	{
		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.Report = ContainerReport.Get();

			return View();
		}

		public string Report()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return "";
			List<ContainerReport> list = ContainerReport.Get();

			DataTablesJson json = new DataTablesJson();
			json.data = list;
			string data = System.Text.Json.JsonSerializer.Serialize(json);
			return data;
		}

	}
}
