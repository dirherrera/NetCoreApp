using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Components;
using NetCoreApp.Models;
using NetCoreApp.Security;

namespace NetCoreApp.Controllers
{
	public class ConfigurationController : Microsoft.AspNetCore.Mvc.Controller
	{

		#region Classes actions
		public IActionResult Index()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index","Home",null);
			ViewBag.AddMethod = "AddData";
			ViewBag.EditMethod = "EditData";
			ViewBag.DeleteMethod = "DeleteData";
			ViewBag.Data = Data.GetDatas();
			return View();
		}

		public IActionResult AddData(string Name, string Description)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Data.InsertData(Name, Description);
			return RedirectToAction("Index", "Configuration", null);
		}

		public IActionResult EditData(string id, string name, string description)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Data.UpdateData(id, name, description);
			return RedirectToAction("Index", "Configuration", null);
		}

		public IActionResult DeleteData(string ID)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			//Data.DeleteData(ID);
			return RedirectToAction("Index", "Configuration", null);
		}
		#endregion


		#region Privileges actions
		public IActionResult Privileges()
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			ViewBag.AddMethod = "AddPrivilege";
			ViewBag.EditMethod = "EditPrivilege";
			ViewBag.DeleteMethod = "DeletePrivilege";
			
			ViewBag.Data = Privilege.GetPrivileges();
			
			return View();
		}

		public IActionResult AddPrivilege(string name)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Privilege.InsertPrivilege(name);
			return RedirectToAction("Privileges", "Configuration", null);
		}

		public IActionResult EditPrivilege(string id, string name)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Privilege.UpdatePrivilege(id, name);
			return RedirectToAction("Privileges", "Configuration", null);
		}

		public IActionResult DeletePrivilege(string id)
		{
			if (!Credential.IsLoggedIn(HttpContext))
				return RedirectToAction("Index", "Home", null);

			Privilege.DeletePrivilege(id);
			return RedirectToAction("Privileges", "Configuration", null);
		}
		#endregion

	}
}
