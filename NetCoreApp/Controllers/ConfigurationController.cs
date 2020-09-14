using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;

namespace NetCoreApp.Controllers
{
	public class ConfigurationController : Controller
	{
		public IActionResult Index()
		{

			ViewBag.Data = Data.GetDatas();

			return View();
		}

		public IActionResult AddData(string Name, string Description)
		{
			Data.InsertData(Name, Description);
			return RedirectToAction("Index", "Configuration", null);
		}

		public IActionResult DeleteData(string ID)
		{
			Data.DeleteData(ID);
			return RedirectToAction("Index", "Configuration", null);
		}

	}
}
